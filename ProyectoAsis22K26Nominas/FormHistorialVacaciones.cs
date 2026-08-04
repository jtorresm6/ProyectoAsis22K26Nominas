using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    //Parte trabajada por Diego Alejandro Cheng Peña - carné: 0901-22-8091
    //Curso: Análisis de sistemas II
    //Fecha de creación: 24-07-2026
    //Fecha de última modificación: 03-08-2026

    public partial class FormHistorialVacaciones : Form
    {
        private DataGridView Dgv_historialVacaciones;
        private Button Btn_generarConstancia;

        public FormHistorialVacaciones()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void FormHistorialVacaciones_Load(object sender, EventArgs e)
        {
            CargarHistorialVacaciones();
        }

        private void InicializarControles()
        {
            this.BackColor = Color.FromArgb(27, 24, 37);

            Dgv_historialVacaciones = new DataGridView();
            Btn_generarConstancia = new Button();

            Dgv_historialVacaciones.Location = new Point(20, 20);
            Dgv_historialVacaciones.Size = new Size(760, 380);
            Dgv_historialVacaciones.AllowUserToAddRows = false;
            Dgv_historialVacaciones.AllowUserToDeleteRows = false;
            Dgv_historialVacaciones.ReadOnly = true;
            Dgv_historialVacaciones.MultiSelect = false;
            Dgv_historialVacaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_historialVacaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_historialVacaciones.BorderStyle = BorderStyle.None;
            Dgv_historialVacaciones.BackgroundColor = Color.FromArgb(32, 30, 43);
            Dgv_historialVacaciones.GridColor = Color.FromArgb(55, 55, 70);
            Dgv_historialVacaciones.RowHeadersVisible = false;
            Dgv_historialVacaciones.EnableHeadersVisualStyles = false;

            Dgv_historialVacaciones.ColumnHeadersHeight = 35;
            Dgv_historialVacaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 22, 86);
            Dgv_historialVacaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Dgv_historialVacaciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Dgv_historialVacaciones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Dgv_historialVacaciones.DefaultCellStyle.BackColor = Color.FromArgb(40, 37, 54);
            Dgv_historialVacaciones.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            Dgv_historialVacaciones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 22, 86);
            Dgv_historialVacaciones.DefaultCellStyle.SelectionForeColor = Color.White;
            Dgv_historialVacaciones.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            Dgv_historialVacaciones.RowsDefaultCellStyle.BackColor = Color.FromArgb(40, 37, 54);
            Dgv_historialVacaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(48, 45, 62);

            Btn_generarConstancia.Name = "Btn_generarConstancia";
            Btn_generarConstancia.Text = "Generar Constancia";
            Btn_generarConstancia.Location = new Point(570, 420);
            Btn_generarConstancia.Size = new Size(210, 40);
            Btn_generarConstancia.BackColor = Color.FromArgb(235, 22, 86);
            Btn_generarConstancia.ForeColor = Color.White;
            Btn_generarConstancia.FlatStyle = FlatStyle.Flat;
            Btn_generarConstancia.FlatAppearance.BorderSize = 0;
            Btn_generarConstancia.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Btn_generarConstancia.Cursor = Cursors.Hand;
            Btn_generarConstancia.Click += BtnGenerarConstancia_Click;

            Controls.Add(Dgv_historialVacaciones);
            Controls.Add(Btn_generarConstancia);
        }

        private void CargarHistorialVacaciones()
        {
            try
            {
                using (MySqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    cn.Open();

                    string query = @"
                        SELECT
                            v.fecha_inicio AS 'Fecha Inicio',
                            v.fecha_fin AS 'Fecha Fin',
                            v.dias_solicitados AS 'Días',
                            v.motivo_vacacion AS 'Motivo',
                            v.estado_vacacion AS 'Estado'
                        FROM tbl_vacaciones v
                        ORDER BY v.fecha_inicio DESC";

                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    Dgv_historialVacaciones.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error de conexión con la base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnGenerarConstancia_Click(object sender, EventArgs e)
        {
            if (Dgv_historialVacaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un registro de vacaciones.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = Dgv_historialVacaciones.SelectedRows[0];

            string fechaInicio = Convert.ToDateTime(fila.Cells["Fecha Inicio"].Value).ToString("dd/MM/yyyy");
            string fechaFin = Convert.ToDateTime(fila.Cells["Fecha Fin"].Value).ToString("dd/MM/yyyy");

            string contenido =
                "CONSTANCIA DE VACACIONES\r\n" +
                "===========================\r\n\r\n" +
                "Fecha Inicio: " + fechaInicio + "\r\n" +
                "Fecha Fin: " + fechaFin + "\r\n" +
                "Cantidad de días: " + fila.Cells["Días"].Value.ToString() + "\r\n" +
                "Motivo: " + fila.Cells["Motivo"].Value.ToString() + "\r\n" +
                "Estado: " + fila.Cells["Estado"].Value.ToString() + "\r\n\r\n" +
                "Sistema de Nóminas";

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo de texto (*.txt)|*.txt";

            string nombreBase = "Constancia_Vacaciones";
            string extension = ".txt";

            string carpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            int contador = 0;
            string nombreArchivo;

            do
            {
                nombreArchivo = contador == 0
                    ? $"{nombreBase}{extension}"
                    : $"{nombreBase}_{contador}{extension}";

                contador++;

            } while (File.Exists(Path.Combine(carpeta, nombreArchivo)));

            guardar.FileName = nombreArchivo;

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(guardar.FileName, contenido);

                MessageBox.Show(
                    "Constancia descargada correctamente.",
                    "Constancia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}