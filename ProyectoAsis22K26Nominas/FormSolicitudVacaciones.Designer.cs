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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Gbo_Empleado = new System.Windows.Forms.GroupBox();
            this.Lbl_Dias_Disponibles = new System.Windows.Forms.Label();
            this.Lbl_Texto_Dias = new System.Windows.Forms.Label();
            this.Cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Gbo_Solicitud = new System.Windows.Forms.GroupBox();
            this.Txt_Motivo = new System.Windows.Forms.TextBox();
            this.Lbl_Motivo = new System.Windows.Forms.Label();
            this.Txt_Dias_Solicitados = new System.Windows.Forms.TextBox();
            this.Lbl_Dias_Solicitados = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fin = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Inicio = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Aprobar = new System.Windows.Forms.Button();
            this.Btn_Rechazar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgv_Solicitudes = new System.Windows.Forms.DataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gbo_Empleado.SuspendLayout();
            this.Gbo_Solicitud.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Solicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(301, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(251, 25);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "SOLICITUD DE VACACIONES";
            this.Lbl_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gbo_Empleado
            // 
            this.Gbo_Empleado.Controls.Add(this.Lbl_Dias_Disponibles);
            this.Gbo_Empleado.Controls.Add(this.Lbl_Texto_Dias);
            this.Gbo_Empleado.Controls.Add(this.Cbo_Empleado);
            this.Gbo_Empleado.Controls.Add(this.Lbl_Empleado);
            this.Gbo_Empleado.Location = new System.Drawing.Point(12, 48);
            this.Gbo_Empleado.Name = "Gbo_Empleado";
            this.Gbo_Empleado.Size = new System.Drawing.Size(700, 120);
            this.Gbo_Empleado.TabIndex = 1;
            this.Gbo_Empleado.TabStop = false;
            this.Gbo_Empleado.Text = "Información del Empleado";
            this.Gbo_Empleado.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Lbl_Dias_Disponibles
            // 
            this.Lbl_Dias_Disponibles.AutoSize = true;
            this.Lbl_Dias_Disponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dias_Disponibles.Location = new System.Drawing.Point(148, 81);
            this.Lbl_Dias_Disponibles.Name = "Lbl_Dias_Disponibles";
            this.Lbl_Dias_Disponibles.Size = new System.Drawing.Size(49, 16);
            this.Lbl_Dias_Disponibles.TabIndex = 3;
            this.Lbl_Dias_Disponibles.Text = "0 días";
            // 
            // Lbl_Texto_Dias
            // 
            this.Lbl_Texto_Dias.AutoSize = true;
            this.Lbl_Texto_Dias.Location = new System.Drawing.Point(26, 81);
            this.Lbl_Texto_Dias.Name = "Lbl_Texto_Dias";
            this.Lbl_Texto_Dias.Size = new System.Drawing.Size(116, 16);
            this.Lbl_Texto_Dias.TabIndex = 2;
            this.Lbl_Texto_Dias.Text = "Días Disponibles: ";
            // 
            // Cbo_Empleado
            // 
            this.Cbo_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Empleado.FormattingEnabled = true;
            this.Cbo_Empleado.Location = new System.Drawing.Point(120, 32);
            this.Cbo_Empleado.Name = "Cbo_Empleado";
            this.Cbo_Empleado.Size = new System.Drawing.Size(350, 24);
            this.Cbo_Empleado.TabIndex = 1;
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Location = new System.Drawing.Point(26, 35);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(76, 16);
            this.Lbl_Empleado.TabIndex = 0;
            this.Lbl_Empleado.Text = "Empleado: ";
            // 
            // Gbo_Solicitud
            // 
            this.Gbo_Solicitud.Controls.Add(this.Txt_Motivo);
            this.Gbo_Solicitud.Controls.Add(this.Lbl_Motivo);
            this.Gbo_Solicitud.Controls.Add(this.Txt_Dias_Solicitados);
            this.Gbo_Solicitud.Controls.Add(this.Lbl_Dias_Solicitados);
            this.Gbo_Solicitud.Controls.Add(this.Dtp_Fecha_Fin);
            this.Gbo_Solicitud.Controls.Add(this.Lbl_Fin);
            this.Gbo_Solicitud.Controls.Add(this.Dtp_Fecha_Inicio);
            this.Gbo_Solicitud.Controls.Add(this.Lbl_Inicio);
            this.Gbo_Solicitud.Location = new System.Drawing.Point(14, 196);
            this.Gbo_Solicitud.Name = "Gbo_Solicitud";
            this.Gbo_Solicitud.Size = new System.Drawing.Size(700, 285);
            this.Gbo_Solicitud.TabIndex = 2;
            this.Gbo_Solicitud.TabStop = false;
            this.Gbo_Solicitud.Text = "Información Solicitud";
            // 
            // Txt_Motivo
            // 
            this.Txt_Motivo.Location = new System.Drawing.Point(38, 190);
            this.Txt_Motivo.Multiline = true;
            this.Txt_Motivo.Name = "Txt_Motivo";
            this.Txt_Motivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Motivo.Size = new System.Drawing.Size(500, 80);
            this.Txt_Motivo.TabIndex = 7;
            // 
            // Lbl_Motivo
            // 
            this.Lbl_Motivo.AutoSize = true;
            this.Lbl_Motivo.Location = new System.Drawing.Point(35, 171);
            this.Lbl_Motivo.Name = "Lbl_Motivo";
            this.Lbl_Motivo.Size = new System.Drawing.Size(50, 16);
            this.Lbl_Motivo.TabIndex = 6;
            this.Lbl_Motivo.Text = "Motivo:";
            // 
            // Txt_Dias_Solicitados
            // 
            this.Txt_Dias_Solicitados.Location = new System.Drawing.Point(149, 123);
            this.Txt_Dias_Solicitados.Name = "Txt_Dias_Solicitados";
            this.Txt_Dias_Solicitados.ReadOnly = true;
            this.Txt_Dias_Solicitados.Size = new System.Drawing.Size(100, 22);
            this.Txt_Dias_Solicitados.TabIndex = 5;
            this.Txt_Dias_Solicitados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Dias_Solicitados
            // 
            this.Lbl_Dias_Solicitados.AutoSize = true;
            this.Lbl_Dias_Solicitados.Location = new System.Drawing.Point(30, 129);
            this.Lbl_Dias_Solicitados.Name = "Lbl_Dias_Solicitados";
            this.Lbl_Dias_Solicitados.Size = new System.Drawing.Size(108, 16);
            this.Lbl_Dias_Solicitados.TabIndex = 4;
            this.Lbl_Dias_Solicitados.Text = "Días Solicitados:";
            // 
            // Dtp_Fecha_Fin
            // 
            this.Dtp_Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Fin.Location = new System.Drawing.Point(149, 78);
            this.Dtp_Fecha_Fin.Name = "Dtp_Fecha_Fin";
            this.Dtp_Fecha_Fin.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Fecha_Fin.TabIndex = 3;
            // 
            // Lbl_Fin
            // 
            this.Lbl_Fin.AutoSize = true;
            this.Lbl_Fin.Location = new System.Drawing.Point(30, 83);
            this.Lbl_Fin.Name = "Lbl_Fin";
            this.Lbl_Fin.Size = new System.Drawing.Size(72, 16);
            this.Lbl_Fin.TabIndex = 2;
            this.Lbl_Fin.Text = "Fecha Fin: ";
            // 
            // Dtp_Fecha_Inicio
            // 
            this.Dtp_Fecha_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Inicio.Location = new System.Drawing.Point(149, 37);
            this.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio";
            this.Dtp_Fecha_Inicio.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Fecha_Inicio.TabIndex = 1;
            // 
            // Lbl_Inicio
            // 
            this.Lbl_Inicio.AutoSize = true;
            this.Lbl_Inicio.Location = new System.Drawing.Point(30, 43);
            this.Lbl_Inicio.Name = "Lbl_Inicio";
            this.Lbl_Inicio.Size = new System.Drawing.Size(85, 16);
            this.Lbl_Inicio.TabIndex = 0;
            this.Lbl_Inicio.Text = "Fecha Inicio: ";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(16, 503);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(150, 45);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar Solicitud";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Aprobar
            // 
            this.Btn_Aprobar.Location = new System.Drawing.Point(189, 503);
            this.Btn_Aprobar.Name = "Btn_Aprobar";
            this.Btn_Aprobar.Size = new System.Drawing.Size(120, 45);
            this.Btn_Aprobar.TabIndex = 4;
            this.Btn_Aprobar.Text = "Aprobar";
            this.Btn_Aprobar.UseVisualStyleBackColor = true;
            // 
            // Btn_Rechazar
            // 
            this.Btn_Rechazar.Location = new System.Drawing.Point(338, 503);
            this.Btn_Rechazar.Name = "Btn_Rechazar";
            this.Btn_Rechazar.Size = new System.Drawing.Size(120, 45);
            this.Btn_Rechazar.TabIndex = 5;
            this.Btn_Rechazar.Text = "Rechazar";
            this.Btn_Rechazar.UseVisualStyleBackColor = true;
            this.Btn_Rechazar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgv_Solicitudes);
            this.groupBox1.Location = new System.Drawing.Point(19, 565);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 318);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitudes Registradas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
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
            this.Dgv_Solicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Col_Empleado,
            this.Col_Inicio,
            this.Col_Fin,
            this.Col_Dias,
            this.Col_Motivo,
            this.Col_Estado});
            this.Dgv_Solicitudes.Location = new System.Drawing.Point(22, 30);
            this.Dgv_Solicitudes.MultiSelect = false;
            this.Dgv_Solicitudes.Name = "Dgv_Solicitudes";
            this.Dgv_Solicitudes.ReadOnly = true;
            this.Dgv_Solicitudes.RowHeadersVisible = false;
            this.Dgv_Solicitudes.RowHeadersWidth = 51;
            this.Dgv_Solicitudes.RowTemplate.Height = 24;
            this.Dgv_Solicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Solicitudes.Size = new System.Drawing.Size(800, 260);
            this.Dgv_Solicitudes.TabIndex = 0;
            // 
            // Col_ID
            // 
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.MinimumWidth = 6;
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.ReadOnly = true;
            // 
            // Col_Empleado
            // 
            this.Col_Empleado.HeaderText = "Empleado";
            this.Col_Empleado.MinimumWidth = 6;
            this.Col_Empleado.Name = "Col_Empleado";
            this.Col_Empleado.ReadOnly = true;
            // 
            // Col_Inicio
            // 
            this.Col_Inicio.HeaderText = "Inicio";
            this.Col_Inicio.MinimumWidth = 6;
            this.Col_Inicio.Name = "Col_Inicio";
            this.Col_Inicio.ReadOnly = true;
            // 
            // Col_Fin
            // 
            this.Col_Fin.HeaderText = "Fin";
            this.Col_Fin.MinimumWidth = 6;
            this.Col_Fin.Name = "Col_Fin";
            this.Col_Fin.ReadOnly = true;
            // 
            // Col_Dias
            // 
            this.Col_Dias.HeaderText = "Días";
            this.Col_Dias.MinimumWidth = 6;
            this.Col_Dias.Name = "Col_Dias";
            this.Col_Dias.ReadOnly = true;
            // 
            // Col_Motivo
            // 
            this.Col_Motivo.HeaderText = "Motivo";
            this.Col_Motivo.MinimumWidth = 6;
            this.Col_Motivo.Name = "Col_Motivo";
            this.Col_Motivo.ReadOnly = true;
            // 
            // Col_Estado
            // 
            this.Col_Estado.HeaderText = "Estado";
            this.Col_Estado.MinimumWidth = 6;
            this.Col_Estado.Name = "Col_Estado";
            this.Col_Estado.ReadOnly = true;
            // 
            // FormSolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(890, 953);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Rechazar);
            this.Controls.Add(this.Btn_Aprobar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Gbo_Solicitud);
            this.Controls.Add(this.Gbo_Empleado);
            this.Controls.Add(this.Lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSolicitudVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSolicitudVacaciones";
            this.Load += new System.EventHandler(this.FormSolicitudVacaciones_Load);
            this.Gbo_Empleado.ResumeLayout(false);
            this.Gbo_Empleado.PerformLayout();
            this.Gbo_Solicitud.ResumeLayout(false);
            this.Gbo_Solicitud.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Solicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.GroupBox Gbo_Empleado;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.ComboBox Cbo_Empleado;
        private System.Windows.Forms.Label Lbl_Texto_Dias;
        private System.Windows.Forms.Label Lbl_Dias_Disponibles;
        private System.Windows.Forms.GroupBox Gbo_Solicitud;
        private System.Windows.Forms.Label Lbl_Inicio;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Inicio;
        private System.Windows.Forms.Label Lbl_Fin;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Fin;
        private System.Windows.Forms.Label Lbl_Dias_Solicitados;
        private System.Windows.Forms.TextBox Txt_Dias_Solicitados;
        private System.Windows.Forms.Label Lbl_Motivo;
        private System.Windows.Forms.TextBox Txt_Motivo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Aprobar;
        private System.Windows.Forms.Button Btn_Rechazar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgv_Solicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Estado;
    }
}