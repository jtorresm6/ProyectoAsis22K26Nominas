using MySql.Data.MySqlClient;

//Parte trabajada por: Jose Javier Torres Martinez - Carné: 0901-23-1091
//Curso:Análisis de Sistemas II
//Fecha de creación: 23-07-2026
//Fecha de última modificación: 27-07-2026

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