namespace ProyectoAsis22K26Nominas
{
    partial class FormBitacora
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
            this.Dgv_Bitacora = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Bitacora
            // 
            this.Dgv_Bitacora.AllowUserToAddRows = false;
            this.Dgv_Bitacora.AllowUserToDeleteRows = false;
            this.Dgv_Bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Bitacora.Location = new System.Drawing.Point(35, 86);
            this.Dgv_Bitacora.Name = "Dgv_Bitacora";
            this.Dgv_Bitacora.ReadOnly = true;
            this.Dgv_Bitacora.RowHeadersWidth = 51;
            this.Dgv_Bitacora.RowTemplate.Height = 24;
            this.Dgv_Bitacora.Size = new System.Drawing.Size(902, 150);
            this.Dgv_Bitacora.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(362, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitácora Sistema";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(408, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vizualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_Bitacora);
            this.Name = "FormBitacora";
            this.Text = "FormBitacora";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Bitacora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}