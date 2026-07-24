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
    public partial class FormLogin : Form
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);


        public FormLogin()
        {
            InitializeComponent();

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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Centra la pantalla de login al iniciar
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            string user = Txt_usuario.Text.Trim();
            string pass = Txt_password.Text.Trim();

            // Validar que no dejen campos vacíos
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDACIÓN DE USUARIOS Y ROLES 
            if (user == "admin" && pass == "123")
            {
                SesionUsuario.NombreCompleto = "Administrador del Sistema";
                SesionUsuario.Usuario = user;
                SesionUsuario.Rol = "Admin";

                this.DialogResult = DialogResult.OK; 
            }
            else if (user == "secre" && pass == "123")
            {
                SesionUsuario.NombreCompleto = "Secretaria General";
                SesionUsuario.Usuario = user;
                SesionUsuario.Rol = "Secretaria";

                this.DialogResult = DialogResult.OK;
            }
            else if (user == "rrhh" && pass == "123")
            {
                SesionUsuario.NombreCompleto = "Encargado de RRHH";
                SesionUsuario.Usuario = user;
                SesionUsuario.Rol = "RRHH";

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}