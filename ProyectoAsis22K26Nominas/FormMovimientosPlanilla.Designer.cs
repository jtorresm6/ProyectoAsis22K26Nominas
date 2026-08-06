
namespace ProyectoAsis22K26Nominas
{
    partial class FormMovimientosPlanilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovimientosPlanilla));
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Lbl_Periodo = new System.Windows.Forms.Label();
            this.Lbl_Codigo_Empleado = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Campo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Empleado = new System.Windows.Forms.TextBox();
            this.Dpt_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Dpt_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Lbl_Tipo_Movimiento = new System.Windows.Forms.Label();
            this.Cbo_Tipo_Movimiento = new System.Windows.Forms.ComboBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_Monto = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Dgv_Movimientos = new System.Windows.Forms.DataGridView();
            this.Cbo_Buscar_Campo = new System.Windows.Forms.ComboBox();
            this.Pnl_Personal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Pnl_Plani = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Movimientos)).BeginInit();
            this.Pnl_Personal.SuspendLayout();
            this.Pnl_Plani.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Empleado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Empleado.ForeColor = System.Drawing.Color.White;
            this.Lbl_Empleado.Location = new System.Drawing.Point(32, 150);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(156, 26);
            this.Lbl_Empleado.TabIndex = 11;
            this.Lbl_Empleado.Text = "Nombre Empleado:";
            // 
            // Lbl_Periodo
            // 
            this.Lbl_Periodo.AutoSize = true;
            this.Lbl_Periodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Periodo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Periodo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Periodo.Location = new System.Drawing.Point(44, 226);
            this.Lbl_Periodo.Name = "Lbl_Periodo";
            this.Lbl_Periodo.Size = new System.Drawing.Size(118, 26);
            this.Lbl_Periodo.TabIndex = 12;
            this.Lbl_Periodo.Text = "Periodo Inicio:";
            // 
            // Lbl_Codigo_Empleado
            // 
            this.Lbl_Codigo_Empleado.AutoSize = true;
            this.Lbl_Codigo_Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Codigo_Empleado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Codigo_Empleado.ForeColor = System.Drawing.Color.White;
            this.Lbl_Codigo_Empleado.Location = new System.Drawing.Point(29, 71);
            this.Lbl_Codigo_Empleado.Name = "Lbl_Codigo_Empleado";
            this.Lbl_Codigo_Empleado.Size = new System.Drawing.Size(155, 26);
            this.Lbl_Codigo_Empleado.TabIndex = 13;
            this.Lbl_Codigo_Empleado.Text = "Buscar por campo:";
            this.Lbl_Codigo_Empleado.Click += new System.EventHandler(this.Lbl_Codigo_Empleado_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(513, 294);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Buscar.TabIndex = 14;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Campo
            // 
            this.Txt_Campo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Campo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Campo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Campo.ForeColor = System.Drawing.Color.White;
            this.Txt_Campo.Location = new System.Drawing.Point(326, 68);
            this.Txt_Campo.Name = "Txt_Campo";
            this.Txt_Campo.Size = new System.Drawing.Size(225, 30);
            this.Txt_Campo.TabIndex = 15;
            // 
            // Txt_Nombre_Empleado
            // 
            this.Txt_Nombre_Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Nombre_Empleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Nombre_Empleado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre_Empleado.ForeColor = System.Drawing.Color.White;
            this.Txt_Nombre_Empleado.Location = new System.Drawing.Point(194, 147);
            this.Txt_Nombre_Empleado.Name = "Txt_Nombre_Empleado";
            this.Txt_Nombre_Empleado.Size = new System.Drawing.Size(247, 30);
            this.Txt_Nombre_Empleado.TabIndex = 16;
            // 
            // Dpt_Fecha_Inicio
            // 
            this.Dpt_Fecha_Inicio.CustomFormat = "dd/MM/yyyy";
            this.Dpt_Fecha_Inicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dpt_Fecha_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dpt_Fecha_Inicio.Location = new System.Drawing.Point(165, 225);
            this.Dpt_Fecha_Inicio.Name = "Dpt_Fecha_Inicio";
            this.Dpt_Fecha_Inicio.Size = new System.Drawing.Size(200, 30);
            this.Dpt_Fecha_Inicio.TabIndex = 17;
            // 
            // Dpt_Fecha_Fin
            // 
            this.Dpt_Fecha_Fin.CustomFormat = "dd/MM/yyyy";
            this.Dpt_Fecha_Fin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dpt_Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dpt_Fecha_Fin.Location = new System.Drawing.Point(165, 289);
            this.Dpt_Fecha_Fin.Name = "Dpt_Fecha_Fin";
            this.Dpt_Fecha_Fin.Size = new System.Drawing.Size(200, 30);
            this.Dpt_Fecha_Fin.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Periodo Fin:";
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consultar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultar.ForeColor = System.Drawing.Color.White;
            this.Btn_Consultar.Location = new System.Drawing.Point(686, 294);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Consultar.TabIndex = 24;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Lbl_Tipo_Movimiento
            // 
            this.Lbl_Tipo_Movimiento.AutoSize = true;
            this.Lbl_Tipo_Movimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Tipo_Movimiento.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo_Movimiento.ForeColor = System.Drawing.Color.White;
            this.Lbl_Tipo_Movimiento.Location = new System.Drawing.Point(582, 72);
            this.Lbl_Tipo_Movimiento.Name = "Lbl_Tipo_Movimiento";
            this.Lbl_Tipo_Movimiento.Size = new System.Drawing.Size(162, 26);
            this.Lbl_Tipo_Movimiento.TabIndex = 25;
            this.Lbl_Tipo_Movimiento.Text = "Tipo de Movimiento:";
            // 
            // Cbo_Tipo_Movimiento
            // 
            this.Cbo_Tipo_Movimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Cbo_Tipo_Movimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Tipo_Movimiento.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Tipo_Movimiento.ForeColor = System.Drawing.Color.White;
            this.Cbo_Tipo_Movimiento.FormattingEnabled = true;
            this.Cbo_Tipo_Movimiento.Location = new System.Drawing.Point(758, 67);
            this.Cbo_Tipo_Movimiento.Name = "Cbo_Tipo_Movimiento";
            this.Cbo_Tipo_Movimiento.Size = new System.Drawing.Size(187, 34);
            this.Cbo_Tipo_Movimiento.TabIndex = 26;
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(474, 151);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(105, 26);
            this.Lbl_Descripcion.TabIndex = 27;
            this.Lbl_Descripcion.Text = "Descripcion:";
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.ForeColor = System.Drawing.Color.White;
            this.Lbl_Cantidad.Location = new System.Drawing.Point(736, 214);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(86, 26);
            this.Lbl_Cantidad.TabIndex = 28;
            this.Lbl_Cantidad.Text = "Cantidad:";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.White;
            this.Txt_Descripcion.Location = new System.Drawing.Point(585, 147);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(355, 30);
            this.Txt_Descripcion.TabIndex = 29;
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Monto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto.ForeColor = System.Drawing.Color.White;
            this.Lbl_Monto.Location = new System.Drawing.Point(516, 214);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(63, 26);
            this.Lbl_Monto.TabIndex = 30;
            this.Lbl_Monto.Text = "Monto:";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Cantidad.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.ForeColor = System.Drawing.Color.White;
            this.Txt_Cantidad.Location = new System.Drawing.Point(828, 210);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(112, 30);
            this.Txt_Cantidad.TabIndex = 32;
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Monto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Monto.ForeColor = System.Drawing.Color.White;
            this.Txt_Monto.Location = new System.Drawing.Point(585, 210);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(127, 30);
            this.Txt_Monto.TabIndex = 33;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Location = new System.Drawing.Point(437, 932);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Guardar.TabIndex = 36;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(630, 932);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Eliminar.TabIndex = 38;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.Btn_Modificar.Location = new System.Drawing.Point(251, 932);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Modificar.TabIndex = 37;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Dgv_Movimientos
            // 
            this.Dgv_Movimientos.AllowUserToAddRows = false;
            this.Dgv_Movimientos.AllowUserToDeleteRows = false;
            this.Dgv_Movimientos.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.Dgv_Movimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Movimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Movimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Movimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.Dgv_Movimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Movimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_Movimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Movimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Movimientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Movimientos.EnableHeadersVisualStyles = false;
            this.Dgv_Movimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Dgv_Movimientos.Location = new System.Drawing.Point(22, 46);
            this.Dgv_Movimientos.MultiSelect = false;
            this.Dgv_Movimientos.Name = "Dgv_Movimientos";
            this.Dgv_Movimientos.ReadOnly = true;
            this.Dgv_Movimientos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Dgv_Movimientos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Movimientos.RowTemplate.Height = 24;
            this.Dgv_Movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Movimientos.Size = new System.Drawing.Size(923, 305);
            this.Dgv_Movimientos.TabIndex = 39;
            this.Dgv_Movimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Movimientos_CellClick);
            // 
            // Cbo_Buscar_Campo
            // 
            this.Cbo_Buscar_Campo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Cbo_Buscar_Campo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Buscar_Campo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Buscar_Campo.ForeColor = System.Drawing.Color.White;
            this.Cbo_Buscar_Campo.FormattingEnabled = true;
            this.Cbo_Buscar_Campo.Location = new System.Drawing.Point(190, 67);
            this.Cbo_Buscar_Campo.Name = "Cbo_Buscar_Campo";
            this.Cbo_Buscar_Campo.Size = new System.Drawing.Size(121, 34);
            this.Cbo_Buscar_Campo.TabIndex = 40;
            // 
            // Pnl_Personal
            // 
            this.Pnl_Personal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Personal.Controls.Add(this.label4);
            this.Pnl_Personal.Controls.Add(this.Cbo_Buscar_Campo);
            this.Pnl_Personal.Controls.Add(this.Lbl_Codigo_Empleado);
            this.Pnl_Personal.Controls.Add(this.Txt_Campo);
            this.Pnl_Personal.Controls.Add(this.Lbl_Empleado);
            this.Pnl_Personal.Controls.Add(this.Dpt_Fecha_Fin);
            this.Pnl_Personal.Controls.Add(this.Btn_Consultar);
            this.Pnl_Personal.Controls.Add(this.label1);
            this.Pnl_Personal.Controls.Add(this.Lbl_Monto);
            this.Pnl_Personal.Controls.Add(this.Dpt_Fecha_Inicio);
            this.Pnl_Personal.Controls.Add(this.Txt_Monto);
            this.Pnl_Personal.Controls.Add(this.Lbl_Periodo);
            this.Pnl_Personal.Controls.Add(this.Lbl_Cantidad);
            this.Pnl_Personal.Controls.Add(this.Txt_Nombre_Empleado);
            this.Pnl_Personal.Controls.Add(this.Txt_Cantidad);
            this.Pnl_Personal.Controls.Add(this.Btn_Buscar);
            this.Pnl_Personal.Controls.Add(this.Lbl_Tipo_Movimiento);
            this.Pnl_Personal.Controls.Add(this.Txt_Descripcion);
            this.Pnl_Personal.Controls.Add(this.Lbl_Descripcion);
            this.Pnl_Personal.Controls.Add(this.Cbo_Tipo_Movimiento);
            this.Pnl_Personal.Location = new System.Drawing.Point(12, 125);
            this.Pnl_Personal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Personal.Name = "Pnl_Personal";
            this.Pnl_Personal.Size = new System.Drawing.Size(971, 366);
            this.Pnl_Personal.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 26);
            this.label4.TabIndex = 71;
            this.label4.Text = "Búsqueda de Empleados";
            // 
            // Pnl_Plani
            // 
            this.Pnl_Plani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Plani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Plani.Controls.Add(this.label8);
            this.Pnl_Plani.Controls.Add(this.Dgv_Movimientos);
            this.Pnl_Plani.Location = new System.Drawing.Point(12, 538);
            this.Pnl_Plani.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Plani.Name = "Pnl_Plani";
            this.Pnl_Plani.Size = new System.Drawing.Size(971, 371);
            this.Pnl_Plani.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label8.Location = new System.Drawing.Point(18, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 26);
            this.label8.TabIndex = 71;
            this.label8.Text = "Detalle de planilla";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 100);
            this.panel1.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(121, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(671, 26);
            this.label6.TabIndex = 72;
            this.label6.Text = "Consulte y gestione los movimientos registrados en la planilla de empleados.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(116, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 54);
            this.label5.TabIndex = 75;
            this.label5.Text = "Edición Planilla";
            // 
            // FormMovimientosPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1015, 995);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Pnl_Personal);
            this.Controls.Add(this.Pnl_Plani);
            this.Controls.Add(this.button1);
            this.Name = "FormMovimientosPlanilla";
            this.Text = "FormMovimientosPlanilla";
            this.Load += new System.EventHandler(this.FormMovimientosPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Movimientos)).EndInit();
            this.Pnl_Personal.ResumeLayout(false);
            this.Pnl_Personal.PerformLayout();
            this.Pnl_Plani.ResumeLayout(false);
            this.Pnl_Plani.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.Label Lbl_Periodo;
        private System.Windows.Forms.Label Lbl_Codigo_Empleado;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Campo;
        private System.Windows.Forms.TextBox Txt_Nombre_Empleado;
        private System.Windows.Forms.DateTimePicker Dpt_Fecha_Inicio;
        private System.Windows.Forms.DateTimePicker Dpt_Fecha_Fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Label Lbl_Tipo_Movimiento;
        private System.Windows.Forms.ComboBox Cbo_Tipo_Movimiento;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.DataGridView Dgv_Movimientos;
        private System.Windows.Forms.ComboBox Cbo_Buscar_Campo;
        private System.Windows.Forms.Panel Pnl_Personal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Pnl_Plani;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}