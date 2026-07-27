using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAsis22K26Nominas
{
    public partial class FormNuevoregistro : Form
    {
        // Banderas para controlar el estado del formulario
        private bool esEdicion = false;
        private bool esNuevo = false;

        public FormNuevoregistro()
        {
            InitializeComponent();
        }

        private void FormNuevoregistro_Load(object sender, EventArgs e)
        {
            CargarComboboxes();
            EstablecerEstadoInicial();
        }

        #region Configuración de Estado y Controles

        // Carga opciones predeterminadas en los ComboBoxes
        private void CargarComboboxes()
        {
            // Puestos
            Cbo_puesto.Items.Clear();
            Cbo_puesto.Items.Add("Secretaria");
            Cbo_puesto.Items.Add("Analista de Nómina");
            Cbo_puesto.Items.Add("Contador");
            Cbo_puesto.Items.Add("Gerente de RH");
            Cbo_puesto.SelectedIndex = 0;

            // Departamentos
            Cbo_Departamento.Items.Clear();
            Cbo_Departamento.Items.Add("Recursos Humanos");
            Cbo_Departamento.Items.Add("Contabilidad");
            Cbo_Departamento.Items.Add("Administración");
            Cbo_Departamento.SelectedIndex = 0;
        }

        // Bloquea o desbloquea todos los controles excepto el ID de búsqueda
        private void BloquearControles(bool bloquear)
        {
            bool habilitado = !bloquear;

            Txt_identificacion.Enabled = habilitado;
            Txt_nombre.Enabled = habilitado;
            Txt_apellidos.Enabled = habilitado;
            Txt_telefono.Enabled = habilitado;
            Txt_direccion.Enabled = habilitado;
            Txt_correo.Enabled = habilitado;
            Txt_salario.Enabled = habilitado;

            Cbo_Departamento.Enabled = habilitado;
            Cbo_puesto.Enabled = habilitado;

            Dtp_fechnacimiento.Enabled = habilitado;
            Dtp_fechcontratacion.Enabled = habilitado;

            Btn_guardar.Enabled = habilitado;
        }

        // Estado inicial al abrir o limpiar el formulario
        private void EstablecerEstadoInicial()
        {
            esEdicion = false;
            esNuevo = false;

            LimpiarCampos();
            BloquearControles(true);

            Txt_idempleado.Enabled = true;
            Btn_Buscar.Enabled = true;
            Btn_actualizar.Enabled = false;
            Btn_eliminar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            Txt_idempleado.Clear();
            Txt_identificacion.Clear();
            Txt_nombre.Clear();
            Txt_apellidos.Clear();
            Txt_telefono.Clear();
            Txt_direccion.Clear();
            Txt_correo.Clear();
            Txt_salario.Clear();

            Dtp_fechnacimiento.Value = DateTime.Now;
            Dtp_fechcontratacion.Value = DateTime.Now;

            if (Cbo_puesto.Items.Count > 0) Cbo_puesto.SelectedIndex = 0;
            if (Cbo_Departamento.Items.Count > 0) Cbo_Departamento.SelectedIndex = 0;
        }

        #endregion

        #region Botones de Acción

        // 1. BUSCAR EMPLEADO POR ID O DPI
        private async void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string idBuscado = Txt_idempleado.Text.Trim();

            if (string.IsNullOrEmpty(idBuscado))
            {
                MessageBox.Show("Ingrese un ID o DPI para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    await con.OpenAsync();

                    string query = @"SELECT e.*, d.cmp_nombre AS departamento, p.cmp_nombre AS puesto, p.cmp_salario_base
                                     FROM tbl_Empleados e
                                     INNER JOIN tbl_Departamentos d ON e.cmp_id_departamento = d.cmp_id_departamento
                                     INNER JOIN tbl_Puestos p ON e.cmp_id_puesto = p.cmp_id_puesto
                                     WHERE e.cmp_id_empleado = @id OR e.cmp_dpi = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idBuscado);

                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                Txt_idempleado.Text = reader["cmp_id_empleado"].ToString();
                                Txt_identificacion.Text = reader["cmp_dpi"].ToString();
                                Txt_nombre.Text = reader["cmp_nombre"].ToString();
                                Txt_apellidos.Text = reader["cmp_apellido"].ToString();
                                Txt_direccion.Text = reader["cmp_direccion"].ToString();
                                Txt_salario.Text = reader["cmp_salario_base"].ToString();

                                if (reader["cmp_fecha_nacimiento"] != DBNull.Value)
                                    Dtp_fechnacimiento.Value = Convert.ToDateTime(reader["cmp_fecha_nacimiento"]);

                                if (reader["cmp_fecha_contratacion"] != DBNull.Value)
                                    Dtp_fechcontratacion.Value = Convert.ToDateTime(reader["cmp_fecha_contratacion"]);

                                // Seleccionar Puesto y Departamento
                                string nombrePuesto = reader["puesto"].ToString();
                                string nombreDepto = reader["departamento"].ToString();

                                if (Cbo_puesto.Items.Contains(nombrePuesto)) Cbo_puesto.SelectedItem = nombrePuesto;
                                if (Cbo_Departamento.Items.Contains(nombreDepto)) Cbo_Departamento.SelectedItem = nombreDepto;

                                // Cargar Teléfono y Correo si existen
                                await CargarContactoEmpleadoAsync(Convert.ToInt32(reader["cmp_id_empleado"]));

                                // Bloquear campos y activar opciones de edición/eliminación
                                BloquearControles(true);
                                Txt_idempleado.Enabled = false;
                                Btn_actualizar.Enabled = true;
                                Btn_eliminar.Enabled = true;
                                esNuevo = false;
                                esEdicion = false;
                            }
                            else
                            {
                                DialogResult resp = MessageBox.Show(
                                    "El empleado no existe. ¿Desea habilitar los campos para registrarlo como nuevo?",
                                    "Sin resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (resp == DialogResult.Yes)
                                {
                                    HabilitarModoNuevo();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el empleado: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga de teléfono y correo
        private async Task CargarContactoEmpleadoAsync(int idEmpleado)
        {
            using (MySqlConnection con = ConexionBD.ObtenerConexion())
            {
                await con.OpenAsync();

                // Teléfono
                string queryTel = "SELECT cmp_telefono FROM tbl_Telefonos WHERE cmp_id_empleado = @id LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(queryTel, con))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    object res = await cmd.ExecuteScalarAsync();
                    Txt_telefono.Text = res != null ? res.ToString() : "";
                }

                // Correo
                string queryCor = "SELECT cmp_correo FROM tbl_Correos WHERE cmp_id_empleado = @id LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(queryCor, con))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    object res = await cmd.ExecuteScalarAsync();
                    Txt_correo.Text = res != null ? res.ToString() : "";
                }
            }
        }

        // Habilita modo nuevo registro
        private void HabilitarModoNuevo()
        {
            string idIngresado = Txt_idempleado.Text.Trim();
            LimpiarCampos();
            Txt_idempleado.Text = idIngresado;

            BloquearControles(false);
            Txt_idempleado.Enabled = false;

            esNuevo = true;
            esEdicion = false;
            Btn_actualizar.Enabled = false;
            Btn_eliminar.Enabled = false;
        }

        // 2. HABILITAR EDICIÓN
        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            BloquearControles(false);
            Txt_idempleado.Enabled = false;

            esEdicion = true;
            esNuevo = false;

            MessageBox.Show("Modo de edición activado. Realice los cambios y presione 'Guardar'.", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. GUARDAR (INSERTA O ACTUALIZA SEGÚN EL MODO)
        private async void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_identificacion.Text.Trim()) || string.IsNullOrEmpty(Txt_nombre.Text.Trim()))
            {
                MessageBox.Show("Complete al menos el DPI y el Nombre del empleado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (esNuevo)
            {
                await InsertarEmpleadoAsync();
            }
            else if (esEdicion)
            {
                await ActualizarEmpleadoAsync();
            }
        }

        // Proceso de Inserción
        private async Task InsertarEmpleadoAsync()
        {
            try
            {
                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    await con.OpenAsync();

                    // Verificar si el DPI ya existe
                    string queryCheck = "SELECT COUNT(*) FROM tbl_Empleados WHERE cmp_dpi = @dpi";
                    using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, con))
                    {
                        cmdCheck.Parameters.AddWithValue("@dpi", Txt_identificacion.Text.Trim());
                        long count = Convert.ToInt64(await cmdCheck.ExecuteScalarAsync());

                        if (count > 0)
                        {
                            MessageBox.Show("Ya existe un empleado registrado con ese DPI. Ingrese uno diferente.", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insertar nuevo empleado
                    string queryInsert = @"INSERT INTO tbl_Empleados 
                                           (cmp_dpi, cmp_nombre, cmp_apellido, cmp_fecha_nacimiento, cmp_direccion, cmp_fecha_contratacion, cmp_id_departamento, cmp_id_puesto) 
                                           VALUES (@dpi, @nombre, @apellido, @fNac, @direccion, @fCont, @idDepto, @idPuesto);
                                           SELECT LAST_INSERT_ID();";

                    int nuevoId = 0;
                    using (MySqlCommand cmd = new MySqlCommand(queryInsert, con))
                    {
                        cmd.Parameters.AddWithValue("@dpi", Txt_identificacion.Text.Trim());
                        cmd.Parameters.AddWithValue("@nombre", Txt_nombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellido", Txt_apellidos.Text.Trim());
                        cmd.Parameters.AddWithValue("@fNac", Dtp_fechnacimiento.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@direccion", Txt_direccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@fCont", Dtp_fechcontratacion.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@idDepto", Cbo_Departamento.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@idPuesto", Cbo_puesto.SelectedIndex + 1);

                        nuevoId = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }

                    // Guardar contacto
                    await GuardarContactoAsync(con, nuevoId);

                    MessageBox.Show($"Empleado guardado exitosamente con ID: {nuevoId}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EstablecerEstadoInicial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar empleado: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Proceso de Actualización
        private async Task ActualizarEmpleadoAsync()
        {
            try
            {
                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    await con.OpenAsync();

                    string queryUpdate = @"UPDATE tbl_Empleados 
                                           SET cmp_dpi = @dpi,
                                               cmp_nombre = @nombre,
                                               cmp_apellido = @apellido,
                                               cmp_fecha_nacimiento = @fNac,
                                               cmp_direccion = @direccion,
                                               cmp_fecha_contratacion = @fCont,
                                               cmp_id_departamento = @idDepto,
                                               cmp_id_puesto = @idPuesto
                                           WHERE cmp_id_empleado = @id";

                    using (MySqlCommand cmd = new MySqlCommand(queryUpdate, con))
                    {
                        cmd.Parameters.AddWithValue("@dpi", Txt_identificacion.Text.Trim());
                        cmd.Parameters.AddWithValue("@nombre", Txt_nombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellido", Txt_apellidos.Text.Trim());
                        cmd.Parameters.AddWithValue("@fNac", Dtp_fechnacimiento.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@direccion", Txt_direccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@fCont", Dtp_fechcontratacion.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@idDepto", Cbo_Departamento.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@idPuesto", Cbo_puesto.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Txt_idempleado.Text));

                        await cmd.ExecuteNonQueryAsync();
                    }

                    MessageBox.Show("Información del empleado actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EstablecerEstadoInicial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar empleado: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GuardarContactoAsync(MySqlConnection con, int idEmpleado)
        {
            if (!string.IsNullOrEmpty(Txt_telefono.Text.Trim()))
            {
                string queryTel = "INSERT INTO tbl_Telefonos (cmp_telefono, cmp_id_empleado) VALUES (@tel, @idEmp)";
                using (MySqlCommand cmd = new MySqlCommand(queryTel, con))
                {
                    cmd.Parameters.AddWithValue("@tel", Txt_telefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@idEmp", idEmpleado);
                    await cmd.ExecuteNonQueryAsync();
                }
            }

            if (!string.IsNullOrEmpty(Txt_correo.Text.Trim()))
            {
                string queryCor = "INSERT INTO tbl_Correos (cmp_correo, cmp_id_empleado) VALUES (@correo, @idEmp)";
                using (MySqlCommand cmd = new MySqlCommand(queryCor, con))
                {
                    cmd.Parameters.AddWithValue("@correo", Txt_correo.Text.Trim());
                    cmd.Parameters.AddWithValue("@idEmp", idEmpleado);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // 4. ELIMINAR REGISTRO CON CONFIRMACIÓN
        private async void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_idempleado.Text.Trim())) return;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar al empleado con ID {Txt_idempleado.Text}?\nEsta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection con = ConexionBD.ObtenerConexion())
                    {
                        await con.OpenAsync();

                        int idEmpleado = Convert.ToInt32(Txt_idempleado.Text.Trim());

                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_Telefonos WHERE cmp_id_empleado = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", idEmpleado);
                            await cmd.ExecuteNonQueryAsync();
                        }
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_Correos WHERE cmp_id_empleado = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", idEmpleado);
                            await cmd.ExecuteNonQueryAsync();
                        }

                        string queryDelete = "DELETE FROM tbl_Empleados WHERE cmp_id_empleado = @id";
                        using (MySqlCommand cmd = new MySqlCommand(queryDelete, con))
                        {
                            cmd.Parameters.AddWithValue("@id", idEmpleado);
                            await cmd.ExecuteNonQueryAsync();
                        }

                        MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EstablecerEstadoInicial();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede eliminar el empleado porque posee registros vinculados.\nDetalle: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Eventos Vacíos de Controles

        private void Txt_idempleado_TextChanged(object sender, EventArgs e) { }
        private void Txt_nombre_TextChanged(object sender, EventArgs e) { }
        private void Txt_apellidos_TextChanged(object sender, EventArgs e) { }
        private void Txt_identificacion_TextChanged(object sender, EventArgs e) { }
        private void Txt_telefono_TextChanged(object sender, EventArgs e) { }
        private void Txt_direccion_TextChanged(object sender, EventArgs e) { }
        private void Txt_correo_TextChanged(object sender, EventArgs e) { }
        private void Txt_salario_TextChanged(object sender, EventArgs e) { }
        private void Cbo_Departamento_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Cbo_puesto_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Dtp_fechnacimiento_ValueChanged(object sender, EventArgs e) { }
        private void Dtp_fechcontratacion_ValueChanged(object sender, EventArgs e) { }

        #endregion
    }
}