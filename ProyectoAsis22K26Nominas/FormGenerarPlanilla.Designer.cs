namespace ProyectoAsis22K26Nominas
{
    partial class FormGenerarPlanilla
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerarPlanilla));
            this.Dgv_Detalle_Planilla = new System.Windows.Forms.DataGridView();
            this.Btn_Generar = new System.Windows.Forms.Button();
            this.Dtp_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Txt_Total_Ingresos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Total_Descuentos = new System.Windows.Forms.TextBox();
            this.Lbl_Total_Pagar = new System.Windows.Forms.Label();
            this.Txt_Total_Paga = new System.Windows.Forms.TextBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Pnl_Personal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pnl_Detalle = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Planilla)).BeginInit();
            this.Pnl_Personal.SuspendLayout();
            this.Pnl_Detalle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Detalle_Planilla
            // 
            this.Dgv_Detalle_Planilla.AllowUserToAddRows = false;
            this.Dgv_Detalle_Planilla.AllowUserToDeleteRows = false;
            this.Dgv_Detalle_Planilla.AllowUserToResizeColumns = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.Dgv_Detalle_Planilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Dgv_Detalle_Planilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Detalle_Planilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Detalle_Planilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.Dgv_Detalle_Planilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Detalle_Planilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_Detalle_Planilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Detalle_Planilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Dgv_Detalle_Planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Detalle_Planilla.DefaultCellStyle = dataGridViewCellStyle11;
            this.Dgv_Detalle_Planilla.EnableHeadersVisualStyles = false;
            this.Dgv_Detalle_Planilla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Dgv_Detalle_Planilla.Location = new System.Drawing.Point(22, 55);
            this.Dgv_Detalle_Planilla.MultiSelect = false;
            this.Dgv_Detalle_Planilla.Name = "Dgv_Detalle_Planilla";
            this.Dgv_Detalle_Planilla.ReadOnly = true;
            this.Dgv_Detalle_Planilla.RowHeadersVisible = false;
            this.Dgv_Detalle_Planilla.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.Dgv_Detalle_Planilla.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.Dgv_Detalle_Planilla.RowTemplate.Height = 24;
            this.Dgv_Detalle_Planilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Detalle_Planilla.Size = new System.Drawing.Size(817, 268);
            this.Dgv_Detalle_Planilla.TabIndex = 51;
            // 
            // Btn_Generar
            // 
            this.Btn_Generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Btn_Generar.FlatAppearance.BorderSize = 0;
            this.Btn_Generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Generar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Generar.Location = new System.Drawing.Point(318, 292);
            this.Btn_Generar.Name = "Btn_Generar";
            this.Btn_Generar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Generar.TabIndex = 50;
            this.Btn_Generar.Text = "Generar";
            this.Btn_Generar.UseMnemonic = false;
            this.Btn_Generar.UseVisualStyleBackColor = false;
            this.Btn_Generar.Click += new System.EventHandler(this.Btn_Generar_Click);
            // 
            // Dtp_Fecha_Fin
            // 
            this.Dtp_Fecha_Fin.CalendarForeColor = System.Drawing.Color.White;
            this.Dtp_Fecha_Fin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.Dtp_Fecha_Fin.CustomFormat = "dd/MM/yyyy";
            this.Dtp_Fecha_Fin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Fecha_Fin.Location = new System.Drawing.Point(377, 67);
            this.Dtp_Fecha_Fin.Name = "Dtp_Fecha_Fin";
            this.Dtp_Fecha_Fin.Size = new System.Drawing.Size(200, 30);
            this.Dtp_Fecha_Fin.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Periodo Fin:";
            // 
            // Dtp_Fecha_Inicio
            // 
            this.Dtp_Fecha_Inicio.CalendarForeColor = System.Drawing.Color.White;
            this.Dtp_Fecha_Inicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.Dtp_Fecha_Inicio.CustomFormat = "dd/MM/yyyy";
            this.Dtp_Fecha_Inicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Fecha_Inicio.Location = new System.Drawing.Point(377, 15);
            this.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio";
            this.Dtp_Fecha_Inicio.Size = new System.Drawing.Size(200, 30);
            this.Dtp_Fecha_Inicio.TabIndex = 47;
            this.Dtp_Fecha_Inicio.ValueChanged += new System.EventHandler(this.Dpt_Fecha_Inicio_ValueChanged);
            // 
            // Txt_Total_Ingresos
            // 
            this.Txt_Total_Ingresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Total_Ingresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Total_Ingresos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total_Ingresos.ForeColor = System.Drawing.Color.White;
            this.Txt_Total_Ingresos.Location = new System.Drawing.Point(377, 119);
            this.Txt_Total_Ingresos.Name = "Txt_Total_Ingresos";
            this.Txt_Total_Ingresos.ReadOnly = true;
            this.Txt_Total_Ingresos.Size = new System.Drawing.Size(208, 30);
            this.Txt_Total_Ingresos.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(258, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Total Ingresos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(237, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "Total Descuentos:";
            // 
            // Txt_Total_Descuentos
            // 
            this.Txt_Total_Descuentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Total_Descuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Total_Descuentos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total_Descuentos.ForeColor = System.Drawing.Color.White;
            this.Txt_Total_Descuentos.Location = new System.Drawing.Point(377, 176);
            this.Txt_Total_Descuentos.Name = "Txt_Total_Descuentos";
            this.Txt_Total_Descuentos.ReadOnly = true;
            this.Txt_Total_Descuentos.Size = new System.Drawing.Size(208, 30);
            this.Txt_Total_Descuentos.TabIndex = 56;
            // 
            // Lbl_Total_Pagar
            // 
            this.Lbl_Total_Pagar.AutoSize = true;
            this.Lbl_Total_Pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Total_Pagar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total_Pagar.ForeColor = System.Drawing.Color.White;
            this.Lbl_Total_Pagar.Location = new System.Drawing.Point(259, 233);
            this.Lbl_Total_Pagar.Name = "Lbl_Total_Pagar";
            this.Lbl_Total_Pagar.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Total_Pagar.TabIndex = 57;
            this.Lbl_Total_Pagar.Text = "Total a Pagar:";
            // 
            // Txt_Total_Paga
            // 
            this.Txt_Total_Paga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Total_Paga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Total_Paga.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total_Paga.ForeColor = System.Drawing.Color.White;
            this.Txt_Total_Paga.Location = new System.Drawing.Point(377, 229);
            this.Txt_Total_Paga.Name = "Txt_Total_Paga";
            this.Txt_Total_Paga.ReadOnly = true;
            this.Txt_Total_Paga.Size = new System.Drawing.Size(208, 30);
            this.Txt_Total_Paga.TabIndex = 58;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpiar.Location = new System.Drawing.Point(495, 292);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Limpiar.TabIndex = 59;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Pnl_Personal
            // 
            this.Pnl_Personal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Personal.Controls.Add(this.label4);
            this.Pnl_Personal.Controls.Add(this.Btn_Limpiar);
            this.Pnl_Personal.Controls.Add(this.label7);
            this.Pnl_Personal.Controls.Add(this.label3);
            this.Pnl_Personal.Controls.Add(this.Btn_Generar);
            this.Pnl_Personal.Controls.Add(this.Lbl_Total_Pagar);
            this.Pnl_Personal.Controls.Add(this.Txt_Total_Paga);
            this.Pnl_Personal.Controls.Add(this.Dtp_Fecha_Inicio);
            this.Pnl_Personal.Controls.Add(this.label1);
            this.Pnl_Personal.Controls.Add(this.Txt_Total_Descuentos);
            this.Pnl_Personal.Controls.Add(this.label2);
            this.Pnl_Personal.Controls.Add(this.Dtp_Fecha_Fin);
            this.Pnl_Personal.Controls.Add(this.Txt_Total_Ingresos);
            this.Pnl_Personal.Location = new System.Drawing.Point(21, 149);
            this.Pnl_Personal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Personal.Name = "Pnl_Personal";
            this.Pnl_Personal.Size = new System.Drawing.Size(891, 350);
            this.Pnl_Personal.TabIndex = 77;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.label7.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(259, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Periodo Inicio:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Pnl_Detalle
            // 
            this.Pnl_Detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Detalle.Controls.Add(this.label8);
            this.Pnl_Detalle.Controls.Add(this.Dgv_Detalle_Planilla);
            this.Pnl_Detalle.Location = new System.Drawing.Point(21, 516);
            this.Pnl_Detalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Detalle.Name = "Pnl_Detalle";
            this.Pnl_Detalle.Size = new System.Drawing.Size(891, 350);
            this.Pnl_Detalle.TabIndex = 78;
            this.Pnl_Detalle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 100);
            this.panel1.TabIndex = 84;
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
            this.label6.Size = new System.Drawing.Size(607, 26);
            this.label6.TabIndex = 72;
            this.label6.Text = "Genere la planilla de pagos correspondiente al período seleccionado.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(116, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 54);
            this.label5.TabIndex = 75;
            this.label5.Text = "Generar Planilla";
            // 
            // FormGenerarPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1015, 895);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_Personal);
            this.Controls.Add(this.Pnl_Detalle);
            this.Name = "FormGenerarPlanilla";
            this.Text = "FormGenerarPlanilla";
            this.Load += new System.EventHandler(this.FormGenerarPlanilla_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Planilla)).EndInit();
            this.Pnl_Personal.ResumeLayout(false);
            this.Pnl_Personal.PerformLayout();
            this.Pnl_Detalle.ResumeLayout(false);
            this.Pnl_Detalle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_Detalle_Planilla;
        private System.Windows.Forms.Button Btn_Generar;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Inicio;
        private System.Windows.Forms.TextBox Txt_Total_Ingresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Total_Descuentos;
        private System.Windows.Forms.Label Lbl_Total_Pagar;
        private System.Windows.Forms.TextBox Txt_Total_Paga;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Panel Pnl_Personal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Pnl_Detalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}