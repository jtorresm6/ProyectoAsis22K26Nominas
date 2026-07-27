using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoAsis22K26Nominas
{
    internal class ConexionBD 
    {
        private const string connectionString = "server=localhost;database=db_sistema_nominas;user=root;password=Smile412**;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
