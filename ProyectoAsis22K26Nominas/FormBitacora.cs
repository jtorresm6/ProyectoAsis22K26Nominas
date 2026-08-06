using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            CargarBitacora();
        }

        // Se ejecuta cuando el formulario ya tomó su tamaño completo en la pantalla
        private void FormBitacora_Shown(object sender, EventArgs e)
        {
            AcomodarBotonAbajo();
        }

        private void FormBitacora_Resize(object sender, EventArgs e)
        {
            AcomodarBotonAbajo();
        }

        private void AcomodarBotonAbajo()
        {
            if (Dgv_Bitacora == null || Btn_actualizar == null) return;

            // 1. Quitar anclajes para tomar control total por código
            Dgv_Bitacora.Anchor = AnchorStyles.None;
            Btn_actualizar.Anchor = AnchorStyles.None;

            // 2. Acortar la altura de la tabla para dejar 80 píxeles libres abajo
            Dgv_Bitacora.Height = this.ClientSize.Height - Dgv_Bitacora.Top - 80;

            // 3. Forzar al botón a colocarse a 20 píxeles del borde inferior
            Btn_actualizar.Top = this.ClientSize.Height - Btn_actualizar.Height - 20;

            // 4. Centrar el botón horizontalmente respecto a la tabla
            Btn_actualizar.Left = Dgv_Bitacora.Left + (Dgv_Bitacora.Width - Btn_actualizar.Width) / 2;

            // 5. Asegurar que quede por encima de cualquier otro elemento
            Btn_actualizar.BringToFront();
        }

        private void Btn_actualizar_click(object sender, EventArgs e)
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

        private void Dgv_Bitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}