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


//Parte trabajada por: Julio Roberto Rosales Mejía - Carné: 0901-23-1426
//Curso:Análisis de Sistemas II
//Fecha de creación: 27/07/2026
//Fecha de última modificación: 31/07/2026


namespace ProyectoAsis22K26Nominas
{
    public partial class FormSolicitudVacaciones : Form
    {
        // Variables globales
        private int idEmpleadoSeleccionado = 0;
        private int diasDisponibles = 0;

        public FormSolicitudVacaciones()
        {
            InitializeComponent();

            // Configurar controles
            Txt_Dias_Solicitados.ReadOnly = true;
            Txt_Dias_Solicitados.Text = "0";
            Lbl_Dias_Disponibles.Text = "0 días";

            // Configurar eventos
            this.Cbo_Empleado.SelectedIndexChanged += new EventHandler(Cbo_Empleado_SelectedIndexChanged);
            this.Dtp_Fecha_Inicio.ValueChanged += new EventHandler(Dtp_Fecha_Inicio_ValueChanged);
            this.Dtp_Fecha_Fin.ValueChanged += new EventHandler(Dtp_Fecha_Fin_ValueChanged);
            this.Btn_Guardar.Click += new EventHandler(Btn_Guardar_Click);
            this.Btn_Aprobar.Click += new EventHandler(Btn_Aprobar_Click);
            this.Btn_Rechazar.Click += new EventHandler(Btn_Rechazar_Click);
            this.Btn_Limpiar.Click += new EventHandler(Btn_Limpiar_Click);
            this.Btn_Refrescar.Click += new EventHandler(Btn_Refrescar_Click);

            // Configurar DataGridView
            Dgv_Solicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Solicitudes.ReadOnly = true;
            Dgv_Solicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Solicitudes.MultiSelect = false;
        }

        private void FormSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                Dtp_Fecha_Inicio.Value = DateTime.Today;
                Dtp_Fecha_Fin.Value = DateTime.Today;

