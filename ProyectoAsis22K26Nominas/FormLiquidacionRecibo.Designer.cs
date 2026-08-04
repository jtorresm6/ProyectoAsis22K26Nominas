namespace ProyectoAsis22K26Nominas
{
    partial class FormLiquidacionRecibo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txt_Empleado = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Dgv_Liquidacion_Recibo = new System.Windows.Forms.DataGridView();
            this.cmp_id_liquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_fecha_calculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_fecha_retiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_motivo_retiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_salario_pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_indemnizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_vacaciones_pendientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_aguinaldo_pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_bono_14_pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_otros_ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_total_descuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_total_liquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_numero_recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Liquidacion_Recibo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Empleado
            // 
            this.Txt_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Empleado.Location = new System.Drawing.Point(282, 175);
            this.Txt_Empleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Empleado.Name = "Txt_Empleado";
            this.Txt_Empleado.Size = new System.Drawing.Size(220, 28);
            this.Txt_Empleado.TabIndex = 7;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Btn_Buscar.FlatAppearance.BorderSize = 3;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Buscar.Location = new System.Drawing.Point(551, 171);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(113, 40);
            this.Btn_Buscar.TabIndex = 6;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Empleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Empleado.Location = new System.Drawing.Point(38, 178);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(215, 23);
            this.Lbl_Empleado.TabIndex = 5;
            this.Lbl_Empleado.Text = "Ingrese el ID del Empleado";
            // 
            // Dgv_Liquidacion_Recibo
            // 
            this.Dgv_Liquidacion_Recibo.AllowUserToAddRows = false;
            this.Dgv_Liquidacion_Recibo.AllowUserToDeleteRows = false;
            this.Dgv_Liquidacion_Recibo.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.Dgv_Liquidacion_Recibo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Liquidacion_Recibo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Liquidacion_Recibo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Liquidacion_Recibo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.Dgv_Liquidacion_Recibo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Liquidacion_Recibo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Liquidacion_Recibo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Liquidacion_Recibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Liquidacion_Recibo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmp_id_liquidacion,
            this.cmp_fecha_calculo,
            this.cmp_fecha_retiro,
            this.cmp_motivo_retiro,
            this.cmp_salario_pendiente,
            this.cmp_indemnizacion,
            this.cmp_vacaciones_pendientes,
            this.cmp_aguinaldo_pendiente,
            this.cmp_bono_14_pendiente,
            this.cmp_otros_ingresos,
            this.cmp_total_descuentos,
            this.cmp_total_liquidacion,
            this.cmp_numero_recibo,
            this.cmp_fecha_pago,
            this.cmp_estado,
            this.cmp_observaciones});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Liquidacion_Recibo.DefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_Liquidacion_Recibo.EnableHeadersVisualStyles = false;
            this.Dgv_Liquidacion_Recibo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Dgv_Liquidacion_Recibo.Location = new System.Drawing.Point(24, 266);
            this.Dgv_Liquidacion_Recibo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Liquidacion_Recibo.MultiSelect = false;
            this.Dgv_Liquidacion_Recibo.Name = "Dgv_Liquidacion_Recibo";
            this.Dgv_Liquidacion_Recibo.ReadOnly = true;
            this.Dgv_Liquidacion_Recibo.RowHeadersVisible = false;
            this.Dgv_Liquidacion_Recibo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.Dgv_Liquidacion_Recibo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Dgv_Liquidacion_Recibo.RowTemplate.Height = 38;
            this.Dgv_Liquidacion_Recibo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Liquidacion_Recibo.Size = new System.Drawing.Size(965, 383);
            this.Dgv_Liquidacion_Recibo.TabIndex = 8;
            this.Dgv_Liquidacion_Recibo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Liquidacion_Recibo_CellContentClick);
            // 
            // cmp_id_liquidacion
            // 
            this.cmp_id_liquidacion.DataPropertyName = "cmp_id_liquidacion";
            this.cmp_id_liquidacion.HeaderText = "ID Liquidacion";
            this.cmp_id_liquidacion.MinimumWidth = 8;
            this.cmp_id_liquidacion.Name = "cmp_id_liquidacion";
            this.cmp_id_liquidacion.ReadOnly = true;
            // 
            // cmp_fecha_calculo
            // 
            this.cmp_fecha_calculo.DataPropertyName = "cmp_fecha_calculo";
            this.cmp_fecha_calculo.HeaderText = "Fecha de Calculo";
            this.cmp_fecha_calculo.MinimumWidth = 8;
            this.cmp_fecha_calculo.Name = "cmp_fecha_calculo";
            this.cmp_fecha_calculo.ReadOnly = true;
            // 
            // cmp_fecha_retiro
            // 
            this.cmp_fecha_retiro.DataPropertyName = "cmp_fecha_retiro";
            this.cmp_fecha_retiro.HeaderText = "Fecha de Retiro";
            this.cmp_fecha_retiro.MinimumWidth = 8;
            this.cmp_fecha_retiro.Name = "cmp_fecha_retiro";
            this.cmp_fecha_retiro.ReadOnly = true;
            // 
            // cmp_motivo_retiro
            // 
            this.cmp_motivo_retiro.DataPropertyName = "cmp_motivo_retiro";
            this.cmp_motivo_retiro.HeaderText = "Motivo de Retiro";
            this.cmp_motivo_retiro.MinimumWidth = 8;
            this.cmp_motivo_retiro.Name = "cmp_motivo_retiro";
            this.cmp_motivo_retiro.ReadOnly = true;
            // 
            // cmp_salario_pendiente
            // 
            this.cmp_salario_pendiente.DataPropertyName = "cmp_salario_pendiente";
            this.cmp_salario_pendiente.HeaderText = "Salario Pendiente";
            this.cmp_salario_pendiente.MinimumWidth = 8;
            this.cmp_salario_pendiente.Name = "cmp_salario_pendiente";
            this.cmp_salario_pendiente.ReadOnly = true;
            // 
            // cmp_indemnizacion
            // 
            this.cmp_indemnizacion.DataPropertyName = "cmp_indemnizacion";
            this.cmp_indemnizacion.HeaderText = "Indemnizacion";
            this.cmp_indemnizacion.MinimumWidth = 8;
            this.cmp_indemnizacion.Name = "cmp_indemnizacion";
            this.cmp_indemnizacion.ReadOnly = true;
            // 
            // cmp_vacaciones_pendientes
            // 
            this.cmp_vacaciones_pendientes.DataPropertyName = "cmp_vacaciones_pendientes";
            this.cmp_vacaciones_pendientes.HeaderText = "Vacaciones Pendientes";
            this.cmp_vacaciones_pendientes.MinimumWidth = 8;
            this.cmp_vacaciones_pendientes.Name = "cmp_vacaciones_pendientes";
            this.cmp_vacaciones_pendientes.ReadOnly = true;
            // 
            // cmp_aguinaldo_pendiente
            // 
            this.cmp_aguinaldo_pendiente.DataPropertyName = "cmp_aguinaldo_pendiente";
            this.cmp_aguinaldo_pendiente.HeaderText = "Aguinaldo Pendiente";
            this.cmp_aguinaldo_pendiente.MinimumWidth = 8;
            this.cmp_aguinaldo_pendiente.Name = "cmp_aguinaldo_pendiente";
            this.cmp_aguinaldo_pendiente.ReadOnly = true;
            // 
            // cmp_bono_14_pendiente
            // 
            this.cmp_bono_14_pendiente.DataPropertyName = "cmp_bono_14_pendiente";
            this.cmp_bono_14_pendiente.HeaderText = "Bono 14 Pendiente";
            this.cmp_bono_14_pendiente.MinimumWidth = 8;
            this.cmp_bono_14_pendiente.Name = "cmp_bono_14_pendiente";
            this.cmp_bono_14_pendiente.ReadOnly = true;
            // 
            // cmp_otros_ingresos
            // 
            this.cmp_otros_ingresos.DataPropertyName = "cmp_otros_ingresos";
            this.cmp_otros_ingresos.HeaderText = "Otros Ingresos";
            this.cmp_otros_ingresos.MinimumWidth = 8;
            this.cmp_otros_ingresos.Name = "cmp_otros_ingresos";
            this.cmp_otros_ingresos.ReadOnly = true;
            // 
            // cmp_total_descuentos
            // 
            this.cmp_total_descuentos.DataPropertyName = "cmp_total_descuentos";
            this.cmp_total_descuentos.HeaderText = "Total Descuentos";
            this.cmp_total_descuentos.MinimumWidth = 8;
            this.cmp_total_descuentos.Name = "cmp_total_descuentos";
            this.cmp_total_descuentos.ReadOnly = true;
            // 
            // cmp_total_liquidacion
            // 
            this.cmp_total_liquidacion.DataPropertyName = "cmp_total_liquidacion";
            this.cmp_total_liquidacion.HeaderText = "Total Liquidacion";
            this.cmp_total_liquidacion.MinimumWidth = 8;
            this.cmp_total_liquidacion.Name = "cmp_total_liquidacion";
            this.cmp_total_liquidacion.ReadOnly = true;
            // 
            // cmp_numero_recibo
            // 
            this.cmp_numero_recibo.DataPropertyName = "cmp_numero_recibo";
            this.cmp_numero_recibo.HeaderText = "No. Recibo";
            this.cmp_numero_recibo.MinimumWidth = 8;
            this.cmp_numero_recibo.Name = "cmp_numero_recibo";
            this.cmp_numero_recibo.ReadOnly = true;
            // 
            // cmp_fecha_pago
            // 
            this.cmp_fecha_pago.DataPropertyName = "cmp_fecha_pago";
            this.cmp_fecha_pago.HeaderText = "Fecha de Pago";
            this.cmp_fecha_pago.MinimumWidth = 8;
            this.cmp_fecha_pago.Name = "cmp_fecha_pago";
            this.cmp_fecha_pago.ReadOnly = true;
            // 
            // cmp_estado
            // 
            this.cmp_estado.DataPropertyName = "cmp_estado";
            this.cmp_estado.HeaderText = "Estado";
            this.cmp_estado.MinimumWidth = 8;
            this.cmp_estado.Name = "cmp_estado";
            this.cmp_estado.ReadOnly = true;
            // 
            // cmp_observaciones
            // 
            this.cmp_observaciones.DataPropertyName = "cmp_observaciones";
            this.cmp_observaciones.HeaderText = "Observaciones";
            this.cmp_observaciones.MinimumWidth = 8;
            this.cmp_observaciones.Name = "cmp_observaciones";
            this.cmp_observaciones.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 100);
            this.panel1.TabIndex = 79;
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
            this.label5.Size = new System.Drawing.Size(396, 54);
            this.label5.TabIndex = 75;
            this.label5.Text = "Liquidación y Pagos";
            // 
            // FormLiquidacionRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1015, 895);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_Liquidacion_Recibo);
            this.Controls.Add(this.Txt_Empleado);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Empleado);
            this.Name = "FormLiquidacionRecibo";
            this.Text = "FormLiquidacionRecibo";
            this.Load += new System.EventHandler(this.FormLiquidacionRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Liquidacion_Recibo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Empleado;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.DataGridView Dgv_Liquidacion_Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_id_liquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_fecha_calculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_fecha_retiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_motivo_retiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_salario_pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_indemnizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_vacaciones_pendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_aguinaldo_pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_bono_14_pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_otros_ingresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_total_descuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_total_liquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_numero_recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_observaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}