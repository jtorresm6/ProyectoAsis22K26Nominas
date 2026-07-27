namespace ProyectoAsis22K26Nominas
{
    partial class FormNuevoregistro
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
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_apellidos = new System.Windows.Forms.TextBox();
            this.Txt_identificacion = new System.Windows.Forms.TextBox();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Txt_salario = new System.Windows.Forms.TextBox();
            this.Dtp_fechnacimiento = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fechcontratacion = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Departamento = new System.Windows.Forms.ComboBox();
            this.Cbo_puesto = new System.Windows.Forms.ComboBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_apellidos = new System.Windows.Forms.Label();
            this.Lbl_identificacion = new System.Windows.Forms.Label();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Lbl_salario = new System.Windows.Forms.Label();
            this.Lbl_Departamento = new System.Windows.Forms.Label();
            this.Lbl_puesto = new System.Windows.Forms.Label();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Txt_idempleado = new System.Windows.Forms.TextBox();
            this.Lbl_idregistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(34, 78);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(132, 22);
            this.Txt_nombre.TabIndex = 0;
            this.Txt_nombre.TextChanged += new System.EventHandler(this.Txt_nombre_TextChanged);
            // 
            // Txt_apellidos
            // 
            this.Txt_apellidos.Location = new System.Drawing.Point(194, 78);
            this.Txt_apellidos.Name = "Txt_apellidos";
            this.Txt_apellidos.Size = new System.Drawing.Size(125, 22);
            this.Txt_apellidos.TabIndex = 1;
            this.Txt_apellidos.TextChanged += new System.EventHandler(this.Txt_apellidos_TextChanged);
            // 
            // Txt_identificacion
            // 
            this.Txt_identificacion.Location = new System.Drawing.Point(348, 78);
            this.Txt_identificacion.Name = "Txt_identificacion";
            this.Txt_identificacion.Size = new System.Drawing.Size(126, 22);
            this.Txt_identificacion.TabIndex = 2;
            this.Txt_identificacion.TextChanged += new System.EventHandler(this.Txt_identificacion_TextChanged);
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Location = new System.Drawing.Point(34, 182);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(132, 22);
            this.Txt_telefono.TabIndex = 3;
            this.Txt_telefono.TextChanged += new System.EventHandler(this.Txt_telefono_TextChanged);
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Location = new System.Drawing.Point(194, 182);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(125, 22);
            this.Txt_direccion.TabIndex = 4;
            this.Txt_direccion.TextChanged += new System.EventHandler(this.Txt_direccion_TextChanged);
            // 
            // Txt_correo
            // 
            this.Txt_correo.Location = new System.Drawing.Point(348, 182);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(126, 22);
            this.Txt_correo.TabIndex = 5;
            this.Txt_correo.TextChanged += new System.EventHandler(this.Txt_correo_TextChanged);
            // 
            // Txt_salario
            // 
            this.Txt_salario.Location = new System.Drawing.Point(34, 287);
            this.Txt_salario.Name = "Txt_salario";
            this.Txt_salario.Size = new System.Drawing.Size(132, 22);
            this.Txt_salario.TabIndex = 6;
            this.Txt_salario.TextChanged += new System.EventHandler(this.Txt_salario_TextChanged);
            // 
            // Dtp_fechnacimiento
            // 
            this.Dtp_fechnacimiento.Location = new System.Drawing.Point(521, 88);
            this.Dtp_fechnacimiento.Name = "Dtp_fechnacimiento";
            this.Dtp_fechnacimiento.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fechnacimiento.TabIndex = 7;
            this.Dtp_fechnacimiento.ValueChanged += new System.EventHandler(this.Dtp_fechnacimiento_ValueChanged);
            // 
            // Dtp_fechcontratacion
            // 
            this.Dtp_fechcontratacion.Location = new System.Drawing.Point(521, 171);
            this.Dtp_fechcontratacion.Name = "Dtp_fechcontratacion";
            this.Dtp_fechcontratacion.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fechcontratacion.TabIndex = 8;
            this.Dtp_fechcontratacion.ValueChanged += new System.EventHandler(this.Dtp_fechcontratacion_ValueChanged);
            // 
            // Cbo_Departamento
            // 
            this.Cbo_Departamento.FormattingEnabled = true;
            this.Cbo_Departamento.Location = new System.Drawing.Point(194, 285);
            this.Cbo_Departamento.Name = "Cbo_Departamento";
            this.Cbo_Departamento.Size = new System.Drawing.Size(125, 24);
            this.Cbo_Departamento.TabIndex = 9;
            this.Cbo_Departamento.SelectedIndexChanged += new System.EventHandler(this.Cbo_Departamento_SelectedIndexChanged);
            // 
            // Cbo_puesto
            // 
            this.Cbo_puesto.FormattingEnabled = true;
            this.Cbo_puesto.Location = new System.Drawing.Point(194, 378);
            this.Cbo_puesto.Name = "Cbo_puesto";
            this.Cbo_puesto.Size = new System.Drawing.Size(125, 24);
            this.Cbo_puesto.TabIndex = 11;
            this.Cbo_puesto.SelectedIndexChanged += new System.EventHandler(this.Cbo_puesto_SelectedIndexChanged);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(521, 348);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 12;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.UseWaitCursor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(646, 348);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.Btn_actualizar.TabIndex = 13;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(585, 315);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_guardar.TabIndex = 14;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_nombre.Location = new System.Drawing.Point(70, 49);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(63, 16);
            this.Lbl_nombre.TabIndex = 15;
            this.Lbl_nombre.Text = "Nombres";
            // 
            // Lbl_apellidos
            // 
            this.Lbl_apellidos.AutoSize = true;
            this.Lbl_apellidos.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_apellidos.Location = new System.Drawing.Point(222, 49);
            this.Lbl_apellidos.Name = "Lbl_apellidos";
            this.Lbl_apellidos.Size = new System.Drawing.Size(64, 16);
            this.Lbl_apellidos.TabIndex = 16;
            this.Lbl_apellidos.Text = "Apellidos";
            // 
            // Lbl_identificacion
            // 
            this.Lbl_identificacion.AutoSize = true;
            this.Lbl_identificacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_identificacion.Location = new System.Drawing.Point(376, 49);
            this.Lbl_identificacion.Name = "Lbl_identificacion";
            this.Lbl_identificacion.Size = new System.Drawing.Size(85, 16);
            this.Lbl_identificacion.TabIndex = 17;
            this.Lbl_identificacion.Text = "Identificacion";
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_telefono.Location = new System.Drawing.Point(70, 153);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(61, 16);
            this.Lbl_telefono.TabIndex = 18;
            this.Lbl_telefono.Text = "Telefono";
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_direccion.Location = new System.Drawing.Point(222, 153);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(64, 16);
            this.Lbl_direccion.TabIndex = 19;
            this.Lbl_direccion.Text = "Direccion";
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_correo.Location = new System.Drawing.Point(386, 153);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(48, 16);
            this.Lbl_correo.TabIndex = 20;
            this.Lbl_correo.Text = "Correo";
            // 
            // Lbl_salario
            // 
            this.Lbl_salario.AutoSize = true;
            this.Lbl_salario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_salario.Location = new System.Drawing.Point(48, 258);
            this.Lbl_salario.Name = "Lbl_salario";
            this.Lbl_salario.Size = new System.Drawing.Size(85, 16);
            this.Lbl_salario.TabIndex = 21;
            this.Lbl_salario.Text = "Salario Base";
            // 
            // Lbl_Departamento
            // 
            this.Lbl_Departamento.AutoSize = true;
            this.Lbl_Departamento.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Departamento.Location = new System.Drawing.Point(207, 258);
            this.Lbl_Departamento.Name = "Lbl_Departamento";
            this.Lbl_Departamento.Size = new System.Drawing.Size(93, 16);
            this.Lbl_Departamento.TabIndex = 22;
            this.Lbl_Departamento.Text = "Departamento";
            // 
            // Lbl_puesto
            // 
            this.Lbl_puesto.AutoSize = true;
            this.Lbl_puesto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_puesto.Location = new System.Drawing.Point(235, 348);
            this.Lbl_puesto.Name = "Lbl_puesto";
            this.Lbl_puesto.Size = new System.Drawing.Size(49, 16);
            this.Lbl_puesto.TabIndex = 24;
            this.Lbl_puesto.Text = "Puesto";
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(585, 392);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar.TabIndex = 25;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Txt_idempleado
            // 
            this.Txt_idempleado.Location = new System.Drawing.Point(34, 378);
            this.Txt_idempleado.Name = "Txt_idempleado";
            this.Txt_idempleado.Size = new System.Drawing.Size(132, 22);
            this.Txt_idempleado.TabIndex = 26;
            this.Txt_idempleado.TextChanged += new System.EventHandler(this.Txt_idempleado_TextChanged);
            // 
            // Lbl_idregistro
            // 
            this.Lbl_idregistro.AutoSize = true;
            this.Lbl_idregistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_idregistro.Location = new System.Drawing.Point(50, 351);
            this.Lbl_idregistro.Name = "Lbl_idregistro";
            this.Lbl_idregistro.Size = new System.Drawing.Size(83, 16);
            this.Lbl_idregistro.TabIndex = 27;
            this.Lbl_idregistro.Text = "Id empleado";
            // 
            // FormNuevoregistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_idregistro);
            this.Controls.Add(this.Txt_idempleado);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Lbl_puesto);
            this.Controls.Add(this.Lbl_Departamento);
            this.Controls.Add(this.Lbl_salario);
            this.Controls.Add(this.Lbl_correo);
            this.Controls.Add(this.Lbl_direccion);
            this.Controls.Add(this.Lbl_telefono);
            this.Controls.Add(this.Lbl_identificacion);
            this.Controls.Add(this.Lbl_apellidos);
            this.Controls.Add(this.Lbl_nombre);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Cbo_puesto);
            this.Controls.Add(this.Cbo_Departamento);
            this.Controls.Add(this.Dtp_fechcontratacion);
            this.Controls.Add(this.Dtp_fechnacimiento);
            this.Controls.Add(this.Txt_salario);
            this.Controls.Add(this.Txt_correo);
            this.Controls.Add(this.Txt_direccion);
            this.Controls.Add(this.Txt_telefono);
            this.Controls.Add(this.Txt_identificacion);
            this.Controls.Add(this.Txt_apellidos);
            this.Controls.Add(this.Txt_nombre);
            this.Name = "FormNuevoregistro";
            this.Text = "FormNuevoregistro";
            this.Load += new System.EventHandler(this.FormNuevoregistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_apellidos;
        private System.Windows.Forms.TextBox Txt_identificacion;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.TextBox Txt_salario;
        private System.Windows.Forms.DateTimePicker Dtp_fechnacimiento;
        private System.Windows.Forms.DateTimePicker Dtp_fechcontratacion;
        private System.Windows.Forms.ComboBox Cbo_Departamento;
        private System.Windows.Forms.ComboBox Cbo_puesto;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_apellidos;
        private System.Windows.Forms.Label Lbl_identificacion;
        private System.Windows.Forms.Label Lbl_telefono;
        private System.Windows.Forms.Label Lbl_direccion;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.Label Lbl_salario;
        private System.Windows.Forms.Label Lbl_Departamento;
        private System.Windows.Forms.Label Lbl_puesto;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.TextBox Txt_idempleado;
        private System.Windows.Forms.Label Lbl_idregistro;
    }
}