using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

//Parte trabajada por: Natali Sofia Montenegro Portillo - Carné: 0901-23-10017
//Curso:Análsis de Sistemas II
//Fecha de creación: 25-07-2026
//Fecha de última modificación: 27-07-2026

namespace ProyectoAsis22K26Nominas
{
    public partial class Formhelp : Form
    {
        public Formhelp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Creación de los botones de ayuda que presenta información resumida de lo que se encuentra en cada formulario
        //del sistema, además de un botón que permite abrir el manual en PDF.
        private void Trv_Sistema_AfterSelect(object sender, TreeViewEventArgs e)
        {

            Rtb_Info.Clear();

            switch (e.Node.Text) {
                case "Gestión de Empleados":

                    Rtb_Info.Text =
                        "EMPLEADOS\n\n" +
                        "Este apartado permite registrar, buscar, modificar, " +
                        "dar de baja y reactivar empleados.\n\n";

                    break;

                case "Gestión de Nóminas":

                    Rtb_Info.Text =
                        "NÓMINAS\n\n" +
                        "Esta opción permite ver un menú para registrar, consultar y modificar " +
                        "las nóminas de los empleados, ademas de un reporte de las mismas.";

                    break;

                case "Vacaciones":

                    Rtb_Info.Text =
                        "VACACIONES\n\n" +
                        "Esta opción permite generar solicitudes de vacaciones, llevar control de saldos " +
                        "y las constancias de asistencias de empleados.";

                    break;

                case "Gestión de Sueldos":

                    Rtb_Info.Text =
                        "PAGOS\n\n" +
                        "Esta opción permite administrar las liquidaciones y los pagos de un empleado " +
                        "además de llevar su historial.";

                    break;

                case "Gestión de Asistencias":

                    Rtb_Info.Text =
                        "ASISTENCIAS\n\n" +
                        "Esta opción permite llevar un control de las asistencias de los empleados " +
                        "para verificar que dias se ausenta y si es con permiso o no. ";

                    break;

                default:

                    Rtb_Info.Text =
                        "Seleccione una opción para consultar la ayuda de dicho formulario.";

                    break;
            }
        }

        //Mensaje default del sistema que se muestra al abrir el centro de ayuda, antes de seleccionar alguna opción.

        private void Formhelp_Load(object sender, EventArgs e)
        {
            Rtb_Info.ReadOnly = true;

            Rtb_Info.Text =
                "Bienvenido al Centro de Ayuda!\n\n" +
                "Seleccione una opción del menú ubicado en el lado izquierdo " +
                "para consultar información básica sobre el funcionamiento del sistema. \n\n" +
                "Si se quiere ver información mas detallada sobre el sistema, seleccionar el botón " +
                "'Manual en PDF' para una mejor visualización. ";

            FormularioPermisos permiso =
            GestionarPermisos.ObtenerPermiso("Formhelp"
            );

            if (!permiso.Ver)
            {
                MessageBox.Show("No tiene permiso para este formulario.");
                Close();
                return;
            }

            Btn_Pdf.Enabled = permiso.Ver;

        }

        

        private void Btn_Cerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        //Llamar el .pdf de nuestro manual de usuario, el cual se encuentra en una carpeta de manuales.

        private void Btn_Pdf_Click(object sender, EventArgs e) {
            string ruta = Application.StartupPath +
              "\\Manuales\\Nominas.pdf";

            if (File.Exists(ruta))
            {
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("No se encontró el archivo PDF.");
            }
        }
    }
}
