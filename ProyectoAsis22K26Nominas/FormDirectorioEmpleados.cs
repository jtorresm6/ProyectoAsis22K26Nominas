using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Parte trabajada por: Jose Javier Torres Martinez - Carné: 0901-23-1091
// Curso: Análisis de Sistemas II
// Fecha de creación: 23-07-2026
// Fecha de última modificación: 27-07-2026

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

            Dtp_fechnacimiento.Format = DateTimePickerFormat.Custom;
            Dtp_fechnacimiento.CustomFormat = "dd/MM/yyyy";

            Dtp_fechcontratacion.Format = DateTimePickerFormat.Custom;
            Dtp_fechcontratacion.CustomFormat = "dd/MM/yyyy";

            LimpiarFiltros();

            FormularioPermisos permiso =
            GestionarPermisos.ObtenerPermiso("FormDirectorioEmpleados");

            if (!permiso.Ver)
            {
                MessageBox.Show("No tiene permiso para este formulario.");
                Close();
                return;
            }

            Btn_Buscar.Enabled = permiso.Ver;
            Btn_exportar.Enabled = permiso.Modificar;
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
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    await conexion.OpenAsync();

                    string consulta = @"
                        SELECT
                            e.id_empleado,
                            e.dpi_emp,
                            e.nombre_emp,
                            e.apellido_emp,
                            e.fecha_nacimiento,
                            e.direccion_emp,
                            e.fecha_contratacion,
                            e.estado_emp,
                            p.id_departamento,
                            e.id_puesto,
                            d.nombre_depto AS departamento,
                            p.nombre_puesto AS puesto,
                            p.salario_base AS salario,
                            t.numero_tel AS telefono,
                            c.correo AS correo
                        FROM tbl_empleados e
                        INNER JOIN tbl_puestos p 
                            ON e.id_puesto = p.id_puesto
                        INNER JOIN tbl_departamentos d 
                            ON p.id_departamento = d.id_departamento
                        LEFT JOIN tbl_telefonos t 
                            ON e.id_empleado = t.id_empleado
                        LEFT JOIN tbl_correos c 
                            ON e.id_empleado = c.id_empleado
                        WHERE e.id_empleado = @idEmpleado
                        LIMIT 1;";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@idEmpleado", Txt_idempleado.Text.Trim());

                        using (MySqlDataReader lector = (MySqlDataReader)await comando.ExecuteReaderAsync())
                        {
                            if (await lector.ReadAsync())
                            {
                                Txt_idempleado.Text = lector["id_empleado"].ToString();
                                Txt_identificacion.Text = lector["dpi_emp"].ToString();
                                Txt_nombre.Text = lector["nombre_emp"].ToString();
                                Txt_apellidos.Text = lector["apellido_emp"].ToString();
                                Txt_direccion.Text = lector["direccion_emp"].ToString();
                                Txt_estado.Text = lector["estado_emp"].ToString();

                                Txt_iddepartamento.Text = lector["id_departamento"].ToString();
                                Txt_idpuesto.Text = lector["id_puesto"].ToString();

                                Txt_departamento.Text = lector["departamento"] != DBNull.Value
                                    ? lector["departamento"].ToString()
                                    : "";

                                Txt_puesto.Text = lector["puesto"] != DBNull.Value
                                    ? lector["puesto"].ToString()
                                    : "";

                                Txt_salario.Text = lector["salario"] != DBNull.Value
                                    ? lector["salario"].ToString()
                                    : "";

                                Txt_telefono.Text = lector["telefono"] != DBNull.Value
                                    ? lector["telefono"].ToString()
                                    : "";

                                Txt_correo.Text = lector["correo"] != DBNull.Value
                                    ? lector["correo"].ToString()
                                    : "";

                                if (lector["fecha_nacimiento"] != DBNull.Value)
                                {
                                    Dtp_fechnacimiento.Value = Convert.ToDateTime(lector["fecha_nacimiento"]);
                                }

                                if (lector["fecha_contratacion"] != DBNull.Value)
                                {
                                    Dtp_fechcontratacion.Value = Convert.ToDateTime(lector["fecha_contratacion"]);
                                }

                                Bitacora.Registrar(
                                    "Consulta de empleado",
                                    "El usuario " +
                                    SesionUsuario.Usuario +
                                    " consultó los datos del empleado " +
                                    Txt_nombre.Text.Trim() +
                                    " " +
                                    Txt_apellidos.Text.Trim() +
                                    ", código " +
                                    Txt_idempleado.Text.Trim() +
                                    "."
                                );
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró el empleado.",
                                    "Búsqueda",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar empleado: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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

        private void Btn_exportar_Click(object sender, EventArgs e)
        {

        }
    }
}