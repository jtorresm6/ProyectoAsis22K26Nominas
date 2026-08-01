namespace ProyectoAsis22K26Nominas
{
    partial class FormControlSaldos
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gbo_Busqueda_Trabajador = new System.Windows.Forms.GroupBox();
            this.Cbo_Buscar_Empleado = new System.Windows.Forms.ComboBox();
            this.Lbl_Buscar_Empleado = new System.Windows.Forms.Label();
            this.Gbo_Saldo_Vacaciones = new System.Windows.Forms.GroupBox();
            this.Dgv_Saldo_Vacaciones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_Dia_Vacaciones = new System.Windows.Forms.DateTimePicker();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Gbo_Busqueda_Trabajador.SuspendLayout();
            this.Gbo_Saldo_Vacaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Saldo_Vacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE SALDO DE VACACIONES";
            // 
            // Gbo_Busqueda_Trabajador
            // 
            this.Gbo_Busqueda_Trabajador.Controls.Add(this.Cbo_Buscar_Empleado);
            this.Gbo_Busqueda_Trabajador.Controls.Add(this.Lbl_Buscar_Empleado);
            this.Gbo_Busqueda_Trabajador.Location = new System.Drawing.Point(13, 60);
            this.Gbo_Busqueda_Trabajador.Name = "Gbo_Busqueda_Trabajador";
            this.Gbo_Busqueda_Trabajador.Size = new System.Drawing.Size(840, 90);
            this.Gbo_Busqueda_Trabajador.TabIndex = 1;
            this.Gbo_Busqueda_Trabajador.TabStop = false;
            this.Gbo_Busqueda_Trabajador.Text = "Búsqueda de Trabajador";
            // 
            // Cbo_Buscar_Empleado
            // 
            this.Cbo_Buscar_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Buscar_Empleado.FormattingEnabled = true;
            this.Cbo_Buscar_Empleado.Location = new System.Drawing.Point(105, 38);
            this.Cbo_Buscar_Empleado.Name = "Cbo_Buscar_Empleado";
            this.Cbo_Buscar_Empleado.Size = new System.Drawing.Size(500, 24);
            this.Cbo_Buscar_Empleado.TabIndex = 1;
            // 
            // Lbl_Buscar_Empleado
            // 
            this.Lbl_Buscar_Empleado.AutoSize = true;
            this.Lbl_Buscar_Empleado.Location = new System.Drawing.Point(28, 41);
            this.Lbl_Buscar_Empleado.Name = "Lbl_Buscar_Empleado";
            this.Lbl_Buscar_Empleado.Size = new System.Drawing.Size(52, 16);
            this.Lbl_Buscar_Empleado.TabIndex = 0;
            this.Lbl_Buscar_Empleado.Text = "Buscar:";
            // 
            // Gbo_Saldo_Vacaciones
            // 
            this.Gbo_Saldo_Vacaciones.Controls.Add(this.Dgv_Saldo_Vacaciones);
            this.Gbo_Saldo_Vacaciones.Location = new System.Drawing.Point(13, 214);
            this.Gbo_Saldo_Vacaciones.Name = "Gbo_Saldo_Vacaciones";
            this.Gbo_Saldo_Vacaciones.Size = new System.Drawing.Size(840, 314);
            this.Gbo_Saldo_Vacaciones.TabIndex = 2;
            this.Gbo_Saldo_Vacaciones.TabStop = false;
            this.Gbo_Saldo_Vacaciones.Text = "Saldo de Vacaciones";
            // 
            // Dgv_Saldo_Vacaciones
            // 
            this.Dgv_Saldo_Vacaciones.AllowUserToAddRows = false;
            this.Dgv_Saldo_Vacaciones.AllowUserToDeleteRows = false;
            this.Dgv_Saldo_Vacaciones.AllowUserToResizeRows = false;
            this.Dgv_Saldo_Vacaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Saldo_Vacaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Saldo_Vacaciones.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_Saldo_Vacaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Saldo_Vacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Saldo_Vacaciones.Location = new System.Drawing.Point(15, 36);
            this.Dgv_Saldo_Vacaciones.MultiSelect = false;
            this.Dgv_Saldo_Vacaciones.Name = "Dgv_Saldo_Vacaciones";
            this.Dgv_Saldo_Vacaciones.ReadOnly = true;
            this.Dgv_Saldo_Vacaciones.RowHeadersVisible = false;
            this.Dgv_Saldo_Vacaciones.RowHeadersWidth = 51;
            this.Dgv_Saldo_Vacaciones.RowTemplate.Height = 24;
            this.Dgv_Saldo_Vacaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Saldo_Vacaciones.Size = new System.Drawing.Size(800, 260);
            this.Dgv_Saldo_Vacaciones.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione una Fecha: ";
            // 
            // Dtp_Dia_Vacaciones
            // 
            this.Dtp_Dia_Vacaciones.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Dia_Vacaciones.Location = new System.Drawing.Point(169, 169);
            this.Dtp_Dia_Vacaciones.Name = "Dtp_Dia_Vacaciones";
            this.Dtp_Dia_Vacaciones.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Dia_Vacaciones.TabIndex = 4;
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.Location = new System.Drawing.Point(394, 160);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(120, 45);
            this.Btn_Refrescar.TabIndex = 5;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            // 
            // FormControlSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(882, 576);
            this.Controls.Add(this.Btn_Refrescar);
            this.Controls.Add(this.Dtp_Dia_Vacaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gbo_Saldo_Vacaciones);
            this.Controls.Add(this.Gbo_Busqueda_Trabajador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormControlSaldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormControlSaldos";
            this.Load += new System.EventHandler(this.FormControlSaldos_Load);
            this.Gbo_Busqueda_Trabajador.ResumeLayout(false);
            this.Gbo_Busqueda_Trabajador.PerformLayout();
            this.Gbo_Saldo_Vacaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Saldo_Vacaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gbo_Busqueda_Trabajador;
        private System.Windows.Forms.Label Lbl_Buscar_Empleado;
        private System.Windows.Forms.ComboBox Cbo_Buscar_Empleado;
        private System.Windows.Forms.GroupBox Gbo_Saldo_Vacaciones;
        private System.Windows.Forms.DataGridView Dgv_Saldo_Vacaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_Dia_Vacaciones;
        private System.Windows.Forms.Button Btn_Refrescar;
    }
}