namespace ProyectoAsis22K26Nominas
{
    partial class FormSolicitudVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolicitudVacaciones));
            this.Lbl_Dias_Disponibles = new System.Windows.Forms.Label();
            this.Lbl_Texto_Dias = new System.Windows.Forms.Label();
            this.Cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Aprobar = new System.Windows.Forms.Button();
            this.Btn_Rechazar = new System.Windows.Forms.Button();
            this.Dgv_Solicitudes = new System.Windows.Forms.DataGridView();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Pnl_Personal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Fin = new System.Windows.Forms.Label();
            this.Lbl_Dias_Solicitados = new System.Windows.Forms.Label();
            this.Lbl_Inicio = new System.Windows.Forms.Label();
            this.Txt_Dias_Solicitados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Motivo = new System.Windows.Forms.Label();
            this.Txt_Motivo = new System.Windows.Forms.TextBox();
            this.Pnl_Solis = new System.Windows.Forms.Panel();
            this.Dtp_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.Pnl_Registr = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Solicitudes)).BeginInit();
            this.Pnl_Personal.SuspendLayout();
            this.Pnl_Solis.SuspendLayout();
            this.Pnl_Registr.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Dias_Disponibles
            // 
            this.Lbl_Dias_Disponibles.AutoSize = true;
            this.Lbl_Dias_Disponibles.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Dias_Disponibles.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dias_Disponibles.ForeColor = System.Drawing.Color.White;
            this.Lbl_Dias_Disponibles.Location = new System.Drawing.Point(180, 77);
            this.Lbl_Dias_Disponibles.Name = "Lbl_Dias_Disponibles";
            this.Lbl_Dias_Disponibles.Size = new System.Drawing.Size(57, 26);
            this.Lbl_Dias_Disponibles.TabIndex = 3;
            this.Lbl_Dias_Disponibles.Text = "0 días";
            // 
            // Lbl_Texto_Dias
            // 
            this.Lbl_Texto_Dias.AutoSize = true;
            this.Lbl_Texto_Dias.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Texto_Dias.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Texto_Dias.ForeColor = System.Drawing.Color.White;
            this.Lbl_Texto_Dias.Location = new System.Drawing.Point(36, 77);
            this.Lbl_Texto_Dias.Name = "Lbl_Texto_Dias";
            this.Lbl_Texto_Dias.Size = new System.Drawing.Size(144, 26);
            this.Lbl_Texto_Dias.TabIndex = 2;
            this.Lbl_Texto_Dias.Text = "Días Disponibles: ";
            // 
            // Cbo_Empleado
            // 
            this.Cbo_Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Cbo_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Empleado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Empleado.ForeColor = System.Drawing.Color.White;
            this.Cbo_Empleado.FormattingEnabled = true;
            this.Cbo_Empleado.Location = new System.Drawing.Point(140, 40);
            this.Cbo_Empleado.Name = "Cbo_Empleado";
            this.Cbo_Empleado.Size = new System.Drawing.Size(350, 34);
            this.Cbo_Empleado.TabIndex = 1;
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Empleado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Empleado.ForeColor = System.Drawing.Color.White;
            this.Lbl_Empleado.Location = new System.Drawing.Point(39, 45);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(95, 26);
            this.Lbl_Empleado.TabIndex = 0;
            this.Lbl_Empleado.Text = "Empleado: ";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Location = new System.Drawing.Point(771, 310);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(190, 45);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar Solicitud";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click_1);
            // 
            // Btn_Aprobar
            // 
            this.Btn_Aprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Aprobar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(100)))));
            this.Btn_Aprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aprobar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aprobar.ForeColor = System.Drawing.Color.White;
            this.Btn_Aprobar.Location = new System.Drawing.Point(567, 186);
            this.Btn_Aprobar.Name = "Btn_Aprobar";
            this.Btn_Aprobar.Size = new System.Drawing.Size(105, 34);
            this.Btn_Aprobar.TabIndex = 4;
            this.Btn_Aprobar.Text = "Aprobar";
            this.Btn_Aprobar.UseVisualStyleBackColor = false;
            this.Btn_Aprobar.Click += new System.EventHandler(this.Btn_Aprobar_Click_1);
            // 
            // Btn_Rechazar
            // 
            this.Btn_Rechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Rechazar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Btn_Rechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Rechazar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rechazar.ForeColor = System.Drawing.Color.White;
            this.Btn_Rechazar.Location = new System.Drawing.Point(567, 234);
            this.Btn_Rechazar.Name = "Btn_Rechazar";
            this.Btn_Rechazar.Size = new System.Drawing.Size(105, 34);
            this.Btn_Rechazar.TabIndex = 5;
            this.Btn_Rechazar.Text = "Rechazar";
            this.Btn_Rechazar.UseVisualStyleBackColor = false;
            // 
            // Dgv_Solicitudes
            // 
            this.Dgv_Solicitudes.AllowUserToAddRows = false;
            this.Dgv_Solicitudes.AllowUserToDeleteRows = false;
            this.Dgv_Solicitudes.AllowUserToResizeRows = false;
            this.Dgv_Solicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Solicitudes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Solicitudes.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_Solicitudes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Solicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Solicitudes.Location = new System.Drawing.Point(21, 51);
            this.Dgv_Solicitudes.MultiSelect = false;
            this.Dgv_Solicitudes.Name = "Dgv_Solicitudes";
            this.Dgv_Solicitudes.ReadOnly = true;
            this.Dgv_Solicitudes.RowHeadersVisible = false;
            this.Dgv_Solicitudes.RowHeadersWidth = 51;
            this.Dgv_Solicitudes.RowTemplate.Height = 24;
            this.Dgv_Solicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Solicitudes.Size = new System.Drawing.Size(800, 245);
            this.Dgv_Solicitudes.TabIndex = 0;
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Refrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.ForeColor = System.Drawing.Color.White;
            this.Btn_Refrescar.Location = new System.Drawing.Point(808, 380);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(118, 45);
            this.Btn_Refrescar.TabIndex = 7;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Location = new System.Drawing.Point(808, 444);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(118, 45);
            this.Btn_Limpiar.TabIndex = 8;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Pnl_Personal
            // 
            this.Pnl_Personal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Personal.Controls.Add(this.Lbl_Dias_Disponibles);
            this.Pnl_Personal.Controls.Add(this.label4);
            this.Pnl_Personal.Controls.Add(this.Lbl_Texto_Dias);
            this.Pnl_Personal.Controls.Add(this.Lbl_Empleado);
            this.Pnl_Personal.Controls.Add(this.Cbo_Empleado);
            this.Pnl_Personal.Location = new System.Drawing.Point(18, 118);
            this.Pnl_Personal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Personal.Name = "Pnl_Personal";
            this.Pnl_Personal.Size = new System.Drawing.Size(700, 120);
            this.Pnl_Personal.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(17, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 26);
            this.label4.TabIndex = 71;
            this.label4.Text = "Búsqueda de Empleados";
            // 
            // Lbl_Fin
            // 
            this.Lbl_Fin.AutoSize = true;
            this.Lbl_Fin.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Fin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fin.ForeColor = System.Drawing.Color.White;
            this.Lbl_Fin.Location = new System.Drawing.Point(51, 78);
            this.Lbl_Fin.Name = "Lbl_Fin";
            this.Lbl_Fin.Size = new System.Drawing.Size(91, 26);
            this.Lbl_Fin.TabIndex = 2;
            this.Lbl_Fin.Text = "Fecha Fin: ";
            // 
            // Lbl_Dias_Solicitados
            // 
            this.Lbl_Dias_Solicitados.AutoSize = true;
            this.Lbl_Dias_Solicitados.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Dias_Solicitados.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dias_Solicitados.ForeColor = System.Drawing.Color.White;
            this.Lbl_Dias_Solicitados.Location = new System.Drawing.Point(32, 119);
            this.Lbl_Dias_Solicitados.Name = "Lbl_Dias_Solicitados";
            this.Lbl_Dias_Solicitados.Size = new System.Drawing.Size(135, 26);
            this.Lbl_Dias_Solicitados.TabIndex = 4;
            this.Lbl_Dias_Solicitados.Text = "Días Solicitados:";
            // 
            // Lbl_Inicio
            // 
            this.Lbl_Inicio.AutoSize = true;
            this.Lbl_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Inicio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Inicio.ForeColor = System.Drawing.Color.White;
            this.Lbl_Inicio.Location = new System.Drawing.Point(32, 35);
            this.Lbl_Inicio.Name = "Lbl_Inicio";
            this.Lbl_Inicio.Size = new System.Drawing.Size(110, 26);
            this.Lbl_Inicio.TabIndex = 0;
            this.Lbl_Inicio.Text = "Fecha Inicio: ";
            // 
            // Txt_Dias_Solicitados
            // 
            this.Txt_Dias_Solicitados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Txt_Dias_Solicitados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Dias_Solicitados.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Dias_Solicitados.ForeColor = System.Drawing.Color.White;
            this.Txt_Dias_Solicitados.Location = new System.Drawing.Point(173, 117);
            this.Txt_Dias_Solicitados.Name = "Txt_Dias_Solicitados";
            this.Txt_Dias_Solicitados.Size = new System.Drawing.Size(100, 30);
            this.Txt_Dias_Solicitados.TabIndex = 5;
            this.Txt_Dias_Solicitados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 71;
            this.label2.Text = "Solicitudes";
            // 
            // Lbl_Motivo
            // 
            this.Lbl_Motivo.AutoSize = true;
            this.Lbl_Motivo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Motivo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Motivo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Motivo.Location = new System.Drawing.Point(32, 159);
            this.Lbl_Motivo.Name = "Lbl_Motivo";
            this.Lbl_Motivo.Size = new System.Drawing.Size(65, 26);
            this.Lbl_Motivo.TabIndex = 6;
            this.Lbl_Motivo.Text = "Motivo:";
            // 
            // Txt_Motivo
            // 
            this.Txt_Motivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Txt_Motivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Motivo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Motivo.ForeColor = System.Drawing.Color.White;
            this.Txt_Motivo.Location = new System.Drawing.Point(37, 188);
            this.Txt_Motivo.Multiline = true;
            this.Txt_Motivo.Name = "Txt_Motivo";
            this.Txt_Motivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Motivo.Size = new System.Drawing.Size(500, 80);
            this.Txt_Motivo.TabIndex = 7;
            // 
            // Pnl_Solis
            // 
            this.Pnl_Solis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Solis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Solis.Controls.Add(this.Txt_Motivo);
            this.Pnl_Solis.Controls.Add(this.Lbl_Motivo);
            this.Pnl_Solis.Controls.Add(this.label2);
            this.Pnl_Solis.Controls.Add(this.Txt_Dias_Solicitados);
            this.Pnl_Solis.Controls.Add(this.Lbl_Inicio);
            this.Pnl_Solis.Controls.Add(this.Lbl_Dias_Solicitados);
            this.Pnl_Solis.Controls.Add(this.Dtp_Fecha_Inicio);
            this.Pnl_Solis.Controls.Add(this.Btn_Rechazar);
            this.Pnl_Solis.Controls.Add(this.Btn_Aprobar);
            this.Pnl_Solis.Controls.Add(this.Dtp_Fecha_Fin);
            this.Pnl_Solis.Controls.Add(this.Lbl_Fin);
            this.Pnl_Solis.Location = new System.Drawing.Point(18, 262);
            this.Pnl_Solis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Solis.Name = "Pnl_Solis";
            this.Pnl_Solis.Size = new System.Drawing.Size(700, 280);
            this.Pnl_Solis.TabIndex = 81;
            // 
            // Dtp_Fecha_Inicio
            // 
            this.Dtp_Fecha_Inicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Inicio.Location = new System.Drawing.Point(156, 30);
            this.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio";
            this.Dtp_Fecha_Inicio.Size = new System.Drawing.Size(200, 30);
            this.Dtp_Fecha_Inicio.TabIndex = 1;
            // 
            // Dtp_Fecha_Fin
            // 
            this.Dtp_Fecha_Fin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Fin.Location = new System.Drawing.Point(156, 71);
            this.Dtp_Fecha_Fin.Name = "Dtp_Fecha_Fin";
            this.Dtp_Fecha_Fin.Size = new System.Drawing.Size(200, 30);
            this.Dtp_Fecha_Fin.TabIndex = 3;
            // 
            // Pnl_Registr
            // 
            this.Pnl_Registr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Registr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Registr.Controls.Add(this.label3);
            this.Pnl_Registr.Controls.Add(this.Dgv_Solicitudes);
            this.Pnl_Registr.Location = new System.Drawing.Point(18, 566);
            this.Pnl_Registr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Registr.Name = "Pnl_Registr";
            this.Pnl_Registr.Size = new System.Drawing.Size(844, 317);
            this.Pnl_Registr.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 26);
            this.label3.TabIndex = 71;
            this.label3.Text = "Solicitudes Registradas";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(18, 565);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 318);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitudes Registradas";
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
            this.label6.Size = new System.Drawing.Size(538, 26);
            this.label6.TabIndex = 72;
            this.label6.Text = "Consulte, edite y administre la información de los empleados.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(116, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 54);
            this.label5.TabIndex = 75;
            this.label5.Text = "Solicitud Vacaciones";
            // 
            // FormSolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1015, 895);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_Registr);
            this.Controls.Add(this.Pnl_Solis);
            this.Controls.Add(this.Pnl_Personal);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Refrescar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSolicitudVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSolicitudVacaciones";
            this.Load += new System.EventHandler(this.FormSolicitudVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Solicitudes)).EndInit();
            this.Pnl_Personal.ResumeLayout(false);
            this.Pnl_Personal.PerformLayout();
            this.Pnl_Solis.ResumeLayout(false);
            this.Pnl_Solis.PerformLayout();
            this.Pnl_Registr.ResumeLayout(false);
            this.Pnl_Registr.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.ComboBox Cbo_Empleado;
        private System.Windows.Forms.Label Lbl_Texto_Dias;
        private System.Windows.Forms.Label Lbl_Dias_Disponibles;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Aprobar;
        private System.Windows.Forms.Button Btn_Rechazar;
        private System.Windows.Forms.DataGridView Dgv_Solicitudes;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Panel Pnl_Personal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Fin;
        private System.Windows.Forms.Label Lbl_Dias_Solicitados;
        private System.Windows.Forms.Label Lbl_Inicio;
        private System.Windows.Forms.TextBox Txt_Dias_Solicitados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Motivo;
        private System.Windows.Forms.TextBox Txt_Motivo;
        private System.Windows.Forms.Panel Pnl_Solis;
        private System.Windows.Forms.Panel Pnl_Registr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Fin;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Inicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}