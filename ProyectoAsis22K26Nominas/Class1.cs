using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProyectoAsis22K26Nominas
{
    public static class Bitacora
    {
        public static void Registrar(string accion, string descripcion)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // Consulta SQL con los nombres actualizados de la nueva BD
                    string consulta = @"INSERT INTO tbl_bitacora 
                                        (fecha_bitacora, accion_bitacora, descripcion_bitacora, id_usuario) 
                                        VALUES 
                                        (NOW(), @accion, @descripcion, @idUsuario);";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Captura el error en la consola de depuración para evitar interrumpir la app si falla la bitácora
                System.Diagnostics.Debug.WriteLine("Error al registrar bitácora: " + ex.Message);
            }
        }
    }
}
