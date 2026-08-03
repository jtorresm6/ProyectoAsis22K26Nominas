using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//Parte trabajada por: Natali Sofia Montenegro Portillo - Carné: 0901-23-10017
//Curso: Análisis de Sistemas II
//Fecha de creación: 25-07-2026
//Fecha de última modificación: 27-07-2026

namespace ProyectoAsis22K26Nominas
{
    public partial class FormMantenimientoEmpleado : Form
    {
        private FormularioPermisos permisoActual;
        private int codigoEmpleado = 0;

        public FormMantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void FormMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            permisoActual = GestionarPermisos.ObtenerPermiso("FormMantenimientoEmpleado");

            if (!permisoActual.Ver)
            {
                MessageBox.Show(
                    "No tiene permiso para ingresar a este formulario.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Close();
                return;
            }

            Cbo_Busqueda.Items.Clear();
            Cbo_Busqueda.Items.Add("Código");
            Cbo_Busqueda.Items.Add("DPI");
            Cbo_Busqueda.Items.Add("NIT");

            Cbo_Busqueda.SelectedIndex = 0;
            Cbo_Busqueda.DropDownStyle = ComboBoxStyle.DropDownList;

            Dtp_Fecha_Nac.Format = DateTimePickerFormat.Custom;
            Dtp_Fecha_Nac.CustomFormat = "yyyy-MM-dd";

            Dtp_Fecha_Cont.Format = DateTimePickerFormat.Custom;
            Dtp_Fecha_Cont.CustomFormat = "yyyy-MM-dd";

            Txt_Estado.ReadOnly = true;

            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            FormularioPermisos permiso = GestionarPermisos.ObtenerPermiso("FormMantenimientoEmpleado");

            if (!permiso.Ver)
            {
                MessageBox.Show(
                    "No tiene permiso para ingresar a este formulario.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Close();
                return;
            }

            Btn_Guardar.Enabled = false;
            Btn_Actu.Enabled = permiso.Modificar;
            Btn_Reactivar.Enabled = permiso.Eliminar;
            Btn_Bajas.Enabled = permiso.Eliminar;
        }

        private void BloquearCampos()
        {
            Txt_Cod.Enabled = false;
            Txt_DPI.Enabled = false;
            Txt_NIT.Enabled = false;
            Txt_Nombre.Enabled = false;
            Txt_Apellido.Enabled = false;
            Dtp_Fecha_Nac.Enabled = false;
            Txt_Dir.Enabled = false;
            Txt_Tel.Enabled = false;
            Txt_Corr.Enabled = false;
            Dtp_Fecha_Cont.Enabled = false;
            Txt_Dep.Enabled = false;
            Txt_Puesto.Enabled = false;
            Txt_Estado.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codigoEmpleado == 0)
            {
                MessageBox.Show("Primero debe buscar un empleado.");
                return;
            }

            Txt_DPI.Enabled = true;
            Txt_NIT.Enabled = true;
            Txt_Nombre.Enabled = true;
            Txt_Apellido.Enabled = true;
            Dtp_Fecha_Nac.Enabled = true;
            Txt_Dir.Enabled = true;
            Txt_Tel.Enabled = true;
            Txt_Corr.Enabled = true;
            Dtp_Fecha_Cont.Enabled = true;
            Txt_Dep.Enabled = true;
            Txt_Puesto.Enabled = true;

            Txt_Cod.Enabled = false;
            Txt_Estado.Enabled = false;

            Btn_Guardar.Enabled = true;
            Btn_Actu.Enabled = false;
            Btn_Bajas.Enabled = false;
            Btn_Reactivar.Enabled = false;

            Txt_DPI.Focus();

            MessageBox.Show("Ahora se pueden modificar los datos del empleado.");
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Datos.Text))
            {
                MessageBox.Show("Ingrese el dato que desea buscar.");
                return;
            }

            string campo = "";

