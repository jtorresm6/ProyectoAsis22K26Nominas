using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    //Parte trabajada por Diego Alejandro Cheng Peña - carné: 0901-22-8091
    //Curso: Análisis de sistemas II
    //Fecha de creación: 24-07-2026
    //Fecha de última modificación 03-08-2026

    public partial class FormHistorialPagos : Form
    {
        private Label Lbl_desde;
        private Label Lbl_hasta;
        private DateTimePicker Dtp_desde;
        private DateTimePicker Dtp_hasta;
        private DataGridView Dgv_historialPagos;
        private Button Btn_filtrar;

        public FormHistorialPagos()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void FormHistorialPagos_Load(object sender, EventArgs e)
        {
            CargarHistorialPagos();
        }

        private void InicializarControles()
        {
            this.BackColor = Color.FromArgb(27, 24, 37);

            Lbl_desde = new Label();
            Lbl_hasta = new Label();
            Dtp_desde = new DateTimePicker();
            Dtp_hasta = new DateTimePicker();
            Dgv_historialPagos = new DataGridView();
            Btn_filtrar = new Button();

            Lbl_desde.Text = "Desde:";
            Lbl_desde.Location = new Point(20, 20);
            Lbl_desde.AutoSize = true;
            Lbl_desde.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Lbl_desde.ForeColor = Color.WhiteSmoke;

            Dtp_desde.Location = new Point(80, 15);
            Dtp_desde.Size = new Size(140, 25);
            Dtp_desde.Format = DateTimePickerFormat.Short;

            Lbl_hasta.Text = "Hasta:";
            Lbl_hasta.Location = new Point(245, 20);
            Lbl_hasta.AutoSize = true;
            Lbl_hasta.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Lbl_hasta.ForeColor = Color.WhiteSmoke;

            Dtp_hasta.Location = new Point(305, 15);
            Dtp_hasta.Size = new Size(140, 25);
            Dtp_hasta.Format = DateTimePickerFormat.Short;

            Btn_filtrar.Name = "Btn_filtrar";
            Btn_filtrar.Text = "Filtrar";
            Btn_filtrar.Location = new Point(470, 14);
            Btn_filtrar.Size = new Size(120, 35);
            Btn_filtrar.BackColor = Color.FromArgb(235, 22, 86);
            Btn_filtrar.ForeColor = Color.White;
            Btn_filtrar.FlatStyle = FlatStyle.Flat;
            Btn_filtrar.FlatAppearance.BorderSize = 0;
            Btn_filtrar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Btn_filtrar.Cursor = Cursors.Hand;
            Btn_filtrar.Click += BtnFiltrar_Click;

            Dgv_historialPagos.Location = new Point(20, 70);
            Dgv_historialPagos.Size = new Size(760, 360);
            Dgv_historialPagos.AllowUserToAddRows = false;
            Dgv_historialPagos.AllowUserToDeleteRows = false;
            Dgv_historialPagos.ReadOnly = true;
            Dgv_historialPagos.MultiSelect = false;
            Dgv_historialPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_historialPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Dgv_historialPagos.BackgroundColor = Color.FromArgb(32, 30, 43);
            Dgv_historialPagos.BorderStyle = BorderStyle.None;
            Dgv_historialPagos.GridColor = Color.FromArgb(55, 55, 70);
            Dgv_historialPagos.RowHeadersVisible = false;
            Dgv_historialPagos.EnableHeadersVisualStyles = false;

            Dgv_historialPagos.ColumnHeadersHeight = 38;
            Dgv_historialPagos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Dgv_historialPagos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 22, 86);
            Dgv_historialPagos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Dgv_historialPagos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Dgv_historialPagos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Dgv_historialPagos.DefaultCellStyle.BackColor = Color.FromArgb(40, 37, 54);
            Dgv_historialPagos.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            Dgv_historialPagos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 22, 86);
            Dgv_historialPagos.DefaultCellStyle.SelectionForeColor = Color.White;
            Dgv_historialPagos.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            Dgv_historialPagos.RowsDefaultCellStyle.BackColor = Color.FromArgb(40, 37, 54);
            Dgv_historialPagos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(48, 45, 62);

            Controls.Add(Lbl_desde);
            Controls.Add(Dtp_desde);
            Controls.Add(Lbl_hasta);
            Controls.Add(Dtp_hasta);
            Controls.Add(Btn_filtrar);
            Controls.Add(Dgv_historialPagos);
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

                    Dgv_historialPagos.DataSource = dt;
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
            if (Dtp_desde.Value.Date > Dtp_hasta.Value.Date)
            {
                MessageBox.Show(
                    "La fecha Desde no puede ser mayor que Hasta.",
                    "Fechas inválidas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Dtp_desde.Focus();
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
                    ON p.id_planilla = d.id_planilla
                    AND p.id_empleado = d.id_empleado
                    INNER JOIN tbl_empleados e
                    ON d.id_empleado = e.id_empleado
                    WHERE p.fecha_pago BETWEEN @desde AND @hasta
                    ORDER BY p.fecha_pago DESC";

                    DateTime fechaDesde = Dtp_desde.Value.Date;
                    DateTime fechaHasta = Dtp_hasta.Value.Date.AddDays(1).AddSeconds(-1);

                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@desde", fechaDesde);
                    cmd.Parameters.AddWithValue("@hasta", fechaHasta);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    Dgv_historialPagos.DataSource = dt;
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
