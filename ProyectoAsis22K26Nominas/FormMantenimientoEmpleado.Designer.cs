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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantenimientoEmpleado));
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Cbo_Busqueda = new System.Windows.Forms.ComboBox();
            this.Txt_Datos = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
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
            this.Pnl_Personal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_Emple = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Laboral = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pnl_Personal.SuspendLayout();
            this.Pnl_Emple.SuspendLayout();
            this.Pnl_Laboral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Buscar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Buscar.Location = new System.Drawing.Point(60, 59);
            this.Lbl_Buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(97, 26);
            this.Lbl_Buscar.TabIndex = 1;
            this.Lbl_Buscar.Text = "Buscar por:";
            // 
            // Cbo_Busqueda
            // 
            this.Cbo_Busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Cbo_Busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Busqueda.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Busqueda.FormattingEnabled = true;
            this.Cbo_Busqueda.Items.AddRange(new object[] {
            "Codigo",
            "DPI",
            "NIT"});
            this.Cbo_Busqueda.Location = new System.Drawing.Point(165, 52);
            this.Cbo_Busqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_Busqueda.Name = "Cbo_Busqueda";
            this.Cbo_Busqueda.Size = new System.Drawing.Size(162, 34);
            this.Cbo_Busqueda.TabIndex = 2;
            // 
            // Txt_Datos
            // 
            this.Txt_Datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Datos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Datos.ForeColor = System.Drawing.Color.White;
            this.Txt_Datos.Location = new System.Drawing.Point(349, 55);
            this.Txt_Datos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Datos.Name = "Txt_Datos";
            this.Txt_Datos.Size = new System.Drawing.Size(241, 30);
            this.Txt_Datos.TabIndex = 3;
            this.Txt_Datos.TextChanged += new System.EventHandler(this.Txt_Datos_TextChanged);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(616, 52);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(117, 32);
            this.Btn_Buscar.TabIndex = 4;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Actu
            // 
            this.Btn_Actu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Actu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Actu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actu.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actu.ForeColor = System.Drawing.Color.White;
            this.Btn_Actu.Location = new System.Drawing.Point(141, 827);
            this.Btn_Actu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Actu.Name = "Btn_Actu";
            this.Btn_Actu.Size = new System.Drawing.Size(140, 42);
            this.Btn_Actu.TabIndex = 10;
            this.Btn_Actu.Text = "Actualizar";
            this.Btn_Actu.UseVisualStyleBackColor = false;
            this.Btn_Actu.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Bajas
            // 
            this.Btn_Bajas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Bajas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Btn_Bajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Bajas.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Bajas.ForeColor = System.Drawing.Color.White;
            this.Btn_Bajas.Location = new System.Drawing.Point(745, 50);
            this.Btn_Bajas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Bajas.Name = "Btn_Bajas";
            this.Btn_Bajas.Size = new System.Drawing.Size(113, 40);
            this.Btn_Bajas.TabIndex = 11;
            this.Btn_Bajas.Text = "Dar de Baja";
            this.Btn_Bajas.UseVisualStyleBackColor = false;
            this.Btn_Bajas.Click += new System.EventHandler(this.Btn_Bajas_Click);
            // 
            // Btn_Reactivar
            // 
            this.Btn_Reactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Reactivar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(100)))));
            this.Btn_Reactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reactivar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reactivar.Location = new System.Drawing.Point(745, 111);
            this.Btn_Reactivar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Reactivar.Name = "Btn_Reactivar";
            this.Btn_Reactivar.Size = new System.Drawing.Size(113, 40);
            this.Btn_Reactivar.TabIndex = 12;
            this.Btn_Reactivar.Text = "Reactivar";
            this.Btn_Reactivar.UseVisualStyleBackColor = false;
            this.Btn_Reactivar.Click += new System.EventHandler(this.Btn_reactivar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Location = new System.Drawing.Point(317, 827);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(140, 42);
            this.Btn_Limpiar.TabIndex = 13;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Lbl_Cod_Emp
            // 
            this.Lbl_Cod_Emp.AutoSize = true;
            this.Lbl_Cod_Emp.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cod_Emp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Cod_Emp.Location = new System.Drawing.Point(8, 62);
            this.Lbl_Cod_Emp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cod_Emp.Name = "Lbl_Cod_Emp";
            this.Lbl_Cod_Emp.Size = new System.Drawing.Size(174, 26);
            this.Lbl_Cod_Emp.TabIndex = 2;
            this.Lbl_Cod_Emp.Text = "Código de Empleado:";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Guardar.Location = new System.Drawing.Point(502, 827);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(183, 42);
            this.Btn_Guardar.TabIndex = 16;
            this.Btn_Guardar.Text = "Guardar Cambios";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancelar.Location = new System.Drawing.Point(721, 827);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(140, 42);
            this.Btn_Cancelar.TabIndex = 17;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Cod.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cod.ForeColor = System.Drawing.Color.White;
            this.Txt_Cod.Location = new System.Drawing.Point(12, 97);
            this.Txt_Cod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(188, 30);
            this.Txt_Cod.TabIndex = 10;
            this.Txt_Cod.TextChanged += new System.EventHandler(this.Txt_Cod_TextChanged);
            // 
            // Dtp_Fecha_Nac
            // 
            this.Dtp_Fecha_Nac.CustomFormat = "dd/MM/yyyy";
            this.Dtp_Fecha_Nac.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Nac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Fecha_Nac.Location = new System.Drawing.Point(349, 279);
            this.Dtp_Fecha_Nac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dtp_Fecha_Nac.Name = "Dtp_Fecha_Nac";
            this.Dtp_Fecha_Nac.Size = new System.Drawing.Size(222, 30);
            this.Dtp_Fecha_Nac.TabIndex = 12;
            this.Dtp_Fecha_Nac.ValueChanged += new System.EventHandler(this.Dtp_Fecha_Nac_ValueChanged);
            // 
            // Lbl_DPI
            // 
            this.Lbl_DPI.AutoSize = true;
            this.Lbl_DPI.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DPI.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_DPI.Location = new System.Drawing.Point(8, 154);
            this.Lbl_DPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DPI.Name = "Lbl_DPI";
            this.Lbl_DPI.Size = new System.Drawing.Size(39, 26);
            this.Lbl_DPI.TabIndex = 18;
            this.Lbl_DPI.Text = "DPI:";
            // 
            // Lbl_NIT
            // 
            this.Lbl_NIT.AutoSize = true;
            this.Lbl_NIT.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NIT.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_NIT.Location = new System.Drawing.Point(8, 244);
            this.Lbl_NIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NIT.Name = "Lbl_NIT";
            this.Lbl_NIT.Size = new System.Drawing.Size(38, 26);
            this.Lbl_NIT.TabIndex = 19;
            this.Lbl_NIT.Text = "NIT:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Nombre.Location = new System.Drawing.Point(345, 62);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(84, 26);
            this.Lbl_Nombre.TabIndex = 20;
            this.Lbl_Nombre.Text = "Nombres:";
            // 
            // Lbl_Apellido
            // 
            this.Lbl_Apellido.AutoSize = true;
            this.Lbl_Apellido.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Apellido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Apellido.Location = new System.Drawing.Point(345, 154);
            this.Lbl_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Apellido.Name = "Lbl_Apellido";
            this.Lbl_Apellido.Size = new System.Drawing.Size(84, 26);
            this.Lbl_Apellido.TabIndex = 21;
            this.Lbl_Apellido.Text = "Apellidos:";
            // 
            // Lbl_Fecha_Nac
            // 
            this.Lbl_Fecha_Nac.AutoSize = true;
            this.Lbl_Fecha_Nac.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Nac.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Fecha_Nac.Location = new System.Drawing.Point(345, 244);
            this.Lbl_Fecha_Nac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Nac.Name = "Lbl_Fecha_Nac";
            this.Lbl_Fecha_Nac.Size = new System.Drawing.Size(175, 26);
            this.Lbl_Fecha_Nac.TabIndex = 22;
            this.Lbl_Fecha_Nac.Text = "Fecha de Nacimiento:";
            // 
            // Lbl_Dir
            // 
            this.Lbl_Dir.AutoSize = true;
            this.Lbl_Dir.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Dir.Location = new System.Drawing.Point(612, 62);
            this.Lbl_Dir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Dir.Name = "Lbl_Dir";
            this.Lbl_Dir.Size = new System.Drawing.Size(87, 26);
            this.Lbl_Dir.TabIndex = 23;
            this.Lbl_Dir.Text = "Dirección:";
            // 
            // Lbl_Tel
            // 
            this.Lbl_Tel.AutoSize = true;
            this.Lbl_Tel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Tel.Location = new System.Drawing.Point(612, 154);
            this.Lbl_Tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Tel.Name = "Lbl_Tel";
            this.Lbl_Tel.Size = new System.Drawing.Size(88, 26);
            this.Lbl_Tel.TabIndex = 24;
            this.Lbl_Tel.Text = "Teléfonos:";
            // 
            // Lbl_Corr
            // 
            this.Lbl_Corr.AutoSize = true;
            this.Lbl_Corr.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Corr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Corr.Location = new System.Drawing.Point(612, 244);
            this.Lbl_Corr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Corr.Name = "Lbl_Corr";
            this.Lbl_Corr.Size = new System.Drawing.Size(76, 26);
            this.Lbl_Corr.TabIndex = 25;
            this.Lbl_Corr.Text = "Correos:";
            // 
            // Txt_DPI
            // 
            this.Txt_DPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_DPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_DPI.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DPI.ForeColor = System.Drawing.Color.White;
            this.Txt_DPI.Location = new System.Drawing.Point(12, 186);
            this.Txt_DPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_DPI.Name = "Txt_DPI";
            this.Txt_DPI.Size = new System.Drawing.Size(292, 30);
            this.Txt_DPI.TabIndex = 26;
            this.Txt_DPI.TextChanged += new System.EventHandler(this.Txt_DPI_TextChanged);
            // 
            // Txt_NIT
            // 
            this.Txt_NIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_NIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_NIT.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NIT.ForeColor = System.Drawing.Color.White;
            this.Txt_NIT.Location = new System.Drawing.Point(12, 280);
            this.Txt_NIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_NIT.Name = "Txt_NIT";
            this.Txt_NIT.Size = new System.Drawing.Size(292, 30);
            this.Txt_NIT.TabIndex = 27;
            this.Txt_NIT.TextChanged += new System.EventHandler(this.Txt_NIT_TextChanged);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Nombre.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.Txt_Nombre.Location = new System.Drawing.Point(349, 97);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(222, 30);
            this.Txt_Nombre.TabIndex = 28;
            this.Txt_Nombre.TextChanged += new System.EventHandler(this.Txt_Nombre_TextChanged);
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Apellido.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.ForeColor = System.Drawing.Color.White;
            this.Txt_Apellido.Location = new System.Drawing.Point(349, 186);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(222, 30);
            this.Txt_Apellido.TabIndex = 29;
            this.Txt_Apellido.TextChanged += new System.EventHandler(this.Txt_Apellido_TextChanged);
            // 
            // Txt_Dir
            // 
            this.Txt_Dir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Dir.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Dir.ForeColor = System.Drawing.Color.White;
            this.Txt_Dir.Location = new System.Drawing.Point(616, 97);
            this.Txt_Dir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Dir.Name = "Txt_Dir";
            this.Txt_Dir.Size = new System.Drawing.Size(296, 30);
            this.Txt_Dir.TabIndex = 30;
            this.Txt_Dir.TextChanged += new System.EventHandler(this.Txt_Dir_TextChanged);
            // 
            // Txt_Tel
            // 
            this.Txt_Tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Tel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Tel.ForeColor = System.Drawing.Color.White;
            this.Txt_Tel.Location = new System.Drawing.Point(616, 186);
            this.Txt_Tel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.Size = new System.Drawing.Size(194, 30);
            this.Txt_Tel.TabIndex = 31;
            this.Txt_Tel.TextChanged += new System.EventHandler(this.Txt_Tel_TextChanged);
            // 
            // Txt_Corr
            // 
            this.Txt_Corr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Corr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Corr.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Corr.ForeColor = System.Drawing.Color.White;
            this.Txt_Corr.Location = new System.Drawing.Point(616, 276);
            this.Txt_Corr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Corr.Name = "Txt_Corr";
            this.Txt_Corr.Size = new System.Drawing.Size(296, 30);
            this.Txt_Corr.TabIndex = 32;
            this.Txt_Corr.TextChanged += new System.EventHandler(this.Txt_Corr_TextChanged);
            // 
            // Lbl_Fecha_Cont
            // 
            this.Lbl_Fecha_Cont.AutoSize = true;
            this.Lbl_Fecha_Cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Fecha_Cont.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Cont.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Fecha_Cont.Location = new System.Drawing.Point(15, 62);
            this.Lbl_Fecha_Cont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Cont.Name = "Lbl_Fecha_Cont";
            this.Lbl_Fecha_Cont.Size = new System.Drawing.Size(166, 26);
            this.Lbl_Fecha_Cont.TabIndex = 33;
            this.Lbl_Fecha_Cont.Text = "Fecha Contratación:";
            // 
            // Lbl_Departamento
            // 
            this.Lbl_Departamento.AutoSize = true;
            this.Lbl_Departamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Departamento.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Departamento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Departamento.Location = new System.Drawing.Point(15, 124);
            this.Lbl_Departamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Departamento.Name = "Lbl_Departamento";
            this.Lbl_Departamento.Size = new System.Drawing.Size(125, 26);
            this.Lbl_Departamento.TabIndex = 34;
            this.Lbl_Departamento.Text = "Departamento:";
            // 
            // Lbl_Puesto
            // 
            this.Lbl_Puesto.AutoSize = true;
            this.Lbl_Puesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Puesto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Puesto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Puesto.Location = new System.Drawing.Point(419, 67);
            this.Lbl_Puesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Puesto.Name = "Lbl_Puesto";
            this.Lbl_Puesto.Size = new System.Drawing.Size(66, 26);
            this.Lbl_Puesto.TabIndex = 35;
            this.Lbl_Puesto.Text = "Puesto:";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Lbl_Estado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Estado.Location = new System.Drawing.Point(419, 124);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(66, 26);
            this.Lbl_Estado.TabIndex = 36;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Dtp_Fecha_Cont
            // 
            this.Dtp_Fecha_Cont.CustomFormat = "dd/MM/yyyy";
            this.Dtp_Fecha_Cont.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Cont.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Fecha_Cont.Location = new System.Drawing.Point(189, 61);
            this.Dtp_Fecha_Cont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dtp_Fecha_Cont.Name = "Dtp_Fecha_Cont";
            this.Dtp_Fecha_Cont.Size = new System.Drawing.Size(202, 30);
            this.Dtp_Fecha_Cont.TabIndex = 37;
            this.Dtp_Fecha_Cont.ValueChanged += new System.EventHandler(this.Dtp_Fecha_Cont_ValueChanged);
            // 
            // Txt_Dep
            // 
            this.Txt_Dep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Dep.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Dep.ForeColor = System.Drawing.Color.White;
            this.Txt_Dep.Location = new System.Drawing.Point(148, 119);
            this.Txt_Dep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Dep.Name = "Txt_Dep";
            this.Txt_Dep.Size = new System.Drawing.Size(243, 30);
            this.Txt_Dep.TabIndex = 38;
            this.Txt_Dep.TextChanged += new System.EventHandler(this.Txt_Dep_TextChanged);
            // 
            // Txt_Puesto
            // 
            this.Txt_Puesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Puesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Puesto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Puesto.ForeColor = System.Drawing.Color.White;
            this.Txt_Puesto.Location = new System.Drawing.Point(493, 58);
            this.Txt_Puesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Puesto.Name = "Txt_Puesto";
            this.Txt_Puesto.Size = new System.Drawing.Size(194, 30);
            this.Txt_Puesto.TabIndex = 39;
            this.Txt_Puesto.TextChanged += new System.EventHandler(this.Txt_Puesto_TextChanged);
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.Txt_Estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Estado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Estado.ForeColor = System.Drawing.Color.White;
            this.Txt_Estado.Location = new System.Drawing.Point(493, 119);
            this.Txt_Estado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(194, 30);
            this.Txt_Estado.TabIndex = 40;
            this.Txt_Estado.TextChanged += new System.EventHandler(this.Txt_Estado_TextChanged);
            // 
            // Pnl_Personal
            // 
            this.Pnl_Personal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Personal.Controls.Add(this.label2);
            this.Pnl_Personal.Controls.Add(this.Lbl_Buscar);
            this.Pnl_Personal.Controls.Add(this.Cbo_Busqueda);
            this.Pnl_Personal.Controls.Add(this.Txt_Datos);
            this.Pnl_Personal.Controls.Add(this.Btn_Buscar);
            this.Pnl_Personal.Location = new System.Drawing.Point(42, 134);
            this.Pnl_Personal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Personal.Name = "Pnl_Personal";
            this.Pnl_Personal.Size = new System.Drawing.Size(939, 116);
            this.Pnl_Personal.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 26);
            this.label2.TabIndex = 71;
            this.label2.Text = "Búsqueda de Empleados";
            // 
            // Pnl_Emple
            // 
            this.Pnl_Emple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Emple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Emple.Controls.Add(this.label1);
            this.Pnl_Emple.Controls.Add(this.Txt_Cod);
            this.Pnl_Emple.Controls.Add(this.Lbl_Cod_Emp);
            this.Pnl_Emple.Controls.Add(this.Txt_DPI);
            this.Pnl_Emple.Controls.Add(this.Lbl_DPI);
            this.Pnl_Emple.Controls.Add(this.Lbl_NIT);
            this.Pnl_Emple.Controls.Add(this.Txt_NIT);
            this.Pnl_Emple.Controls.Add(this.Lbl_Nombre);
            this.Pnl_Emple.Controls.Add(this.Txt_Apellido);
            this.Pnl_Emple.Controls.Add(this.Txt_Corr);
            this.Pnl_Emple.Controls.Add(this.Lbl_Apellido);
            this.Pnl_Emple.Controls.Add(this.Lbl_Corr);
            this.Pnl_Emple.Controls.Add(this.Txt_Tel);
            this.Pnl_Emple.Controls.Add(this.Lbl_Fecha_Nac);
            this.Pnl_Emple.Controls.Add(this.Txt_Dir);
            this.Pnl_Emple.Controls.Add(this.Lbl_Tel);
            this.Pnl_Emple.Controls.Add(this.Dtp_Fecha_Nac);
            this.Pnl_Emple.Controls.Add(this.Txt_Nombre);
            this.Pnl_Emple.Controls.Add(this.Lbl_Dir);
            this.Pnl_Emple.Location = new System.Drawing.Point(42, 269);
            this.Pnl_Emple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Emple.Name = "Pnl_Emple";
            this.Pnl_Emple.Size = new System.Drawing.Size(939, 334);
            this.Pnl_Emple.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 72;
            this.label1.Text = "Información de Empleados";
            // 
            // Pnl_Laboral
            // 
            this.Pnl_Laboral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.Pnl_Laboral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Laboral.Controls.Add(this.label3);
            this.Pnl_Laboral.Controls.Add(this.Txt_Dep);
            this.Pnl_Laboral.Controls.Add(this.Txt_Estado);
            this.Pnl_Laboral.Controls.Add(this.Lbl_Fecha_Cont);
            this.Pnl_Laboral.Controls.Add(this.Txt_Puesto);
            this.Pnl_Laboral.Controls.Add(this.Dtp_Fecha_Cont);
            this.Pnl_Laboral.Controls.Add(this.Btn_Bajas);
            this.Pnl_Laboral.Controls.Add(this.Lbl_Estado);
            this.Pnl_Laboral.Controls.Add(this.Btn_Reactivar);
            this.Pnl_Laboral.Controls.Add(this.Lbl_Puesto);
            this.Pnl_Laboral.Controls.Add(this.Lbl_Departamento);
            this.Pnl_Laboral.Location = new System.Drawing.Point(42, 624);
            this.Pnl_Laboral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_Laboral.Name = "Pnl_Laboral";
            this.Pnl_Laboral.Size = new System.Drawing.Size(939, 176);
            this.Pnl_Laboral.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(18, 11);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 73;
            this.label3.Text = "Informacion Laboral";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 100);
            this.panel1.TabIndex = 85;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(121, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(576, 26);
            this.label6.TabIndex = 72;
            this.label6.Text = "Modifique y actualice la información registrada de los empleados.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(116, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(530, 54);
            this.label5.TabIndex = 75;
            this.label5.Text = "Mantenimiento Empleados";
            // 
            // FormMantenimientoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1015, 895);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Actu);
            this.Controls.Add(this.Pnl_Personal);
            this.Controls.Add(this.Pnl_Emple);
            this.Controls.Add(this.Pnl_Laboral);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMantenimientoEmpleado";
            this.Text = "G";
            this.Load += new System.EventHandler(this.FormMantenimientoEmpleado_Load);
            this.Pnl_Personal.ResumeLayout(false);
            this.Pnl_Personal.PerformLayout();
            this.Pnl_Emple.ResumeLayout(false);
            this.Pnl_Emple.PerformLayout();
            this.Pnl_Laboral.ResumeLayout(false);
            this.Pnl_Laboral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.ComboBox Cbo_Busqueda;
        private System.Windows.Forms.TextBox Txt_Datos;
        private System.Windows.Forms.Button Btn_Buscar;
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
        private System.Windows.Forms.Panel Pnl_Personal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Pnl_Emple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_Laboral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}