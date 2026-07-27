using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    public class ConexionBD
    {
        // La variable debe ser static para usarse en un método static
        private static string cadenaConexion = "Server=192.168.174.148;Port=3306;Database=BD_ProyectoNominas;Uid=usuprueba;Pwd=1234;";

        // Método estático accesible directamente como ConexionBD.ObtenerConexion()
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}