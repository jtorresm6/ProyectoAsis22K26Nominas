using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAsis22K26Nominas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Instanciamos el formulario de Login dentro de un 'using' para liberar memoria al cerrar
            using (FormLogin login = new FormLogin())
            {
                // 2. Mostramos el Login como ventana modal
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Si el login fue exitoso, abrimos el Form1 principal
                    Application.Run(new Form1());
                }
                else
                {
                    // Si el usuario cancela o cierra la ventana, la aplicación finaliza
                    Application.Exit();
                }
            }
        }
    }
}