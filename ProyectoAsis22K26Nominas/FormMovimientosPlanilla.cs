using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// Roger Yankhel de Jesús Herrera Alcántara 0901-23-2429 
// Fecha de creacion: 25/07/2026
// Fecha de finalizacion: 27/07/2026

namespace ProyectoAsis22K26Nominas
{
    public partial class FormMovimientosPlanilla : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataAdapter adaptador;
        DataTable tabla;
        int idEmpleadoSeleccionado = 0;
        int idMovimientoSeleccionado = 0;

        public FormMovimientosPlanilla()
        {
            InitializeComponent();
        }

        private void FormMovimientosPlanilla_Load(object sender, EventArgs e)
        {
            CargarTipoMovimiento();

            Cbo_Buscar_Campo.Items.Add("ID");
            Cbo_Buscar_Campo.Items.Add("DPI");
            Cbo_Buscar_Campo.Items.Add("NIT");

            Cbo_Buscar_Campo.SelectedIndex = 0;

            Txt_Nombre_Empleado.ReadOnly = true;
        }

        private void CargarTipoMovimiento()
        {
            try
            {
                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"SELECT 
                    cmp_id_tipo_movimiento,
                    cmp_nombre 
                    FROM tbl_Tipo_Movimiento";

                comando = new MySqlCommand(consulta, conexion);
                adaptador = new MySqlDataAdapter(comando);

                tabla = new DataTable();
                adaptador.Fill(tabla);

                Cbo_Tipo_Movimiento.DataSource = tabla;
                Cbo_Tipo_Movimiento.DisplayMember = "cmp_nombre";
                Cbo_Tipo_Movimiento.ValueMember = "cmp_id_tipo_movimiento";

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de movimiento: " + ex.Message);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void BuscarEmpleado()
        {
            try
            {
                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string campo = "";

                if (Cbo_Buscar_Campo.Text == "ID")
                {
                    campo = "cmp_id_empleado";
                }
                else if (Cbo_Buscar_Campo.Text == "DPI")
                {
                    campo = "cmp_dpi";
                }
                else if (Cbo_Buscar_Campo.Text == "NIT")
                {
                    campo = "cmp_nit";
                }

                string consulta = $@"SELECT 
                            cmp_id_empleado,
                            cmp_nombre,
                            cmp_apellido
                            FROM tbl_Empleados
                            WHERE {campo} = @dato";

                comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@dato", Txt_Campo.Text);

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    idEmpleadoSeleccionado = Convert.ToInt32(lector["cmp_id_empleado"]);

                    Txt_Nombre_Empleado.Text =
                        lector["cmp_nombre"].ToString() + " " +
                        lector["cmp_apellido"].ToString();
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado");
                    idEmpleadoSeleccionado = 0;
                    Txt_Nombre_Empleado.Clear();
                }

                lector.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleado: " + ex.Message);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void CargarMovimientos()
        {
            try
            {
                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"SELECT 
m.cmp_id_movimiento,
m.cmp_cantidad,
m.cmp_id_tipo_movimiento,
tm.cmp_nombre AS Tipo,
m.cmp_monto AS Monto,
m.cmp_descripcion AS Descripcion,
m.cmp_estado AS Estado

FROM tbl_Movimientos_Planilla m

INNER JOIN tbl_Tipo_Movimiento tm
ON m.cmp_id_tipo_movimiento = tm.cmp_id_tipo_movimiento

WHERE m.cmp_id_empleado = @empleado
AND m.cmp_fecha BETWEEN @inicio AND @fin";

                comando = new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@empleado", idEmpleadoSeleccionado);
                comando.Parameters.AddWithValue("@inicio", Dpt_Fecha_Inicio.Value.Date);
                comando.Parameters.AddWithValue("@fin", Dpt_Fecha_Fin.Value.Date);

                adaptador = new MySqlDataAdapter(comando);

                tabla = new DataTable();
                adaptador.Fill(tabla);

                Dgv_Movimientos.DataSource = tabla;
                Dgv_Movimientos.Columns["cmp_id_movimiento"].Visible = false;
                Dgv_Movimientos.Columns["cmp_cantidad"].Visible = false;
                Dgv_Movimientos.Columns["cmp_id_tipo_movimiento"].Visible = false;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar movimientos: " + ex.Message);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void GuardarMovimiento()
        {
            try
            {
                if (idEmpleadoSeleccionado == 0)
                {
                    MessageBox.Show("Primero busque un empleado");
                    return;
                }

                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"INSERT INTO tbl_Movimientos_Planilla
        (
        cmp_fecha,
        cmp_cantidad,
        cmp_monto,
        cmp_descripcion,
        cmp_id_empleado,
        cmp_id_tipo_movimiento,
        cmp_id_usuario
        )
        VALUES
        (
        @fecha,
        @cantidad,
        @monto,
        @descripcion,
        @empleado,
        @tipo,
        @usuario
        )";

                comando = new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@fecha", Dpt_Fecha_Inicio.Value.Date);
                comando.Parameters.AddWithValue("@cantidad", Txt_Cantidad.Text);
                comando.Parameters.AddWithValue("@monto", Txt_Monto.Text);
                comando.Parameters.AddWithValue("@descripcion", Txt_Descripcion.Text);
                comando.Parameters.AddWithValue("@empleado", idEmpleadoSeleccionado);
                comando.Parameters.AddWithValue("@tipo", Cbo_Tipo_Movimiento.SelectedValue);
                comando.Parameters.AddWithValue("@usuario", 1);

                comando.ExecuteNonQuery();

                MessageBox.Show("Movimiento guardado");

                conexion.Close();

                CargarMovimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
                LimpiarCampos();
            }
        }

        private void ModificarMovimiento()
        {
            try
            {
                if (idMovimientoSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un movimiento primero");
                    return;
                }

                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"UPDATE tbl_Movimientos_Planilla
                            SET 
                            cmp_cantidad=@cantidad,
                            cmp_monto=@monto,
                            cmp_descripcion=@descripcion,
                            cmp_id_tipo_movimiento=@tipo
                            WHERE cmp_id_movimiento=@id";

                comando = new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@cantidad", Txt_Cantidad.Text);
                comando.Parameters.AddWithValue("@monto", Txt_Monto.Text);
                comando.Parameters.AddWithValue("@descripcion", Txt_Descripcion.Text);
                comando.Parameters.AddWithValue("@tipo", Cbo_Tipo_Movimiento.SelectedValue);
                comando.Parameters.AddWithValue("@id", idMovimientoSeleccionado);

                comando.ExecuteNonQuery();

                MessageBox.Show("Movimiento modificado correctamente");

                conexion.Close();

                CargarMovimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void EliminarMovimiento()
        {
            try
            {
                if (idMovimientoSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un movimiento primero");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar este movimiento?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (respuesta == DialogResult.No)
                    return;

                conexion = ConexionBD.ObtenerConexion();
                conexion.Open();

                string consulta = @"DELETE FROM tbl_Movimientos_Planilla
                            WHERE cmp_id_movimiento=@id";

                comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", idMovimientoSeleccionado);

                comando.ExecuteNonQuery();

                MessageBox.Show("Movimiento eliminado");

                conexion.Close();

                CargarMovimientos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void LimpiarCampos()
        {
            Txt_Cantidad.Clear();
            Txt_Monto.Clear();
            Txt_Descripcion.Clear();

            idMovimientoSeleccionado = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Periodo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void Txt_Monto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un empleado primero");
                return;
            }

            CargarMovimientos();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarMovimiento();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            ModificarMovimiento();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarMovimiento();
        }

        private void Data_Movimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Movimientos.Rows[e.RowIndex];

                idMovimientoSeleccionado = Convert.ToInt32(
                    fila.Cells["cmp_id_movimiento"].Value
                );

                Txt_Monto.Text = fila.Cells["Monto"].Value.ToString();
                Txt_Descripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                Txt_Cantidad.Text = fila.Cells["cmp_cantidad"].Value.ToString();

                Cbo_Tipo_Movimiento.SelectedValue =
                fila.Cells["cmp_id_tipo_movimiento"].Value;
            }
        }
    }
}