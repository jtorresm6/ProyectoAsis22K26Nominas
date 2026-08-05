using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// Parte trabajada por: Julio Roberto Rosales Mejía - Carné: 0901-23-1426
// Curso: Análisis de Sistemas II
// Adaptado a la base de datos BD_ProyectoNominas

namespace ProyectoAsis22K26Nominas
{
    public partial class FormControlSaldos : Form
    {
        private int idEmpleadoSeleccionado = 0;

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

        // 1. CARGAR EMPLEADOS
        private void CargarEmpleados()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"SELECT 
                                            id_empleado,
                                            CONCAT(nombre_emp, ' ', apellido_emp) AS NombreCompleto
                                        FROM tbl_empleados
                                        WHERE LOWER(estado_emp) = 'activo'
                                        ORDER BY nombre_emp, apellido_emp";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    // Agregar opción "Todos"
                    DataRow row = tabla.NewRow();
                    row["id_empleado"] = 0;
                    row["NombreCompleto"] = "--- Todos los empleados ---";
                    tabla.Rows.InsertAt(row, 0);

                    Cbo_Buscar_Empleado.DataSource = tabla;
                    Cbo_Buscar_Empleado.DisplayMember = "NombreCompleto";
                    Cbo_Buscar_Empleado.ValueMember = "id_empleado";
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
                    return Convert.ToInt32(rowView["id_empleado"]);
                }

                return Convert.ToInt32(Cbo_Buscar_Empleado.SelectedValue);
            }
            catch
            {
                return 0;
            }
        }

        // 3. CARGAR SALDOS
        private void CargarSaldos(DateTime fechaReferencia)
        {
            try
            {
                int idEmpleado = ObtenerIdEmpleadoSeleccionado();

                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"
                        SELECT 
                            v.id_vacacion AS ID,
                            CONCAT(e.nombre_emp, ' ', e.apellido_emp) AS Empleado,
                            v.fecha_inicio AS Inicio,
                            v.fecha_fin AS Fin,
                            v.dias_solicitados AS 'Días Totales',
                            CASE 
                                WHEN @fechaReferencia < v.fecha_inicio THEN 0
                                WHEN @fechaReferencia > v.fecha_fin THEN v.dias_solicitados
                                ELSE DATEDIFF(@fechaReferencia, v.fecha_inicio) + 1
                            END AS 'Días Gozados',
                            CASE 
                                WHEN @fechaReferencia < v.fecha_inicio THEN v.dias_solicitados
                                WHEN @fechaReferencia > v.fecha_fin THEN 0
                                ELSE v.dias_solicitados - (DATEDIFF(@fechaReferencia, v.fecha_inicio) + 1)
                            END AS 'Días Pendientes'
                        FROM tbl_vacaciones v
                        INNER JOIN tbl_empleados e 
                            ON v.id_empleado = e.id_empleado
                        WHERE LOWER(v.estado_vacacion) = 'aprobada'";

                    if (idEmpleado > 0)
                    {
                        consulta += " AND v.id_empleado = @idEmpleado";
                    }

                    consulta += " ORDER BY e.nombre_emp, e.apellido_emp, v.fecha_inicio";

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

            if (Dgv_Saldo_Vacaciones.Columns.Contains("ID"))
                Dgv_Saldo_Vacaciones.Columns["ID"].Visible = false;

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
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 199, 206);
                        fila.DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);
                    }
                    else if (diasPendientes <= 3)
                    {
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 242, 204);
                        fila.DefaultCellStyle.ForeColor = Color.FromArgb(128, 96, 0);
                    }
                    else
                    {
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(198, 239, 206);
                        fila.DefaultCellStyle.ForeColor = Color.FromArgb(0, 128, 0);
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
        private void Cbo_Buscar_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar_Empleado.SelectedIndex >= 0)
            {
                ActualizarSaldos();
            }
        }

        private void Dtp_Dia_Vacaciones_ValueChanged(object sender, EventArgs e)
        {
            ActualizarSaldos();
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            Dtp_Dia_Vacaciones.Value = DateTime.Today;
            ActualizarSaldos();
        }

        // Eventos vacíos para el diseñador
        private void Lbl_Titulo_Saldos_Click(object sender, EventArgs e) { }
        private void Lbl_Buscar_Click(object sender, EventArgs e) { }
        private void Gb_Busqueda_Trabajador_Enter(object sender, EventArgs e) { }
        private void Gb_Saldo_Vacaciones_Enter(object sender, EventArgs e) { }
    }
}