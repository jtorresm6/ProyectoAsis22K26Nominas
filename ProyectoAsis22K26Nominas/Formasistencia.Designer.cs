namespace ProyectoAsis22K26Nominas
{
    partial class Formasistencia
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
            this.components = new System.ComponentModel.Container();
            this.Txt_codempleado = new System.Windows.Forms.TextBox();
            this.Dpt_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_tipregistro = new System.Windows.Forms.ComboBox();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Dgv_asistenicas = new System.Windows.Forms.DataGridView();
            this.timer_reloj = new System.Windows.Forms.Timer(this.components);
            this.Lbl_idempelado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asistenicas)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_codempleado
            // 
            this.Txt_codempleado.Location = new System.Drawing.Point(42, 136);
            this.Txt_codempleado.Name = "Txt_codempleado";
            this.Txt_codempleado.Size = new System.Drawing.Size(127, 22);
            this.Txt_codempleado.TabIndex = 0;
            // 
            // Dpt_fecha
            // 
            this.Dpt_fecha.Location = new System.Drawing.Point(449, 379);
            this.Dpt_fecha.Name = "Dpt_fecha";
            this.Dpt_fecha.Size = new System.Drawing.Size(200, 22);
            this.Dpt_fecha.TabIndex = 4;
            // 
            // Cbo_tipregistro
            // 
            this.Cbo_tipregistro.FormattingEnabled = true;
            this.Cbo_tipregistro.Location = new System.Drawing.Point(77, 262);
            this.Cbo_tipregistro.Name = "Cbo_tipregistro";
            this.Cbo_tipregistro.Size = new System.Drawing.Size(240, 24);
            this.Cbo_tipregistro.TabIndex = 5;
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.Location = new System.Drawing.Point(41, 182);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(128, 36);
            this.Btn_registrar.TabIndex = 7;
            this.Btn_registrar.Text = "Registrar";
            this.Btn_registrar.UseVisualStyleBackColor = true;
            this.Btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click_1);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(77, 324);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btn_limpiar.TabIndex = 8;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click_1);
            // 
            // Dgv_asistenicas
            // 
            this.Dgv_asistenicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asistenicas.Location = new System.Drawing.Point(397, 25);
            this.Dgv_asistenicas.Name = "Dgv_asistenicas";
            this.Dgv_asistenicas.RowHeadersWidth = 51;
            this.Dgv_asistenicas.RowTemplate.Height = 24;
            this.Dgv_asistenicas.Size = new System.Drawing.Size(888, 276);
            this.Dgv_asistenicas.TabIndex = 9;
            this.Dgv_asistenicas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_asistenicas_CellContentClick);
            // 
            // Lbl_idempelado
            // 
            this.Lbl_idempelado.AutoSize = true;
            this.Lbl_idempelado.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_idempelado.Location = new System.Drawing.Point(58, 107);
            this.Lbl_idempelado.Name = "Lbl_idempelado";
            this.Lbl_idempelado.Size = new System.Drawing.Size(83, 16);
            this.Lbl_idempelado.TabIndex = 48;
            this.Lbl_idempelado.Text = "Id empleado";
            // 
            // Formasistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1265, 450);
            this.Controls.Add(this.Lbl_idempelado);
            this.Controls.Add(this.Dgv_asistenicas);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_registrar);
            this.Controls.Add(this.Cbo_tipregistro);
            this.Controls.Add(this.Dpt_fecha);
            this.Controls.Add(this.Txt_codempleado);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Formasistencia";
            this.Text = "Formhelp";
            this.Load += new System.EventHandler(this.Formasistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asistenicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_codempleado;
        private System.Windows.Forms.DateTimePicker Dpt_fecha;
        private System.Windows.Forms.ComboBox Cbo_tipregistro;
        private System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.DataGridView Dgv_asistenicas;
        private System.Windows.Forms.Timer timer_reloj;
        private System.Windows.Forms.Label Lbl_idempelado;
    }
}