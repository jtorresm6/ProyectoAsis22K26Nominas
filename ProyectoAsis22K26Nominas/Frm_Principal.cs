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
    public partial class Frm_Principal : Form
    {
        // MODO DESARROLLO: 
        // - false: Aplica las restricciones de roles (Gerente, RRHH, Supervisor, Secretaria).
        // - true: Muestra todos los botones e ignora los permisos.
        private bool modoDesarrollo = false;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            int attr,
            ref int attrValue,
            int attrSize
        );

        private Form formActivo = null;

        public Frm_Principal()
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

        /*
         * Consulta y evalúa el permiso del usuario conectado según su IdRol.
         * Roles definidos en Base de Datos:
         *  1 = Gerente / Admin
         *  2 = Recursos Humanos
         *  3 = Supervisor
         *  4 = Secretaria
         */
        private bool TienePermisoVer(string nombreFormulario)
        {
            // 1. Modo desarrollo libre (si estuviera en true)
            if (modoDesarrollo) return true;

            int idRol = SesionUsuario.IdRol;

            // 2. Validación por Roles
            switch (idRol)
            {
                case 1: // GERENTE / ADMINISTRADOR
                    return true; // Acceso total

                case 2: // RECURSOS HUMANOS
                    // Acceso a todo el sistema excepto la Bitácora
                    if (nombreFormulario.Equals("Frm_Bitacora", StringComparison.OrdinalIgnoreCase))
                        return false;
                    return true;

                case 3: // SUPERVISOR
                    switch (nombreFormulario)
                    {
                        case "Frm_Asistencias":
                        case "Frm_DirectorioEmpleados":
                        case "Frm_SolicitudVacaciones":
                        case "Frm_Controlsaldos":
                        case "Frm_help":
                            return true;
                        default:
                            return false; // Bloquea Altas/Mantenimiento, Planillas, Pagos y Bitácora
                    }

                case 4: // SECRETARIA
                    switch (nombreFormulario)
                    {
                        case "Frm_Asistencias":
                        case "Frm_DirectorioEmpleados": // Permite SOLO consultar el directorio
                        case "Frm_help":
                            return true;
                        default:
                            return false; // Bloquea Altas/Nuevos, Mantenimiento, Planillas, Pagos, etc.
                    }

                default:
                    // Respaldo en caso de consultar la tabla de permisos en la BD para otros roles
                    try
                    {
                        FormularioPermisos permiso = GestionarPermisos.ObtenerPermiso(nombreFormulario);
                        if (permiso != null && permiso.Ver) return true;
                    }
                    catch
                    {
                        // Excepción silenciosa
                    }
                    return false;
            }
        }

        /*
         * Abre el formulario dinámicamente dentro del panel contenedor.
         */
        private void AbrirFormHijo(Form formHijo)
        {
            // Se usa GetType().Name para garantizar que evalúe el nombre de la clase C# exacta
            if (!TienePermisoVer(formHijo.GetType().Name))
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
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            Pnl_contenedor.Controls.Clear();
            Pnl_contenedor.Controls.Add(formHijo);
            Pnl_contenedor.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();

            // Registrar actividad en la Bitácora
            Bitacora.Registrar(
                "Acceso a formulario",
                "El usuario " + SesionUsuario.Usuario + " ingresó al formulario " + formHijo.GetType().Name + "."
            );
        }

        private void AplicarPermisos()
        {
            // EMPLEADOS
            bool verNuevoEmpleado = TienePermisoVer("Frm_Nuevoregistro");
            bool verDirectorio = TienePermisoVer("Frm_DirectorioEmpleados");
            bool verMantenimiento = TienePermisoVer("Frm_MantenimientoEmpleado");

            Btn_nuevempleado.Visible = verNuevoEmpleado;
            Btn_directempleado.Visible = verDirectorio;
            Btn_mantempleado.Visible = verMantenimiento;

            // Se muestra el menú principal "Empleado" si tiene permiso a al menos una opción
            Btn_empleado.Visible = verNuevoEmpleado || verDirectorio || verMantenimiento;


            // NÓMINA
            bool verMovimientos = TienePermisoVer("Frm_MovimientosPlanilla");
            bool verGenerarPlanilla = TienePermisoVer("Frm_GenerarPlanilla");
            bool verHistorialNomina = TienePermisoVer("Frm_HistorialNomina");

            Btn_movplanilla.Visible = verMovimientos;
            Btn_genplanilla.Visible = verGenerarPlanilla;
            Btn_histreportes.Visible = verHistorialNomina;

            btn_nomina.Visible = verMovimientos || verGenerarPlanilla || verHistorialNomina;


            // VACACIONES
            bool verSolicitudVacaciones = TienePermisoVer("Frm_SolicitudVacaciones");
            bool verControlSaldos = TienePermisoVer("Frm_Controlsaldos");
            bool verHistorialVacaciones = TienePermisoVer("Frm_HistorialVacaciones");

            Btn_nvsolicitud.Visible = verSolicitudVacaciones;
            Btn_ctrlsaldos.Visible = verControlSaldos;
            Btn_histconstancias.Visible = verHistorialVacaciones;

            Btn_vacacioness.Visible = verSolicitudVacaciones || verControlSaldos || verHistorialVacaciones;


            // PAGOS
            bool verLiquidaciones = TienePermisoVer("Frm_LiquidacionRecibo");
            bool verHistorialPagos = TienePermisoVer("Frm_HistorialPagos");

            Btn_luiquidrecibos.Visible = verLiquidaciones;
            Btn_histpagos.Visible = verHistorialPagos;

            Btn_pagos.Visible = verLiquidaciones || verHistorialPagos;


            // ASISTENCIA
            bool verAsistencia = TienePermisoVer("Frm_Asistencias");

            Btn_asistencias.Visible = verAsistencia;
            Btn_asistencia.Visible = verAsistencia;


            // AYUDA
            Btn_Help.Visible = TienePermisoVer("Frm_help");


            // BITÁCORA
            button1.Visible = TienePermisoVer("Frm_Bitacora");


            // Ocultar submenús inicialmente
            customizeDesign();
        }


        // MENÚS PRINCIPALES
        private void Btn_empleado_Click(object sender, EventArgs e)
        {
            showSubMenu(Pnl_emplaeado);
        }

        private void btn_nomina_Click(object sender, EventArgs e)
        {
            showSubMenu(Pnl_nomina);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            showSubMenu(Pnl_vacaciones);
        }

        private void Btn_pagos_Click(object sender, EventArgs e)
        {
            showSubMenu(Pnl_pagos);
        }

        private void Btn_asistencia_Click_1(object sender, EventArgs e)
        {
            showSubMenu(Pnl_asistencia);
        }


        // ACCIONES DE BOTONES HIJOS (EMPLEADOS)
        private void Btn_nuevempleado_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_Nuevoregistro());
            hideSubMenu();
        }

        private void Btn_directempleado_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_DirectorioEmpleados());
            hideSubMenu();
        }

        private void Btn_mantempleado_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_MantenimientoEmpleado());
            hideSubMenu();
        }


        // ACCIONES DE BOTONES HIJOS (NÓMINA)
        private void Btn_movplanilla_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_MovimientosPlanilla());
            hideSubMenu();
        }

        private void Btn_genplanilla_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_GenerarPlanilla());
            hideSubMenu();
        }

        private void Btn_histreportes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_HistorialNomina());
            hideSubMenu();
        }


        // ACCIONES DE BOTONES HIJOS (VACACIONES)
        private void Btn_nvsolicitud_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_SolicitudVacaciones());
            hideSubMenu();
        }

        private void Btn_ctrlsaldos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_Controlsaldos());
            hideSubMenu();
        }

        private void Btn_histconstancias_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_HistorialVacaciones());
            hideSubMenu();
        }


        // ACCIONES DE BOTONES HIJOS (PAGOS)
        private void Btn_luiquidrecibos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_LiquidacionRecibo());
            hideSubMenu();
        }

        private void Btn_histpagos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_HistorialPagos());
            hideSubMenu();
        }


        // ACCIONES DE BOTONES HIJOS (ASISTENCIA)
        private void Btn_asistencia_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_Asistencias());
            hideSubMenu();
        }


        // ACCIONES DE BOTONES HIJOS (AYUDA Y BITÁCORA)
        private void Btn_Help_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_help());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Frm_Bitacora());
            hideSubMenu();
        }


        // CERRAR SESIÓN
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            if (SesionUsuario.IdUsuario > 0)
            {
                Bitacora.Registrar(
                    "Cierre de sesión",
                    "El usuario " + SesionUsuario.Usuario + " cerró sesión correctamente."
                );
            }

            SesionUsuario.IdUsuario = 0;
            SesionUsuario.Usuario = string.Empty;
            SesionUsuario.IdRol = 0;
            SesionUsuario.Rol = string.Empty;

            this.Hide();

            Frm_Login login = new Frm_Login();

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
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Pnl_cont1_Paint(object sender, PaintEventArgs e) { }
        private void Pnl_contenedor_Paint(object sender, PaintEventArgs e) { }
    }
}