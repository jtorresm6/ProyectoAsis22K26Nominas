using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//Parte trabajada por: Matthew Andreé Juárez Xoy - Carné: 0901-23-4250
//Curso:Análisis de Sistemas II
//Fecha de creación: 26-07-2026
//Fecha de última modificación: 27-07-2026

namespace ProyectoAsis22K26Nominas
{
    public partial class FormHistorialNomina : Form
    {
        public FormHistorialNomina()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Usuario.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID del usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Se corrigió 'Conexion' a 'ConexionBD'
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string query = @"SELECT cmp_id_planilla, 
                                            cmp_periodo_inicio, 
                                            cmp_periodo_fin, 
                                            cmp_fecha_generacion, 
                                            cmp_estado, 
                                            cmp_total_ingresos, 
                                            cmp_total_descuentos, 
                                            cmp_total_pagar, 
                                            cmp_observaciones 
                                     FROM tbl_Planilla 
                                     WHERE cmp_id_usuario = @idUsuario";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", Txt_Usuario.Text.Trim());

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        adaptador.Fill(dt);

                        // Asigna los nuevos datos al DataGridView
                        Dgv_Historial_Nomina.DataSource = null;
                        Dgv_Historial_Nomina.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron registros para este usuario.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormHistorialNomina_Load(object sender, EventArgs e)
        {

        }
    }
}