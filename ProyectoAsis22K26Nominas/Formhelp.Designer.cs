namespace ProyectoAsis22K26Nominas
{
    partial class Formhelp
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Gestión de Empleados");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Gestión de Nóminas");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Vacaciones");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Gestión de Sueldos");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Gestión de Asistencias");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Centro de Ayuda", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.Trv_Sistema = new System.Windows.Forms.TreeView();
            this.Rtb_Info = new System.Windows.Forms.RichTextBox();
            this.Información = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Pdf = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Información.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Trv_Sistema
            // 
            this.Trv_Sistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Trv_Sistema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trv_Sistema.Location = new System.Drawing.Point(57, 156);
            this.Trv_Sistema.Name = "Trv_Sistema";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Gestión de Empleados";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Gestión de Nóminas";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Vacaciones";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Gestión de Sueldos";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Gestión de Asistencias";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Centro de Ayuda";
            this.Trv_Sistema.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.Trv_Sistema.Size = new System.Drawing.Size(216, 169);
            this.Trv_Sistema.TabIndex = 1;
            this.Trv_Sistema.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Trv_Sistema_AfterSelect);
            // 
            // Rtb_Info
            // 
            this.Rtb_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rtb_Info.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtb_Info.Location = new System.Drawing.Point(279, 156);
            this.Rtb_Info.Name = "Rtb_Info";
            this.Rtb_Info.Size = new System.Drawing.Size(360, 169);
            this.Rtb_Info.TabIndex = 2;
            this.Rtb_Info.Text = "";
            // 
            // Información
            // 
            this.Información.Controls.Add(this.label7);
            this.Información.Controls.Add(this.label6);
            this.Información.Controls.Add(this.label1);
            this.Información.Controls.Add(this.label4);
            this.Información.Controls.Add(this.label3);
            this.Información.Controls.Add(this.label2);
            this.Información.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Información.ForeColor = System.Drawing.Color.White;
            this.Información.Location = new System.Drawing.Point(57, 407);
            this.Información.Name = "Información";
            this.Información.Size = new System.Drawing.Size(582, 131);
            this.Información.TabIndex = 3;
            this.Información.TabStop = false;
            this.Información.Text = "Información del Sistema";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Version: 4.8.09221";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 31);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(183, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Microsoft .NET Framework";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Microsoft Visual Studio Community 2022 ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sistema: Nóminas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Curso: Análisis de Sistemas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Version: 17.14.36";
            // 
            // Btn_Pdf
            // 
            this.Btn_Pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.Btn_Pdf.FlatAppearance.BorderSize = 0;
            this.Btn_Pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pdf.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pdf.ForeColor = System.Drawing.Color.White;
            this.Btn_Pdf.Location = new System.Drawing.Point(156, 571);
            this.Btn_Pdf.Name = "Btn_Pdf";
            this.Btn_Pdf.Size = new System.Drawing.Size(158, 44);
            this.Btn_Pdf.TabIndex = 4;
            this.Btn_Pdf.Text = "Manual en PDF";
            this.Btn_Pdf.UseVisualStyleBackColor = false;
            this.Btn_Pdf.Click += new System.EventHandler(this.Btn_Pdf_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cerrar.Location = new System.Drawing.Point(363, 571);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(133, 44);
            this.Btn_Cerrar.TabIndex = 6;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(402, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 100);
            this.panel1.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.label8.Location = new System.Drawing.Point(58, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(438, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "Consulte, edite y administre la información de los empleados.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(33, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 54);
            this.label9.TabIndex = 75;
            this.label9.Text = "Centro de Ayuda";
            // 
            // Formhelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(724, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Pdf);
            this.Controls.Add(this.Información);
            this.Controls.Add(this.Rtb_Info);
            this.Controls.Add(this.Trv_Sistema);
            this.Name = "Formhelp";
            this.Text = "Formhelp";
            this.Load += new System.EventHandler(this.Formhelp_Load);
            this.Información.ResumeLayout(false);
            this.Información.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView Trv_Sistema;
        private System.Windows.Forms.RichTextBox Rtb_Info;
        private System.Windows.Forms.GroupBox Información;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Pdf;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}