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
            this.Dgv_Detalle_Planilla = new System.Windows.Forms.DataGridView();
            this.Btn_Generar = new System.Windows.Forms.Button();
            this.Dtp_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Periodo = new System.Windows.Forms.Label();
            this.Txt_Total_Ingresos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Total_Descuentos = new System.Windows.Forms.TextBox();
            this.Lbl_Total_Pagar = new System.Windows.Forms.Label();
            this.Txt_Total_Paga = new System.Windows.Forms.TextBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Planilla)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Detalle_Planilla
            // 
            this.Dgv_Detalle_Planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle_Planilla.Location = new System.Drawing.Point(175, 298);
            this.Dgv_Detalle_Planilla.Name = "Dgv_Detalle_Planilla";
            this.Dgv_Detalle_Planilla.RowHeadersWidth = 51;
            this.Dgv_Detalle_Planilla.RowTemplate.Height = 24;
            this.Dgv_Detalle_Planilla.Size = new System.Drawing.Size(556, 150);
            this.Dgv_Detalle_Planilla.TabIndex = 51;
            // 
            // Btn_Generar
            // 
            this.Btn_Generar.Location = new System.Drawing.Point(254, 225);
            this.Btn_Generar.Name = "Btn_Generar";
            this.Btn_Generar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Generar.TabIndex = 50;
            this.Btn_Generar.Text = "Generar";
            this.Btn_Generar.UseVisualStyleBackColor = true;
            this.Btn_Generar.Click += new System.EventHandler(this.Btn_Generar_Click);
            // 
            // Dtp_Fecha_Fin
            // 
            this.Dtp_Fecha_Fin.Location = new System.Drawing.Point(404, 83);
            this.Dtp_Fecha_Fin.Name = "Dtp_Fecha_Fin";
            this.Dtp_Fecha_Fin.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Fecha_Fin.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(288, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Periodo Fin";
            // 
            // Dtp_Fecha_Inicio
            // 
            this.Dtp_Fecha_Inicio.Location = new System.Drawing.Point(404, 55);
            this.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio";
            this.Dtp_Fecha_Inicio.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Fecha_Inicio.TabIndex = 47;
            this.Dtp_Fecha_Inicio.ValueChanged += new System.EventHandler(this.Dpt_Fecha_Inicio_ValueChanged);
            // 
            // Lbl_Periodo
            // 
            this.Lbl_Periodo.AutoSize = true;
            this.Lbl_Periodo.BackColor = System.Drawing.Color.White;
            this.Lbl_Periodo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Periodo.Location = new System.Drawing.Point(275, 60);
            this.Lbl_Periodo.Name = "Lbl_Periodo";
            this.Lbl_Periodo.Size = new System.Drawing.Size(89, 16);
            this.Lbl_Periodo.TabIndex = 42;
            this.Lbl_Periodo.Text = "Periodo Inicio";
            // 
            // Txt_Total_Ingresos
            // 
            this.Txt_Total_Ingresos.Location = new System.Drawing.Point(404, 111);
            this.Txt_Total_Ingresos.Name = "Txt_Total_Ingresos";
            this.Txt_Total_Ingresos.ReadOnly = true;
            this.Txt_Total_Ingresos.Size = new System.Drawing.Size(208, 22);
            this.Txt_Total_Ingresos.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(271, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Total Ingresos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(251, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Total Descuentos";
            // 
            // Txt_Total_Descuentos
            // 
            this.Txt_Total_Descuentos.Location = new System.Drawing.Point(404, 140);
            this.Txt_Total_Descuentos.Name = "Txt_Total_Descuentos";
            this.Txt_Total_Descuentos.ReadOnly = true;
            this.Txt_Total_Descuentos.Size = new System.Drawing.Size(208, 22);
            this.Txt_Total_Descuentos.TabIndex = 56;
            // 
            // Lbl_Total_Pagar
            // 
            this.Lbl_Total_Pagar.AutoSize = true;
            this.Lbl_Total_Pagar.BackColor = System.Drawing.Color.White;
            this.Lbl_Total_Pagar.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Total_Pagar.Location = new System.Drawing.Point(251, 172);
            this.Lbl_Total_Pagar.Name = "Lbl_Total_Pagar";
            this.Lbl_Total_Pagar.Size = new System.Drawing.Size(89, 16);
            this.Lbl_Total_Pagar.TabIndex = 57;
            this.Lbl_Total_Pagar.Text = "Total a Pagar";
            // 
            // Txt_Total_Paga
            // 
            this.Txt_Total_Paga.Location = new System.Drawing.Point(404, 169);
            this.Txt_Total_Paga.Name = "Txt_Total_Paga";
            this.Txt_Total_Paga.ReadOnly = true;
            this.Txt_Total_Paga.Size = new System.Drawing.Size(208, 22);
            this.Txt_Total_Paga.TabIndex = 58;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(477, 225);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Limpiar.TabIndex = 59;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // FormGenerarPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(963, 653);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Txt_Total_Paga);
            this.Controls.Add(this.Lbl_Total_Pagar);
            this.Controls.Add(this.Txt_Total_Descuentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Total_Ingresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgv_Detalle_Planilla);
            this.Controls.Add(this.Btn_Generar);
            this.Controls.Add(this.Dtp_Fecha_Fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_Fecha_Inicio);
            this.Controls.Add(this.Lbl_Periodo);
            this.Name = "FormGenerarPlanilla";
            this.Text = "FormGenerarPlanilla";
            this.Load += new System.EventHandler(this.FormGenerarPlanilla_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Planilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_Detalle_Planilla;
        private System.Windows.Forms.Button Btn_Generar;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Inicio;
        private System.Windows.Forms.Label Lbl_Periodo;
        private System.Windows.Forms.TextBox Txt_Total_Ingresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Total_Descuentos;
        private System.Windows.Forms.Label Lbl_Total_Pagar;
        private System.Windows.Forms.TextBox Txt_Total_Paga;
        private System.Windows.Forms.Button Btn_Limpiar;
    }
}