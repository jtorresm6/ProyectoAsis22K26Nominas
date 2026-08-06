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

// Parte trabajada por: Julio Roberto Rosales Mejía - Carné: 0901-23-1426
// Curso: Análisis de Sistemas II
// Adaptado a la BD: BD_ProyectoNominas

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
            Redondear(Pnl_Personal, 20);
            Redondear(Pnl_Registr, 20);
            Redondear(Pnl_Solis, 20);
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;


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
                    string consulta = "SELECT id_empleado, CONCAT(nombre_emp, ' ', apellido_emp) AS Nombre FROM tbl_empleados WHERE estado_emp = 'activo' ORDER BY nombre_emp";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Cbo_Empleado.DataSource = tabla;
                    Cbo_Empleado.DisplayMember = "Nombre";
                    Cbo_Empleado.ValueMember = "id_empleado";
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
                        v.id_vacacion AS ID,
                        CONCAT(e.nombre_emp, ' ', e.apellido_emp) AS Empleado,
                        v.fecha_inicio AS Inicio,
                        v.fecha_fin AS Fin,
                        v.dias_solicitados AS Dias,
                        v.motivo_vacacion AS Motivo,
                        v.estado_vacacion AS Estado
                        FROM tbl_vacaciones v
                        INNER JOIN tbl_empleados e ON v.id_empleado = e.id_empleado
                        ORDER BY v.fecha_solicitud DESC";

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
                    return Convert.ToInt32(rowView["id_empleado"]);
                }

                return Convert.ToInt32(Cbo_Empleado.SelectedValue);
            }
            catch
            {
                return 0;
            }
        }

        // 4. MOSTRAR DÍAS DISPONIBLES
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
                    // Asegurar que la conexión se encuentre abierta
                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    string consulta = @"
                        SELECT SUM(dias_solicitados) 
                        FROM tbl_vacaciones 
                        WHERE id_empleado = @id 
                        AND LOWER(estado_vacacion) = 'aprobada' 
                        AND YEAR(fecha_inicio) = YEAR(CURDATE())";

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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculando días disponibles: " + ex.Message);
                Lbl_Dias_Disponibles.Text = "0 días";
                diasDisponibles = 0;
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
                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    string sql = @"INSERT INTO tbl_vacaciones 
                        (fecha_solicitud, fecha_inicio, fecha_fin, 
                         dias_solicitados, motivo_vacacion, estado_vacacion, id_empleado)
                        VALUES (@fecha, @inicio, @fin, @dias, @motivo, 'Pendiente', @empleado)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Today);
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
                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    string sql = "UPDATE tbl_vacaciones SET estado_vacacion = 'Aprobada' WHERE id_vacacion = @id";
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
                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    string sql = "UPDATE tbl_vacaciones SET estado_vacacion = 'Rechazada' WHERE id_vacacion = @id";
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
            if (ObtenerIdEmpleadoSeleccionado() != 0) { return; }

        }

        private void Dtp_Fecha_Fin_ValueChanged(object sender, EventArgs e)
        {
            if (ObtenerIdEmpleadoSeleccionado() != 0) { return; }

        }

        private void Gbo_Empleado_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_Aprobar_Click_1(object sender, EventArgs e)
        {

        }

        private void Redondear(Control control, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(control.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(control.Width - radio, control.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, control.Height - radio, radio, radio, 90, 90);

            path.CloseAllFigures();

            control.Region = new Region(path);
        }
    }
}