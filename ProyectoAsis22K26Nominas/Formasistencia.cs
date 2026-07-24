using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoAsis22K26Nominas
{
    public partial class Formasistencia : Form
    {
        // Tabla en memoria para guardar temporalmente las asistencias en pantalla
        private DataTable tablaAsistencias;

        public Formasistencia()
        {
            InitializeComponent();
        }

        private void Formasistencia_Load(object sender, EventArgs e)
        {
            // 1. Iniciar el Timer del reloj digital
            timer_reloj.Start();

            // 2. Llenar el ComboBox de Tipo de Registro
            Cbo_tipregistro.Items.Clear();
            Cbo_tipregistro.Items.Add("Entrada Normal");
            Cbo_tipregistro.Items.Add("Salida Normal");
            Cbo_tipregistro.Items.Add("Llegada Tardía");
            Cbo_tipregistro.Items.Add("Permiso / Justificado");
            Cbo_tipregistro.SelectedIndex = 0;

            // 3. Configurar la tabla del DataGridView
            InicializarTablaAsistencias();
        }

        // --- RELOJ DIGITAL EN TIEMPO REAL ---
        private void timer_reloj_Tick(object sender, EventArgs e)
        {
            Lbl_reloj.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss tt");
        }

        // --- ESTRUCTURA DE LA TABLA DE ASISTENCIA ---
        private void InicializarTablaAsistencias()
        {
            tablaAsistencias = new DataTable();
            tablaAsistencias.Columns.Add("Código");
            tablaAsistencias.Columns.Add("Empleado");
            tablaAsistencias.Columns.Add("Fecha");
            tablaAsistencias.Columns.Add("Hora");
            tablaAsistencias.Columns.Add("Tipo Registro");
            tablaAsistencias.Columns.Add("Observaciones");

            Dgv_asistenicas.DataSource = tablaAsistencias;
            Dgv_asistenicas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // --- BOTÓN BUSCAR EMPLEADO ---
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string codigo = Txt_codempleado.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese un código de empleado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SIMULACIÓN DE BÚSQUEDA (Luego se conecta a la Base de Datos)
            if (codigo == "EMP001")
            {
                Lbl_nombempleado.Text = "Juan Carlos Pérez";
                Lbl_nombempleado.ForeColor = Color.LightGreen;
            }
            else if (codigo == "EMP002")
            {
                Lbl_nombempleado.Text = "María Fernanda Gómez";
                Lbl_nombempleado.ForeColor = Color.LightGreen;
            }
            else
            {
                Lbl_nombempleado.Text = "Empleado no encontrado";
                Lbl_nombempleado.ForeColor = Color.IndianRed;
            }
        }

        // --- BOTÓN REGISTRAR ASISTENCIA ---
        private void Btn_registrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_codempleado.Text.Trim()) || Lbl_nombempleado.Text == "Empleado no encontrado" || Lbl_nombempleado.Text == "---")
            {
                MessageBox.Show("Debe buscar un empleado válido antes de registrar la asistencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       
          

            // Agregar la fila a la tabla visual
            DataRow fila = tablaAsistencias.NewRow();
            fila["Código"] = Txt_codempleado.Text.Trim();
            fila["Empleado"] = Lbl_nombempleado.Text;
            fila["Fecha"] = Dpt_fecha.Value.ToString("dd/MM/yyyy");
            fila["Hora"] = DateTime.Now.ToString("hh:mm:ss tt");
            fila["Tipo Registro"] = Cbo_tipregistro.SelectedItem.ToString();
            fila["Observaciones"] = Txt_observaciones.Text.Trim();

            tablaAsistencias.Rows.Add(fila);

            MessageBox.Show($"Asistencia registrada exitosamente para {Lbl_nombempleado.Text}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }

        // --- BOTÓN LIMPIAR ---
      
        private void Btn_limpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            Txt_codempleado.Clear();
            Txt_observaciones.Clear();
            if (Cbo_tipregistro.Items.Count > 0) Cbo_tipregistro.SelectedIndex = 0;
            Txt_codempleado.Focus();
        }

        private void Dgv_asistenicas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}