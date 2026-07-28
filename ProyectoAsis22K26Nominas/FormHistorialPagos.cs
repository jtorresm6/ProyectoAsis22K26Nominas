using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    public partial class FormHistorialPagos : Form
    {
        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private DataGridView dgvHistorialPagos;
        private Button btnFiltrar;

        private string conexion = "server=localhost;database=db_sistema_nominas;uid=root;pwd=;";

        public FormHistorialPagos()
        {
            InitializeComponent();
            InicializarControles();
            CargarHistorialPagos();
        }

        private void InicializarControles()
        {
            this.BackColor = Color.FromArgb(27, 24, 37);

            lblDesde = new Label();
            lblHasta = new Label();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            dgvHistorialPagos = new DataGridView();
            btnFiltrar = new Button();


            lblDesde.Text = "Desde:";
            lblDesde.Location = new Point(20, 20);
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblDesde.ForeColor = Color.WhiteSmoke;


            dtpDesde.Location = new Point(80, 15);
            dtpDesde.Size = new Size(140, 25);
            dtpDesde.Format = DateTimePickerFormat.Short;


            lblHasta.Text = "Hasta:";
            lblHasta.Location = new Point(245, 20);
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblHasta.ForeColor = Color.WhiteSmoke;


            dtpHasta.Location = new Point(305, 15);
            dtpHasta.Size = new Size(140, 25);
            dtpHasta.Format = DateTimePickerFormat.Short;


            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Location = new Point(470, 14);
            btnFiltrar.Size = new Size(120, 35);
            btnFiltrar.BackColor = Color.FromArgb(235, 22, 86);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.Click += BtnFiltrar_Click;


            dgvHistorialPagos.Location = new Point(20, 70);
            dgvHistorialPagos.Size = new Size(760, 360);
            dgvHistorialPagos.AllowUserToAddRows = false;
            dgvHistorialPagos.AllowUserToDeleteRows = false;
            dgvHistorialPagos.ReadOnly = true;
            dgvHistorialPagos.MultiSelect = false;
            dgvHistorialPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvHistorialPagos.BackgroundColor = Color.FromArgb(32, 30, 43);
            dgvHistorialPagos.BorderStyle = BorderStyle.None;
            dgvHistorialPagos.GridColor = Color.FromArgb(55, 55, 70);
            dgvHistorialPagos.RowHeadersVisible = false;
            dgvHistorialPagos.EnableHeadersVisualStyles = false;


            dgvHistorialPagos.ColumnHeadersHeight = 38;
            dgvHistorialPagos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHistorialPagos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 22, 86);
            dgvHistorialPagos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorialPagos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvHistorialPagos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvHistorialPagos.DefaultCellStyle.BackColor = Color.FromArgb(40, 37, 54);
            dgvHistorialPagos.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvHistorialPagos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 22, 86);
            dgvHistorialPagos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistorialPagos.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvHistorialPagos.RowsDefaultCellStyle.BackColor = Color.FromArgb(40, 37, 54);
            dgvHistorialPagos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(48, 45, 62);


            Controls.Add(lblDesde);
            Controls.Add(dtpDesde);
            Controls.Add(lblHasta);
            Controls.Add(dtpHasta);
            Controls.Add(btnFiltrar);
            Controls.Add(dgvHistorialPagos);
        }


        private void CargarHistorialPagos()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(conexion))
                {
                    cn.Open();

                    string query = @"
                    SELECT
                        p.cmp_fecha_pago AS Fecha,
                        CONCAT(e.cmp_nombre,' ',e.cmp_apellido) AS Empleado,
                        p.cmp_forma_pago AS TipoPago,
                        p.cmp_numero_recibo AS Transferencia,
                        p.cmp_monto_pagado AS Monto
                    FROM tbl_pagos p
                    INNER JOIN tbl_detalle_planilla d
                    ON p.cmp_id_detalle_planilla = d.cmp_id_detalle_planilla
                    INNER JOIN tbl_empleados e
                    ON d.cmp_id_empleado = e.cmp_id_empleado";

                    MySqlCommand cmd = new MySqlCommand(query, cn);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvHistorialPagos.DataSource = dt;
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


        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show(
                    "La fecha Desde no puede ser mayor que Hasta.",
                    "Fechas inválidas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpDesde.Focus();
                return;
            }


            try
            {
                using (MySqlConnection cn = new MySqlConnection(conexion))
                {
                    cn.Open();

                    string query = @"
                    SELECT
                        p.cmp_fecha_pago AS Fecha,
                        CONCAT(e.cmp_nombre,' ',e.cmp_apellido) AS Empleado,
                        p.cmp_forma_pago AS TipoPago,
                        p.cmp_numero_recibo AS Transferencia,
                        p.cmp_monto_pagado AS Monto
                    FROM tbl_pagos p
                    INNER JOIN tbl_detalle_planilla d
                    ON p.cmp_id_detalle_planilla = d.cmp_id_detalle_planilla
                    INNER JOIN tbl_empleados e
                    ON d.cmp_id_empleado = e.cmp_id_empleado
                    WHERE p.cmp_fecha_pago BETWEEN @desde AND @hasta";


                    MySqlCommand cmd = new MySqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@desde", dtpDesde.Value.Date);
                    cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);


                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvHistorialPagos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
