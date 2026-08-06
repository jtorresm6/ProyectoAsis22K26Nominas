using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//Parte trabajada por: Matthew Andreé Juárez Xoy - Carné: 0901-23-4250
//Curso:Análisis de Sistemas II
//Fecha de creación: 26-07-2026
//Fecha de última modificación: 27-07-2026

namespace ProyectoAsis22K26Nominas
{
    public partial class FormLiquidacionRecibo : Form
    {
        public FormLiquidacionRecibo()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Empleado.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID del empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string query = @"SELECT 
                                        id_liquidacion AS 'ID Liquidación', 
                                        fecha_calculo AS 'Fecha Cálculo', 
                                        fecha_retiro AS 'Fecha Retiro', 
                                        motivo_retiro AS 'Motivo Retiro', 
                                        total_percepciones AS 'Total Percepciones', 
                                        total_deducciones AS 'Total Deducciones', 
                                        total_liquidacion AS 'Total Liquidación', 
                                        fecha_pago AS 'Fecha Pago', 
                                        estado_liquidacion AS 'Estado', 
                                        observaciones_liquidacion AS 'Observaciones' 
                                     FROM tbl_liquidaciones 
                                     WHERE id_empleado = @idEmpleado";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idEmpleado", Txt_Empleado.Text.Trim());

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        // 1. Limpiamos completamente el DataGridView (datos y columnas previas)
                        Dgv_Liquidacion_Recibo.DataSource = null;
                        Dgv_Liquidacion_Recibo.Columns.Clear();
                        Dgv_Liquidacion_Recibo.AutoGenerateColumns = true;

                        // 2. Llenamos el DataTable con la nueva consulta
                        adaptador.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // 3. Asignamos el nuevo resultado
                            Dgv_Liquidacion_Recibo.DataSource = dt;

                            Bitacora.Registrar(
                                "Consulta de liquidación",
                                SesionUsuario.Usuario +
                                " consultó la liquidación del empleado ID " +
                                Txt_Empleado.Text.Trim() + "."
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se encontraron registros de liquidación para este ID de empleado.",
                                "Sin resultados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la liquidación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLiquidacionRecibo_Load(object sender, EventArgs e)
        {
            FormularioPermisos permiso =
            GestionarPermisos.ObtenerPermiso(this.Name);

            if (!permiso.Ver)
            {
                MessageBox.Show("No tiene permiso para este formulario.");
                Close();
                return;
            }

            Btn_Buscar.Enabled = permiso.Ver;
        }

        private void Dgv_Liquidacion_Recibo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}