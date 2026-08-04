using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
            string usuario = Txt_usuario.Text.Trim();
            string contrasena = Txt_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Ingrese el usuario y la contraseña.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            bool ingresoCorrecto = false;

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // Consulta adaptada exactamente a la nueva base de datos BD_ProyectoNominas
                    string consulta = @"SELECT
                                            u.id_usuario,
                                            u.nombre_usuario AS Usuario,
                                            u.id_rol,
                                            r.nombre_rol,
                                            CONCAT(e.nombre_emp, ' ', e.apellido_emp) AS nombre_completo
                                        FROM tbl_usuarios u
                                        INNER JOIN tbl_roles r 
                                            ON u.id_rol = r.id_rol
                                        INNER JOIN tbl_empleados e 
                                            ON u.id_empleado = e.id_empleado
                                        WHERE u.nombre_usuario = @usuario
                                          AND u.contrasena = @contrasena
                                          AND u.estado_usuario = 1
                                        LIMIT 1;";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@contrasena", contrasena);

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                SesionUsuario.IdUsuario = Convert.ToInt32(lector["id_usuario"]);
                                SesionUsuario.Usuario = lector["Usuario"].ToString();
                                SesionUsuario.IdRol = Convert.ToInt32(lector["id_rol"]);
                                SesionUsuario.Rol = lector["nombre_rol"].ToString();

                                ingresoCorrecto = true;
                            }
                        }
                    }
                }

                if (ingresoCorrecto)
                {
                    Bitacora.Registrar(
                        "Inicio de sesión",
                        "El usuario " + SesionUsuario.Usuario + " inició sesión correctamente."
                    );

                    MessageBox.Show(
                        "Bienvenido/a " + SesionUsuario.Usuario,
                        "Inicio de sesión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos, o usuario inactivo.",
                        "Inicio de sesión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al iniciar sesión: " + ex.Message,
                    "Error BD",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}