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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Historial_Nomina)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Usuario.Location = new System.Drawing.Point(24, 55);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(251, 26);
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
            this.Btn_Buscar.Location = new System.Drawing.Point(547, 45);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(127, 50);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(318, 52);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(168, 32);
            this.Txt_Usuario.TabIndex = 4;
            // 
            // Dgv_Historial_Nomina
            // 
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
            this.Dgv_Historial_Nomina.Location = new System.Drawing.Point(29, 168);
            this.Dgv_Historial_Nomina.Name = "Dgv_Historial_Nomina";
            this.Dgv_Historial_Nomina.ReadOnly = true;
            this.Dgv_Historial_Nomina.RowHeadersVisible = false;
            this.Dgv_Historial_Nomina.RowHeadersWidth = 62;
            this.Dgv_Historial_Nomina.RowTemplate.Height = 28;
            this.Dgv_Historial_Nomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Historial_Nomina.Size = new System.Drawing.Size(693, 163);
            this.Dgv_Historial_Nomina.TabIndex = 5;
            // 
            // cmp_id_planilla
            // 
            this.cmp_id_planilla.DataPropertyName = "cmp_id_planilla";
            this.cmp_id_planilla.HeaderText = "ID";
            this.cmp_id_planilla.MinimumWidth = 8;
            this.cmp_id_planilla.Name = "cmp_id_planilla";
            this.cmp_id_planilla.ReadOnly = true;
            this.cmp_id_planilla.Width = 81;
            // 
            // cmp_periodo_inicio
            // 
            this.cmp_periodo_inicio.DataPropertyName = "cmp_periodo_inicio";
            this.cmp_periodo_inicio.HeaderText = "Inicio";
            this.cmp_periodo_inicio.MinimumWidth = 8;
            this.cmp_periodo_inicio.Name = "cmp_periodo_inicio";
            this.cmp_periodo_inicio.ReadOnly = true;
            this.cmp_periodo_inicio.Width = 81;
            // 
            // cmp_periodo_fin
            // 
            this.cmp_periodo_fin.DataPropertyName = "cmp_periodo_fin";
            this.cmp_periodo_fin.HeaderText = "Fin";
            this.cmp_periodo_fin.MinimumWidth = 8;
            this.cmp_periodo_fin.Name = "cmp_periodo_fin";
            this.cmp_periodo_fin.ReadOnly = true;
            this.cmp_periodo_fin.Width = 81;
            // 
            // cmp_fecha_generacion
            // 
            this.cmp_fecha_generacion.DataPropertyName = "cmp_fecha_generacion";
            this.cmp_fecha_generacion.HeaderText = "Fecha de Generacion";
            this.cmp_fecha_generacion.MinimumWidth = 8;
            this.cmp_fecha_generacion.Name = "cmp_fecha_generacion";
            this.cmp_fecha_generacion.ReadOnly = true;
            this.cmp_fecha_generacion.Width = 80;
            // 
            // cmp_estado
            // 
            this.cmp_estado.DataPropertyName = "cmp_estado";
            this.cmp_estado.HeaderText = "Estado";
            this.cmp_estado.MinimumWidth = 8;
            this.cmp_estado.Name = "cmp_estado";
            this.cmp_estado.ReadOnly = true;
            this.cmp_estado.Width = 82;
            // 
            // cmp_total_ingresos
            // 
            this.cmp_total_ingresos.DataPropertyName = "cmp_total_ingresos";
            this.cmp_total_ingresos.HeaderText = "Ingresos";
            this.cmp_total_ingresos.MinimumWidth = 8;
            this.cmp_total_ingresos.Name = "cmp_total_ingresos";
            this.cmp_total_ingresos.ReadOnly = true;
            this.cmp_total_ingresos.Width = 81;
            // 
            // cmp_total_descuentos
            // 
            this.cmp_total_descuentos.DataPropertyName = "cmp_total_descuentos";
            this.cmp_total_descuentos.HeaderText = "Descuentos";
            this.cmp_total_descuentos.MinimumWidth = 8;
            this.cmp_total_descuentos.Name = "cmp_total_descuentos";
            this.cmp_total_descuentos.ReadOnly = true;
            this.cmp_total_descuentos.Width = 81;
            // 
            // cmp_total_pagar
            // 
            this.cmp_total_pagar.DataPropertyName = "cmp_total_pagar";
            this.cmp_total_pagar.HeaderText = "Total a Pagar";
            this.cmp_total_pagar.MinimumWidth = 8;
            this.cmp_total_pagar.Name = "cmp_total_pagar";
            this.cmp_total_pagar.ReadOnly = true;
            this.cmp_total_pagar.Width = 81;
            // 
            // cmp_observaciones
            // 
            this.cmp_observaciones.DataPropertyName = "cmp_observaciones";
            this.cmp_observaciones.HeaderText = "Observaciones";
            this.cmp_observaciones.MinimumWidth = 8;
            this.cmp_observaciones.Name = "cmp_observaciones";
            this.cmp_observaciones.ReadOnly = true;
            this.cmp_observaciones.Width = 81;
            // 
            // FormHistorialNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(891, 562);
            this.Controls.Add(this.Dgv_Historial_Nomina);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Usuario);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHistorialNomina";
            this.Text = "FormHistorialNomina";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Historial_Nomina)).EndInit();
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
    }
}