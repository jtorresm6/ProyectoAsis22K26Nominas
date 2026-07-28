using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    public partial class FormGenerarPlanilla : Form
    {

        Conexion cn = new Conexion();

        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataAdapter adaptador;
        DataTable tabla;

        int idPlanillaSeleccionada = 0;


        public FormGenerarPlanilla()
        {
            InitializeComponent();

            CrearColumnas();
        }
        private void CrearColumnas()
        {
            Dgv_Detalle_Planilla.Columns.Clear();

            Dgv_Detalle_Planilla.Columns.Add("ID", "ID");
            Dgv_Detalle_Planilla.Columns.Add("Empleado", "Empleado");
            Dgv_Detalle_Planilla.Columns.Add("Puesto", "Puesto");
            Dgv_Detalle_Planilla.Columns.Add("SalarioBase", "Salario Base");
            Dgv_Detalle_Planilla.Columns.Add("Ingresos", "Ingresos");
            Dgv_Detalle_Planilla.Columns.Add("Descuentos", "Descuentos");
            Dgv_Detalle_Planilla.Columns.Add("Neto", "Salario Neto");

            Dgv_Detalle_Planilla.Columns["ID"].Visible = false;
        }
        private void FormGenerarPlanilla_Load(object sender, EventArgs e)
        {
  

            Txt_Total_Ingresos.ReadOnly = true;
            Txt_Total_Descuentos.ReadOnly = true;
            Txt_Total_Paga.ReadOnly = true;

            Dgv_Detalle_Planilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Dgv_Detalle_Planilla.AllowUserToAddRows = false;
            Dgv_Detalle_Planilla.ReadOnly = true;
            Dgv_Detalle_Planilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void GenerarPlanilla()
        {
            try
            {
                Dgv_Detalle_Planilla.Rows.Clear();

                conexion = cn.AbrirConexion();

                string consulta = @"
        SELECT
        e.cmp_id_empleado,
        CONCAT(e.cmp_nombre,' ',e.cmp_apellido) AS Empleado,
        p.cmp_nombre AS Puesto,
        p.cmp_salario_base
        FROM tbl_Empleados e
        INNER JOIN tbl_Puestos p
        ON e.cmp_id_puesto = p.cmp_id_puesto
        WHERE e.cmp_estado='activo'";

                comando = new MySqlCommand(consulta, conexion);

                MySqlDataReader lector = comando.ExecuteReader();

                decimal totalIngresos = 0;
                decimal totalDescuentos = 0;
                decimal totalPagar = 0;


                while (lector.Read())
                {
                    int idEmpleado = Convert.ToInt32(lector["cmp_id_empleado"]);

                    string empleado = lector["Empleado"].ToString();

                    string puesto = lector["Puesto"].ToString();

                    decimal salarioBase =
                        Convert.ToDecimal(lector["cmp_salario_base"]);


                    // CALCULOS
                    decimal ingresos = salarioBase;

                    decimal descuentos = 0;

                    decimal salarioNeto = ingresos - descuentos;


                    totalIngresos += ingresos;
                    totalDescuentos += descuentos;
                    totalPagar += salarioNeto;


                    Dgv_Detalle_Planilla.Rows.Add(
                        idEmpleado,
                        empleado,
                        puesto,
                        salarioBase,
                        ingresos,
                        descuentos,
                        salarioNeto
                    );
                }


                lector.Close();
                conexion.Close();


                Txt_Total_Ingresos.Text = totalIngresos.ToString("N2");

                Txt_Total_Descuentos.Text = totalDescuentos.ToString("N2");

                Txt_Total_Paga.Text = totalPagar.ToString("N2");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

                if (conexion != null)
                    conexion.Close();
            }
        }
        private void Dpt_Fecha_Inicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Empleado_Click(object sender, EventArgs e)
        {

        }
        private void Btn_Generar_Click(object sender, EventArgs e)
        {
          
            if (Dtp_Fecha_Inicio.Value.Date > Dtp_Fecha_Fin.Value.Date)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final.");
                return;
            }

            GenerarPlanilla();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {


            // Reiniciar fechas
            Dtp_Fecha_Inicio.Value = DateTime.Now;
            Dtp_Fecha_Fin.Value = DateTime.Now;

  

            // Limpiar totales
            Txt_Total_Ingresos.Text = "0.00";
            Txt_Total_Descuentos.Text = "0.00";
            Txt_Total_Paga.Text = "0.00";

            // Limpiar tabla
            Dgv_Detalle_Planilla.Rows.Clear();
        }
    }
}
