using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProyectoAsis22K26Nominas
{
    internal static class GestionarPermisos
    {
        public static FormularioPermisos ObtenerPermiso(string nombreFormulario)
        {
            FormularioPermisos permiso = new FormularioPermisos();

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // Consulta construida exactamente con las columnas de tbl_aplicaciones
                    string consulta = @"SELECT
                                            permiso_ver,
                                            permiso_crear,
                                            permiso_modificar,
                                            permiso_eliminar
                                        FROM tbl_aplicaciones
                                        WHERE id_rol = @idRol
                                          AND nombre_formulario = @formulario
                                        LIMIT 1;";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@idRol", SesionUsuario.IdRol);
                        comando.Parameters.AddWithValue("@formulario", nombreFormulario.Trim());

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                // Mapeo directo de las columnas tinyint(1) a boolean
                                permiso.Ver = Convert.ToBoolean(lector["permiso_ver"]);
                                permiso.Crear = Convert.ToBoolean(lector["permiso_crear"]);
                                permiso.Modificar = Convert.ToBoolean(lector["permiso_modificar"]);
                                permiso.Eliminar = Convert.ToBoolean(lector["permiso_eliminar"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al consultar permisos: " + ex.Message,
                    "Error de Permisos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return permiso;
        }
    }
}