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

namespace ProyectoAsis22K26Nominas
{
    public partial class Form1 : Form
    {
        // DECLARACIÓN OBLIGATORIA (Debe estar dentro de la clase Form1, pero FUERA de cualquier función)
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        // VARIABLE PARA CONTROLAR EL FORMULARIO HIJO ACTIVO
        private Form formActivo = null;

        public Form1()
        {
            InitializeComponent();
            customizeDesign();

            // Modo oscuro barra título
            // 1. Activa el modo oscuro base
            int useDarkMode = 1;
            DwmSetWindowAttribute(this.Handle, 20, ref useDarkMode, sizeof(int));

            // 2. Asigna el color RGB (11, 7, 17) a la Barra de Título
            int captionColor = ColorTranslator.ToWin32(Color.FromArgb(11, 7, 17));
            DwmSetWindowAttribute(this.Handle, 35, ref captionColor, sizeof(int));

            // 3. Pone el texto de la barra de título en color Blanco para contrastar
            int textColor = ColorTranslator.ToWin32(Color.White);
            DwmSetWindowAttribute(this.Handle, 36, ref textColor, sizeof(int));

            // 4. Aplica también el color al fondo de la ventana principal
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

        // MÉTODO ÚNICO PARA ABRIR FORMULARIOS HIJOS
        private void AbrirFormHijo(Form formHijo)
        {
            // 1. Cierra la pantalla anterior liberando memoria
            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = formHijo;

            // 2. Configura el formulario
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // 3. Carga en el panel contenedor
            Pnl_contenedor.Controls.Clear();
            Pnl_contenedor.Controls.Add(formHijo);
            Pnl_contenedor.Tag = formHijo;

            // 4. Muestra la pantalla
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aplica los permisos del usuario logueado en cuanto carga el Form1
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

        // ==========================================
        // 🔐 MÉTODO PARA APLICAR PERMISOS SEGÚN ROL
        // ==========================================
        private void AplicarPermisos()
        {
            string rol = SesionUsuario.Rol;

            if (rol == "Secretaria")
            {
                // ❌ Oculta los módulos que no corresponden a Secretaría
                Btn_empleado.Visible = false;
                btn_nomina.Visible = false;
                Btn_vacacioness.Visible = false; // Módulo Vacaciones
                Btn_pagos.Visible = false;

                // Si la secretaria no necesita el menú desplegable, se puede abrir directamente el Formasistencia:
                AbrirFormHijo(new Formasistencia());
            }
            else if (rol == "RRHH")
            {
                // RRHH ve gestión de personal, nómina y vacaciones, pero no el módulo de pagos
                Btn_empleado.Visible = true;
                btn_nomina.Visible = true;
                Btn_vacacioness.Visible = true;
                Btn_pagos.Visible = false;
            }
            else if (rol == "Admin")
            {
                // El administrador tiene acceso a todo el sistema
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
            AbrirFormHijo(new help());
        }
    }
}