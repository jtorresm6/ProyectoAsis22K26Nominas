using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    public partial class FormSolicitudVacaciones : Form
    {
        // Variables globales
        private int idEmpleadoSeleccionado = 0;
        private int diasDisponibles = 0;

        public FormSolicitudVacaciones()
        {
            InitializeComponent();
        }

        private void FormSolicitudVacaciones_Load(object sender, EventArgs e)
        {

        // EVENTOS DE CONTROLES
        private void Cbo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDiasDisponibles();
        }
    }
}
