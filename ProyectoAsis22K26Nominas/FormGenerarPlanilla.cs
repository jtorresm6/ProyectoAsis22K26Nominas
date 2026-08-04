using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

// Roger Yankhel de Jesús Herrera Alcántara 0901-23-2429 
// Fecha de creacion: 25/07/2026
// Fecha de finalizacion: 27/07/2026

namespace ProyectoAsis22K26Nominas
{
    public partial class FormGenerarPlanilla : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando;

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

            FormularioPermisos permiso =
                GestionarPermisos.ObtenerPermiso("FormGenerarPlanilla");

            if (!permiso.Ver)
            {
                MessageBox.Show("No tiene permiso para este formulario.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            Btn_Generar.Enabled = permiso.Crear;
        }

        private void GenerarPlanilla()
        {
            try
            {
                Dgv_Detalle_Planilla.Rows.Clear();

                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"
                    SELECT
                        e.id_empleado,
                        CONCAT(e.nombre_emp, ' ', e.apellido_emp) AS Empleado,
                        p.nombre_puesto AS Puesto,
                        p.salario_base
                    FROM tbl_empleados e
                    INNER JOIN tbl_puestos p
                        ON e.id_puesto = p.id_puesto
                    WHERE e.estado_emp = 'activo';";

                comando = new MySqlCommand(consulta, conexion);

                using (MySqlDataReader lector = comando.ExecuteReader())
                {
                    decimal totalIngresos = 0;
                    decimal totalDescuentos = 0;
                    decimal totalPagar = 0;

                    while (lector.Read())
                    {
                        int idEmpleado = Convert.ToInt32(lector["id_empleado"]);
                        string empleado = lector["Empleado"].ToString();
                        string puesto = lector["Puesto"].ToString();
                        decimal salarioBase = Convert.ToDecimal(lector["salario_base"]);

                        // CÁLCULOS
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

                    Txt_Total_Ingresos.Text = totalIngresos.ToString("N2");
                    Txt_Total_Descuentos.Text = totalDescuentos.ToString("N2");
                    Txt_Total_Paga.Text = totalPagar.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar planilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void Dpt_Fecha_Inicio_ValueChanged(object sender, EventArgs e) { }

        private void Lbl_Empleado_Click(object sender, EventArgs e) { }

        private void Btn_Generar_Click(object sender, EventArgs e)
        {
            if (Dtp_Fecha_Inicio.Value.Date > Dtp_Fecha_Fin.Value.Date)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GenerarPlanilla();

            Bitacora.Registrar(
                "Generación de planilla",
                SesionUsuario.Usuario + " generó una nueva planilla."
            );
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

        private void FormGenerarPlanilla_Load_1(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}