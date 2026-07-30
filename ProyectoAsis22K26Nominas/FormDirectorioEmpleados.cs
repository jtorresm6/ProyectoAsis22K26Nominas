using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//Parte trabajada por: Jose Javier Torres Martinez - Carné: 0901-23-1091
//Curso:Análisis de Sistemas II
//Fecha de creación: 23-07-2026
//Fecha de última modificación: 27-07-2026

namespace ProyectoAsis22K26Nominas
{
    public partial class FormDirectorioEmpleados : Form
    {
        public FormDirectorioEmpleados()
        {
            InitializeComponent();
        }

        private void FormDirectorioEmpleados_Load(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        #region Métodos de Carga e Inicialización

        private void LimpiarFiltros()
        {
            Txt_idempleado.Clear();
            Txt_identificacion.Clear();
            Txt_nombre.Clear();
            Txt_apellidos.Clear();
            Txt_telefono.Clear();
            Txt_direccion.Clear();
            Txt_correo.Clear();
            Txt_salario.Clear();

            // Campos de Departamento
            Txt_departamento.Clear();
            Txt_iddepartamento.Clear();

            // Campos de Puesto
            Txt_puesto.Clear();
            Txt_idpuesto.Clear();

            Txt_estado.Clear();

            Dtp_fechnacimiento.Value = DateTime.Now;
            Dtp_fechcontratacion.Value = DateTime.Now;
        }

        #endregion

        #region Lógica de Búsqueda y Relleno de Controles

        private async Task BuscarEmpleadoAsync()
        {
            try
            {
                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    await con.OpenAsync();

                    StringBuilder query = new StringBuilder(@"
                        SELECT e.*, 
                               d.cmp_nombre AS departamento, 
                               p.cmp_nombre AS puesto, 
                               p.cmp_salario_base AS salario,
                               (SELECT cmp_telefono FROM tbl_Telefonos WHERE cmp_id_empleado = e.cmp_id_empleado LIMIT 1) AS telefono,
                               (SELECT cmp_correo FROM tbl_Correos WHERE cmp_id_empleado = e.cmp_id_empleado LIMIT 1) AS correo
                        FROM tbl_Empleados e
                        LEFT JOIN tbl_Departamentos d ON e.cmp_id_departamento = d.cmp_id_departamento
                        LEFT JOIN tbl_Puestos p ON e.cmp_id_puesto = p.cmp_id_puesto
                        WHERE 1=1 ");

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        // Filtro ID Empleado
                        if (int.TryParse(Txt_idempleado.Text.Trim(), out int idEmp))
                        {
                            query.Append(" AND e.cmp_id_empleado = @idEmp");
                            cmd.Parameters.AddWithValue("@idEmp", idEmp);
                        }

                        // Filtro DPI / Identificación
                        if (!string.IsNullOrWhiteSpace(Txt_identificacion.Text))
                        {
                            query.Append(" AND e.cmp_dpi LIKE @dpi");
                            cmd.Parameters.AddWithValue("@dpi", "%" + Txt_identificacion.Text.Trim() + "%");
                        }

                        // Filtro Nombre
                        if (!string.IsNullOrWhiteSpace(Txt_nombre.Text))
                        {
                            query.Append(" AND e.cmp_nombre LIKE @nombre");
                            cmd.Parameters.AddWithValue("@nombre", "%" + Txt_nombre.Text.Trim() + "%");
                        }

                        // Filtro Apellido
                        if (!string.IsNullOrWhiteSpace(Txt_apellidos.Text))
                        {
                            query.Append(" AND e.cmp_apellido LIKE @apellido");
                            cmd.Parameters.AddWithValue("@apellido", "%" + Txt_apellidos.Text.Trim() + "%");
                        }

                        // Filtro ID Departamento
                        if (int.TryParse(Txt_iddepartamento.Text.Trim(), out int idDepto))
                        {
                            query.Append(" AND e.cmp_id_departamento = @idDepto");
                            cmd.Parameters.AddWithValue("@idDepto", idDepto);
                        }

                        // Filtro Nombre Departamento
                        if (!string.IsNullOrWhiteSpace(Txt_departamento.Text))
                        {
                            query.Append(" AND d.cmp_nombre LIKE @depto");
                            cmd.Parameters.AddWithValue("@depto", "%" + Txt_departamento.Text.Trim() + "%");
                        }

                        // Filtro ID Puesto
                        if (int.TryParse(Txt_idpuesto.Text.Trim(), out int idPuesto))
                        {
                            query.Append(" AND e.cmp_id_puesto = @idPuesto");
                            cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
                        }

                        // Filtro Nombre Puesto
                        if (!string.IsNullOrWhiteSpace(Txt_puesto.Text))
                        {
                            query.Append(" AND p.cmp_nombre LIKE @puesto");
                            cmd.Parameters.AddWithValue("@puesto", "%" + Txt_puesto.Text.Trim() + "%");
                        }

                        // Filtro Estado
                        if (!string.IsNullOrWhiteSpace(Txt_estado.Text))
                        {
                            query.Append(" AND e.cmp_estado LIKE @estado");
                            cmd.Parameters.AddWithValue("@estado", "%" + Txt_estado.Text.Trim() + "%");
                        }

                        query.Append(" LIMIT 1;");

                        cmd.Connection = con;
                        cmd.CommandText = query.ToString();

                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                // Datos de Empleado
                                Txt_idempleado.Text = reader["cmp_id_empleado"].ToString();
                                Txt_identificacion.Text = reader["cmp_dpi"].ToString();
                                Txt_nombre.Text = reader["cmp_nombre"].ToString();
                                Txt_apellidos.Text = reader["cmp_apellido"].ToString();
                                Txt_direccion.Text = reader["cmp_direccion"].ToString();
                                Txt_estado.Text = reader["cmp_estado"].ToString();

                                // IDs Relacionales
                                Txt_iddepartamento.Text = reader["cmp_id_departamento"].ToString();
                                Txt_idpuesto.Text = reader["cmp_id_puesto"].ToString();

                                // Nombres y Detalles Relacionados
                                Txt_departamento.Text = reader["departamento"] != DBNull.Value ? reader["departamento"].ToString() : string.Empty;
                                Txt_puesto.Text = reader["puesto"] != DBNull.Value ? reader["puesto"].ToString() : string.Empty;
                                Txt_salario.Text = reader["salario"] != DBNull.Value ? reader["salario"].ToString() : string.Empty;

                                // Contacto
                                Txt_telefono.Text = reader["telefono"] != DBNull.Value ? reader["telefono"].ToString() : string.Empty;
                                Txt_correo.Text = reader["correo"] != DBNull.Value ? reader["correo"].ToString() : string.Empty;

                                // Fechas
                                if (reader["cmp_fecha_nacimiento"] != DBNull.Value)
                                    Dtp_fechnacimiento.Value = Convert.ToDateTime(reader["cmp_fecha_nacimiento"]);

                                if (reader["cmp_fecha_contratacion"] != DBNull.Value)
                                    Dtp_fechcontratacion.Value = Convert.ToDateTime(reader["cmp_fecha_contratacion"]);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún empleado con los datos ingresados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleado: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos de Botones

        private async void Btn_Buscar_Click(object sender, EventArgs e)
        {
            await BuscarEmpleadoAsync();
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        #endregion

        #region Eventos del Formulario (Control de interfaz)

        private void Txt_nombre_TextChanged(object sender, EventArgs e) { }
        private void Txt_apellidos_TextChanged(object sender, EventArgs e) { }
        private void Txt_identificacion_TextChanged(object sender, EventArgs e) { }
        private void Txt_telefono_TextChanged(object sender, EventArgs e) { }
        private void Txt_direccion_TextChanged(object sender, EventArgs e) { }
        private void Txt_correo_TextChanged(object sender, EventArgs e) { }
        private void Txt_salario_TextChanged(object sender, EventArgs e) { }
        private void Txt_idpuesto_TextChanged(object sender, EventArgs e) { }
        private void Txt_idempleado_TextChanged(object sender, EventArgs e) { }
        private void Txt_estado_TextChanged(object sender, EventArgs e) { }
        private void Lbl_estado_Click(object sender, EventArgs e) { }
        private void Dtp_fechnacimiento_ValueChanged(object sender, EventArgs e) { }
        private void Dtp_fechcontratacion_ValueChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }

        #endregion
    }
}