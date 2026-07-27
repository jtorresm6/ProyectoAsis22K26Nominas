namespace ProyectoAsis22K26Nominas
{
    partial class FormMantenimientoEmpleado
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Cbo_Busqueda = new System.Windows.Forms.ComboBox();
            this.Txt_Datos = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_Sub1 = new System.Windows.Forms.Label();
            this.Lbl_Info_Empleados = new System.Windows.Forms.Label();
            this.Lbl_Info_Laboral = new System.Windows.Forms.Label();
            this.Btn_Actu = new System.Windows.Forms.Button();
            this.Btn_Bajas = new System.Windows.Forms.Button();
            this.Btn_Reactivar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Lbl_Cod_Emp = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_Cod = new System.Windows.Forms.TextBox();
            this.Dtp_Fecha_Nac = new System.Windows.Forms.DateTimePicker();
            this.Lbl_DPI = new System.Windows.Forms.Label();
            this.Lbl_NIT = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Apellido = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Nac = new System.Windows.Forms.Label();
            this.Lbl_Dir = new System.Windows.Forms.Label();
            this.Lbl_Tel = new System.Windows.Forms.Label();
            this.Lbl_Corr = new System.Windows.Forms.Label();
            this.Txt_DPI = new System.Windows.Forms.TextBox();
            this.Txt_NIT = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Txt_Dir = new System.Windows.Forms.TextBox();
            this.Txt_Tel = new System.Windows.Forms.TextBox();
            this.Txt_Corr = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha_Cont = new System.Windows.Forms.Label();
            this.Lbl_Departamento = new System.Windows.Forms.Label();
            this.Lbl_Puesto = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Cont = new System.Windows.Forms.DateTimePicker();
            this.Txt_Dep = new System.Windows.Forms.TextBox();
            this.Txt_Puesto = new System.Windows.Forms.TextBox();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Titulo.Location = new System.Drawing.Point(547, 23);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(352, 32);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Mantenimiento Empleados";
            this.Lbl_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Buscar.Location = new System.Drawing.Point(374, 157);
            this.Lbl_Buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(97, 20);
            this.Lbl_Buscar.TabIndex = 1;
            this.Lbl_Buscar.Text = "Buscar por:";
            // 
            // Cbo_Busqueda
            // 
            this.Cbo_Busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Busqueda.FormattingEnabled = true;
            this.Cbo_Busqueda.Items.AddRange(new object[] {
            "Codigo",
            "DPI",
            "NIT"});
            this.Cbo_Busqueda.Location = new System.Drawing.Point(475, 153);
            this.Cbo_Busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Busqueda.Name = "Cbo_Busqueda";
            this.Cbo_Busqueda.Size = new System.Drawing.Size(150, 28);
            this.Cbo_Busqueda.TabIndex = 2;
            // 
            // Txt_Datos
            // 
            this.Txt_Datos.Location = new System.Drawing.Point(653, 153);
            this.Txt_Datos.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Datos.Name = "Txt_Datos";
            this.Txt_Datos.Size = new System.Drawing.Size(216, 27);
            this.Txt_Datos.TabIndex = 3;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(893, 152);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(156, 29);
            this.Btn_Buscar.TabIndex = 4;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Lbl_Sub1
            // 
            this.Lbl_Sub1.AutoSize = true;
            this.Lbl_Sub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sub1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Sub1.Location = new System.Drawing.Point(373, 107);
            this.Lbl_Sub1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Sub1.Name = "Lbl_Sub1";
            this.Lbl_Sub1.Size = new System.Drawing.Size(210, 22);
            this.Lbl_Sub1.TabIndex = 5;
            this.Lbl_Sub1.Text = "Búsqueda de Empleados";
            this.Lbl_Sub1.Click += new System.EventHandler(this.label3_Click);
            // 
            // Lbl_Info_Empleados
            // 
            this.Lbl_Info_Empleados.AutoSize = true;
            this.Lbl_Info_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Info_Empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Info_Empleados.Location = new System.Drawing.Point(40, 220);
            this.Lbl_Info_Empleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Info_Empleados.Name = "Lbl_Info_Empleados";
            this.Lbl_Info_Empleados.Size = new System.Drawing.Size(187, 22);
            this.Lbl_Info_Empleados.TabIndex = 8;
            this.Lbl_Info_Empleados.Text = "Información Empleado";
            this.Lbl_Info_Empleados.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lbl_Info_Laboral
            // 
            this.Lbl_Info_Laboral.AutoSize = true;
            this.Lbl_Info_Laboral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Info_Laboral.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Info_Laboral.Location = new System.Drawing.Point(40, 482);
            this.Lbl_Info_Laboral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Info_Laboral.Name = "Lbl_Info_Laboral";
            this.Lbl_Info_Laboral.Size = new System.Drawing.Size(167, 22);
            this.Lbl_Info_Laboral.TabIndex = 9;
            this.Lbl_Info_Laboral.Text = "Información Laboral";
            this.Lbl_Info_Laboral.Click += new System.EventHandler(this.Lbl_Info_Laboral_Click);
            // 
            // Btn_Actu
            // 
            this.Btn_Actu.Location = new System.Drawing.Point(70, 721);
            this.Btn_Actu.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Actu.Name = "Btn_Actu";
            this.Btn_Actu.Size = new System.Drawing.Size(111, 35);
            this.Btn_Actu.TabIndex = 10;
            this.Btn_Actu.Text = "Actualizar";
            this.Btn_Actu.UseVisualStyleBackColor = true;
            this.Btn_Actu.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Bajas
            // 
            this.Btn_Bajas.Location = new System.Drawing.Point(972, 536);
            this.Btn_Bajas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Bajas.Name = "Btn_Bajas";
            this.Btn_Bajas.Size = new System.Drawing.Size(126, 35);
            this.Btn_Bajas.TabIndex = 11;
            this.Btn_Bajas.Text = "Dar de Baja";
            this.Btn_Bajas.UseVisualStyleBackColor = true;
            this.Btn_Bajas.Click += new System.EventHandler(this.Btn_Bajas_Click);
            // 
            // Btn_Reactivar
            // 
            this.Btn_Reactivar.Location = new System.Drawing.Point(972, 589);
            this.Btn_Reactivar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reactivar.Name = "Btn_Reactivar";
            this.Btn_Reactivar.Size = new System.Drawing.Size(126, 35);
            this.Btn_Reactivar.TabIndex = 12;
            this.Btn_Reactivar.Text = "Reactivar";
            this.Btn_Reactivar.UseVisualStyleBackColor = true;
            this.Btn_Reactivar.Click += new System.EventHandler(this.button4_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(296, 721);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(99, 35);
            this.Btn_Limpiar.TabIndex = 13;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Lbl_Cod_Emp
            // 
            this.Lbl_Cod_Emp.AutoSize = true;
            this.Lbl_Cod_Emp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Cod_Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cod_Emp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Cod_Emp.Location = new System.Drawing.Point(45, 275);
            this.Lbl_Cod_Emp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cod_Emp.Name = "Lbl_Cod_Emp";
            this.Lbl_Cod_Emp.Size = new System.Drawing.Size(153, 20);
            this.Lbl_Cod_Emp.TabIndex = 2;
            this.Lbl_Cod_Emp.Text = "Código de Empleado:";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(481, 719);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(188, 40);
            this.Btn_Guardar.TabIndex = 16;
            this.Btn_Guardar.Text = "Guardar Cambios";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(729, 721);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(120, 40);
            this.Btn_Cancelar.TabIndex = 17;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cod.Location = new System.Drawing.Point(214, 275);
            this.Txt_Cod.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(208, 27);
            this.Txt_Cod.TabIndex = 10;
            this.Txt_Cod.TextChanged += new System.EventHandler(this.Txt_Cod_TextChanged);
            // 
            // Dtp_Fecha_Nac
            // 
            this.Dtp_Fecha_Nac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Nac.Location = new System.Drawing.Point(729, 381);
            this.Dtp_Fecha_Nac.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Fecha_Nac.Name = "Dtp_Fecha_Nac";
            this.Dtp_Fecha_Nac.Size = new System.Drawing.Size(149, 27);
            this.Dtp_Fecha_Nac.TabIndex = 12;
            this.Dtp_Fecha_Nac.ValueChanged += new System.EventHandler(this.Dtp_Fecha_Nac_ValueChanged);
            // 
            // Lbl_DPI
            // 
            this.Lbl_DPI.AutoSize = true;
            this.Lbl_DPI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_DPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DPI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_DPI.Location = new System.Drawing.Point(45, 330);
            this.Lbl_DPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DPI.Name = "Lbl_DPI";
            this.Lbl_DPI.Size = new System.Drawing.Size(38, 20);
            this.Lbl_DPI.TabIndex = 18;
            this.Lbl_DPI.Text = "DPI:";
            // 
            // Lbl_NIT
            // 
            this.Lbl_NIT.AutoSize = true;
            this.Lbl_NIT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_NIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NIT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_NIT.Location = new System.Drawing.Point(45, 385);
            this.Lbl_NIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NIT.Name = "Lbl_NIT";
            this.Lbl_NIT.Size = new System.Drawing.Size(37, 20);
            this.Lbl_NIT.TabIndex = 19;
            this.Lbl_NIT.Text = "NIT:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Nombre.Location = new System.Drawing.Point(548, 272);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(76, 20);
            this.Lbl_Nombre.TabIndex = 20;
            this.Lbl_Nombre.Text = "Nombres:";
            // 
            // Lbl_Apellido
            // 
            this.Lbl_Apellido.AutoSize = true;
            this.Lbl_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Apellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Apellido.Location = new System.Drawing.Point(548, 329);
            this.Lbl_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Apellido.Name = "Lbl_Apellido";
            this.Lbl_Apellido.Size = new System.Drawing.Size(73, 20);
            this.Lbl_Apellido.TabIndex = 21;
            this.Lbl_Apellido.Text = "Apellidos:";
            // 
            // Lbl_Fecha_Nac
            // 
            this.Lbl_Fecha_Nac.AutoSize = true;
            this.Lbl_Fecha_Nac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Fecha_Nac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Nac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Fecha_Nac.Location = new System.Drawing.Point(548, 384);
            this.Lbl_Fecha_Nac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Nac.Name = "Lbl_Fecha_Nac";
            this.Lbl_Fecha_Nac.Size = new System.Drawing.Size(154, 20);
            this.Lbl_Fecha_Nac.TabIndex = 22;
            this.Lbl_Fecha_Nac.Text = "Fecha de Nacimiento:";
            // 
            // Lbl_Dir
            // 
            this.Lbl_Dir.AutoSize = true;
            this.Lbl_Dir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Dir.Location = new System.Drawing.Point(975, 275);
            this.Lbl_Dir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Dir.Name = "Lbl_Dir";
            this.Lbl_Dir.Size = new System.Drawing.Size(77, 20);
            this.Lbl_Dir.TabIndex = 23;
            this.Lbl_Dir.Text = "Dirección:";
            // 
            // Lbl_Tel
            // 
            this.Lbl_Tel.AutoSize = true;
            this.Lbl_Tel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Tel.Location = new System.Drawing.Point(975, 332);
            this.Lbl_Tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Tel.Name = "Lbl_Tel";
            this.Lbl_Tel.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Tel.TabIndex = 24;
            this.Lbl_Tel.Text = "Teléfonos:";
            // 
            // Lbl_Corr
            // 
            this.Lbl_Corr.AutoSize = true;
            this.Lbl_Corr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Corr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Corr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Corr.Location = new System.Drawing.Point(975, 388);
            this.Lbl_Corr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Corr.Name = "Lbl_Corr";
            this.Lbl_Corr.Size = new System.Drawing.Size(69, 20);
            this.Lbl_Corr.TabIndex = 25;
            this.Lbl_Corr.Text = "Correos:";
            // 
            // Txt_DPI
            // 
            this.Txt_DPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DPI.Location = new System.Drawing.Point(100, 328);
            this.Txt_DPI.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DPI.Name = "Txt_DPI";
            this.Txt_DPI.Size = new System.Drawing.Size(345, 27);
            this.Txt_DPI.TabIndex = 26;
            this.Txt_DPI.TextChanged += new System.EventHandler(this.Txt_DPI_TextChanged);
            // 
            // Txt_NIT
            // 
            this.Txt_NIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NIT.Location = new System.Drawing.Point(100, 384);
            this.Txt_NIT.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_NIT.Name = "Txt_NIT";
            this.Txt_NIT.Size = new System.Drawing.Size(345, 27);
            this.Txt_NIT.TabIndex = 27;
            this.Txt_NIT.TextChanged += new System.EventHandler(this.Txt_NIT_TextChanged);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(653, 271);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(246, 27);
            this.Txt_Nombre.TabIndex = 28;
            this.Txt_Nombre.TextChanged += new System.EventHandler(this.Txt_Nombre_TextChanged);
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.Location = new System.Drawing.Point(653, 326);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(246, 27);
            this.Txt_Apellido.TabIndex = 29;
            this.Txt_Apellido.TextChanged += new System.EventHandler(this.Txt_Apellido_TextChanged);
            // 
            // Txt_Dir
            // 
            this.Txt_Dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Dir.Location = new System.Drawing.Point(1081, 272);
            this.Txt_Dir.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Dir.Name = "Txt_Dir";
            this.Txt_Dir.Size = new System.Drawing.Size(215, 27);
            this.Txt_Dir.TabIndex = 30;
            this.Txt_Dir.TextChanged += new System.EventHandler(this.Txt_Dir_TextChanged);
            // 
            // Txt_Tel
            // 
            this.Txt_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Tel.Location = new System.Drawing.Point(1081, 326);
            this.Txt_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.Size = new System.Drawing.Size(215, 27);
            this.Txt_Tel.TabIndex = 31;
            this.Txt_Tel.TextChanged += new System.EventHandler(this.Txt_Tel_TextChanged);
            // 
            // Txt_Corr
            // 
            this.Txt_Corr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Corr.Location = new System.Drawing.Point(1081, 384);
            this.Txt_Corr.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Corr.Name = "Txt_Corr";
            this.Txt_Corr.Size = new System.Drawing.Size(236, 27);
            this.Txt_Corr.TabIndex = 32;
            this.Txt_Corr.TextChanged += new System.EventHandler(this.Txt_Corr_TextChanged);
            // 
            // Lbl_Fecha_Cont
            // 
            this.Lbl_Fecha_Cont.AutoSize = true;
            this.Lbl_Fecha_Cont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Fecha_Cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Cont.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Fecha_Cont.Location = new System.Drawing.Point(45, 540);
            this.Lbl_Fecha_Cont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Cont.Name = "Lbl_Fecha_Cont";
            this.Lbl_Fecha_Cont.Size = new System.Drawing.Size(144, 20);
            this.Lbl_Fecha_Cont.TabIndex = 33;
            this.Lbl_Fecha_Cont.Text = "Fecha Contratación:";
            // 
            // Lbl_Departamento
            // 
            this.Lbl_Departamento.AutoSize = true;
            this.Lbl_Departamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Departamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Departamento.Location = new System.Drawing.Point(45, 594);
            this.Lbl_Departamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Departamento.Name = "Lbl_Departamento";
            this.Lbl_Departamento.Size = new System.Drawing.Size(108, 20);
            this.Lbl_Departamento.TabIndex = 34;
            this.Lbl_Departamento.Text = "Departamento:";
            // 
            // Lbl_Puesto
            // 
            this.Lbl_Puesto.AutoSize = true;
            this.Lbl_Puesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Puesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Puesto.Location = new System.Drawing.Point(564, 540);
            this.Lbl_Puesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Puesto.Name = "Lbl_Puesto";
            this.Lbl_Puesto.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Puesto.TabIndex = 35;
            this.Lbl_Puesto.Text = "Puesto:";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Estado.Location = new System.Drawing.Point(564, 594);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Estado.TabIndex = 36;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Dtp_Fecha_Cont
            // 
            this.Dtp_Fecha_Cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Cont.Location = new System.Drawing.Point(220, 538);
            this.Dtp_Fecha_Cont.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Fecha_Cont.Name = "Dtp_Fecha_Cont";
            this.Dtp_Fecha_Cont.Size = new System.Drawing.Size(225, 27);
            this.Dtp_Fecha_Cont.TabIndex = 37;
            this.Dtp_Fecha_Cont.ValueChanged += new System.EventHandler(this.Dtp_Fecha_Cont_ValueChanged);
            // 
            // Txt_Dep
            // 
            this.Txt_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Dep.Location = new System.Drawing.Point(175, 589);
            this.Txt_Dep.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Dep.Name = "Txt_Dep";
            this.Txt_Dep.Size = new System.Drawing.Size(270, 27);
            this.Txt_Dep.TabIndex = 38;
            this.Txt_Dep.TextChanged += new System.EventHandler(this.Txt_Dep_TextChanged);
            // 
            // Txt_Puesto
            // 
            this.Txt_Puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Puesto.Location = new System.Drawing.Point(666, 540);
            this.Txt_Puesto.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Puesto.Name = "Txt_Puesto";
            this.Txt_Puesto.Size = new System.Drawing.Size(215, 27);
            this.Txt_Puesto.TabIndex = 39;
            this.Txt_Puesto.TextChanged += new System.EventHandler(this.Txt_Puesto_TextChanged);
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Estado.Location = new System.Drawing.Point(666, 591);
            this.Txt_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(215, 27);
            this.Txt_Estado.TabIndex = 40;
            this.Txt_Estado.TextChanged += new System.EventHandler(this.Txt_Estado_TextChanged);
            // 
            // FormMantenimientoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1384, 939);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.Txt_Puesto);
            this.Controls.Add(this.Txt_Dep);
            this.Controls.Add(this.Dtp_Fecha_Cont);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Puesto);
            this.Controls.Add(this.Lbl_Departamento);
            this.Controls.Add(this.Lbl_Fecha_Cont);
            this.Controls.Add(this.Txt_Corr);
            this.Controls.Add(this.Txt_Tel);
            this.Controls.Add(this.Txt_Dir);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_NIT);
            this.Controls.Add(this.Txt_DPI);
            this.Controls.Add(this.Lbl_Corr);
            this.Controls.Add(this.Dtp_Fecha_Nac);
            this.Controls.Add(this.Lbl_Tel);
            this.Controls.Add(this.Lbl_Dir);
            this.Controls.Add(this.Lbl_Fecha_Nac);
            this.Controls.Add(this.Lbl_Apellido);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_NIT);
            this.Controls.Add(this.Txt_Cod);
            this.Controls.Add(this.Lbl_DPI);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Reactivar);
            this.Controls.Add(this.Btn_Bajas);
            this.Controls.Add(this.Btn_Actu);
            this.Controls.Add(this.Lbl_Info_Laboral);
            this.Controls.Add(this.Lbl_Info_Empleados);
            this.Controls.Add(this.Lbl_Sub1);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Datos);
            this.Controls.Add(this.Cbo_Busqueda);
            this.Controls.Add(this.Lbl_Cod_Emp);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.Lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMantenimientoEmpleado";
            this.Text = "G";
            this.Load += new System.EventHandler(this.FormMantenimientoEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.ComboBox Cbo_Busqueda;
        private System.Windows.Forms.TextBox Txt_Datos;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_Sub1;
        private System.Windows.Forms.Label Lbl_Info_Empleados;
        private System.Windows.Forms.Label Lbl_Info_Laboral;
        private System.Windows.Forms.Button Btn_Actu;
        private System.Windows.Forms.Button Btn_Bajas;
        private System.Windows.Forms.Button Btn_Reactivar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Label Lbl_Cod_Emp;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Nac;
        private System.Windows.Forms.TextBox Txt_Cod;
        private System.Windows.Forms.Label Lbl_DPI;
        private System.Windows.Forms.Label Lbl_NIT;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Apellido;
        private System.Windows.Forms.Label Lbl_Fecha_Nac;
        private System.Windows.Forms.Label Lbl_Dir;
        private System.Windows.Forms.Label Lbl_Tel;
        private System.Windows.Forms.Label Lbl_Corr;
        private System.Windows.Forms.TextBox Txt_DPI;
        private System.Windows.Forms.TextBox Txt_NIT;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.TextBox Txt_Dir;
        private System.Windows.Forms.TextBox Txt_Tel;
        private System.Windows.Forms.TextBox Txt_Corr;
        private System.Windows.Forms.Label Lbl_Fecha_Cont;
        private System.Windows.Forms.Label Lbl_Departamento;
        private System.Windows.Forms.Label Lbl_Puesto;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Cont;
        private System.Windows.Forms.TextBox Txt_Dep;
        private System.Windows.Forms.TextBox Txt_Puesto;
        private System.Windows.Forms.TextBox Txt_Estado;
    }
}