            if (Cbo_Busqueda.Text == "Código")
            {
                campo = "e.id_empleado";
            }
            else if (Cbo_Busqueda.Text == "DPI")
            {
                campo = "e.dpi_emp";
            }
            else if (Cbo_Busqueda.Text == "NIT")
            {
                campo = "e.nit_emp";
            }

            string sql = $@"SELECT 
                                e.id_empleado,
                                e.dpi_emp,
                                e.nit_emp,
                                e.nombre_emp,
                                e.apellido_emp,
                                e.fecha_nacimiento,
                                e.direccion_emp,
                                e.fecha_contratacion,
                                e.estado_emp,
                                p.nombre_puesto AS Puesto,
                                d.nombre_depto AS Departamento,
                                t.numero_tel AS Telefono,
                                c.correo AS Correo
                            FROM tbl_empleados e
                            INNER JOIN tbl_puestos p ON e.id_puesto = p.id_puesto
                            INNER JOIN tbl_departamentos d ON p.id_departamento = d.id_departamento
                            LEFT JOIN tbl_telefonos t ON e.id_empleado = t.id_empleado
                            LEFT JOIN tbl_correos c ON e.id_empleado = c.id_empleado
                            WHERE {campo} = @dato
                            LIMIT 1";

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@dato", Txt_Datos.Text.Trim());

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                codigoEmpleado = Convert.ToInt32(lector["id_empleado"]);

                                Txt_Cod.Text = lector["id_empleado"].ToString();
                                Txt_DPI.Text = lector["dpi_emp"].ToString();
                                Txt_NIT.Text = lector["nit_emp"] != DBNull.Value ? lector["nit_emp"].ToString() : "";
                                Txt_Nombre.Text = lector["nombre_emp"].ToString();
                                Txt_Apellido.Text = lector["apellido_emp"].ToString();

                                if (lector["fecha_nacimiento"] != DBNull.Value)
                                    Dtp_Fecha_Nac.Value = Convert.ToDateTime(lector["fecha_nacimiento"]);

                                Txt_Dir.Text = lector["direccion_emp"] != DBNull.Value ? lector["direccion_emp"].ToString() : "";
                                Txt_Tel.Text = lector["Telefono"] != DBNull.Value ? lector["Telefono"].ToString() : "";
                                Txt_Corr.Text = lector["Correo"] != DBNull.Value ? lector["Correo"].ToString() : "";

                                if (lector["fecha_contratacion"] != DBNull.Value)
                                    Dtp_Fecha_Cont.Value = Convert.ToDateTime(lector["fecha_contratacion"]);

                                Txt_Dep.Text = lector["Departamento"].ToString();
                                Txt_Puesto.Text = lector["Puesto"].ToString();
                                Txt_Estado.Text = lector["estado_emp"].ToString();

                                BloquearCampos();

