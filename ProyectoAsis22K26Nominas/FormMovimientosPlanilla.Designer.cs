
namespace ProyectoAsis22K26Nominas
{
    partial class FormMovimientosPlanilla
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
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Lbl_Periodo = new System.Windows.Forms.Label();
            this.Lbl_Codigo_Empleado = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Campo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Empleado = new System.Windows.Forms.TextBox();
            this.Dpt_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Dpt_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Lbl_Tipo_Movimiento = new System.Windows.Forms.Label();
            this.Cbo_Tipo_Movimiento = new System.Windows.Forms.ComboBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_Monto = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Data_Movimientos = new System.Windows.Forms.DataGridView();
            this.Cbo_Buscar_Campo = new System.Windows.Forms.ComboBox();
            this.Txt_Observacion = new System.Windows.Forms.TextBox();
            this.Lbl_Observacion = new System.Windows.Forms.Label();
            this.Lbl_Id_Empleado = new System.Windows.Forms.Label();
            this.Txt_Id_Empleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Movimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.BackColor = System.Drawing.Color.White;
            this.Lbl_Empleado.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Empleado.Location = new System.Drawing.Point(116, 80);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(122, 16);
            this.Lbl_Empleado.TabIndex = 11;
            this.Lbl_Empleado.Text = "Nombre Empleado";
            // 
            // Lbl_Periodo
            // 
            this.Lbl_Periodo.AutoSize = true;
            this.Lbl_Periodo.BackColor = System.Drawing.Color.White;
            this.Lbl_Periodo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Periodo.Location = new System.Drawing.Point(121, 199);
            this.Lbl_Periodo.Name = "Lbl_Periodo";
            this.Lbl_Periodo.Size = new System.Drawing.Size(89, 16);
            this.Lbl_Periodo.TabIndex = 12;
            this.Lbl_Periodo.Text = "Periodo Inicio";
            this.Lbl_Periodo.Click += new System.EventHandler(this.Lbl_Periodo_Click);
            // 
            // Lbl_Codigo_Empleado
            // 
            this.Lbl_Codigo_Empleado.AutoSize = true;
            this.Lbl_Codigo_Empleado.BackColor = System.Drawing.Color.White;
            this.Lbl_Codigo_Empleado.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Codigo_Empleado.Location = new System.Drawing.Point(12, 43);
            this.Lbl_Codigo_Empleado.Name = "Lbl_Codigo_Empleado";
            this.Lbl_Codigo_Empleado.Size = new System.Drawing.Size(117, 16);
            this.Lbl_Codigo_Empleado.TabIndex = 13;
            this.Lbl_Codigo_Empleado.Text = "Buscar por campo";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(186, 127);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Buscar.TabIndex = 14;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Campo
            // 
            this.Txt_Campo.Location = new System.Drawing.Point(272, 43);
            this.Txt_Campo.Name = "Txt_Campo";
            this.Txt_Campo.Size = new System.Drawing.Size(127, 22);
            this.Txt_Campo.TabIndex = 15;
            // 
            // Txt_Nombre_Empleado
            // 
            this.Txt_Nombre_Empleado.Location = new System.Drawing.Point(272, 80);
            this.Txt_Nombre_Empleado.Name = "Txt_Nombre_Empleado";
            this.Txt_Nombre_Empleado.Size = new System.Drawing.Size(208, 22);
            this.Txt_Nombre_Empleado.TabIndex = 16;
            // 
            // Dpt_Fecha_Inicio
            // 
            this.Dpt_Fecha_Inicio.Location = new System.Drawing.Point(229, 194);
            this.Dpt_Fecha_Inicio.Name = "Dpt_Fecha_Inicio";
            this.Dpt_Fecha_Inicio.Size = new System.Drawing.Size(200, 22);
            this.Dpt_Fecha_Inicio.TabIndex = 17;
            // 
            // Dpt_Fecha_Fin
            // 
            this.Dpt_Fecha_Fin.Location = new System.Drawing.Point(229, 239);
            this.Dpt_Fecha_Fin.Name = "Dpt_Fecha_Fin";
            this.Dpt_Fecha_Fin.Size = new System.Drawing.Size(200, 22);
            this.Dpt_Fecha_Fin.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Periodo Fin";
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Location = new System.Drawing.Point(186, 278);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(127, 36);
            this.Btn_Consultar.TabIndex = 24;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Lbl_Tipo_Movimiento
            // 
            this.Lbl_Tipo_Movimiento.AutoSize = true;
            this.Lbl_Tipo_Movimiento.BackColor = System.Drawing.Color.White;
            this.Lbl_Tipo_Movimiento.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Tipo_Movimiento.Location = new System.Drawing.Point(691, 83);
            this.Lbl_Tipo_Movimiento.Name = "Lbl_Tipo_Movimiento";
            this.Lbl_Tipo_Movimiento.Size = new System.Drawing.Size(126, 16);
            this.Lbl_Tipo_Movimiento.TabIndex = 25;
            this.Lbl_Tipo_Movimiento.Text = "Tipo de Movimiento";
            // 
            // Cbo_Tipo_Movimiento
            // 
            this.Cbo_Tipo_Movimiento.FormattingEnabled = true;
            this.Cbo_Tipo_Movimiento.Location = new System.Drawing.Point(857, 77);
            this.Cbo_Tipo_Movimiento.Name = "Cbo_Tipo_Movimiento";
            this.Cbo_Tipo_Movimiento.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Tipo_Movimiento.TabIndex = 26;
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.BackColor = System.Drawing.Color.White;
            this.Lbl_Descripcion.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(691, 120);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(79, 16);
            this.Lbl_Descripcion.TabIndex = 27;
            this.Lbl_Descripcion.Text = "Descripcion";
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.BackColor = System.Drawing.Color.White;
            this.Lbl_Cantidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Cantidad.Location = new System.Drawing.Point(691, 161);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(61, 16);
            this.Lbl_Cantidad.TabIndex = 28;
            this.Lbl_Cantidad.Text = "Cantidad";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(857, 120);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(127, 22);
            this.Txt_Descripcion.TabIndex = 29;
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.BackColor = System.Drawing.Color.White;
            this.Lbl_Monto.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Monto.Location = new System.Drawing.Point(691, 205);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Monto.TabIndex = 30;
            this.Lbl_Monto.Text = "Monto";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(857, 158);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(127, 22);
            this.Txt_Cantidad.TabIndex = 32;
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Location = new System.Drawing.Point(857, 202);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(127, 22);
            this.Txt_Monto.TabIndex = 33;
            this.Txt_Monto.TextChanged += new System.EventHandler(this.Txt_Monto_TextChanged);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(785, 316);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Guardar.TabIndex = 36;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(889, 381);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Eliminar.TabIndex = 38;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(686, 381);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Modificar.TabIndex = 37;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Data_Movimientos
            // 
            this.Data_Movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Movimientos.Location = new System.Drawing.Point(43, 351);
            this.Data_Movimientos.Name = "Data_Movimientos";
            this.Data_Movimientos.RowHeadersWidth = 51;
            this.Data_Movimientos.RowTemplate.Height = 24;
            this.Data_Movimientos.Size = new System.Drawing.Size(459, 150);
            this.Data_Movimientos.TabIndex = 39;
            this.Data_Movimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Movimientos_CellClick);
            // 
            // Cbo_Buscar_Campo
            // 
            this.Cbo_Buscar_Campo.ForeColor = System.Drawing.Color.Black;
            this.Cbo_Buscar_Campo.FormattingEnabled = true;
            this.Cbo_Buscar_Campo.Location = new System.Drawing.Point(135, 43);
            this.Cbo_Buscar_Campo.Name = "Cbo_Buscar_Campo";
            this.Cbo_Buscar_Campo.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Buscar_Campo.TabIndex = 40;
            // 
            // Txt_Observacion
            // 
            this.Txt_Observacion.Location = new System.Drawing.Point(857, 244);
            this.Txt_Observacion.Name = "Txt_Observacion";
            this.Txt_Observacion.Size = new System.Drawing.Size(127, 22);
            this.Txt_Observacion.TabIndex = 34;
            // 
            // Lbl_Observacion
            // 
            this.Lbl_Observacion.AutoSize = true;
            this.Lbl_Observacion.BackColor = System.Drawing.Color.White;
            this.Lbl_Observacion.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Observacion.Location = new System.Drawing.Point(691, 250);
            this.Lbl_Observacion.Name = "Lbl_Observacion";
            this.Lbl_Observacion.Size = new System.Drawing.Size(84, 16);
            this.Lbl_Observacion.TabIndex = 31;
            this.Lbl_Observacion.Text = "Observacion";
            // 
            // Lbl_Id_Empleado
            // 
            this.Lbl_Id_Empleado.AutoSize = true;
            this.Lbl_Id_Empleado.BackColor = System.Drawing.Color.White;
            this.Lbl_Id_Empleado.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Id_Empleado.Location = new System.Drawing.Point(691, 37);
            this.Lbl_Id_Empleado.Name = "Lbl_Id_Empleado";
            this.Lbl_Id_Empleado.Size = new System.Drawing.Size(86, 16);
            this.Lbl_Id_Empleado.TabIndex = 41;
            this.Lbl_Id_Empleado.Text = "ID Empleado";
            // 
            // Txt_Id_Empleado
            // 
            this.Txt_Id_Empleado.Location = new System.Drawing.Point(857, 37);
            this.Txt_Id_Empleado.Name = "Txt_Id_Empleado";
            this.Txt_Id_Empleado.Size = new System.Drawing.Size(208, 22);
            this.Txt_Id_Empleado.TabIndex = 42;
            // 
            // FormMovimientosPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1090, 532);
            this.Controls.Add(this.Txt_Id_Empleado);
            this.Controls.Add(this.Lbl_Id_Empleado);
            this.Controls.Add(this.Cbo_Buscar_Campo);
            this.Controls.Add(this.Data_Movimientos);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Txt_Observacion);
            this.Controls.Add(this.Txt_Monto);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.Lbl_Observacion);
            this.Controls.Add(this.Lbl_Monto);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Lbl_Cantidad);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Cbo_Tipo_Movimiento);
            this.Controls.Add(this.Lbl_Tipo_Movimiento);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.Dpt_Fecha_Fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dpt_Fecha_Inicio);
            this.Controls.Add(this.Txt_Nombre_Empleado);
            this.Controls.Add(this.Txt_Campo);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Codigo_Empleado);
            this.Controls.Add(this.Lbl_Periodo);
            this.Controls.Add(this.Lbl_Empleado);
            this.Name = "FormMovimientosPlanilla";
            this.Text = "FormMovimientosPlanilla";
            this.Load += new System.EventHandler(this.FormMovimientosPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Movimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.Label Lbl_Periodo;
        private System.Windows.Forms.Label Lbl_Codigo_Empleado;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Campo;
        private System.Windows.Forms.TextBox Txt_Nombre_Empleado;
        private System.Windows.Forms.DateTimePicker Dpt_Fecha_Inicio;
        private System.Windows.Forms.DateTimePicker Dpt_Fecha_Fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Label Lbl_Tipo_Movimiento;
        private System.Windows.Forms.ComboBox Cbo_Tipo_Movimiento;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.DataGridView Data_Movimientos;
        private System.Windows.Forms.ComboBox Cbo_Buscar_Campo;
        private System.Windows.Forms.TextBox Txt_Observacion;
        private System.Windows.Forms.Label Lbl_Observacion;
        private System.Windows.Forms.Label Lbl_Id_Empleado;
        private System.Windows.Forms.TextBox Txt_Id_Empleado;
    }
}