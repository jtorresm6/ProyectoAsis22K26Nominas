using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
    
namespace ProyectoAsis22K26Nominas
{
    //Parte trabajada por Diego Alejandro Cheng Peña - carné: 0901-22-8091
    //Curso:Análisis de sistemas II
    //Fecha de creación: 24-07-2026
    //Fecha de última modificación 02-08-2026
    public partial class FormHistorialPagos : Form
    {
        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private DataGridView dgvHistorialPagos;
        private Button btnFiltrar;

        public FormHistorialPagos()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void FormHistorialPagos_Load(object sender, EventArgs e)
        {
            // Carga los datos cuando el formulario ya se ha renderizado
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
                using (MySqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    cn.Open();

                    string query = @"
                    SELECT
                        p.fecha_pago AS Fecha,
                        CONCAT(e.nombre_emp, ' ', e.apellido_emp) AS Empleado,
                        p.forma_pago AS TipoPago,
                        p.numero_recibo AS Transferencia,
                        p.monto_pago AS Monto
                    FROM tbl_pagos p
                    INNER JOIN tbl_planilla_detalle d
                    ON p.id_planilla = d.id_planilla AND p.id_empleado = d.id_empleado
                    INNER JOIN tbl_empleados e
                    ON d.id_empleado = e.id_empleado
                    ORDER BY p.fecha_pago DESC";

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
                    "Error de conexión con la base de datos",
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
                using (MySqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    cn.Open();

                    string query = @"
                    SELECT
                        p.fecha_pago AS Fecha,
                        CONCAT(e.nombre_emp, ' ', e.apellido_emp) AS Empleado,
                        p.forma_pago AS TipoPago,
                        p.numero_recibo AS Transferencia,
                        p.monto_pago AS Monto
                    FROM tbl_pagos p
                    INNER JOIN tbl_planilla_detalle d
                    ON p.id_planilla = d.id_planilla AND p.id_empleado = d.id_empleado
                    INNER JOIN tbl_empleados e
                    ON d.id_empleado = e.id_empleado
                    WHERE p.fecha_pago BETWEEN @desde AND @hasta
                    ORDER BY p.fecha_pago DESC";

                    // Ajuste de rango para abarcar todo el día límite (hasta las 23:59:59)
                    DateTime fechaDesde = dtpDesde.Value.Date;
                    DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@desde", fechaDesde);
                    cmd.Parameters.AddWithValue("@hasta", fechaHasta);

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
                    "Error al filtrar los datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