                CargarEmpleados();
                CargarSolicitudes();
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
                    string consulta = "SELECT cmp_id_empleado, CONCAT(cmp_nombre, ' ', cmp_apellido) AS Nombre FROM tbl_empleados WHERE cmp_estado = 'activo' ORDER BY cmp_nombre";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Cbo_Empleado.DataSource = tabla;
                    Cbo_Empleado.DisplayMember = "Nombre";
                    Cbo_Empleado.ValueMember = "cmp_id_empleado";
                    Cbo_Empleado.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando empleados: " + ex.Message);
            }
        }

       
        // 2. CARGAR SOLICITUDES EN EL DataGridView
        
        private void CargarSolicitudes()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"SELECT 
                        v.cmp_id_vacacion AS ID,
                        CONCAT(e.cmp_nombre, ' ', e.cmp_apellido) AS Empleado,
                        v.cmp_fecha_inicio AS Inicio,
                        v.cmp_fecha_fin AS Fin,
                        v.cmp_cantidad_dias AS Dias,
                        v.cmp_motivo AS Motivo,
                        v.cmp_estado AS Estado
                        FROM tbl_vacaciones v
                        INNER JOIN tbl_empleados e ON v.cmp_id_empleado = e.cmp_id_empleado
                        ORDER BY v.cmp_fecha_solicitud DESC";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Dgv_Solicitudes.DataSource = tabla;

                    if (Dgv_Solicitudes.Columns.Contains("ID"))
                        Dgv_Solicitudes.Columns["ID"].Visible = false;

                    Dgv_Solicitudes.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando solicitudes: " + ex.Message);
            }
        }

        
        // 3. OBTENER ID DEL EMPLEADO SELECCIONADO
        
        private int ObtenerIdEmpleadoSeleccionado()
        {
            try
            {
                if (Cbo_Empleado.SelectedIndex == -1 || Cbo_Empleado.SelectedItem == null)
                    return 0;

                DataRowView rowView = Cbo_Empleado.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    return Convert.ToInt32(rowView["cmp_id_empleado"]);
                }

                return Convert.ToInt32(Cbo_Empleado.SelectedValue);
            }
            catch
            {
                return 0;
            }
        }

        
        // 4. MOSTRAR DÍAS DISPONIBLES - VERSIÓN SEGURA CON DATAREADER
        
        private void MostrarDiasDisponibles()
        {
            try
            {
                int idEmpleado = ObtenerIdEmpleadoSeleccionado();

                if (idEmpleado == 0)
                {
                    Lbl_Dias_Disponibles.Text = "0 días";
                    diasDisponibles = 0;
                    Txt_Dias_Solicitados.Text = "0";
                    return;
                }

                int diasUsados = 0;

                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                   
                    string consulta = @"
                        SELECT SUM(cmp_cantidad_dias) 
                        FROM tbl_vacaciones 
                        WHERE cmp_id_empleado = @id 
                        AND cmp_estado = 'aprobada' 
                        AND YEAR(cmp_fecha_inicio) = YEAR(CURDATE())";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@id", idEmpleado);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            diasUsados = reader.GetInt32(0);
                        }
                        else
                        {
                            diasUsados = 0;
                        }
                    }
                }

                diasDisponibles = 15 - diasUsados;
                if (diasDisponibles < 0) diasDisponibles = 0;

                Lbl_Dias_Disponibles.Text = diasDisponibles + " días";
                CalcularDias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculando días disponibles: " + ex.Message);
                Lbl_Dias_Disponibles.Text = "0 días";
                diasDisponibles = 0;
            }
        }

        
        // 5. CALCULAR DÍAS SOLICITADOS
        
        private void CalcularDias()
        {
            try
            {
                DateTime inicio = Dtp_Fecha_Inicio.Value;
                DateTime fin = Dtp_Fecha_Fin.Value;

                if (fin < inicio)
                {
                    Txt_Dias_Solicitados.Text = "0";
                    return;
                }

                int dias = 0;
                DateTime fecha = inicio;
                while (fecha <= fin)
                {
                    if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
                        dias++;
                    fecha = fecha.AddDays(1);
                }

                Txt_Dias_Solicitados.Text = dias.ToString();
            }
            catch (Exception ex)
            {
                Txt_Dias_Solicitados.Text = "0";
            }
        }

        
        // 6. VALIDAR ANTES DE GUARDAR
       
        private bool Validar()
        {
            int idEmpleado = ObtenerIdEmpleadoSeleccionado();

            if (idEmpleado == 0)
            {
                MessageBox.Show("Seleccione un empleado.");
                return false;
            }

            if (Dtp_Fecha_Fin.Value < Dtp_Fecha_Inicio.Value)
            {
                MessageBox.Show("La fecha final debe ser mayor a la inicial.");
                return false;
            }

            int dias = 0;
            if (!int.TryParse(Txt_Dias_Solicitados.Text, out dias) || dias <= 0)
            {
                MessageBox.Show("Los días deben ser mayores a 0.");
                return false;
            }

            if (dias > diasDisponibles)
            {
                MessageBox.Show($"Días insuficientes. Disponibles: {diasDisponibles}");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Txt_Motivo.Text))
            {
                MessageBox.Show("Ingrese un motivo.");
                return false;
            }

            return true;
        }

        
        // 7. BOTÓN GUARDAR
        
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;

                int idEmpleado = ObtenerIdEmpleadoSeleccionado();

                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string sql = @"INSERT INTO tbl_vacaciones 
                        (cmp_fecha_solicitud, cmp_fecha_inicio, cmp_fecha_fin, 
                         cmp_cantidad_dias, cmp_motivo, cmp_estado, cmp_id_empleado)
                        VALUES (@fecha, @inicio, @fin, @dias, @motivo, 'pendiente', @empleado)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Today);
                    cmd.Parameters.AddWithValue("@inicio", Dtp_Fecha_Inicio.Value);
                    cmd.Parameters.AddWithValue("@fin", Dtp_Fecha_Fin.Value);
                    cmd.Parameters.AddWithValue("@dias", Convert.ToInt32(Txt_Dias_Solicitados.Text));
                    cmd.Parameters.AddWithValue("@motivo", Txt_Motivo.Text.Trim());
                    cmd.Parameters.AddWithValue("@empleado", idEmpleado);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Solicitud guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarSolicitudes();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        // 8. BOTÓN APROBAR
        
        private void Btn_Aprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Solicitudes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una solicitud de la tabla.");
                    return;
                }

                int id = Convert.ToInt32(Dgv_Solicitudes.SelectedRows[0].Cells["ID"].Value);

                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string sql = "UPDATE tbl_vacaciones SET cmp_estado = 'aprobada' WHERE cmp_id_vacacion = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✅ Solicitud aprobada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSolicitudes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        // 9. BOTÓN RECHAZAR
        
        private void Btn_Rechazar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Solicitudes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una solicitud de la tabla.");
                    return;
                }

                int id = Convert.ToInt32(Dgv_Solicitudes.SelectedRows[0].Cells["ID"].Value);

                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string sql = "UPDATE tbl_vacaciones SET cmp_estado = 'rechazada' WHERE cmp_id_vacacion = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Solicitud rechazada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSolicitudes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        // LIMPIAR FORMULARIO
       
        private void LimpiarFormulario()
        {
            Cbo_Empleado.SelectedIndex = -1;
            Txt_Motivo.Clear();
            Dtp_Fecha_Inicio.Value = DateTime.Today;
            Dtp_Fecha_Fin.Value = DateTime.Today;
            Txt_Dias_Solicitados.Text = "0";
            Lbl_Dias_Disponibles.Text = "0 días";
            diasDisponibles = 0;
        }

        
        // BOTÓN LIMPIAR
        
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

       
        // BOTÓN REFRESCAR
        
        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarSolicitudes();
        }

        
        // EVENTOS DE CONTROLES
        
        private void Cbo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDiasDisponibles();
        }

        private void Dtp_Fecha_Inicio_ValueChanged(object sender, EventArgs e)
        {
            if (ObtenerIdEmpleadoSeleccionado() != 0)
                CalcularDias();
        }

        private void Dtp_Fecha_Fin_ValueChanged(object sender, EventArgs e)
        {
            if (ObtenerIdEmpleadoSeleccionado() != 0)
                CalcularDias();
        }
    }
}