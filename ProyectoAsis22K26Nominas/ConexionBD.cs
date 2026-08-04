using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    public class ConexionBD
    {
        private static string cadenaConexion = "Server=localhost;Port=3306;Database=db_sistema_nominas;Uid=root;Pwd=sqlogJR_mj101;";

        public static MySqlConnection ObtenerConexion()
        {
            // CREAR Y ABRIR LA CONEXIÓN
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}