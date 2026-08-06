using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ProyectoAsis22K26Nominas
{
    public partial class FormBitacora : Form
    {
        public FormBitacora()
        {
            InitializeComponent();
        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {
            // Carga automáticamente los datos al abrir el formulario
            CargarBitacora();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón manual para refrescar los datos
            CargarBitacora();
        }

        private void CargarBitacora()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // Se eliminaron 'nombre_formulario' y 'tabla_afectada' de la consulta
                    string consulta = @"SELECT 
                                            id_bitacora AS Codigo,
                                            fecha_bitacora AS Fecha,
                                            nombre_usuario AS Usuario,
                                            nombre_empleado AS Empleado,
                                            nombre_rol AS Rol,
                                            direccion_ip AS IP,
                                            accion_bitacora AS Accion,
                                            descripcion_bitacora AS Descripcion
                                        FROM vw_bitacora
                                        ORDER BY id_bitacora DESC, fecha_bitacora DESC;";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        Dgv_Bitacora.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la bitácora: " + ex.Message,
                    "Error BD",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}