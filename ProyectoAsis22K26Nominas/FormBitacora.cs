using MySql.Data.MySqlClient;
using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void CargarBitacora()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // Se consulta directamente la vista 'vw_bitacora' creada en MySQL
                    string consulta = @"SELECT 
                                            id_bitacora AS Codigo,
                                            fecha_bitacora AS Fecha,
                                            nombre_usuario AS Usuario,
                                            nombre_empleado AS Empleado,
                                            nombre_rol AS Rol,
                                            direccion_ip AS IP,
                                            nombre_formulario AS Formulario,
                                            tabla_afectada AS Tabla,
                                            accion_bitacora AS Accion,
                                            descripcion_bitacora AS Descripcion
                                        FROM vw_bitacora
                                        ORDER BY fecha_bitacora DESC;";

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