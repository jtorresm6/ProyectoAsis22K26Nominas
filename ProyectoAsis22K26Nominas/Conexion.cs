using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;

namespace ProyectoAsis22K26Nominas
{
    class Conexion
    {
        private MySqlConnection conexion;

        private string servidor = "localhost";
        private string bd = "db_sistema_nominas";
        private string usuario = "root";
        private string password = "yankhel5";
        private string puerto = "3306";


        public MySqlConnection AbrirConexion()
        {
            try
            {
                conexion = new MySqlConnection(
                    $"Server={servidor};Database={bd};Uid={usuario};Pwd={password};Port={puerto};"
                );

                conexion.Open();

                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión: " + ex.Message);
            }
        }


        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}