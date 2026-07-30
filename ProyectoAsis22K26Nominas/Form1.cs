using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


//Parte trabajada por: Jose Javier Torres Martinez - Carné: 0901-23-1091
//Curso:Análisis de Sistemas II
//Fecha de creación: 23-07-2026
//Fecha de última modificación: 27-07-2026

namespace ProyectoAsis22K26Nominas
{
    public partial class Form1 : Form
    {
        
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private Form formActivo = null;

        public Form1()
        {
            InitializeComponent();
            customizeDesign();

            int useDarkMode = 1;
            DwmSetWindowAttribute(this.Handle, 20, ref useDarkMode, sizeof(int));

         
            int captionColor = ColorTranslator.ToWin32(Color.FromArgb(11, 7, 17));
            DwmSetWindowAttribute(this.Handle, 35, ref captionColor, sizeof(int));

            int textColor = ColorTranslator.ToWin32(Color.White);
            DwmSetWindowAttribute(this.Handle, 36, ref textColor, sizeof(int));

            this.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void customizeDesign()
        {
            Pnl_emplaeado.Visible = false;
            Pnl_nomina.Visible = false;
            Pnl_vacaciones.Visible = false;
            Pnl_pagos.Visible = false;
            Pnl_asistencia.Visible = false;
        }

        private void hideSubMenu()
        {
            if (Pnl_emplaeado.Visible) Pnl_emplaeado.Visible = false;
            if (Pnl_nomina.Visible) Pnl_nomina.Visible = false;
            if (Pnl_vacaciones.Visible) Pnl_vacaciones.Visible = false;
            if (Pnl_pagos.Visible) Pnl_pagos.Visible = false;
            if (Pnl_asistencia.Visible) Pnl_asistencia.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

      
        private void AbrirFormHijo(Form formHijo)
        {
         
            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = formHijo;

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

          
            Pnl_contenedor.Controls.Clear();
            Pnl_contenedor.Controls.Add(formHijo);
            Pnl_contenedor.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
            AplicarPermisos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        // Menús principales
        private void Btn_empleado_Click(object sender, EventArgs e) => showSubMenu(Pnl_emplaeado);
        private void btn_nomina_Click(object sender, EventArgs e) => showSubMenu(Pnl_nomina);
        private void Button5_Click(object sender, EventArgs e) => showSubMenu(Pnl_vacaciones);
        private void Btn_pagos_Click(object sender, EventArgs e) => showSubMenu(Pnl_pagos);

        // Subopciones: Empleados
        private void Btn_nuevempleado_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormNuevoregistro());
            hideSubMenu();
        }

        private void Btn_directempleado_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormDirectorioEmpleados());
            hideSubMenu();
        }
        private void Btn_mantempleado_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormMantenimientoEmpleado());
            hideSubMenu();

        }

        // Subopciones: Nómina 
        private void Btn_movplanilla_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormMovimientosPlanilla());
            hideSubMenu();
        }

        private void Btn_genplanilla_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormGenerarPlanilla());
            hideSubMenu();
        }

        private void Btn_histreportes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormHistorialNomina());
            hideSubMenu();
        }

        // Subopciones: Vacaciones
        private void Btn_nvsolicitud_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormSolicitudVacaciones());
            hideSubMenu();
        }

        private void Btn_ctrlsaldos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormControlSaldos());
            hideSubMenu();
        }

        private void Btn_histconstancias_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormHistorialVacaciones());
            hideSubMenu();
        }

        // Subopciones: Pagos
        private void Btn_luiquidrecibos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormLiquidacionRecibo());
            hideSubMenu();
        }

        private void Btn_histpagos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormHistorialPagos());
            hideSubMenu();
        }

        private void Pnl_cont1_Paint(object sender, PaintEventArgs e) { }

        private void Btn_asistencia_Click_1(object sender, EventArgs e)
        {
            showSubMenu(Pnl_asistencia);
        }

        private void Pnl_contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_asistencia_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Formasistencia());
            hideSubMenu();
        }

    
        private void AplicarPermisos()
        {
            string rol = SesionUsuario.Rol;

            if (rol == "Secretaria")
            {
    
                Btn_empleado.Visible = false;
                btn_nomina.Visible = false;
                Btn_vacacioness.Visible = false; 
                Btn_pagos.Visible = false;

           
                AbrirFormHijo(new Formasistencia());
            }
            else if (rol == "RRHH")
            {
                
                Btn_empleado.Visible = true;
                btn_nomina.Visible = true;
                Btn_vacacioness.Visible = true;
                Btn_pagos.Visible = false;
            }
            else if (rol == "Admin")
            {
               
                Btn_empleado.Visible = true;
                btn_nomina.Visible = true;
                Btn_vacacioness.Visible = true;
                Btn_pagos.Visible = true;
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Help_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Formhelp());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormBitacora());
            hideSubMenu();
        }
    }
}