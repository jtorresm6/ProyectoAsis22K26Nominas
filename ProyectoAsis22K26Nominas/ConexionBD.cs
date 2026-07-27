using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    public class ConexionBD
    {
        // Cadena de conexión ajustada para tu servidor MySQL (Puerto 3306)
        private static string cadenaConexion = "Server=172.20.10.4;Port=3306;Database=BD_ProyectoNominas;Uid=usuprueba;Pwd=1234;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}