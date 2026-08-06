using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas

//Parte trabajada por: Jose Javier Torres Martinez - Carné: 0901-23-1091
//Curso:Análisis de Sistemas II
//Fecha de creación: 23-07-2026
//Fecha de última modificación: 27-07-2026

{
    public class ConexionBD
    {

        private static string cadenaConexion = "Server=192.168.1.115;Port=3306;Database=BD_ProyectoNominas;Uid=usuprueba;Pwd=1234;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}