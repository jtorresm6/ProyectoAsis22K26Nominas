using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

// Parte trabajada por: Matthew Andreé Juárez Xoy - Carné: 0901-23-4250
// Curso: Análisis de Sistemas II
// Fecha de creación: 26-07-2026
// Fecha de última modificación: 27-07-2026

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
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // Se agregan alias (AS) para que coincidan exactamente con el encabezado que necesitas
                    string query = @"SELECT 
                                        id_planilla AS 'ID', 
                                        fecha_inicio AS 'Inicio', 
                                        fecha_fin AS 'Fin', 
                                        fecha_generacion AS 'Fecha de Generacion', 
                                        estado_planilla AS 'Estado', 
                                        total_percepciones AS 'Ingresos', 
                                        total_deducciones AS 'Descuentos', 
                                        total_neto AS 'Total a Pagar', 
                                        observaciones_planilla AS 'Observaciones' 
                                     FROM tbl_planillas 
                                     WHERE id_usuario = @idUsuario";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", Txt_Usuario.Text.Trim());

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);

                            // Limpiamos las columnas vacías creadas en el Diseñador
                            Dgv_Historial_Nomina.Columns.Clear();

                            // Asignamos el DataTable directamente
                            Dgv_Historial_Nomina.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No se encontraron registros para este usuario.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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
            FormularioPermisos permiso =
                GestionarPermisos.ObtenerPermiso("FormHistorialNomina");

            if (!permiso.Ver)
            {
                MessageBox.Show("No tiene permiso para este formulario.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            Btn_Buscar.Enabled = permiso.Ver;
        }


        private void Dgv_Historial_Nomina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}