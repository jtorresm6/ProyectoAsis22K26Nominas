using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoAsis22K26Nominas
{
    public partial class FormBitacora : Form
    {
        public FormBitacora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void CargarBitacora()
        {
            try
            {
                using (MySqlConnection conexion =
                    ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta =
                        @"select
                    b.cmp_id_bitacora as Codigo,
                    b.cmp_fecha as Fecha,
                    u.cmp_nombre as Usuario,
                    concat(e.cmp_nombre,' ',e.cmp_apellido) as Empleado,
                    r.cmp_nombre as Rol,
                    b.cmp_direccion_ip as IP,
                    b.cmp_nombre_formulario as Formulario,
                    b.cmp_tabla_afectada as Tabla,
                    b.cmp_accion as Accion,
                    b.cmp_descripcion as Descripcion
                from tbl_Bitacora b
                inner join tbl_Usuarios u
                    on b.cmp_id_usuario = u.cmp_id_usuario
                inner join tbl_Empleados e
                    on u.cmp_id_empleado = e.cmp_id_empleado
                inner join tbl_Roles r
                    on u.cmp_id_rol = r.cmp_id_rol
                order by b.cmp_fecha desc;";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        MySqlDataAdapter adaptador =
                            new MySqlDataAdapter(comando);

                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        Dgv_Bitacora.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la bitácora: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}