                                Btn_Actu.Enabled = permisoActual.Modificar;
                                Btn_Bajas.Enabled = permisoActual.Eliminar;
                                Btn_Reactivar.Enabled = permisoActual.Eliminar;
                                Btn_Guardar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Empleado no encontrado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar al empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (codigoEmpleado == 0)
            {
                MessageBox.Show("No hay un empleado seleccionado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_DPI.Text))
            {
                MessageBox.Show("Debe ingresar el DPI.");
                Txt_DPI.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre.");
                Txt_Nombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Apellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido.");
                Txt_Apellido.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Puesto.Text))
            {
                MessageBox.Show("Debe ingresar el puesto.");
                Txt_Puesto.Focus();
                return;
            }

            string sqlEmpleado = @"UPDATE tbl_empleados SET 
                                    dpi_emp = @dpi, 
                                    nit_emp = @nit, 
                                    nombre_emp = @nombre, 
                                    apellido_emp = @apellido, 
                                    fecha_nacimiento = @fechaNacimiento, 
                                    direccion_emp = @direccion, 
                                    fecha_contratacion = @fechaContratacion, 
                                    id_puesto = (SELECT id_puesto FROM tbl_puestos WHERE nombre_puesto = @puesto LIMIT 1) 
                                 WHERE id_empleado = @codigo";

            string sqlTel = @"INSERT INTO tbl_telefonos (numero_tel, id_empleado) 
                              VALUES (@tel, @codigo) 
                              ON DUPLICATE KEY UPDATE numero_tel = @tel";

            string sqlCorreo = @"INSERT INTO tbl_correos (correo, id_empleado) 
                                VALUES (@correo, @codigo) 
                                ON DUPLICATE KEY UPDATE correo = @correo";

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(sqlEmpleado, conexion))
                    {
                        comando.Parameters.AddWithValue("@dpi", Txt_DPI.Text.Trim());
                        comando.Parameters.AddWithValue("@nit", Txt_NIT.Text.Trim());
                        comando.Parameters.AddWithValue("@nombre", Txt_Nombre.Text.Trim());
                        comando.Parameters.AddWithValue("@apellido", Txt_Apellido.Text.Trim());
                        comando.Parameters.AddWithValue("@fechaNacimiento", Dtp_Fecha_Nac.Value.Date);
                        comando.Parameters.AddWithValue("@direccion", Txt_Dir.Text.Trim());
                        comando.Parameters.AddWithValue("@fechaContratacion", Dtp_Fecha_Cont.Value.Date);
                        comando.Parameters.AddWithValue("@puesto", Txt_Puesto.Text.Trim());
                        comando.Parameters.AddWithValue("@codigo", codigoEmpleado);

                        int filasModificadas = comando.ExecuteNonQuery();

                        if (filasModificadas > 0)
                        {
                            // Actualizar teléfono si ingresó uno
                            if (!string.IsNullOrWhiteSpace(Txt_Tel.Text))
                            {
                                using (MySqlCommand cmdTel = new MySqlCommand(sqlTel, conexion))
                                {
                                    cmdTel.Parameters.AddWithValue("@tel", Txt_Tel.Text.Trim());
                                    cmdTel.Parameters.AddWithValue("@codigo", codigoEmpleado);
                                    cmdTel.ExecuteNonQuery();
                                }
                            }

                            // Actualizar correo si ingresó uno
                            if (!string.IsNullOrWhiteSpace(Txt_Corr.Text))
                            {
                                using (MySqlCommand cmdCorreo = new MySqlCommand(sqlCorreo, conexion))
                                {
                                    cmdCorreo.Parameters.AddWithValue("@correo", Txt_Corr.Text.Trim());
                                    cmdCorreo.Parameters.AddWithValue("@codigo", codigoEmpleado);
                                    cmdCorreo.ExecuteNonQuery();
                                }
                            }

                            Bitacora.Registrar(
                                "Modificación de empleado",
                                SesionUsuario.Usuario + " modificó los datos del empleado ID " + codigoEmpleado + "."
                            );

                            MessageBox.Show("Datos personales y laborales actualizados correctamente.");

                            BloquearCampos();

                            Btn_Guardar.Enabled = false;
                            Btn_Actu.Enabled = permisoActual.Modificar;

                            if (Txt_Estado.Text.ToLower() == "activo")
                            {
                                Btn_Bajas.Enabled = permisoActual.Eliminar;
                                Btn_Reactivar.Enabled = false;
                            }
                            else
                            {
                                Btn_Bajas.Enabled = false;
                                Btn_Reactivar.Enabled = permisoActual.Eliminar;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se modificó ningún registro.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     
        private void Btn_reactivar_Click(object sender, EventArgs e)
        {
            if (!permisoActual.Eliminar)
            {
                MessageBox.Show(
                    "Solo el personal autorizado puede reactivar empleados.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (codigoEmpleado == 0)
            {
                MessageBox.Show("Primero debe buscar un empleado.");
                return;
            }

            if (Txt_Estado.Text.Equals("activo", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El empleado ya se encuentra activo.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de reactivar al empleado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No) return;

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string sql = "UPDATE tbl_empleados SET estado_emp = 'activo' WHERE id_empleado = @codigo";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigoEmpleado);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Bitacora.Registrar(
                                "Reactivación de empleado",
                                SesionUsuario.Usuario + " reactivó al empleado ID " + codigoEmpleado + "."
                            );

                            // 1. Actualizar el estado visualmente
                            Txt_Estado.Text = "activo";

                            // 2. Desactivar el botón de Reactivar y activar el de Bajas
                            Btn_Reactivar.Enabled = false;
                            Btn_Bajas.Enabled = permisoActual.Eliminar;

                            MessageBox.Show("Empleado reactivado correctamente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al reactivar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Bajas_Click(object sender, EventArgs e)
        {
            if (!permisoActual.Eliminar)
            {
                MessageBox.Show(
                    "Solo el personal autorizado puede dar de baja empleados.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (codigoEmpleado == 0)
            {
                MessageBox.Show("Primero debe buscar un empleado.");
                return;
            }

            if (Txt_Estado.Text.ToLower() == "inactivo")
            {
                MessageBox.Show("El empleado ya se encuentra inactivo.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de dar de baja al empleado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No) return;

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string sql = "UPDATE tbl_empleados SET estado_emp = 'inactivo' WHERE id_empleado = @codigo";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigoEmpleado);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Bitacora.Registrar(
                                "Baja de empleado",
                                SesionUsuario.Usuario + " dio de baja al empleado ID " + codigoEmpleado + "."
                            );

                            Txt_Estado.Text = "inactivo";
                            MessageBox.Show("Empleado dado de baja correctamente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de baja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            BloquearCampos();

            Btn_Guardar.Enabled = false;
            Btn_Actu.Enabled = permisoActual.Modificar;

            if (Txt_Estado.Text.ToLower() == "activo")
            {
                Btn_Bajas.Enabled = permisoActual.Eliminar;
                Btn_Reactivar.Enabled = false;
            }
            else
            {
                Btn_Bajas.Enabled = false;
                Btn_Reactivar.Enabled = permisoActual.Eliminar;
            }

            MessageBox.Show("Edición cancelada.");
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Datos.Clear();
            Txt_Cod.Clear();
            Txt_DPI.Clear();
            Txt_NIT.Clear();
            Txt_Nombre.Clear();
            Txt_Apellido.Clear();
            Txt_Dir.Clear();
            Txt_Tel.Clear();
            Txt_Corr.Clear();
            Txt_Dep.Clear();
            Txt_Puesto.Clear();
            Txt_Estado.Clear();

            codigoEmpleado = 0;

            Btn_Actu.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Bajas.Enabled = false;
            Btn_Reactivar.Enabled = false;

            Txt_Datos.Focus();
        }

        // Eventos no utilizados del diseñador
        private void Txt_Dir_TextChanged(object sender, EventArgs e) { }
        private void Txt_Tel_TextChanged(object sender, EventArgs e) { }
        private void Txt_Cod_TextChanged(object sender, EventArgs e) { }
        private void Txt_Dep_TextChanged(object sender, EventArgs e) { }
        private void Dtp_Fecha_Nac_ValueChanged(object sender, EventArgs e) { }
        private void Txt_Nombre_TextChanged(object sender, EventArgs e) { }
        private void Txt_Corr_TextChanged(object sender, EventArgs e) { }
        private void Txt_DPI_TextChanged(object sender, EventArgs e) { }
        private void Txt_Apellido_TextChanged(object sender, EventArgs e) { }
        private void Txt_Puesto_TextChanged(object sender, EventArgs e) { }
        private void Txt_Estado_TextChanged(object sender, EventArgs e) { }
        private void Dtp_Fecha_Cont_ValueChanged(object sender, EventArgs e) { }
        private void Txt_NIT_TextChanged(object sender, EventArgs e) { }
        private void Lbl_Info_Laboral_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
    }
}