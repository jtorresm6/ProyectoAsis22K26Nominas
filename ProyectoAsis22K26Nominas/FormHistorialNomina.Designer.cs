namespace ProyectoAsis22K26Nominas
{
    partial class FormHistorialNomina
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
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Dgv_Historial_Nomina = new System.Windows.Forms.DataGridView();
            this.cmp_id_planilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_periodo_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_periodo_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_fecha_generacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_total_ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_total_descuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_total_pagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Historial_Nomina)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Usuario.Location = new System.Drawing.Point(53, 171);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(197, 23);
            this.Lbl_Usuario.TabIndex = 0;
            this.Lbl_Usuario.Text = "Ingrese el ID del Usuario";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Btn_Buscar.FlatAppearance.BorderSize = 3;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Buscar.Location = new System.Drawing.Point(573, 164);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(113, 40);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(265, 168);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(262, 28);
            this.Txt_Usuario.TabIndex = 4;
            // 
            // Dgv_Historial_Nomina
            // 
            this.Dgv_Historial_Nomina.AllowUserToAddRows = false;
            this.Dgv_Historial_Nomina.AllowUserToDeleteRows = false;
            this.Dgv_Historial_Nomina.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.Dgv_Historial_Nomina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Historial_Nomina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Historial_Nomina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.Dgv_Historial_Nomina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Historial_Nomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Historial_Nomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Historial_Nomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmp_id_planilla,
            this.cmp_periodo_inicio,
            this.cmp_periodo_fin,
            this.cmp_fecha_generacion,
            this.cmp_estado,
            this.cmp_total_ingresos,
            this.cmp_total_descuentos,
            this.cmp_total_pagar,
            this.cmp_observaciones});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Historial_Nomina.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Historial_Nomina.EnableHeadersVisualStyles = false;
            this.Dgv_Historial_Nomina.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Dgv_Historial_Nomina.Location = new System.Drawing.Point(23, 254);
            this.Dgv_Historial_Nomina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Historial_Nomina.MultiSelect = false;
            this.Dgv_Historial_Nomina.Name = "Dgv_Historial_Nomina";
            this.Dgv_Historial_Nomina.ReadOnly = true;
            this.Dgv_Historial_Nomina.RowHeadersVisible = false;
            this.Dgv_Historial_Nomina.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Dgv_Historial_Nomina.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Historial_Nomina.RowTemplate.Height = 28;
            this.Dgv_Historial_Nomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Historial_Nomina.Size = new System.Drawing.Size(1231, 417);
            this.Dgv_Historial_Nomina.TabIndex = 5;
            this.Dgv_Historial_Nomina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Historial_Nomina_CellContentClick);
            // 
            // cmp_id_planilla
            // 
            this.cmp_id_planilla.DataPropertyName = "cmp_id_planilla";
            this.cmp_id_planilla.HeaderText = "ID";
            this.cmp_id_planilla.MinimumWidth = 8;
            this.cmp_id_planilla.Name = "cmp_id_planilla";
            this.cmp_id_planilla.ReadOnly = true;
            // 
            // cmp_periodo_inicio
            // 
            this.cmp_periodo_inicio.DataPropertyName = "cmp_periodo_inicio";
            this.cmp_periodo_inicio.HeaderText = "Inicio";
            this.cmp_periodo_inicio.MinimumWidth = 8;
            this.cmp_periodo_inicio.Name = "cmp_periodo_inicio";
            this.cmp_periodo_inicio.ReadOnly = true;
            // 
            // cmp_periodo_fin
            // 
            this.cmp_periodo_fin.DataPropertyName = "cmp_periodo_fin";
            this.cmp_periodo_fin.HeaderText = "Fin";
            this.cmp_periodo_fin.MinimumWidth = 8;
            this.cmp_periodo_fin.Name = "cmp_periodo_fin";
            this.cmp_periodo_fin.ReadOnly = true;
            // 
            // cmp_fecha_generacion
            // 
            this.cmp_fecha_generacion.DataPropertyName = "cmp_fecha_generacion";
            this.cmp_fecha_generacion.HeaderText = "Fecha de Generacion";
            this.cmp_fecha_generacion.MinimumWidth = 8;
            this.cmp_fecha_generacion.Name = "cmp_fecha_generacion";
            this.cmp_fecha_generacion.ReadOnly = true;
            // 
            // cmp_estado
            // 
            this.cmp_estado.DataPropertyName = "cmp_estado";
            this.cmp_estado.HeaderText = "Estado";
            this.cmp_estado.MinimumWidth = 8;
            this.cmp_estado.Name = "cmp_estado";
            this.cmp_estado.ReadOnly = true;
            // 
            // cmp_total_ingresos
            // 
            this.cmp_total_ingresos.DataPropertyName = "cmp_total_ingresos";
            this.cmp_total_ingresos.HeaderText = "Ingresos";
            this.cmp_total_ingresos.MinimumWidth = 8;
            this.cmp_total_ingresos.Name = "cmp_total_ingresos";
            this.cmp_total_ingresos.ReadOnly = true;
            // 
            // cmp_total_descuentos
            // 
            this.cmp_total_descuentos.DataPropertyName = "cmp_total_descuentos";
            this.cmp_total_descuentos.HeaderText = "Descuentos";
            this.cmp_total_descuentos.MinimumWidth = 8;
            this.cmp_total_descuentos.Name = "cmp_total_descuentos";
            this.cmp_total_descuentos.ReadOnly = true;
            // 
            // cmp_total_pagar
            // 
            this.cmp_total_pagar.DataPropertyName = "cmp_total_pagar";
            this.cmp_total_pagar.HeaderText = "Total a Pagar";
            this.cmp_total_pagar.MinimumWidth = 8;
            this.cmp_total_pagar.Name = "cmp_total_pagar";
            this.cmp_total_pagar.ReadOnly = true;
            // 
            // cmp_observaciones
            // 
            this.cmp_observaciones.DataPropertyName = "cmp_observaciones";
            this.cmp_observaciones.HeaderText = "Observaciones";
            this.cmp_observaciones.MinimumWidth = 8;
            this.cmp_observaciones.Name = "cmp_observaciones";
            this.cmp_observaciones.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 100);
            this.panel1.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(58, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(438, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Consulte, edite y administre la información de los empleados.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(33, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 54);
            this.label5.TabIndex = 75;
            this.label5.Text = "Historial Nóminas";
            // 
            // FormHistorialNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1297, 895);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_Historial_Nomina);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Usuario);
            this.Name = "FormHistorialNomina";
            this.Text = "FormHistorialNomina";
            this.Load += new System.EventHandler(this.FormHistorialNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Historial_Nomina)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.DataGridView Dgv_Historial_Nomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_id_planilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_periodo_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_periodo_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_fecha_generacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_total_ingresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_total_descuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_total_pagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_observaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}