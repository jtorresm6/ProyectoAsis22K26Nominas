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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Liquidacion_Recibo)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Empleado
            // 
            this.Txt_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Empleado.Location = new System.Drawing.Point(318, 52);
            this.Txt_Empleado.Name = "Txt_Empleado";
            this.Txt_Empleado.Size = new System.Drawing.Size(168, 32);
            this.Txt_Empleado.TabIndex = 7;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Btn_Buscar.FlatAppearance.BorderSize = 3;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Buscar.Location = new System.Drawing.Point(547, 45);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(127, 50);
            this.Btn_Buscar.TabIndex = 6;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Empleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Empleado.Location = new System.Drawing.Point(24, 55);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(275, 26);
            this.Lbl_Empleado.TabIndex = 5;
            this.Lbl_Empleado.Text = "Ingrese el ID del Empleado";
            // 
            // Dgv_Liquidacion_Recibo
            // 
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
            this.Dgv_Liquidacion_Recibo.Location = new System.Drawing.Point(29, 168);
            this.Dgv_Liquidacion_Recibo.Name = "Dgv_Liquidacion_Recibo";
            this.Dgv_Liquidacion_Recibo.ReadOnly = true;
            this.Dgv_Liquidacion_Recibo.RowHeadersVisible = false;
            this.Dgv_Liquidacion_Recibo.RowHeadersWidth = 62;
            this.Dgv_Liquidacion_Recibo.RowTemplate.Height = 28;
            this.Dgv_Liquidacion_Recibo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Liquidacion_Recibo.Size = new System.Drawing.Size(749, 163);
            this.Dgv_Liquidacion_Recibo.TabIndex = 8;
            // 
            // cmp_id_liquidacion
            // 
            this.cmp_id_liquidacion.DataPropertyName = "cmp_id_liquidacion";
            this.cmp_id_liquidacion.HeaderText = "ID Liquidacion";
            this.cmp_id_liquidacion.MinimumWidth = 8;
            this.cmp_id_liquidacion.Name = "cmp_id_liquidacion";
            this.cmp_id_liquidacion.ReadOnly = true;
            this.cmp_id_liquidacion.Width = 81;
            // 
            // cmp_fecha_calculo
            // 
            this.cmp_fecha_calculo.DataPropertyName = "cmp_fecha_calculo";
            this.cmp_fecha_calculo.HeaderText = "Fecha de Calculo";
            this.cmp_fecha_calculo.MinimumWidth = 8;
            this.cmp_fecha_calculo.Name = "cmp_fecha_calculo";
            this.cmp_fecha_calculo.ReadOnly = true;
            this.cmp_fecha_calculo.Width = 81;
            // 
            // cmp_fecha_retiro
            // 
            this.cmp_fecha_retiro.DataPropertyName = "cmp_fecha_retiro";
            this.cmp_fecha_retiro.HeaderText = "Fecha de Retiro";
            this.cmp_fecha_retiro.MinimumWidth = 8;
            this.cmp_fecha_retiro.Name = "cmp_fecha_retiro";
            this.cmp_fecha_retiro.ReadOnly = true;
            this.cmp_fecha_retiro.Width = 81;
            // 
            // cmp_motivo_retiro
            // 
            this.cmp_motivo_retiro.DataPropertyName = "cmp_motivo_retiro";
            this.cmp_motivo_retiro.HeaderText = "Motivo de Retiro";
            this.cmp_motivo_retiro.MinimumWidth = 8;
            this.cmp_motivo_retiro.Name = "cmp_motivo_retiro";
            this.cmp_motivo_retiro.ReadOnly = true;
            this.cmp_motivo_retiro.Width = 80;
            // 
            // cmp_salario_pendiente
            // 
            this.cmp_salario_pendiente.DataPropertyName = "cmp_salario_pendiente";
            this.cmp_salario_pendiente.HeaderText = "Salario Pendiente";
            this.cmp_salario_pendiente.MinimumWidth = 8;
            this.cmp_salario_pendiente.Name = "cmp_salario_pendiente";
            this.cmp_salario_pendiente.ReadOnly = true;
            this.cmp_salario_pendiente.Width = 82;
            // 
            // cmp_indemnizacion
            // 
            this.cmp_indemnizacion.DataPropertyName = "cmp_indemnizacion";
            this.cmp_indemnizacion.HeaderText = "Indemnizacion";
            this.cmp_indemnizacion.MinimumWidth = 8;
            this.cmp_indemnizacion.Name = "cmp_indemnizacion";
            this.cmp_indemnizacion.ReadOnly = true;
            this.cmp_indemnizacion.Width = 81;
            // 
            // cmp_vacaciones_pendientes
            // 
            this.cmp_vacaciones_pendientes.DataPropertyName = "cmp_vacaciones_pendientes";
            this.cmp_vacaciones_pendientes.HeaderText = "Vacaciones Pendientes";
            this.cmp_vacaciones_pendientes.MinimumWidth = 8;
            this.cmp_vacaciones_pendientes.Name = "cmp_vacaciones_pendientes";
            this.cmp_vacaciones_pendientes.ReadOnly = true;
            this.cmp_vacaciones_pendientes.Width = 81;
            // 
            // cmp_aguinaldo_pendiente
            // 
            this.cmp_aguinaldo_pendiente.DataPropertyName = "cmp_aguinaldo_pendiente";
            this.cmp_aguinaldo_pendiente.HeaderText = "Aguinaldo Pendiente";
            this.cmp_aguinaldo_pendiente.MinimumWidth = 8;
            this.cmp_aguinaldo_pendiente.Name = "cmp_aguinaldo_pendiente";
            this.cmp_aguinaldo_pendiente.ReadOnly = true;
            this.cmp_aguinaldo_pendiente.Width = 81;
            // 
            // cmp_bono_14_pendiente
            // 
            this.cmp_bono_14_pendiente.DataPropertyName = "cmp_bono_14_pendiente";
            this.cmp_bono_14_pendiente.HeaderText = "Bono 14 Pendiente";
            this.cmp_bono_14_pendiente.MinimumWidth = 8;
            this.cmp_bono_14_pendiente.Name = "cmp_bono_14_pendiente";
            this.cmp_bono_14_pendiente.ReadOnly = true;
            this.cmp_bono_14_pendiente.Width = 81;
            // 
            // cmp_otros_ingresos
            // 
            this.cmp_otros_ingresos.DataPropertyName = "cmp_otros_ingresos";
            this.cmp_otros_ingresos.HeaderText = "Otros Ingresos";
            this.cmp_otros_ingresos.MinimumWidth = 8;
            this.cmp_otros_ingresos.Name = "cmp_otros_ingresos";
            this.cmp_otros_ingresos.ReadOnly = true;
            this.cmp_otros_ingresos.Width = 150;
            // 
            // cmp_total_descuentos
            // 
            this.cmp_total_descuentos.DataPropertyName = "cmp_total_descuentos";
            this.cmp_total_descuentos.HeaderText = "Total Descuentos";
            this.cmp_total_descuentos.MinimumWidth = 8;
            this.cmp_total_descuentos.Name = "cmp_total_descuentos";
            this.cmp_total_descuentos.ReadOnly = true;
            this.cmp_total_descuentos.Width = 150;
            // 
            // cmp_total_liquidacion
            // 
            this.cmp_total_liquidacion.DataPropertyName = "cmp_total_liquidacion";
            this.cmp_total_liquidacion.HeaderText = "Total Liquidacion";
            this.cmp_total_liquidacion.MinimumWidth = 8;
            this.cmp_total_liquidacion.Name = "cmp_total_liquidacion";
            this.cmp_total_liquidacion.ReadOnly = true;
            this.cmp_total_liquidacion.Width = 150;
            // 
            // cmp_numero_recibo
            // 
            this.cmp_numero_recibo.DataPropertyName = "cmp_numero_recibo";
            this.cmp_numero_recibo.HeaderText = "No. Recibo";
            this.cmp_numero_recibo.MinimumWidth = 8;
            this.cmp_numero_recibo.Name = "cmp_numero_recibo";
            this.cmp_numero_recibo.ReadOnly = true;
            this.cmp_numero_recibo.Width = 150;
            // 
            // cmp_fecha_pago
            // 
            this.cmp_fecha_pago.DataPropertyName = "cmp_fecha_pago";
            this.cmp_fecha_pago.HeaderText = "Fecha de Pago";
            this.cmp_fecha_pago.MinimumWidth = 8;
            this.cmp_fecha_pago.Name = "cmp_fecha_pago";
            this.cmp_fecha_pago.ReadOnly = true;
            this.cmp_fecha_pago.Width = 150;
            // 
            // cmp_estado
            // 
            this.cmp_estado.DataPropertyName = "cmp_estado";
            this.cmp_estado.HeaderText = "Estado";
            this.cmp_estado.MinimumWidth = 8;
            this.cmp_estado.Name = "cmp_estado";
            this.cmp_estado.ReadOnly = true;
            this.cmp_estado.Width = 150;
            // 
            // cmp_observaciones
            // 
            this.cmp_observaciones.DataPropertyName = "cmp_observaciones";
            this.cmp_observaciones.HeaderText = "Observaciones";
            this.cmp_observaciones.MinimumWidth = 8;
            this.cmp_observaciones.Name = "cmp_observaciones";
            this.cmp_observaciones.ReadOnly = true;
            this.cmp_observaciones.Width = 150;
            // 
            // FormLiquidacionRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.Dgv_Liquidacion_Recibo);
            this.Controls.Add(this.Txt_Empleado);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Empleado);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLiquidacionRecibo";
            this.Text = "FormLiquidacionRecibo";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Liquidacion_Recibo)).EndInit();
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
    }
}