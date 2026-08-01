using MySql.Data.MySqlClient;
using System;

namespace ProyectoAsis22K26Nominas
{
    public static class Bitacora
    {
        public static void Registrar(string accion, string descripcion)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string consulta =
                    "insert into tbl_Bitacora " +
                    "(cmp_fecha, cmp_accion, cmp_descripcion, cmp_id_usuario) " +
                    "values (now(), @accion, @descripcion, @idUsuario);";

                using (MySqlCommand comando =
                    new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@accion",
                        accion
                    );

                    comando.Parameters.AddWithValue(
                        "@descripcion",
                        descripcion
                    );

                    comando.Parameters.AddWithValue(
                        "@idUsuario",
                        SesionUsuario.IdUsuario
                    );

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
