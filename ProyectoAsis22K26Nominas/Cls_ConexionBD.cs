using System;
using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    public class Conexion
    {
        // Cadena de conexión para tu Local instance MySQL80
        private static string servidor = "localhost";
        private static string puerto = "3306";
        private static string usuario = "root";
        private static string password = "SQLMatthew2003$"; // Cambia esto por tu contraseña de MySQL
        private static string baseDatos = "db_sistema_nominas";  // Cambia esto por el nombre de tu esquema

        private static string cadenaConexion = $"server={servidor};port={puerto};database={baseDatos};uid={usuario};pwd={password};";

        // Método para abrir la conexión
        public static MySqlConnection ObtenerConexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }
    }
}