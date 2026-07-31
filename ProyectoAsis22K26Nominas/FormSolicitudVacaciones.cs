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
        
        // VARIABLES GLOBALES
        
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataAdapter adaptador;
        DataTable tabla;

        int idEmpleadoSeleccionado = 0;
        int diasDisponibles = 0;
        int diasSolicitados = 0;
        int idSolicitudSeleccionada = 0;

        
        // CONSTRUCTOR
       
        public FormSolicitudVacaciones()
        {
            InitializeComponent();

            // Configurar propiedades de controles
            Txt_Dias_Solicitados.ReadOnly = true;
            Txt_Dias_Solicitados.Text = "0";
            Txt_Dias_Solicitados.BackColor = Color.White;
            Lbl_Dias_Disponibles.Text = "0 días";
            Txt_Motivo.Clear();

            // Suscribir eventos
            Cbo_Empleado.SelectedIndexChanged += Cbo_Empleado_SelectedIndexChanged;
            Dtp_Fecha_Inicio.ValueChanged += Dtp_Fecha_ValueChanged;
            Dtp_Fecha_Fin.ValueChanged += Dtp_Fecha_ValueChanged;
            Dgv_Solicitudes.CellClick += Dgv_Solicitudes_CellClick;

            // Configurar DataGridView
            ConfigurarDataGridView();
        }

        
        // CONFIGURAR DATAGRIDVIEW
        
        private void ConfigurarDataGridView()
        {
            // Configurar propiedades generales
            Dgv_Solicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Solicitudes.ReadOnly = true;
            Dgv_Solicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Solicitudes.MultiSelect = false;
            Dgv_Solicitudes.AllowUserToAddRows = false;
            Dgv_Solicitudes.RowHeadersVisible = false;

            // Configurar columnas con los nombres exactos 
            if (Dgv_Solicitudes.Columns.Count > 0)
            {
                // Renombrar columnas según lo que pides
                if (Dgv_Solicitudes.Columns.Contains("ID"))
                {
                    Dgv_Solicitudes.Columns["ID"].HeaderText = "ID";
                    Dgv_Solicitudes.Columns["ID"].Visible = false; // Ocultar ID
                }

                if (Dgv_Solicitudes.Columns.Contains("Nombre"))
                {
                    Dgv_Solicitudes.Columns["Nombre"].HeaderText = "Empleado";
                    Dgv_Solicitudes.Columns["Nombre"].Width = 150;
                }

                if (Dgv_Solicitudes.Columns.Contains("Apellido"))
                {
                    Dgv_Solicitudes.Columns["Apellido"].HeaderText = "Apellido";
                    Dgv_Solicitudes.Columns["Apellido"].Width = 150;
                }

                if (Dgv_Solicitudes.Columns.Contains("Fecha Inicio"))
                {
                    Dgv_Solicitudes.Columns["Fecha Inicio"].HeaderText = "Inicio";
                    Dgv_Solicitudes.Columns["Fecha Inicio"].Width = 100;
                    Dgv_Solicitudes.Columns["Fecha Inicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (Dgv_Solicitudes.Columns.Contains("Fecha Fin"))
                {
                    Dgv_Solicitudes.Columns["Fecha Fin"].HeaderText = "Fin";
                    Dgv_Solicitudes.Columns["Fecha Fin"].Width = 100;
                    Dgv_Solicitudes.Columns["Fecha Fin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (Dgv_Solicitudes.Columns.Contains("Días"))
                {
                    Dgv_Solicitudes.Columns["Días"].HeaderText = "Días";
                    Dgv_Solicitudes.Columns["Días"].Width = 80;
                    Dgv_Solicitudes.Columns["Días"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (Dgv_Solicitudes.Columns.Contains("Motivo"))
                {
                    Dgv_Solicitudes.Columns["Motivo"].HeaderText = "Motivo";
                    Dgv_Solicitudes.Columns["Motivo"].Width = 200;
                }

                if (Dgv_Solicitudes.Columns.Contains("Estado"))
                {
                    Dgv_Solicitudes.Columns["Estado"].HeaderText = "Estado";
                    Dgv_Solicitudes.Columns["Estado"].Width = 100;
                    Dgv_Solicitudes.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (Dgv_Solicitudes.Columns.Contains("Fecha Solicitud"))
                {
                    Dgv_Solicitudes.Columns["Fecha Solicitud"].HeaderText = "Fecha Solicitud";
                    Dgv_Solicitudes.Columns["Fecha Solicitud"].Width = 110;
                    Dgv_Solicitudes.Columns["Fecha Solicitud"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }

            // Configurar evento para colorear filas después de cargar datos
            Dgv_Solicitudes.RowPrePaint += Dgv_Solicitudes_RowPrePaint;
        }

        
        // EVENTO PARA COLOREAR FILAS SEGÚN ESTADO
        
        private void Dgv_Solicitudes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= Dgv_Solicitudes.Rows.Count)
                return;

            DataGridViewRow fila = Dgv_Solicitudes.Rows[e.RowIndex];

            if (fila.Cells["Estado"] != null && fila.Cells["Estado"].Value != null)
            {
                string estado = fila.Cells["Estado"].Value.ToString().ToLower();

                switch (estado)
                {
                    case "aprobada":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(198, 239, 206); // Verde claro
                        fila.DefaultCellStyle.ForeColor = Color.FromArgb(0, 128, 0);      // Verde oscuro
                        break;
                    case "rechazada":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 199, 206); // Rojo claro
                        fila.DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);      // Rojo oscuro
                        break;
                    case "pendiente":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 242, 204); // Amarillo claro
                        fila.DefaultCellStyle.ForeColor = Color.FromArgb(128, 96, 0);     // Amarillo oscuro
                        break;
                    default:
                        fila.DefaultCellStyle.BackColor = Color.White;
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }

        
        // EVENTO LOAD
        
        private void FormSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            // Centrar formulario
            this.StartPosition = FormStartPosition.CenterScreen;

            // Configurar DateTimePickers
            Dtp_Fecha_Inicio.Value = DateTime.Today;
            Dtp_Fecha_Fin.Value = DateTime.Today;

            // Cargar datos iniciales
            CargarEmpleados();
            CargarSolicitudes();

            // Deshabilitar botones de aprobar/rechazar hasta que se seleccione una solicitud
            Btn_Aprobar.Enabled = false;
            Btn_Rechazar.Enabled = false;
        }


        // CARGAR EMPLEADOS

        private void CargarEmpleados()
        {
            try
            {
                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"SELECT 
                                    cmp_id_empleado,
                                    CONCAT(cmp_nombre, ' ', cmp_apellido) AS NombreCompleto
                                    FROM tbl_empleados
                                    WHERE cmp_estado = 'activo'
                                    ORDER BY cmp_nombre, cmp_apellido";

                comando = new MySqlCommand(consulta, conexion);
                adaptador = new MySqlDataAdapter(comando);

                tabla = new DataTable();
                adaptador.Fill(tabla);

                Cbo_Empleado.DataSource = tabla;
                Cbo_Empleado.DisplayMember = "NombreCompleto";
                Cbo_Empleado.ValueMember = "cmp_id_empleado";
                Cbo_Empleado.SelectedIndex = -1;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
        
        // CARGAR SOLICITUDES
        private void CargarSolicitudes()
        {
            try
            {
                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"SELECT 
                                    v.cmp_id_vacacion AS ID,
                                    e.cmp_nombre AS Nombre,
                                    e.cmp_apellido AS Apellido,
                                    v.cmp_fecha_inicio AS 'Fecha Inicio',
                                    v.cmp_fecha_fin AS 'Fecha Fin',
                                    v.cmp_cantidad_dias AS 'Días',
                                    v.cmp_motivo AS Motivo,
                                    v.cmp_estado AS Estado,
                                    v.cmp_fecha_solicitud AS 'Fecha Solicitud'
                                    FROM tbl_vacaciones v
                                    INNER JOIN tbl_empleados e 
                                        ON v.cmp_id_empleado = e.cmp_id_empleado
                                    ORDER BY v.cmp_fecha_solicitud DESC";

                comando = new MySqlCommand(consulta, conexion);
                adaptador = new MySqlDataAdapter(comando);

                tabla = new DataTable();
                adaptador.Fill(tabla);

                Dgv_Solicitudes.DataSource = tabla;

                // Configurar columnas después de asignar el DataSource
                ConfigurarColumnas();

                conexion.Close();

                // Deseleccionar solicitud
                idSolicitudSeleccionada = 0;
                Btn_Aprobar.Enabled = false;
                Btn_Rechazar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar solicitudes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
        
        // CONFIGURAR COLUMNAS DESPUÉS DE CARGAR DATOS
       
        private void ConfigurarColumnas()
        {
            if (Dgv_Solicitudes.Columns.Count == 0)
                return;

            // Ocultar ID
            if (Dgv_Solicitudes.Columns.Contains("ID"))
                Dgv_Solicitudes.Columns["ID"].Visible = false;

            // Configurar cabeceras y anchos
            if (Dgv_Solicitudes.Columns.Contains("Nombre"))
            {
                Dgv_Solicitudes.Columns["Nombre"].HeaderText = "Empleado";
                Dgv_Solicitudes.Columns["Nombre"].Width = 150;
            }

            if (Dgv_Solicitudes.Columns.Contains("Apellido"))
            {
                Dgv_Solicitudes.Columns["Apellido"].HeaderText = "Apellido";
                Dgv_Solicitudes.Columns["Apellido"].Width = 150;
            }

            if (Dgv_Solicitudes.Columns.Contains("Fecha Inicio"))
            {
                Dgv_Solicitudes.Columns["Fecha Inicio"].HeaderText = "Inicio";
                Dgv_Solicitudes.Columns["Fecha Inicio"].Width = 100;
                Dgv_Solicitudes.Columns["Fecha Inicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (Dgv_Solicitudes.Columns.Contains("Fecha Fin"))
            {
                Dgv_Solicitudes.Columns["Fecha Fin"].HeaderText = "Fin";
                Dgv_Solicitudes.Columns["Fecha Fin"].Width = 100;
                Dgv_Solicitudes.Columns["Fecha Fin"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (Dgv_Solicitudes.Columns.Contains("Días"))
            {
                Dgv_Solicitudes.Columns["Días"].HeaderText = "Días";
                Dgv_Solicitudes.Columns["Días"].Width = 80;
                Dgv_Solicitudes.Columns["Días"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (Dgv_Solicitudes.Columns.Contains("Motivo"))
            {
                Dgv_Solicitudes.Columns["Motivo"].HeaderText = "Motivo";
                Dgv_Solicitudes.Columns["Motivo"].Width = 200;
            }

            if (Dgv_Solicitudes.Columns.Contains("Estado"))
            {
                Dgv_Solicitudes.Columns["Estado"].HeaderText = "Estado";
                Dgv_Solicitudes.Columns["Estado"].Width = 100;
                Dgv_Solicitudes.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (Dgv_Solicitudes.Columns.Contains("Fecha Solicitud"))
            {
                Dgv_Solicitudes.Columns["Fecha Solicitud"].HeaderText = "Fecha Solicitud";
                Dgv_Solicitudes.Columns["Fecha Solicitud"].Width = 110;
                Dgv_Solicitudes.Columns["Fecha Solicitud"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            // Ajustar el modo de llenado para que todas las columnas se vean bien
            Dgv_Solicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn col in Dgv_Solicitudes.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        // MOSTRAR DÍAS DISPONIBLES
       
        private void MostrarDiasDisponibles()
        {
            try
            {
                if (Cbo_Empleado.SelectedIndex == -1 || Cbo_Empleado.SelectedValue == null)
                {
                    Lbl_Dias_Disponibles.Text = "0 días";
                    diasDisponibles = 0;
                    Txt_Dias_Solicitados.Text = "0";
                    return;
                }

                int idEmpleado = Convert.ToInt32(Cbo_Empleado.SelectedValue);

                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"SELECT 
                                    15 - COALESCE(SUM(cmp_cantidad_dias), 0) AS DiasDisponibles
                                    FROM tbl_vacaciones
                                    WHERE cmp_id_empleado = @empleado
                                    AND cmp_estado = 'aprobada'
                                    AND YEAR(cmp_fecha_inicio) = YEAR(CURDATE())";

                comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@empleado", idEmpleado);

                object resultado = comando.ExecuteScalar();

                if (resultado != DBNull.Value && resultado != null)
                {
                    diasDisponibles = Convert.ToInt32(resultado);
                }
                else
                {
                    diasDisponibles = 15;
                }

                Lbl_Dias_Disponibles.Text = diasDisponibles.ToString() + " días";
                CalcularDiasPorFechas();

                conexion.Close();
            }
            catch (Exception ex)
            {
                Lbl_Dias_Disponibles.Text = "0 días";
                diasDisponibles = 0;
                MessageBox.Show("Error al calcular días disponibles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        // CALCULAR DÍAS SOLICITADOS
        
        private void CalcularDiasPorFechas()
        {
            try
            {
                DateTime inicio = Dtp_Fecha_Inicio.Value.Date;
                DateTime fin = Dtp_Fecha_Fin.Value.Date;

                if (fin < inicio)
                {
                    Txt_Dias_Solicitados.Text = "0";
                    diasSolicitados = 0;
                    Txt_Dias_Solicitados.BackColor = Color.White;
                    return;
                }

                diasSolicitados = CalcularDiasHabiles(inicio, fin);
                Txt_Dias_Solicitados.Text = diasSolicitados.ToString();

                if (diasSolicitados > diasDisponibles && diasDisponibles > 0)
                {
                    Txt_Dias_Solicitados.BackColor = Color.LightSalmon;
                }
                else
                {
                    Txt_Dias_Solicitados.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                Txt_Dias_Solicitados.Text = "0";
                diasSolicitados = 0;
                Txt_Dias_Solicitados.BackColor = Color.White;
            }
        }

        
        // CALCULAR DÍAS HÁBILES
        
        private int CalcularDiasHabiles(DateTime inicio, DateTime fin)
        {
            int diasHabiles = 0;
            DateTime fechaActual = inicio;

            while (fechaActual <= fin)
            {
                if (fechaActual.DayOfWeek != DayOfWeek.Saturday &&
                    fechaActual.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasHabiles++;
                }
                fechaActual = fechaActual.AddDays(1);
            }

            return diasHabiles;
        }

        
        // VALIDAR SOLICITUD
       
        private bool ValidarSolicitud()
        {
            if (Cbo_Empleado.SelectedIndex == -1 || Cbo_Empleado.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cbo_Empleado.Focus();
                return false;
            }

            if (Dtp_Fecha_Fin.Value.Date < Dtp_Fecha_Inicio.Value.Date)
            {
                MessageBox.Show("La fecha final no puede ser menor que la fecha inicial.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dtp_Fecha_Fin.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(Txt_Motivo.Text))
            {
                MessageBox.Show("Debe ingresar un motivo para la solicitud.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Motivo.Focus();
                return false;
            }

            if (diasSolicitados <= 0)
            {
                MessageBox.Show("La cantidad de días solicitados debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (diasSolicitados > diasDisponibles)
            {
                MessageBox.Show(
                    $"El empleado no posee suficientes días disponibles.\n\n" +
                    $"Días disponibles: {diasDisponibles}\n" +
                    $"Días solicitados: {diasSolicitados}\n\n" +
                    $"Por favor, ajuste las fechas de la solicitud.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

      
        // GUARDAR SOLICITUD
       
        private void GuardarSolicitud()
        {
            try
            {
                if (!ValidarSolicitud())
                    return;

                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"INSERT INTO tbl_vacaciones 
                                    (cmp_fecha_solicitud,
                                     cmp_fecha_inicio,
                                     cmp_fecha_fin,
                                     cmp_cantidad_dias,
                                     cmp_motivo,
                                     cmp_estado,
                                     cmp_id_empleado)
                                    VALUES
                                    (@fecha_solicitud,
                                     @fecha_inicio,
                                     @fecha_fin,
                                     @cantidad_dias,
                                     @motivo,
                                     'pendiente',
                                     @empleado)";

                comando = new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@fecha_solicitud", DateTime.Today);
                comando.Parameters.AddWithValue("@fecha_inicio", Dtp_Fecha_Inicio.Value.Date);
                comando.Parameters.AddWithValue("@fecha_fin", Dtp_Fecha_Fin.Value.Date);
                comando.Parameters.AddWithValue("@cantidad_dias", diasSolicitados);
                comando.Parameters.AddWithValue("@motivo", Txt_Motivo.Text.Trim());
                comando.Parameters.AddWithValue("@empleado", idEmpleadoSeleccionado);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show(
                        "Solicitud de vacaciones registrada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarFormulario();
                    CargarSolicitudes();  // Recarga la tabla mostrando la nueva solicitud
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar la solicitud.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar solicitud: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        
        // CAMBIAR ESTADO DE SOLICITUD
        
        private void CambiarEstadoSolicitud(string estado)
        {
            try
            {
                if (idSolicitudSeleccionada == 0)
                {
                    MessageBox.Show("Seleccione una solicitud de la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si la solicitud ya tiene un estado final
                string estadoActual = ObtenerEstadoSolicitud(idSolicitudSeleccionada);
                if (estadoActual == "aprobada" || estadoActual == "rechazada")
                {
                    MessageBox.Show(
                        $"Esta solicitud ya está {estadoActual}. No se puede modificar.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    $"¿Está seguro que desea {estado} esta solicitud?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.No)
                    return;

                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"UPDATE tbl_vacaciones 
                                    SET cmp_estado = @estado
                                    WHERE cmp_id_vacacion = @id";

                comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@id", idSolicitudSeleccionada);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show(
                        $"Solicitud {estado} correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarSolicitudes();  // Recarga la tabla mostrando el nuevo estado
                    idSolicitudSeleccionada = 0;
                    Btn_Aprobar.Enabled = false;
                    Btn_Rechazar.Enabled = false;
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar la solicitud.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar solicitud: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

      
        // OBTENER ESTADO DE SOLICITUD
       
        private string ObtenerEstadoSolicitud(int idSolicitud)
        {
            try
            {
                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = "SELECT cmp_estado FROM tbl_vacaciones WHERE cmp_id_vacacion = @id";
                comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", idSolicitud);

                object resultado = comando.ExecuteScalar();
                conexion.Close();

                return resultado != null ? resultado.ToString().ToLower() : "";
            }
            catch
            {
                return "";
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
            Txt_Dias_Solicitados.BackColor = Color.White;
            Lbl_Dias_Disponibles.Text = "0 días";
            diasDisponibles = 0;
            diasSolicitados = 0;
            idEmpleadoSeleccionado = 0;
            idSolicitudSeleccionada = 0;
            Btn_Aprobar.Enabled = false;
            Btn_Rechazar.Enabled = false;
        }

        
        // EVENTOS DE CONTROLES
      
        private void Cbo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Empleado.SelectedIndex == -1 || Cbo_Empleado.SelectedValue == null)
            {
                idEmpleadoSeleccionado = 0;
                Lbl_Dias_Disponibles.Text = "0 días";
                diasDisponibles = 0;
                Txt_Dias_Solicitados.Text = "0";
                Txt_Dias_Solicitados.BackColor = Color.White;
                return;
            }

            try
            {
                idEmpleadoSeleccionado = Convert.ToInt32(Cbo_Empleado.SelectedValue);
                MostrarDiasDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dtp_Fecha_ValueChanged(object sender, EventArgs e)
        {
            if (Cbo_Empleado.SelectedIndex != -1 && Cbo_Empleado.SelectedValue != null)
            {
                CalcularDiasPorFechas();
            }
        }

        private void Dgv_Solicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Solicitudes.Rows[e.RowIndex];

                if (fila.Cells["ID"] != null && fila.Cells["ID"].Value != DBNull.Value)
                {
                    idSolicitudSeleccionada = Convert.ToInt32(fila.Cells["ID"].Value);

                    string estado = fila.Cells["Estado"].Value.ToString().ToLower();

                    // Habilitar botones solo si la solicitud está pendiente
                    if (estado == "pendiente")
                    {
                        Btn_Aprobar.Enabled = true;
                        Btn_Rechazar.Enabled = true;
                    }
                    else
                    {
                        Btn_Aprobar.Enabled = false;
                        Btn_Rechazar.Enabled = false;
                    }
                }
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarSolicitud();
        }

        private void Btn_Aprobar_Click(object sender, EventArgs e)
        {
            CambiarEstadoSolicitud("aprobada");
        }

        private void Btn_Rechazar_Click(object sender, EventArgs e)
        {
            CambiarEstadoSolicitud("rechazada");
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarSolicitudes();
            if (Cbo_Empleado.SelectedIndex != -1)
            {
                MostrarDiasDisponibles();
            }
        }

        // ============================================================
        // EVENTOS VACÍOS (Compatibilidad con el diseñador)
        // ============================================================
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter_1(object sender, EventArgs e) { }
        private void groupBox1_Enter_2(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void button1_Click_2(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}