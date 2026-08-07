using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    public partial class FormControlSaldos : Form
    {
        public FormControlSaldos()
        {
            InitializeComponent();

            // Configurar propiedades iniciales
            Dtp_Dia_Vacaciones.Value = DateTime.Today;

            // Configurar DataGridView
            Dgv_Saldo_Vacaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Saldo_Vacaciones.ReadOnly = true;
            Dgv_Saldo_Vacaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Saldo_Vacaciones.MultiSelect = false;
            Dgv_Saldo_Vacaciones.AllowUserToAddRows = false;
            Dgv_Saldo_Vacaciones.RowHeadersVisible = false;

            // Configurar eventos
            this.Cbo_Buscar_Empleado.SelectedIndexChanged += new EventHandler(Cbo_Buscar_Empleado_SelectedIndexChanged);
            this.Dtp_Dia_Vacaciones.ValueChanged += new EventHandler(Dtp_Dia_Vacaciones_ValueChanged);
            this.Btn_Refrescar.Click += new EventHandler(Btn_Refrescar_Click);
        }

        private void FormControlSaldos_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                CargarEmpleados();
                CargarSaldos(Dtp_Dia_Vacaciones.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        
        // 1. CARGAR EMPLEADOS (CON OPCIÓN "TODOS")
        
        private void CargarEmpleados()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"SELECT 
                                        cmp_id_empleado,
                                        CONCAT(cmp_nombre, ' ', cmp_apellido) AS NombreCompleto
                                        FROM tbl_empleados
                                        WHERE cmp_estado = 'activo'
                                        ORDER BY cmp_nombre, cmp_apellido";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    // Agregar opción "Todos" al inicio
                    DataRow row = tabla.NewRow();
                    row["cmp_id_empleado"] = 0;
                    row["NombreCompleto"] = "--- Todos los empleados ---";
                    tabla.Rows.InsertAt(row, 0);

                    Cbo_Buscar_Empleado.DataSource = tabla;
                    Cbo_Buscar_Empleado.DisplayMember = "NombreCompleto";
                    Cbo_Buscar_Empleado.ValueMember = "cmp_id_empleado";
                    Cbo_Buscar_Empleado.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        
        // 2. OBTENER ID DEL EMPLEADO SELECCIONADO
        
        private int ObtenerIdEmpleadoSeleccionado()
        {
            try
            {
                if (Cbo_Buscar_Empleado.SelectedIndex == -1 || Cbo_Buscar_Empleado.SelectedItem == null)
                    return 0;

                DataRowView rowView = Cbo_Buscar_Empleado.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    return Convert.ToInt32(rowView["cmp_id_empleado"]);
                }

                return Convert.ToInt32(Cbo_Buscar_Empleado.SelectedValue);
            }
            catch
            {
                return 0;
            }
        }

       
        // 3. CARGAR SALDOS - CORREGIDO
       
        private void CargarSaldos(DateTime fechaReferencia)
        {
            try
            {
                int idEmpleado = ObtenerIdEmpleadoSeleccionado();

                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"
                        SELECT 
                            v.cmp_id_vacacion AS ID,
                            CONCAT(e.cmp_nombre, ' ', e.cmp_apellido) AS Empleado,
                            v.cmp_fecha_inicio AS Inicio,
                            v.cmp_fecha_fin AS Fin,
                            v.cmp_cantidad_dias AS 'Días Totales',
                            CASE 
                                WHEN @fechaReferencia < v.cmp_fecha_inicio THEN 0
                                WHEN @fechaReferencia > v.cmp_fecha_fin THEN v.cmp_cantidad_dias
                                ELSE DATEDIFF(@fechaReferencia, v.cmp_fecha_inicio) + 1
                            END AS 'Días Gozados',
                            CASE 
                                WHEN @fechaReferencia < v.cmp_fecha_inicio THEN v.cmp_cantidad_dias
                                WHEN @fechaReferencia > v.cmp_fecha_fin THEN 0
                                ELSE v.cmp_cantidad_dias - (DATEDIFF(@fechaReferencia, v.cmp_fecha_inicio) + 1)
                            END AS 'Días Pendientes'
                        FROM tbl_vacaciones v
                        INNER JOIN tbl_empleados e 
                            ON v.cmp_id_empleado = e.cmp_id_empleado
                        WHERE v.cmp_estado = 'aprobada'";

                    if (idEmpleado > 0)
                    {
                        consulta += " AND v.cmp_id_empleado = @idEmpleado";
                    }

                    consulta += " ORDER BY e.cmp_nombre, e.cmp_apellido, v.cmp_fecha_inicio";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@fechaReferencia", fechaReferencia.Date);
                    if (idEmpleado > 0)
                    {
                        comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    }

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Dgv_Saldo_Vacaciones.DataSource = tabla;
                    ConfigurarColumnas();
                    AplicarColoresPorPendientes();
                    Dgv_Saldo_Vacaciones.Refresh();

                    if (tabla.Rows.Count == 0)
                    {
                        string mensaje = idEmpleado > 0 ?
                            "El empleado seleccionado no tiene vacaciones aprobadas." :
                            "No hay vacaciones aprobadas registradas.";
                        // Mostrar mensaje solo si no es la primera carga (opcional)
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar saldos: " + ex.Message);
            }
        }

        
        // 4. CONFIGURAR COLUMNAS
        
        private void ConfigurarColumnas()
        {
            if (Dgv_Saldo_Vacaciones.Columns.Count == 0)
                return;

            // Ocultar ID
            if (Dgv_Saldo_Vacaciones.Columns.Contains("ID"))
                Dgv_Saldo_Vacaciones.Columns["ID"].Visible = false;

            // Configurar cabeceras y anchos
            if (Dgv_Saldo_Vacaciones.Columns.Contains("Empleado"))
            {
                Dgv_Saldo_Vacaciones.Columns["Empleado"].HeaderText = "Empleado";
                Dgv_Saldo_Vacaciones.Columns["Empleado"].Width = 180;
            }

            if (Dgv_Saldo_Vacaciones.Columns.Contains("Inicio"))
            {
                Dgv_Saldo_Vacaciones.Columns["Inicio"].HeaderText = "Inicio";
                Dgv_Saldo_Vacaciones.Columns["Inicio"].Width = 100;
                Dgv_Saldo_Vacaciones.Columns["Inicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (Dgv_Saldo_Vacaciones.Columns.Contains("Fin"))
            {
                Dgv_Saldo_Vacaciones.Columns["Fin"].HeaderText = "Fin";
                Dgv_Saldo_Vacaciones.Columns["Fin"].Width = 100;
                Dgv_Saldo_Vacaciones.Columns["Fin"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (Dgv_Saldo_Vacaciones.Columns.Contains("Días Totales"))
            {
                Dgv_Saldo_Vacaciones.Columns["Días Totales"].HeaderText = "Días Totales";
                Dgv_Saldo_Vacaciones.Columns["Días Totales"].Width = 100;
                Dgv_Saldo_Vacaciones.Columns["Días Totales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (Dgv_Saldo_Vacaciones.Columns.Contains("Días Gozados"))
            {
                Dgv_Saldo_Vacaciones.Columns["Días Gozados"].HeaderText = "Días Gozados";
                Dgv_Saldo_Vacaciones.Columns["Días Gozados"].Width = 100;
                Dgv_Saldo_Vacaciones.Columns["Días Gozados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (Dgv_Saldo_Vacaciones.Columns.Contains("Días Pendientes"))
            {
                Dgv_Saldo_Vacaciones.Columns["Días Pendientes"].HeaderText = "Días Pendientes";
                Dgv_Saldo_Vacaciones.Columns["Días Pendientes"].Width = 100;
                Dgv_Saldo_Vacaciones.Columns["Días Pendientes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Dgv_Saldo_Vacaciones.Columns["Días Pendientes"].DefaultCellStyle.Font = new Font(Dgv_Saldo_Vacaciones.Font, FontStyle.Bold);
            }

            // Ajustar el modo de llenado
            Dgv_Saldo_Vacaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn col in Dgv_Saldo_Vacaciones.Columns)
            {
                if (col.Visible)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        
        // 5. APLICAR COLORES SEGÚN DÍAS PENDIENTES
        
        private void AplicarColoresPorPendientes()
        {
            foreach (DataGridViewRow fila in Dgv_Saldo_Vacaciones.Rows)
            {
                if (fila.Cells["Días Pendientes"] != null && fila.Cells["Días Pendientes"].Value != null)
                {
                    int diasPendientes = Convert.ToInt32(fila.Cells["Días Pendientes"].Value);

                    if (diasPendientes <= 0)
                    {
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 199, 206); // Rojo claro
                        fila.DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);     // Rojo oscuro
                    }
                    else if (diasPendientes <= 3)
                    {
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 242, 204); // Amarillo claro
                        fila.DefaultCellStyle.ForeColor = Color.FromArgb(128, 96, 0);     // Amarillo oscuro
                    }
                    else
                    {
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(198, 239, 206); // Verde claro
                        fila.DefaultCellStyle.ForeColor = Color.FromArgb(0, 128, 0);     // Verde oscuro
                    }
                }
            }
        }

        
        // 6. ACTUALIZAR SALDOS
        
        private void ActualizarSaldos()
        {
            CargarSaldos(Dtp_Dia_Vacaciones.Value);
        }

       
        // EVENTOS DE CONTROLES
        

        // ---- Cambio de empleado ----
        private void Cbo_Buscar_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar_Empleado.SelectedIndex >= 0)
            {
                ActualizarSaldos();
            }
        }

        // ---- Cambio de fecha ----
        private void Dtp_Dia_Vacaciones_ValueChanged(object sender, EventArgs e)
        {
            ActualizarSaldos();
        }

        }

        
        // EVENTOS VACÍOS (Compatibilidad con el diseñador)
        
        private void Lbl_Titulo_Saldos_Click(object sender, EventArgs e) { }
        private void Lbl_Buscar_Click(object sender, EventArgs e) { }
        private void Gb_Busqueda_Trabajador_Enter(object sender, EventArgs e) { }
        private void Gb_Saldo_Vacaciones_Enter(object sender, EventArgs e) { }
    }
}