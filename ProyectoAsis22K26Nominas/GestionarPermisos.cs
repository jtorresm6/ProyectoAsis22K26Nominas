using MySql.Data.MySqlClient;
using System;

namespace ProyectoAsis22K26Nominas
{
    internal static class GestionarPermisos
    {
        public static FormularioPermisos ObtenerPermiso(
            string nombreFormulario
        )
        {
            FormularioPermisos permiso =
                new FormularioPermisos();

            using (MySqlConnection conexion =
                ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string consulta =
                    @"select
                        cmp_ver,
                        cmp_crear,
                        cmp_modificar,
                        cmp_eliminar
                      from tbl_Aplicaciones
                      where cmp_id_rol = @idRol
                      and cmp_nombre_formulario = @formulario
                      limit 1;";

                using (MySqlCommand comando =
                    new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@idRol",
                        SesionUsuario.IdRol
                    );

                    comando.Parameters.AddWithValue(
                        "@formulario",
                        nombreFormulario.Trim()
                    );

                    using (MySqlDataReader lector =
                        comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            permiso.Ver =
                                Convert.ToBoolean(
                                    lector["cmp_ver"]
                                );

                            permiso.Crear =
                                Convert.ToBoolean(
                                    lector["cmp_crear"]
                                );

                            permiso.Modificar =
                                Convert.ToBoolean(
                                    lector["cmp_modificar"]
                                );

                            permiso.Eliminar =
                                Convert.ToBoolean(
                                    lector["cmp_eliminar"]
                                );
                        }
                    }
                }
            }

            return permiso;
        }
    }
}
