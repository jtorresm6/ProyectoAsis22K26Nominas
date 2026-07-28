using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    public partial class FormHistorialVacaciones : Form
    {
        private DataGridView dgvHistorialVacaciones;
        private Button btnGenerarConstancia;

        private string conexion = "server=localhost;database=db_sistema_nominas;uid=root;pwd=;";


        public FormHistorialVacaciones()
        {
            InitializeComponent();
            InicializarControles();
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
                using (MySqlConnection cn = new MySqlConnection(conexion))
                {
                    cn.Open();


                    string query = @"
                    SELECT
                        v.cmp_fecha_inicio AS 'Fecha Inicio',
                        v.cmp_fecha_fin AS 'Fecha Fin',
                        v.cmp_cantidad_dias AS 'Días',
                        v.cmp_motivo AS 'Motivo',
                        v.cmp_estado AS 'Estado'
                    FROM tbl_vacaciones v
                    ORDER BY v.cmp_fecha_inicio DESC";


                    MySqlDataAdapter da = new MySqlDataAdapter(query, cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvHistorialVacaciones.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error de conexión",
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


            string contenido =
                "CONSTANCIA DE VACACIONES\n" +
                "===========================\n\n" +
                "Fecha Inicio: " + fila.Cells["Fecha Inicio"].Value.ToString() + "\n" +
                "Fecha Fin: " + fila.Cells["Fecha Fin"].Value.ToString() + "\n" +
                "Cantidad de días: " + fila.Cells["Días"].Value.ToString() + "\n" +
                "Motivo: " + fila.Cells["Motivo"].Value.ToString() + "\n" +
                "Estado: " + fila.Cells["Estado"].Value.ToString() + "\n\n" +
                "Sistema de Nóminas";


            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Archivo de texto (*.txt)|*.txt";
            guardar.FileName = "Constancia_Vacaciones.txt";


            if (guardar.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(
                    guardar.FileName,
                    contenido
                );


                MessageBox.Show(
                    "Constancia descargada correctamente.",
                    "Constancia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
