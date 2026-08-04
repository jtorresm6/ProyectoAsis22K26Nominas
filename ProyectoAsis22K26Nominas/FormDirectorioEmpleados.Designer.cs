namespace ProyectoAsis22K26Nominas
{
    partial class FormDirectorioEmpleados
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
            this.Lbl_idpusto = new System.Windows.Forms.Label();
            this.Txt_puesto = new System.Windows.Forms.TextBox();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Lbl_idregistro = new System.Windows.Forms.Label();
            this.Txt_idempleado = new System.Windows.Forms.TextBox();
            this.Lbl_puesto = new System.Windows.Forms.Label();
            this.Lbl_Departamento = new System.Windows.Forms.Label();
            this.Lbl_salario = new System.Windows.Forms.Label();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.Lbl_identificacion = new System.Windows.Forms.Label();
            this.Lbl_apellidos = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Btn_exportar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Dtp_fechcontratacion = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fechnacimiento = new System.Windows.Forms.DateTimePicker();
            this.Txt_salario = new System.Windows.Forms.TextBox();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Txt_identificacion = new System.Windows.Forms.TextBox();
            this.Txt_apellidos = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Txt_departamento = new System.Windows.Forms.TextBox();
            this.Txt_idpuesto = new System.Windows.Forms.TextBox();
            this.Txt_iddepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_fechnacimiento = new System.Windows.Forms.Label();
            this.Lbl_fechcontratacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_idpusto
            // 
            this.Lbl_idpusto.AutoSize = true;
            this.Lbl_idpusto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_idpusto.Location = new System.Drawing.Point(409, 258);
            this.Lbl_idpusto.Name = "Lbl_idpusto";
            this.Lbl_idpusto.Size = new System.Drawing.Size(62, 16);
            this.Lbl_idpusto.TabIndex = 59;
            this.Lbl_idpusto.Text = "Id puesto";
            // 
            // Txt_puesto
            // 
            this.Txt_puesto.Location = new System.Drawing.Point(371, 285);
            this.Txt_puesto.Name = "Txt_puesto";
            this.Txt_puesto.Size = new System.Drawing.Size(132, 22);
            this.Txt_puesto.TabIndex = 58;
            this.Txt_puesto.TextChanged += new System.EventHandler(this.Txt_idpuesto_TextChanged);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(669, 379);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btn_limpiar.TabIndex = 57;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Lbl_idregistro
            // 
            this.Lbl_idregistro.AutoSize = true;
            this.Lbl_idregistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_idregistro.Location = new System.Drawing.Point(73, 351);
            this.Lbl_idregistro.Name = "Lbl_idregistro";
            this.Lbl_idregistro.Size = new System.Drawing.Size(83, 16);
            this.Lbl_idregistro.TabIndex = 56;
            this.Lbl_idregistro.Text = "Id empleado";
            // 
            // Txt_idempleado
            // 
            this.Txt_idempleado.Location = new System.Drawing.Point(57, 378);
            this.Txt_idempleado.Name = "Txt_idempleado";
            this.Txt_idempleado.Size = new System.Drawing.Size(132, 22);
            this.Txt_idempleado.TabIndex = 55;
            this.Txt_idempleado.TextChanged += new System.EventHandler(this.Txt_idempleado_TextChanged);
            // 
            // Lbl_puesto
            // 
            this.Lbl_puesto.AutoSize = true;
            this.Lbl_puesto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_puesto.Location = new System.Drawing.Point(258, 348);
            this.Lbl_puesto.Name = "Lbl_puesto";
            this.Lbl_puesto.Size = new System.Drawing.Size(49, 16);
            this.Lbl_puesto.TabIndex = 53;
            this.Lbl_puesto.Text = "Puesto";
            // 
            // Lbl_Departamento
            // 
            this.Lbl_Departamento.AutoSize = true;
            this.Lbl_Departamento.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Departamento.Location = new System.Drawing.Point(230, 258);
            this.Lbl_Departamento.Name = "Lbl_Departamento";
            this.Lbl_Departamento.Size = new System.Drawing.Size(93, 16);
            this.Lbl_Departamento.TabIndex = 52;
            this.Lbl_Departamento.Text = "Departamento";
            // 
            // Lbl_salario
            // 
            this.Lbl_salario.AutoSize = true;
            this.Lbl_salario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_salario.Location = new System.Drawing.Point(71, 258);
            this.Lbl_salario.Name = "Lbl_salario";
            this.Lbl_salario.Size = new System.Drawing.Size(85, 16);
            this.Lbl_salario.TabIndex = 51;
            this.Lbl_salario.Text = "Salario Base";
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_correo.Location = new System.Drawing.Point(409, 153);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(48, 16);
            this.Lbl_correo.TabIndex = 50;
            this.Lbl_correo.Text = "Correo";
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_direccion.Location = new System.Drawing.Point(245, 153);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(64, 16);
            this.Lbl_direccion.TabIndex = 49;
            this.Lbl_direccion.Text = "Direccion";
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_telefono.Location = new System.Drawing.Point(93, 153);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(61, 16);
            this.Lbl_telefono.TabIndex = 48;
            this.Lbl_telefono.Text = "Telefono";
            // 
            // Lbl_identificacion
            // 
            this.Lbl_identificacion.AutoSize = true;
            this.Lbl_identificacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_identificacion.Location = new System.Drawing.Point(399, 49);
            this.Lbl_identificacion.Name = "Lbl_identificacion";
            this.Lbl_identificacion.Size = new System.Drawing.Size(85, 16);
            this.Lbl_identificacion.TabIndex = 47;
            this.Lbl_identificacion.Text = "Identificacion";
            // 
            // Lbl_apellidos
            // 
            this.Lbl_apellidos.AutoSize = true;
            this.Lbl_apellidos.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_apellidos.Location = new System.Drawing.Point(245, 49);
            this.Lbl_apellidos.Name = "Lbl_apellidos";
            this.Lbl_apellidos.Size = new System.Drawing.Size(64, 16);
            this.Lbl_apellidos.TabIndex = 46;
            this.Lbl_apellidos.Text = "Apellidos";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_nombre.Location = new System.Drawing.Point(93, 49);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(63, 16);
            this.Lbl_nombre.TabIndex = 45;
            this.Lbl_nombre.Text = "Nombres";
            // 
            // Btn_exportar
            // 
            this.Btn_exportar.Location = new System.Drawing.Point(562, 379);
            this.Btn_exportar.Name = "Btn_exportar";
            this.Btn_exportar.Size = new System.Drawing.Size(75, 23);
            this.Btn_exportar.TabIndex = 43;
            this.Btn_exportar.Text = "Exportar";
            this.Btn_exportar.UseVisualStyleBackColor = true;
            this.Btn_exportar.Click += new System.EventHandler(this.Btn_exportar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(614, 341);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 42;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.UseWaitCursor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Dtp_fechcontratacion
            // 
            this.Dtp_fechcontratacion.Location = new System.Drawing.Point(544, 153);
            this.Dtp_fechcontratacion.Name = "Dtp_fechcontratacion";
            this.Dtp_fechcontratacion.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fechcontratacion.TabIndex = 39;
            this.Dtp_fechcontratacion.ValueChanged += new System.EventHandler(this.Dtp_fechcontratacion_ValueChanged);
            // 
            // Dtp_fechnacimiento
            // 
            this.Dtp_fechnacimiento.Location = new System.Drawing.Point(544, 88);
            this.Dtp_fechnacimiento.Name = "Dtp_fechnacimiento";
            this.Dtp_fechnacimiento.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fechnacimiento.TabIndex = 38;
            this.Dtp_fechnacimiento.ValueChanged += new System.EventHandler(this.Dtp_fechnacimiento_ValueChanged);
            // 
            // Txt_salario
            // 
            this.Txt_salario.Location = new System.Drawing.Point(57, 287);
            this.Txt_salario.Name = "Txt_salario";
            this.Txt_salario.Size = new System.Drawing.Size(132, 22);
            this.Txt_salario.TabIndex = 37;
            this.Txt_salario.TextChanged += new System.EventHandler(this.Txt_salario_TextChanged);
            // 
            // Txt_correo
            // 
            this.Txt_correo.Location = new System.Drawing.Point(371, 182);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(126, 22);
            this.Txt_correo.TabIndex = 36;
            this.Txt_correo.TextChanged += new System.EventHandler(this.Txt_correo_TextChanged);
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Location = new System.Drawing.Point(217, 182);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(125, 22);
            this.Txt_direccion.TabIndex = 35;
            this.Txt_direccion.TextChanged += new System.EventHandler(this.Txt_direccion_TextChanged);
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Location = new System.Drawing.Point(57, 182);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(132, 22);
            this.Txt_telefono.TabIndex = 34;
            this.Txt_telefono.TextChanged += new System.EventHandler(this.Txt_telefono_TextChanged);
            // 
            // Txt_identificacion
            // 
            this.Txt_identificacion.Location = new System.Drawing.Point(371, 78);
            this.Txt_identificacion.Name = "Txt_identificacion";
            this.Txt_identificacion.Size = new System.Drawing.Size(126, 22);
            this.Txt_identificacion.TabIndex = 33;
            this.Txt_identificacion.TextChanged += new System.EventHandler(this.Txt_identificacion_TextChanged);
            // 
            // Txt_apellidos
            // 
            this.Txt_apellidos.Location = new System.Drawing.Point(217, 78);
            this.Txt_apellidos.Name = "Txt_apellidos";
            this.Txt_apellidos.Size = new System.Drawing.Size(125, 22);
            this.Txt_apellidos.TabIndex = 32;
            this.Txt_apellidos.TextChanged += new System.EventHandler(this.Txt_apellidos_TextChanged);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(57, 78);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(132, 22);
            this.Txt_nombre.TabIndex = 31;
            this.Txt_nombre.TextChanged += new System.EventHandler(this.Txt_nombre_TextChanged);
            // 
            // Txt_estado
            // 
            this.Txt_estado.Location = new System.Drawing.Point(210, 466);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(132, 22);
            this.Txt_estado.TabIndex = 60;
            this.Txt_estado.TextChanged += new System.EventHandler(this.Txt_estado_TextChanged);
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_estado.Location = new System.Drawing.Point(257, 447);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(50, 16);
            this.Lbl_estado.TabIndex = 61;
            this.Lbl_estado.Text = "Estado";
            this.Lbl_estado.Click += new System.EventHandler(this.Lbl_estado_Click);
            // 
            // Txt_departamento
            // 
            this.Txt_departamento.Location = new System.Drawing.Point(210, 287);
            this.Txt_departamento.Name = "Txt_departamento";
            this.Txt_departamento.Size = new System.Drawing.Size(132, 22);
            this.Txt_departamento.TabIndex = 62;
            this.Txt_departamento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_idpuesto
            // 
            this.Txt_idpuesto.Location = new System.Drawing.Point(210, 379);
            this.Txt_idpuesto.Name = "Txt_idpuesto";
            this.Txt_idpuesto.Size = new System.Drawing.Size(132, 22);
            this.Txt_idpuesto.TabIndex = 63;
            this.Txt_idpuesto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Txt_iddepartamento
            // 
            this.Txt_iddepartamento.Location = new System.Drawing.Point(371, 378);
            this.Txt_iddepartamento.Name = "Txt_iddepartamento";
            this.Txt_iddepartamento.Size = new System.Drawing.Size(132, 22);
            this.Txt_iddepartamento.TabIndex = 64;
            this.Txt_iddepartamento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(399, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Id departamento";
            // 
            // Lbl_fechnacimiento
            // 
            this.Lbl_fechnacimiento.AutoSize = true;
            this.Lbl_fechnacimiento.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_fechnacimiento.Location = new System.Drawing.Point(582, 49);
            this.Lbl_fechnacimiento.Name = "Lbl_fechnacimiento";
            this.Lbl_fechnacimiento.Size = new System.Drawing.Size(130, 16);
            this.Lbl_fechnacimiento.TabIndex = 66;
            this.Lbl_fechnacimiento.Text = "fecha de Nacimiento";
            // 
            // Lbl_fechcontratacion
            // 
            this.Lbl_fechcontratacion.AutoSize = true;
            this.Lbl_fechcontratacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_fechcontratacion.Location = new System.Drawing.Point(582, 134);
            this.Lbl_fechcontratacion.Name = "Lbl_fechcontratacion";
            this.Lbl_fechcontratacion.Size = new System.Drawing.Size(135, 16);
            this.Lbl_fechcontratacion.TabIndex = 67;
            this.Lbl_fechcontratacion.Text = "fecha de contratacion";
            // 
            // FormDirectorioEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(853, 526);
            this.Controls.Add(this.Lbl_fechcontratacion);
            this.Controls.Add(this.Lbl_fechnacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_iddepartamento);
            this.Controls.Add(this.Txt_idpuesto);
            this.Controls.Add(this.Txt_departamento);
            this.Controls.Add(this.Lbl_estado);
            this.Controls.Add(this.Txt_estado);
            this.Controls.Add(this.Lbl_idpusto);
            this.Controls.Add(this.Txt_puesto);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Lbl_idregistro);
            this.Controls.Add(this.Txt_idempleado);
            this.Controls.Add(this.Lbl_puesto);
            this.Controls.Add(this.Lbl_Departamento);
            this.Controls.Add(this.Lbl_salario);
            this.Controls.Add(this.Lbl_correo);
            this.Controls.Add(this.Lbl_direccion);
            this.Controls.Add(this.Lbl_telefono);
            this.Controls.Add(this.Lbl_identificacion);
            this.Controls.Add(this.Lbl_apellidos);
            this.Controls.Add(this.Lbl_nombre);
            this.Controls.Add(this.Btn_exportar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Dtp_fechcontratacion);
            this.Controls.Add(this.Dtp_fechnacimiento);
            this.Controls.Add(this.Txt_salario);
            this.Controls.Add(this.Txt_correo);
            this.Controls.Add(this.Txt_direccion);
            this.Controls.Add(this.Txt_telefono);
            this.Controls.Add(this.Txt_identificacion);
            this.Controls.Add(this.Txt_apellidos);
            this.Controls.Add(this.Txt_nombre);
            this.Name = "FormDirectorioEmpleados";
            this.Text = "FormDirectorioEmpleados";
            this.Load += new System.EventHandler(this.FormDirectorioEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_idpusto;
        private System.Windows.Forms.TextBox Txt_puesto;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Label Lbl_idregistro;
        private System.Windows.Forms.TextBox Txt_idempleado;
        private System.Windows.Forms.Label Lbl_puesto;
        private System.Windows.Forms.Label Lbl_Departamento;
        private System.Windows.Forms.Label Lbl_salario;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.Label Lbl_direccion;
        private System.Windows.Forms.Label Lbl_telefono;
        private System.Windows.Forms.Label Lbl_identificacion;
        private System.Windows.Forms.Label Lbl_apellidos;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Button Btn_exportar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.DateTimePicker Dtp_fechcontratacion;
        private System.Windows.Forms.DateTimePicker Dtp_fechnacimiento;
        private System.Windows.Forms.TextBox Txt_salario;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.TextBox Txt_identificacion;
        private System.Windows.Forms.TextBox Txt_apellidos;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.TextBox Txt_departamento;
        private System.Windows.Forms.TextBox Txt_idpuesto;
        private System.Windows.Forms.TextBox Txt_iddepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_fechnacimiento;
        private System.Windows.Forms.Label Lbl_fechcontratacion;
    }
}