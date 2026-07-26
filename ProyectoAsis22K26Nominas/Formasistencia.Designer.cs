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
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Lbl_nombempleado = new System.Windows.Forms.Label();
            this.Lbl_reloj = new System.Windows.Forms.Label();
            this.Dpt_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_tipregistro = new System.Windows.Forms.ComboBox();
            this.Txt_observaciones = new System.Windows.Forms.TextBox();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Dgv_asistenicas = new System.Windows.Forms.DataGridView();
            this.timer_reloj = new System.Windows.Forms.Timer(this.components);
            this.Lbl_observaciones = new System.Windows.Forms.Label();
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
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(42, 185);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(127, 36);
            this.Btn_buscar.TabIndex = 1;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Lbl_nombempleado
            // 
            this.Lbl_nombempleado.AutoSize = true;
            this.Lbl_nombempleado.BackColor = System.Drawing.Color.White;
            this.Lbl_nombempleado.ForeColor = System.Drawing.Color.Black;
            this.Lbl_nombempleado.Location = new System.Drawing.Point(47, 89);
            this.Lbl_nombempleado.Name = "Lbl_nombempleado";
            this.Lbl_nombempleado.Size = new System.Drawing.Size(122, 16);
            this.Lbl_nombempleado.TabIndex = 2;
            this.Lbl_nombempleado.Text = "Nombre Empleado";
            // 
            // Lbl_reloj
            // 
            this.Lbl_reloj.AutoSize = true;
            this.Lbl_reloj.BackColor = System.Drawing.Color.White;
            this.Lbl_reloj.ForeColor = System.Drawing.Color.Black;
            this.Lbl_reloj.Location = new System.Drawing.Point(524, 360);
            this.Lbl_reloj.Name = "Lbl_reloj";
            this.Lbl_reloj.Size = new System.Drawing.Size(39, 16);
            this.Lbl_reloj.TabIndex = 3;
            this.Lbl_reloj.Text = "Reloj";
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
            this.Cbo_tipregistro.Location = new System.Drawing.Point(424, 250);
            this.Cbo_tipregistro.Name = "Cbo_tipregistro";
            this.Cbo_tipregistro.Size = new System.Drawing.Size(240, 24);
            this.Cbo_tipregistro.TabIndex = 5;
            // 
            // Txt_observaciones
            // 
            this.Txt_observaciones.Location = new System.Drawing.Point(231, 136);
            this.Txt_observaciones.Name = "Txt_observaciones";
            this.Txt_observaciones.Size = new System.Drawing.Size(128, 22);
            this.Txt_observaciones.TabIndex = 6;
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.Location = new System.Drawing.Point(231, 185);
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
            this.Dgv_asistenicas.Location = new System.Drawing.Point(387, 71);
            this.Dgv_asistenicas.Name = "Dgv_asistenicas";
            this.Dgv_asistenicas.RowHeadersWidth = 51;
            this.Dgv_asistenicas.RowTemplate.Height = 24;
            this.Dgv_asistenicas.Size = new System.Drawing.Size(318, 150);
            this.Dgv_asistenicas.TabIndex = 9;
            this.Dgv_asistenicas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_asistenicas_CellContentClick);
            // 
            // Lbl_observaciones
            // 
            this.Lbl_observaciones.AutoSize = true;
            this.Lbl_observaciones.BackColor = System.Drawing.Color.White;
            this.Lbl_observaciones.ForeColor = System.Drawing.Color.Black;
            this.Lbl_observaciones.Location = new System.Drawing.Point(244, 89);
            this.Lbl_observaciones.Name = "Lbl_observaciones";
            this.Lbl_observaciones.Size = new System.Drawing.Size(99, 16);
            this.Lbl_observaciones.TabIndex = 10;
            this.Lbl_observaciones.Text = "Observaciones";
            // 
            // Formasistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_observaciones);
            this.Controls.Add(this.Dgv_asistenicas);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_registrar);
            this.Controls.Add(this.Txt_observaciones);
            this.Controls.Add(this.Cbo_tipregistro);
            this.Controls.Add(this.Dpt_fecha);
            this.Controls.Add(this.Lbl_reloj);
            this.Controls.Add(this.Lbl_nombempleado);
            this.Controls.Add(this.Btn_buscar);
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
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_nombempleado;
        private System.Windows.Forms.Label Lbl_reloj;
        private System.Windows.Forms.DateTimePicker Dpt_fecha;
        private System.Windows.Forms.ComboBox Cbo_tipregistro;
        private System.Windows.Forms.TextBox Txt_observaciones;
        private System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.DataGridView Dgv_asistenicas;
        private System.Windows.Forms.Timer timer_reloj;
        private System.Windows.Forms.Label Lbl_observaciones;
    }
}