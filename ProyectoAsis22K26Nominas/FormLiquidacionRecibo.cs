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
                // Se corrigió 'Conexion' a 'ConexionBD'
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string query = @"SELECT cmp_id_liquidacion, 
                                            cmp_fecha_calculo, 
                                            cmp_fecha_retiro, 
                                            cmp_motivo_retiro, 
                                            cmp_salario_pendiente, 
                                            cmp_indemnizacion, 
                                            cmp_vacaciones_pendientes, 
                                            cmp_aguinaldo_pendiente, 
                                            cmp_bono_14_pendiente, 
                                            cmp_otros_ingresos, 
                                            cmp_total_descuentos, 
                                            cmp_total_liquidacion, 
                                            cmp_numero_recibo, 
                                            cmp_fecha_pago, 
                                            cmp_estado, 
                                            cmp_observaciones 
                                     FROM tbl_Liquidaciones 
                                     WHERE cmp_id_empleado = @idEmpleado";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idEmpleado", Txt_Empleado.Text.Trim());

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        Dgv_Liquidacion_Recibo.DataSource = null;
                        adaptador.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            Dgv_Liquidacion_Recibo.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros de liquidación para este ID de empleado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }
    }
}