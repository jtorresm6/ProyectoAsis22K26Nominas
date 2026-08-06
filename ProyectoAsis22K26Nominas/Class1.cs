using MySql.Data.MySqlClient;
using System;
using System.Net;
using System.Windows.Forms;

namespace ProyectoAsis22K26Nominas
{
    public static class Bitacora
    {
        public static void Registrar(string accion, string descripcion, string formulario = null, string tabla = null, int? idRegistro = null)
        {
            try
            {
                // Si por alguna razón el usuario aún no tiene ID, se evita lanzar la excepción
                if (SesionUsuario.IdUsuario <= 0) return;

                string ipLocal = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
                string nombreEquipo = Environment.MachineName;

                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    con.Open();

                    // Se incluye 'id_usuario' y 'NOW()' para guardar la fecha y hora exacta del sistema
                    string query = @"INSERT INTO tbl_bitacora 
                                    (id_usuario, fecha_bitacora, accion_bitacora, descripcion_bitacora, nombre_formulario, tabla_afectada, id_registro, direccion_ip, nombre_equipo) 
                                    VALUES 
                                    (@idUsuario, NOW(), @accion, @descripcion, @formulario, @tabla, @idReg, @ip, @equipo);";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);
                        cmd.Parameters.AddWithValue("@accion", accion);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@formulario", (object)formulario ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@tabla", (object)tabla ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@idReg", (object)idRegistro ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ip", ipLocal);
                        cmd.Parameters.AddWithValue("@equipo", nombreEquipo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Bitácora: " + ex.Message);
            }
        }
    }
}