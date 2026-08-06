using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Parte trabajada por: Jose Javier Torres Martinez
// Carné: 0901-23-1091
// Curso: Análisis de Sistemas II
// Fecha de creación: 23-07-2026
// Fecha de última modificación: 31-07-2026

namespace ProyectoAsis22K26Nominas
{
    public partial class Form1 : Form
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            int attr,
            ref int attrValue,
            int attrSize
        );

        private Form formActivo = null;

        public Form1()
        {
            InitializeComponent();
            customizeDesign();

            int useDarkMode = 1;

            DwmSetWindowAttribute(
                this.Handle,
                20,
                ref useDarkMode,
                sizeof(int)
            );

            int captionColor = ColorTranslator.ToWin32(
                Color.FromArgb(11, 7, 17)
            );

            DwmSetWindowAttribute(
                this.Handle,
                35,
                ref captionColor,
                sizeof(int)
            );

            int textColor = ColorTranslator.ToWin32(
                Color.White
            );

            DwmSetWindowAttribute(
                this.Handle,
                36,
                ref textColor,
                sizeof(int)
            );

            this.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
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
            if (Pnl_emplaeado.Visible)
            {
                Pnl_emplaeado.Visible = false;
            }

            if (Pnl_nomina.Visible)
            {
                Pnl_nomina.Visible = false;
            }

            if (Pnl_vacaciones.Visible)
            {
                Pnl_vacaciones.Visible = false;
            }

            if (Pnl_pagos.Visible)
            {
                Pnl_pagos.Visible = false;
            }

            if (Pnl_asistencia.Visible)
            {
                Pnl_asistencia.Visible = false;
            }
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

        /*
         * Consulta el permiso del usuario conectado.
         * Devuelve true solamente cuando puede ver el formulario.
         */
        private bool TienePermisoVer(string nombreFormulario)
        {
            FormularioPermisos permiso =
                GestionarPermisos.ObtenerPermiso(
                    nombreFormulario
                );

            return permiso.Ver;
        }

        /*
         * Abre el formulario solamente si el usuario tiene permiso.
         * Esta validación funciona como una segunda protección.
         */
        private void AbrirFormHijo(Form formHijo)
        {
            FormularioPermisos permiso =
                GestionarPermisos.ObtenerPermiso(formHijo.Name);

            if (!permiso.Ver)
            {
                MessageBox.Show(
                    "No tiene permiso para ingresar a este formulario.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                formHijo.Dispose();
                return;
            }

            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = formHijo;

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle =
                FormBorderStyle.None;

            formHijo.Dock = DockStyle.Fill;

            Pnl_contenedor.Controls.Clear();
            Pnl_contenedor.Controls.Add(formHijo);
            Pnl_contenedor.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();

            // Registrar quién ingresó al formulario
            Bitacora.Registrar(
                "Acceso a formulario",
                "El usuario " +
                SesionUsuario.Usuario +
                " ingresó al formulario " +
                formHijo.Name + "."
            );
        }

        private void AplicarPermisos()
        {

            // EMPLEADOS

            bool verNuevoEmpleado =
                TienePermisoVer("FormNuevoregistro");

            bool verDirectorio =
                TienePermisoVer("FormDirectorioEmpleados");

            bool verMantenimiento =
                TienePermisoVer("FormMantenimientoEmpleado");

            Btn_nuevempleado.Visible = verNuevoEmpleado;
            Btn_directempleado.Visible = verDirectorio;
            Btn_mantempleado.Visible = verMantenimiento;

            Btn_empleado.Visible =
                verNuevoEmpleado ||
                verDirectorio ||
                verMantenimiento;



            // NÓMINA

            bool verMovimientos =
                TienePermisoVer("FormMovimientosPlanilla");

            bool verGenerarPlanilla =
                TienePermisoVer("FormGenerarPlanilla");

            bool verHistorialNomina =
                TienePermisoVer("FormHistorialNomina");

            Btn_movplanilla.Visible = verMovimientos;
            Btn_genplanilla.Visible = verGenerarPlanilla;
            Btn_histreportes.Visible = verHistorialNomina;

            btn_nomina.Visible =
                verMovimientos ||
                verGenerarPlanilla ||
                verHistorialNomina;


            // VACACIONES
            bool verSolicitudVacaciones =
                TienePermisoVer("FormSolicitudVacaciones");

            bool verControlSaldos =
                TienePermisoVer("FormControlSaldos");

            bool verHistorialVacaciones =
                TienePermisoVer("FormHistorialVacaciones");

            Btn_nvsolicitud.Visible = verSolicitudVacaciones;
            Btn_ctrlsaldos.Visible = verControlSaldos;
            Btn_histconstancias.Visible = verHistorialVacaciones;

            Btn_vacacioness.Visible =
                verSolicitudVacaciones ||
                verControlSaldos ||
                verHistorialVacaciones;


            // PAGOS
            bool verLiquidaciones =
                TienePermisoVer("FormLiquidacionRecibo");

            bool verHistorialPagos =
                TienePermisoVer("FormHistorialPagos");

            Btn_luiquidrecibos.Visible = verLiquidaciones;
            Btn_histpagos.Visible = verHistorialPagos;

            Btn_pagos.Visible =
                verLiquidaciones ||
                verHistorialPagos;



            // ASISTENCIA

            bool verAsistencia =
                TienePermisoVer("Formasistencia");

            // Botón principal de Control
            Btn_asistencias.Visible = verAsistencia;

            // Botón interno que abre el formulario
            Btn_asistencia.Visible = verAsistencia;



            // AYUDA
            Btn_Help.Visible =
                TienePermisoVer("Formhelp");


            // BITÁCORA
            button1.Visible =
                TienePermisoVer("FormBitacora");


            // Los submenús deben iniciar cerrados
            Pnl_emplaeado.Visible = false;
            Pnl_nomina.Visible = false;
            Pnl_vacaciones.Visible = false;
            Pnl_pagos.Visible = false;
            Pnl_asistencia.Visible = false;
        }




        // MENÚS PRINCIPALES
        private void Btn_empleado_Click(
            object sender,
            EventArgs e
        )
        {
            showSubMenu(Pnl_emplaeado);
        }

        private void btn_nomina_Click(
            object sender,
            EventArgs e
        )
        {
            showSubMenu(Pnl_nomina);
        }

        private void Button5_Click(
            object sender,
            EventArgs e
        )
        {
            showSubMenu(Pnl_vacaciones);
        }

        private void Btn_pagos_Click(
            object sender,
            EventArgs e
        )
        {
            showSubMenu(Pnl_pagos);
        }

        private void Btn_asistencia_Click_1(
            object sender,
            EventArgs e
        )
        {
            showSubMenu(Pnl_asistencia);
        }

        // EMPLEADOS

        private void Btn_nuevempleado_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormNuevoregistro()
            );

            hideSubMenu();
        }

        private void Btn_directempleado_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormDirectorioEmpleados()
            );

            hideSubMenu();
        }

        private void Btn_mantempleado_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormMantenimientoEmpleado()
            );

            hideSubMenu();
        }


        // NÓMINA
        private void Btn_movplanilla_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormMovimientosPlanilla()
            );

            hideSubMenu();
        }

        private void Btn_genplanilla_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormGenerarPlanilla()
            );

            hideSubMenu();
        }

        private void Btn_histreportes_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormHistorialNomina()
            );

            hideSubMenu();
        }


        // VACACIONES

        private void Btn_nvsolicitud_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormSolicitudVacaciones()
            );

            hideSubMenu();
        }

        private void Btn_ctrlsaldos_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormControlSaldos()
            );

            hideSubMenu();
        }

        private void Btn_histconstancias_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormHistorialVacaciones()
            );

            hideSubMenu();
        }

        // PAGOS

        private void Btn_luiquidrecibos_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormLiquidacionRecibo()
            );

            hideSubMenu();
        }

        private void Btn_histpagos_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormHistorialPagos()
            );

            hideSubMenu();
        }


        // ASISTENCIA

        private void Btn_asistencia_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new Formasistencia()
            );

            hideSubMenu();
        }


        // AYUDA Y BITÁCORA

        private void Btn_Help_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new Formhelp()
            );

            hideSubMenu();
        }

        private void button1_Click(
            object sender,
            EventArgs e
        )
        {
            AbrirFormHijo(
                new FormBitacora()
            );

            hideSubMenu();
        }


        // SALIR

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            // 1. Registrar la salida en la bitácora antes de limpiar la sesión
            if (SesionUsuario.IdUsuario > 0)
            {
                Bitacora.Registrar(
                    "Cierre de sesión",
                    "El usuario " + SesionUsuario.Usuario + " cerró sesión correctamente."
                );
            }

            // 2. Limpiar las variables estáticas de la sesión activa
            SesionUsuario.IdUsuario = 0;
            SesionUsuario.Usuario = string.Empty;
            SesionUsuario.IdRol = 0;
            SesionUsuario.Rol = string.Empty;

            // 3. Ocultar la ventana actual y abrir la pantalla de Login
            this.Hide();

            FormLogin login = new FormLogin();

        
            if (login.ShowDialog() == DialogResult.OK)
            {
                
                this.Show();
            }
            else
            {
                
                this.Close();
            }
        }


        // EVENTOS VACÍOS DEL DISEÑADOR

        private void panel1_Paint(
            object sender,
            PaintEventArgs e
        )
        {
        }

        private void Pnl_cont1_Paint(
            object sender,
            PaintEventArgs e
        )
        {
        }

        private void Pnl_contenedor_Paint(
            object sender,
            PaintEventArgs e
        )
        {
        }
    }
}