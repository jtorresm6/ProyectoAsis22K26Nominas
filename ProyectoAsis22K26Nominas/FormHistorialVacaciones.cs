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
    //Fecha de última modificación: 02-08-2026

    public partial class FormHistorialVacaciones : Form
    {
        private DataGridView dgvHistorialVacaciones;
        private Button btnGenerarConstancia;

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

            dgvHistorialVacaciones = new DataGridView();
            btnGenerarConstancia = new Button();

            dgvHistorialVacaciones.Location = new Point(20, 20);
            dgvHistorialVacaciones.Size = new Size(760, 380);
            dgvHistorialVacaciones.AllowUserToAddRows = false;
            dgvHistorialVacaciones.AllowUserToDeleteRows = false;
            dgvHistorialVacaciones.ReadOnly = true;
            dgvHistorialVacaciones.MultiSelect = false;
            dgvHistorialVacaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialVacaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialVacaciones.BorderStyle = BorderStyle.None;
            dgvHistorialVacaciones.BackgroundColor = Color.FromArgb(32, 30, 43);
            dgvHistorialVacaciones.GridColor = Color.FromArgb(55, 55, 70);
            dgvHistorialVacaciones.RowHeadersVisible = false;
            dgvHistorialVacaciones.EnableHeadersVisualStyles = false;

            dgvHistorialVacaciones.ColumnHeadersHeight = 35;
            dgvHistorialVacaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 22, 86);
            dgvHistorialVacaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorialVacaciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvHistorialVacaciones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHistorialVacaciones.DefaultCellStyle.BackColor = Color.FromArgb(40, 37, 54);
            dgvHistorialVacaciones.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvHistorialVacaciones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 22, 86);
            dgvHistorialVacaciones.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistorialVacaciones.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvHistorialVacaciones.RowsDefaultCellStyle.BackColor = Color.FromArgb(40, 37, 54);
            dgvHistorialVacaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(48, 45, 62);

            btnGenerarConstancia.Name = "btnGenerarConstancia";
            btnGenerarConstancia.Text = "Generar Constancia";
            btnGenerarConstancia.Location = new Point(570, 420);
            btnGenerarConstancia.Size = new Size(210, 40);
            btnGenerarConstancia.BackColor = Color.FromArgb(235, 22, 86);
            btnGenerarConstancia.ForeColor = Color.White;
            btnGenerarConstancia.FlatStyle = FlatStyle.Flat;
            btnGenerarConstancia.FlatAppearance.BorderSize = 0;
            btnGenerarConstancia.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnGenerarConstancia.Cursor = Cursors.Hand;
            btnGenerarConstancia.Click += BtnGenerarConstancia_Click;

            Controls.Add(dgvHistorialVacaciones);
            Controls.Add(btnGenerarConstancia);
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

                    dgvHistorialVacaciones.DataSource = dt;
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
            if (dgvHistorialVacaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un registro de vacaciones.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dgvHistorialVacaciones.SelectedRows[0];

            // Formatear las fechas para que no aparezca la hora
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

            // Nombre base
            string nombreBase = "Constancia_Vacaciones";
            string extension = ".txt";

            // Carpeta Documentos
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

