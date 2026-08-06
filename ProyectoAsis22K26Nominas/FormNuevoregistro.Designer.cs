using System;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoregistro));
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
            this.Btn_agregar = new System.Windows.Forms.Button();
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
            this.Txt_idempleado = new System.Windows.Forms.TextBox();
            this.Lbl_idregistro = new System.Windows.Forms.Label();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Txt_idpuesto = new System.Windows.Forms.TextBox();
            this.Lbl_idpusto = new System.Windows.Forms.Label();
            this.Dgv_empleados = new System.Windows.Forms.DataGridView();
            this.Txt_iddepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_fechnacimiento = new System.Windows.Forms.Label();
            this.Lbl_fechcontartacion = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Txt_nit = new System.Windows.Forms.TextBox();
            this.Lbl_nit = new System.Windows.Forms.Label();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pnl_Personal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_empleados)).BeginInit();
            this.panel1.SuspendLayout();
            this.Pnl_Personal.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_nombre.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.ForeColor = System.Drawing.Color.White;
            this.Txt_nombre.Location = new System.Drawing.Point(248, 92);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(240, 30);
            this.Txt_nombre.TabIndex = 0;
            this.Txt_nombre.TextChanged += new System.EventHandler(this.Txt_nombre_TextChanged);
            // 
            // Txt_apellidos
            // 
            this.Txt_apellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_apellidos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellidos.ForeColor = System.Drawing.Color.White;
            this.Txt_apellidos.Location = new System.Drawing.Point(546, 92);
            this.Txt_apellidos.Name = "Txt_apellidos";
            this.Txt_apellidos.Size = new System.Drawing.Size(240, 30);
            this.Txt_apellidos.TabIndex = 1;
            this.Txt_apellidos.TextChanged += new System.EventHandler(this.Txt_apellidos_TextChanged);
            // 
            // Txt_identificacion
            // 
            this.Txt_identificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_identificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_identificacion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_identificacion.ForeColor = System.Drawing.Color.White;
            this.Txt_identificacion.Location = new System.Drawing.Point(832, 92);
            this.Txt_identificacion.Name = "Txt_identificacion";
            this.Txt_identificacion.Size = new System.Drawing.Size(264, 30);
            this.Txt_identificacion.TabIndex = 2;
            this.Txt_identificacion.TextChanged += new System.EventHandler(this.Txt_identificacion_TextChanged);
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_telefono.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.ForeColor = System.Drawing.Color.White;
            this.Txt_telefono.Location = new System.Drawing.Point(248, 172);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(160, 30);
            this.Txt_telefono.TabIndex = 3;
            this.Txt_telefono.TextChanged += new System.EventHandler(this.Txt_telefono_TextChanged);
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_direccion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion.ForeColor = System.Drawing.Color.White;
            this.Txt_direccion.Location = new System.Drawing.Point(452, 172);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(334, 30);
            this.Txt_direccion.TabIndex = 4;
            this.Txt_direccion.TextChanged += new System.EventHandler(this.Txt_direccion_TextChanged);
            // 
            // Txt_correo
            // 
            this.Txt_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_correo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correo.ForeColor = System.Drawing.Color.White;
            this.Txt_correo.Location = new System.Drawing.Point(832, 172);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(264, 30);
            this.Txt_correo.TabIndex = 5;
            this.Txt_correo.TextChanged += new System.EventHandler(this.Txt_correo_TextChanged);
            // 
            // Txt_salario
            // 
            this.Txt_salario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_salario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_salario.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_salario.ForeColor = System.Drawing.Color.White;
            this.Txt_salario.Location = new System.Drawing.Point(250, 294);
            this.Txt_salario.Name = "Txt_salario";
            this.Txt_salario.Size = new System.Drawing.Size(132, 30);
            this.Txt_salario.TabIndex = 6;
            this.Txt_salario.TextChanged += new System.EventHandler(this.Txt_salario_TextChanged);
            // 
            // Dtp_fechnacimiento
            // 
            this.Dtp_fechnacimiento.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechnacimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.Dtp_fechnacimiento.CustomFormat = "dd/MM/yyyy";
            this.Dtp_fechnacimiento.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Dtp_fechnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechnacimiento.Location = new System.Drawing.Point(251, 465);
            this.Dtp_fechnacimiento.Name = "Dtp_fechnacimiento";
            this.Dtp_fechnacimiento.Size = new System.Drawing.Size(200, 30);
            this.Dtp_fechnacimiento.TabIndex = 7;
            this.Dtp_fechnacimiento.ValueChanged += new System.EventHandler(this.Dtp_fechnacimiento_ValueChanged);
            // 
            // Dtp_fechcontratacion
            // 
            this.Dtp_fechcontratacion.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechcontratacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Dtp_fechcontratacion.CustomFormat = "dd/MM/yyyy";
            this.Dtp_fechcontratacion.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Dtp_fechcontratacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechcontratacion.Location = new System.Drawing.Point(508, 465);
            this.Dtp_fechcontratacion.Name = "Dtp_fechcontratacion";
            this.Dtp_fechcontratacion.Size = new System.Drawing.Size(200, 30);
            this.Dtp_fechcontratacion.TabIndex = 8;
            this.Dtp_fechcontratacion.ValueChanged += new System.EventHandler(this.Dtp_fechcontratacion_ValueChanged);
            // 
            // Cbo_Departamento
            // 
            this.Cbo_Departamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Cbo_Departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Departamento.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Departamento.ForeColor = System.Drawing.Color.White;
            this.Cbo_Departamento.FormattingEnabled = true;
            this.Cbo_Departamento.Location = new System.Drawing.Point(250, 384);
            this.Cbo_Departamento.Name = "Cbo_Departamento";
            this.Cbo_Departamento.Size = new System.Drawing.Size(240, 34);
            this.Cbo_Departamento.TabIndex = 9;
            this.Cbo_Departamento.SelectedIndexChanged += new System.EventHandler(this.Cbo_Departamento_SelectedIndexChanged);
            // 
            // Cbo_puesto
            // 
            this.Cbo_puesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Cbo_puesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_puesto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_puesto.ForeColor = System.Drawing.Color.White;
            this.Cbo_puesto.FormattingEnabled = true;
            this.Cbo_puesto.Location = new System.Drawing.Point(834, 294);
            this.Cbo_puesto.Name = "Cbo_puesto";
            this.Cbo_puesto.Size = new System.Drawing.Size(264, 34);
            this.Cbo_puesto.TabIndex = 11;
            this.Cbo_puesto.SelectedIndexChanged += new System.EventHandler(this.Cbo_puesto_SelectedIndexChanged);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.ForeColor = System.Drawing.Color.White;
            this.Btn_agregar.Location = new System.Drawing.Point(1197, 676);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(113, 35);
            this.Btn_agregar.TabIndex = 13;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.Location = new System.Drawing.Point(1197, 563);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(113, 35);
            this.Btn_guardar.TabIndex = 14;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_nombre.Location = new System.Drawing.Point(244, 60);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(98, 26);
            this.Lbl_nombre.TabIndex = 15;
            this.Lbl_nombre.Text = "Nombre(s):";
            // 
            // Lbl_apellidos
            // 
            this.Lbl_apellidos.AutoSize = true;
            this.Lbl_apellidos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_apellidos.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_apellidos.Location = new System.Drawing.Point(543, 60);
            this.Lbl_apellidos.Name = "Lbl_apellidos";
            this.Lbl_apellidos.Size = new System.Drawing.Size(84, 26);
            this.Lbl_apellidos.TabIndex = 16;
            this.Lbl_apellidos.Text = "Apellidos:";
            // 
            // Lbl_identificacion
            // 
            this.Lbl_identificacion.AutoSize = true;
            this.Lbl_identificacion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_identificacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_identificacion.Location = new System.Drawing.Point(828, 60);
            this.Lbl_identificacion.Name = "Lbl_identificacion";
            this.Lbl_identificacion.Size = new System.Drawing.Size(160, 26);
            this.Lbl_identificacion.TabIndex = 17;
            this.Lbl_identificacion.Text = "Identificacion (DPI):";
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_telefono.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_telefono.Location = new System.Drawing.Point(247, 141);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(80, 26);
            this.Lbl_telefono.TabIndex = 18;
            this.Lbl_telefono.Text = "Teléfono:";
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_direccion.Location = new System.Drawing.Point(448, 141);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(87, 26);
            this.Lbl_direccion.TabIndex = 19;
            this.Lbl_direccion.Text = "Dirección:";
            this.Lbl_direccion.Click += new System.EventHandler(this.Lbl_direccion_Click);
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_correo.Location = new System.Drawing.Point(828, 141);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(68, 26);
            this.Lbl_correo.TabIndex = 20;
            this.Lbl_correo.Text = "Correo:";
            // 
            // Lbl_salario
            // 
            this.Lbl_salario.AutoSize = true;
            this.Lbl_salario.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_salario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_salario.Location = new System.Drawing.Point(249, 258);
            this.Lbl_salario.Name = "Lbl_salario";
            this.Lbl_salario.Size = new System.Drawing.Size(108, 26);
            this.Lbl_salario.TabIndex = 21;
            this.Lbl_salario.Text = "Salario Base:";
            // 
            // Lbl_Departamento
            // 
            this.Lbl_Departamento.AutoSize = true;
            this.Lbl_Departamento.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Departamento.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Departamento.Location = new System.Drawing.Point(249, 346);
            this.Lbl_Departamento.Name = "Lbl_Departamento";
            this.Lbl_Departamento.Size = new System.Drawing.Size(125, 26);
            this.Lbl_Departamento.TabIndex = 22;
            this.Lbl_Departamento.Text = "Departamento:";
            this.Lbl_Departamento.Click += new System.EventHandler(this.Lbl_Departamento_Click);
            // 
            // Lbl_puesto
            // 
            this.Lbl_puesto.AutoSize = true;
            this.Lbl_puesto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_puesto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_puesto.Location = new System.Drawing.Point(830, 258);
            this.Lbl_puesto.Name = "Lbl_puesto";
            this.Lbl_puesto.Size = new System.Drawing.Size(66, 26);
            this.Lbl_puesto.TabIndex = 24;
            this.Lbl_puesto.Text = "Puesto:";
            // 
            // Txt_idempleado
            // 
            this.Txt_idempleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_idempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_idempleado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idempleado.ForeColor = System.Drawing.Color.White;
            this.Txt_idempleado.Location = new System.Drawing.Point(548, 384);
            this.Txt_idempleado.Name = "Txt_idempleado";
            this.Txt_idempleado.Size = new System.Drawing.Size(223, 30);
            this.Txt_idempleado.TabIndex = 26;
            this.Txt_idempleado.TextChanged += new System.EventHandler(this.Txt_idempleado_TextChanged);
            // 
            // Lbl_idregistro
            // 
            this.Lbl_idregistro.AutoSize = true;
            this.Lbl_idregistro.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idregistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_idregistro.Location = new System.Drawing.Point(544, 346);
            this.Lbl_idregistro.Name = "Lbl_idregistro";
            this.Lbl_idregistro.Size = new System.Drawing.Size(110, 26);
            this.Lbl_idregistro.TabIndex = 27;
            this.Lbl_idregistro.Text = "ID Empleado:";
            this.Lbl_idregistro.Click += new System.EventHandler(this.Lbl_idregistro_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_limpiar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.Btn_limpiar.Location = new System.Drawing.Point(1197, 619);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(113, 35);
            this.Btn_limpiar.TabIndex = 28;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = false;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Txt_idpuesto
            // 
            this.Txt_idpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_idpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_idpuesto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idpuesto.ForeColor = System.Drawing.Color.White;
            this.Txt_idpuesto.Location = new System.Drawing.Point(454, 294);
            this.Txt_idpuesto.Name = "Txt_idpuesto";
            this.Txt_idpuesto.Size = new System.Drawing.Size(132, 30);
            this.Txt_idpuesto.TabIndex = 29;
            this.Txt_idpuesto.TextChanged += new System.EventHandler(this.Txt_idpuesto_TextChanged);
            // 
            // Lbl_idpusto
            // 
            this.Lbl_idpusto.AutoSize = true;
            this.Lbl_idpusto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idpusto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_idpusto.Location = new System.Drawing.Point(450, 258);
            this.Lbl_idpusto.Name = "Lbl_idpusto";
            this.Lbl_idpusto.Size = new System.Drawing.Size(85, 26);
            this.Lbl_idpusto.TabIndex = 30;
            this.Lbl_idpusto.Text = "ID Puesto:";
            // 
            // Dgv_empleados
            // 
            this.Dgv_empleados.AllowUserToAddRows = false;
            this.Dgv_empleados.AllowUserToDeleteRows = false;
            this.Dgv_empleados.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.Dgv_empleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_empleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_empleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.Dgv_empleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_empleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_empleados.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_empleados.EnableHeadersVisualStyles = false;
            this.Dgv_empleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Dgv_empleados.Location = new System.Drawing.Point(12, 523);
            this.Dgv_empleados.MultiSelect = false;
            this.Dgv_empleados.Name = "Dgv_empleados";
            this.Dgv_empleados.ReadOnly = true;
            this.Dgv_empleados.RowHeadersVisible = false;
            this.Dgv_empleados.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Dgv_empleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_empleados.RowTemplate.Height = 24;
            this.Dgv_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_empleados.Size = new System.Drawing.Size(1168, 269);
            this.Dgv_empleados.TabIndex = 31;
            this.Dgv_empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_empleados_CellContentClick);
            // 
            // Txt_iddepartamento
            // 
            this.Txt_iddepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_iddepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_iddepartamento.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_iddepartamento.ForeColor = System.Drawing.Color.White;
            this.Txt_iddepartamento.Location = new System.Drawing.Point(639, 294);
            this.Txt_iddepartamento.Name = "Txt_iddepartamento";
            this.Txt_iddepartamento.Size = new System.Drawing.Size(132, 30);
            this.Txt_iddepartamento.TabIndex = 32;
            this.Txt_iddepartamento.TextChanged += new System.EventHandler(this.Txt_iddepartamento_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(635, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID Departamento:";
            this.label1.Click += new System.EventHandler(this.Lbl_departamento);
            // 
            // Lbl_fechnacimiento
            // 
            this.Lbl_fechnacimiento.AutoSize = true;
            this.Lbl_fechnacimiento.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechnacimiento.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_fechnacimiento.Location = new System.Drawing.Point(247, 433);
            this.Lbl_fechnacimiento.Name = "Lbl_fechnacimiento";
            this.Lbl_fechnacimiento.Size = new System.Drawing.Size(152, 26);
            this.Lbl_fechnacimiento.TabIndex = 34;
            this.Lbl_fechnacimiento.Text = "Fecha Nacimiento:";
            this.Lbl_fechnacimiento.Click += new System.EventHandler(this.Lbl_fechnacimiento_Click);
            // 
            // Lbl_fechcontartacion
            // 
            this.Lbl_fechcontartacion.AutoSize = true;
            this.Lbl_fechcontartacion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechcontartacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_fechcontartacion.Location = new System.Drawing.Point(504, 433);
            this.Lbl_fechcontartacion.Name = "Lbl_fechcontartacion";
            this.Lbl_fechcontartacion.Size = new System.Drawing.Size(166, 26);
            this.Lbl_fechcontartacion.TabIndex = 35;
            this.Lbl_fechcontartacion.Text = "Fecha Contratación:";
            this.Lbl_fechcontartacion.Click += new System.EventHandler(this.Lbl_fechcontartacion_Click);
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Cbo_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_estado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_estado.ForeColor = System.Drawing.Color.White;
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Location = new System.Drawing.Point(804, 383);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(125, 34);
            this.Cbo_estado.TabIndex = 36;
            this.Cbo_estado.SelectedIndexChanged += new System.EventHandler(this.Cbo_estado_SelectedIndexChanged);
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_estado.Location = new System.Drawing.Point(797, 346);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(66, 26);
            this.Lbl_estado.TabIndex = 37;
            this.Lbl_estado.Text = "Estado:";
            this.Lbl_estado.Click += new System.EventHandler(this.Lbl_estado_Click);
            // 
            // Txt_nit
            // 
            this.Txt_nit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_nit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_nit.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nit.ForeColor = System.Drawing.Color.White;
            this.Txt_nit.Location = new System.Drawing.Point(966, 383);
            this.Txt_nit.Name = "Txt_nit";
            this.Txt_nit.Size = new System.Drawing.Size(132, 30);
            this.Txt_nit.TabIndex = 38;
            this.Txt_nit.TextChanged += new System.EventHandler(this.Txt_nit_TextChanged);
            // 
            // Lbl_nit
            // 
            this.Lbl_nit.AutoSize = true;
            this.Lbl_nit.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nit.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_nit.Location = new System.Drawing.Point(962, 346);
            this.Lbl_nit.Name = "Lbl_nit";
            this.Lbl_nit.Size = new System.Drawing.Size(35, 26);
            this.Lbl_nit.TabIndex = 39;
            this.Lbl_nit.Text = "Nit:";
            this.Lbl_nit.Click += new System.EventHandler(this.Lbl_nit_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.AutoEllipsis = true;
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_eliminar.Location = new System.Drawing.Point(1197, 729);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(113, 35);
            this.Btn_eliminar.TabIndex = 40;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 100);
            this.panel1.TabIndex = 77;
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
            this.label5.Size = new System.Drawing.Size(345, 54);
            this.label5.TabIndex = 75;
            this.label5.Text = "Nuevo Empleado";
            // 
            // Pnl_Personal
            // 
            this.Pnl_Personal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Personal.Controls.Add(this.panel4);
            this.Pnl_Personal.Controls.Add(this.Btn_guardar);
            this.Pnl_Personal.Controls.Add(this.label2);
            this.Pnl_Personal.Controls.Add(this.Btn_eliminar);
            this.Pnl_Personal.Controls.Add(this.Dgv_empleados);
            this.Pnl_Personal.Controls.Add(this.Btn_agregar);
            this.Pnl_Personal.Controls.Add(this.Txt_apellidos);
            this.Pnl_Personal.Controls.Add(this.Btn_limpiar);
            this.Pnl_Personal.Controls.Add(this.Txt_nit);
            this.Pnl_Personal.Controls.Add(this.Lbl_nit);
            this.Pnl_Personal.Controls.Add(this.Txt_nombre);
            this.Pnl_Personal.Controls.Add(this.Txt_identificacion);
            this.Pnl_Personal.Controls.Add(this.Lbl_estado);
            this.Pnl_Personal.Controls.Add(this.Cbo_estado);
            this.Pnl_Personal.Controls.Add(this.Lbl_nombre);
            this.Pnl_Personal.Controls.Add(this.Lbl_apellidos);
            this.Pnl_Personal.Controls.Add(this.Txt_iddepartamento);
            this.Pnl_Personal.Controls.Add(this.label1);
            this.Pnl_Personal.Controls.Add(this.Txt_idempleado);
            this.Pnl_Personal.Controls.Add(this.Lbl_idregistro);
            this.Pnl_Personal.Controls.Add(this.Lbl_fechcontartacion);
            this.Pnl_Personal.Controls.Add(this.Lbl_fechnacimiento);
            this.Pnl_Personal.Controls.Add(this.Lbl_puesto);
            this.Pnl_Personal.Controls.Add(this.Lbl_identificacion);
            this.Pnl_Personal.Controls.Add(this.Cbo_puesto);
            this.Pnl_Personal.Controls.Add(this.Txt_idpuesto);
            this.Pnl_Personal.Controls.Add(this.Lbl_idpusto);
            this.Pnl_Personal.Controls.Add(this.Lbl_telefono);
            this.Pnl_Personal.Controls.Add(this.Txt_telefono);
            this.Pnl_Personal.Controls.Add(this.Dtp_fechnacimiento);
            this.Pnl_Personal.Controls.Add(this.Dtp_fechcontratacion);
            this.Pnl_Personal.Controls.Add(this.Lbl_direccion);
            this.Pnl_Personal.Controls.Add(this.Txt_direccion);
            this.Pnl_Personal.Controls.Add(this.Lbl_Departamento);
            this.Pnl_Personal.Controls.Add(this.Lbl_correo);
            this.Pnl_Personal.Controls.Add(this.Lbl_salario);
            this.Pnl_Personal.Controls.Add(this.Cbo_Departamento);
            this.Pnl_Personal.Controls.Add(this.Txt_correo);
            this.Pnl_Personal.Controls.Add(this.Txt_salario);
            this.Pnl_Personal.Location = new System.Drawing.Point(29, 128);
            this.Pnl_Personal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Personal.Name = "Pnl_Personal";
            this.Pnl_Personal.Size = new System.Drawing.Size(1335, 814);
            this.Pnl_Personal.TabIndex = 78;
            this.Pnl_Personal.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Personal_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 26);
            this.label2.TabIndex = 71;
            this.label2.Text = "Ingreso de Empleados";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 100);
            this.panel2.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(121, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(538, 26);
            this.label3.TabIndex = 72;
            this.label3.Text = "Consulte, edite y administre la información de los empleados.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(116, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(510, 54);
            this.label4.TabIndex = 75;
            this.label4.Text = "Agregar Nuevo Empleado";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1376, 100);
            this.panel3.TabIndex = 86;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label7.Location = new System.Drawing.Point(121, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(538, 26);
            this.label7.TabIndex = 72;
            this.label7.Text = "Consulte, edite y administre la información de los empleados.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(116, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(510, 54);
            this.label8.TabIndex = 75;
            this.label8.Text = "Agregar Nuevo Empleado";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.panel4.Location = new System.Drawing.Point(147, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 4);
            this.panel4.TabIndex = 72;
            // 
            // FormNuevoregistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1376, 955);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_Personal);
            this.Name = "FormNuevoregistro";
            this.Text = "FormNuevoregistro";
            this.Load += new System.EventHandler(this.FormNuevoregistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_empleados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnl_Personal.ResumeLayout(false);
            this.Pnl_Personal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button Btn_agregar;
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
        private System.Windows.Forms.TextBox Txt_idempleado;
        private System.Windows.Forms.Label Lbl_idregistro;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.TextBox Txt_idpuesto;
        private System.Windows.Forms.Label Lbl_idpusto;
        private System.Windows.Forms.DataGridView Dgv_empleados;
        private System.Windows.Forms.TextBox Txt_iddepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_fechnacimiento;
        private System.Windows.Forms.Label Lbl_fechcontartacion;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.TextBox Txt_nit;
        private System.Windows.Forms.Label Lbl_nit;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Pnl_Personal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
    }
}