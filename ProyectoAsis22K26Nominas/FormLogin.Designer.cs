namespace ProyectoAsis22K26Nominas
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Lbl_contra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_password
            // 
            this.Txt_password.Location = new System.Drawing.Point(267, 264);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.Size = new System.Drawing.Size(250, 22);
            this.Txt_password.TabIndex = 0;
            this.Txt_password.TextChanged += new System.EventHandler(this.Txt_password_TextChanged);
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(267, 167);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(250, 22);
            this.Txt_usuario.TabIndex = 0;
            this.Txt_usuario.TextChanged += new System.EventHandler(this.Txt_usuario_TextChanged);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Btn_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Btn_ingresar.FlatAppearance.BorderSize = 3;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_ingresar.Location = new System.Drawing.Point(228, 322);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(144, 59);
            this.Btn_ingresar.TabIndex = 2;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Btn_salir.FlatAppearance.BorderSize = 3;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_salir.Location = new System.Drawing.Point(422, 322);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(144, 59);
            this.Btn_salir.TabIndex = 3;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = false;
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_usuario.Location = new System.Drawing.Point(325, 148);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(131, 16);
            this.Lbl_usuario.TabIndex = 4;
            this.Lbl_usuario.Text = "INGRESE USUARIO";
            // 
            // Lbl_contra
            // 
            this.Lbl_contra.AutoSize = true;
            this.Lbl_contra.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_contra.Location = new System.Drawing.Point(312, 245);
            this.Lbl_contra.Name = "Lbl_contra";
            this.Lbl_contra.Size = new System.Drawing.Size(164, 16);
            this.Lbl_contra.TabIndex = 5;
            this.Lbl_contra.Text = "INGRESE CONTRASEÑA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoAsis22K26Nominas.Properties.Resources.red1;
            this.pictureBox1.Location = new System.Drawing.Point(-196, -148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.Lbl_contra);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Txt_password);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 754);
            this.Name = "FormLogin";
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.Label Lbl_contra;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}