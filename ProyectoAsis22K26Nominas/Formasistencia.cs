using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAsis22K26Nominas
{
    public partial class Formasistencia : Form
    {
        public Formasistencia()
        {
            InitializeComponent();
        }

        private async void Formasistencia_Load(object sender, EventArgs e)
        {
            // 1. Iniciar el Timer si existe
            timer_reloj.Start();

            // 2. Llenar el ComboBox de Tipo de Registro
            Cbo_tipregistro.Items.Clear();
            Cbo_tipregistro.Items.Add("Entrada Normal");
            Cbo_tipregistro.Items.Add("Salida Normal");
            Cbo_tipregistro.Items.Add("Llegada Tardía");
            Cbo_tipregistro.Items.Add("Permiso / Justificado");
            Cbo_tipregistro.SelectedIndex = 0;

            // 3. Cargar historial de asistencias desde la BD
            await CargarTablaAsistenciasAsync();
        }

        private void timer_reloj_Tick(object sender, EventArgs e)
        {
            // Evento de timer libre de controles Lbl
        }

        // --- CARGAR HISTORIAL DESDE MYSQL ---
        private async Task CargarTablaAsistenciasAsync()
        {
            try
            {
                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    await con.OpenAsync();
                    string query = @"SELECT 
                                        a.cmp_id_asistencia AS 'ID',
                                        e.cmp_id_empleado AS 'Código',
                                        CONCAT(e.cmp_nombre, ' ', e.cmp_apellido) AS 'Empleado',
                                        DATE_FORMAT(a.cmp_fecha, '%d/%m/%Y') AS 'Fecha',
                                        TIME_FORMAT(a.cmp_hora_entrada, '%r') AS 'Hora Entrada',
                                        TIME_FORMAT(a.cmp_hora_salida, '%r') AS 'Hora Salida',
                                        a.cmp_minutos_tardanza AS 'Min. Tardanza',
                                        a.cmp_horas_trabajadas AS 'Horas Trab.',
                                        a.cmp_horas_extra AS 'Horas Extra',
                                        a.cmp_observaciones AS 'Observaciones'
                                     FROM tbl_Asistencias a
                                     INNER JOIN tbl_Empleados e ON a.cmp_id_empleado = e.cmp_id_empleado
                                     ORDER BY a.cmp_fecha DESC, a.cmp_id_asistencia DESC;";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            Dgv_asistenicas.DataSource = dt;
                            Dgv_asistenicas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las asistencias: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- BÚSQUEDA DE EMPLEADO EN BASE DE DATOS ---
        private async void Btn_buscar_Click(object sender, EventArgs e)
        {
            await BuscarEmpleadoAsync();
        }

        private async Task<bool> BuscarEmpleadoAsync()
        {
            string codigoTxt = Txt_codempleado.Text.Trim();

            if (string.IsNullOrEmpty(codigoTxt))
            {
                MessageBox.Show("Ingrese un código de empleado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(codigoTxt, out int idEmpleado))
            {
                MessageBox.Show("El código de empleado debe ser un número entero válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    await con.OpenAsync();
                    string query = "SELECT cmp_nombre, cmp_apellido FROM tbl_Empleados WHERE cmp_id_empleado = @id LIMIT 1;";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idEmpleado);

                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                string nombreCompleto = $"{reader["cmp_nombre"]} {reader["cmp_apellido"]}";
                                MessageBox.Show($"Empleado encontrado: {nombreCompleto}", "Empleado Válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("No existe ningún empleado registrado con ese código.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar empleado: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // --- REGISTRO DE ENTRADA O SALIDA EN MYSQL ---
        private async void Btn_registrar_Click_1(object sender, EventArgs e)
        {
            string codigoTxt = Txt_codempleado.Text.Trim();

            if (string.IsNullOrEmpty(codigoTxt) || !int.TryParse(codigoTxt, out int idEmpleado))
            {
                MessageBox.Show("Debe ingresar un código de empleado válido antes de registrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fechaSel = Dpt_fecha.Value.ToString("yyyy-MM-dd");
            string tipoRegistro = Cbo_tipregistro.SelectedItem?.ToString() ?? "Entrada Normal";
            TimeSpan horaActual = DateTime.Now.TimeOfDay;

            try
            {
                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    await con.OpenAsync();

                    // 1. Validar que el empleado exista
                    string qCheckEmp = "SELECT COUNT(*) FROM tbl_Empleados WHERE cmp_id_empleado = @idEmp;";
                    using (MySqlCommand cmdCheck = new MySqlCommand(qCheckEmp, con))
                    {
                        cmdCheck.Parameters.AddWithValue("@idEmp", idEmpleado);
                        long count = Convert.ToInt64(await cmdCheck.ExecuteScalarAsync());
                        if (count == 0)
                        {
                            MessageBox.Show("El código de empleado no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 2. Verificar si ya existe un registro en la fecha elegida
                    string qExiste = "SELECT cmp_id_asistencia, cmp_hora_entrada FROM tbl_Asistencias WHERE cmp_id_empleado = @idEmp AND cmp_fecha = @fecha LIMIT 1;";

                    int idAsistenciaExistente = 0;
                    TimeSpan horaEntradaExistente = TimeSpan.Zero;

                    using (MySqlCommand cmdExiste = new MySqlCommand(qExiste, con))
                    {
                        cmdExiste.Parameters.AddWithValue("@idEmp", idEmpleado);
                        cmdExiste.Parameters.AddWithValue("@fecha", fechaSel);

                        using (MySqlDataReader reader = (MySqlDataReader)await cmdExiste.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                idAsistenciaExistente = Convert.ToInt32(reader["cmp_id_asistencia"]);
                                if (reader["cmp_hora_entrada"] != DBNull.Value)
                                {
                                    horaEntradaExistente = (TimeSpan)reader["cmp_hora_entrada"];
                                }
                            }
                        }
                    }

                    // 3. CASO SALIDA: Se actualiza el registro existente
                    if (tipoRegistro == "Salida Normal")
                    {
                        if (idAsistenciaExistente == 0)
                        {
                            MessageBox.Show("No se puede registrar la salida porque no existe una entrada registrada para este día.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Cálculo de horas trabajadas y extras
                        double totalHoras = (horaActual - horaEntradaExistente).TotalHours;
                        decimal horasTrabajadas = (decimal)Math.Max(0, Math.Round(totalHoras, 2));
                        decimal horasExtra = (decimal)Math.Max(0, Math.Round(totalHoras > 8 ? totalHoras - 8 : 0, 2));

                        string qUpdate = @"UPDATE tbl_Asistencias 
                                           SET cmp_hora_salida = @hSalida, 
                                               cmp_horas_trabajadas = @hTrab, 
                                               cmp_horas_extra = @hExtra, 
                                               cmp_observaciones = IF(cmp_observaciones IS NULL OR cmp_observaciones = '', @obs, CONCAT(cmp_observaciones, ' | ', @obs))
                                           WHERE cmp_id_asistencia = @idAsis;";

                        using (MySqlCommand cmdUpd = new MySqlCommand(qUpdate, con))
                        {
                            cmdUpd.Parameters.AddWithValue("@hSalida", horaActual);
                            cmdUpd.Parameters.AddWithValue("@hTrab", horasTrabajadas);
                            cmdUpd.Parameters.AddWithValue("@hExtra", horasExtra);
                            cmdUpd.Parameters.AddWithValue("@obs", tipoRegistro); // Parámetro asignado correctamente
                            cmdUpd.Parameters.AddWithValue("@idAsis", idAsistenciaExistente);

                            await cmdUpd.ExecuteNonQueryAsync();
                        }
                    }
                    // 4. CASO ENTRADA: Se crea un nuevo registro
                    else
                    {
                        if (idAsistenciaExistente > 0)
                        {
                            MessageBox.Show("Ya existe una entrada registrada para este empleado en la fecha seleccionada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Cálculo de minutos de tardanza (Hora límite 08:00 AM)
                        int minutosTardanza = 0;
                        TimeSpan horaLimite = new TimeSpan(8, 0, 0);

                        if (tipoRegistro == "Llegada Tardía" || horaActual > horaLimite)
                        {
                            minutosTardanza = (int)Math.Max(0, (horaActual - horaLimite).TotalMinutes);
                        }

                        string qInsert = @"INSERT INTO tbl_Asistencias 
                                           (cmp_fecha, cmp_hora_entrada, cmp_minutos_tardanza, cmp_observaciones, cmp_id_empleado) 
                                           VALUES (@fecha, @hEntrada, @minTardanza, @obs, @idEmp);";

                        using (MySqlCommand cmdIns = new MySqlCommand(qInsert, con))
                        {
                            cmdIns.Parameters.AddWithValue("@fecha", fechaSel);
                            cmdIns.Parameters.AddWithValue("@hEntrada", horaActual);
                            cmdIns.Parameters.AddWithValue("@minTardanza", minutosTardanza);
                            cmdIns.Parameters.AddWithValue("@obs", tipoRegistro); // Parámetro asignado correctamente
                            cmdIns.Parameters.AddWithValue("@idEmp", idEmpleado);

                            await cmdIns.ExecuteNonQueryAsync();
                        }
                    }

                    MessageBox.Show($"Registro de {tipoRegistro} completado con éxito para el empleado ID {idEmpleado}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    await CargarTablaAsistenciasAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la asistencia: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- BOTÓN LIMPIAR ---
        private void Btn_limpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            Txt_codempleado.Clear();

            if (Cbo_tipregistro.Items.Count > 0) Cbo_tipregistro.SelectedIndex = 0;
            Txt_codempleado.Focus();
        }

        private void Dgv_asistenicas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}