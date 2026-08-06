using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Roger Yankhel de Jesús Herrera Alcántara 09a01-23-2429 
// Fecha de creacion: 25/07/2026
// Fecha de finalizacion: 27/07/2026

namespace ProyectoAsis22K26Nominas
{
    public partial class FormMovimientosPlanilla : Form
    {
        private int idEmpleadoSeleccionado = 0;
        private int idConceptoSeleccionado = 0;
        private int idPlanillaSeleccionada = 0; // Se requiere para la clave compuesta

        public FormMovimientosPlanilla()
        {
            InitializeComponent();
        }

        private void FormMovimientosPlanilla_Load(object sender, EventArgs e)
        {
            Redondear(Pnl_Personal, 20);
            Redondear(Pnl_Plani, 20);
            CargarTipoMovimiento();

            Cbo_Buscar_Campo.Items.Clear();
            Cbo_Buscar_Campo.Items.Add("ID");
            Cbo_Buscar_Campo.Items.Add("DPI");
            Cbo_Buscar_Campo.Items.Add("NIT");
            Cbo_Buscar_Campo.SelectedIndex = 0;

            Txt_Nombre_Empleado.ReadOnly = true;

            FormularioPermisos permiso = GestionarPermisos.ObtenerPermiso("FormMovimientosPlanilla");

            if (!permiso.Ver)
            {
                MessageBox.Show("No tiene permiso para este formulario.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            Btn_Guardar.Enabled = permiso.Modificar;
            Btn_Modificar.Enabled = permiso.Modificar;
        }

        private void CargarTipoMovimiento()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = "SELECT id_concepto, nombre_concepto FROM tbl_conceptos_nomina";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        Cbo_Tipo_Movimiento.DataSource = tabla;
                        Cbo_Tipo_Movimiento.DisplayMember = "nombre_concepto";
                        Cbo_Tipo_Movimiento.ValueMember = "id_concepto";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar conceptos de nómina: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarEmpleado()
        {
            try
            {
                string campoBD = "id_empleado";
                if (Cbo_Buscar_Campo.Text == "DPI") campoBD = "dpi_emp";
                else if (Cbo_Buscar_Campo.Text == "NIT") campoBD = "nit_emp";

                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = $@"SELECT id_empleado, nombre_emp, apellido_emp 
                                        FROM tbl_empleados 
                                        WHERE {campoBD} = @dato";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@dato", Txt_Campo.Text.Trim());

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                idEmpleadoSeleccionado = Convert.ToInt32(lector["id_empleado"]);
                                Txt_Nombre_Empleado.Text = $"{lector["nombre_emp"]} {lector["apellido_emp"]}";
                                idPlanillaSeleccionada = 0; // Reiniciamos la planilla al seleccionar nuevo empleado
                            }
                            else
                            {
                                MessageBox.Show("Empleado no encontrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                idEmpleadoSeleccionado = 0;
                                idPlanillaSeleccionada = 0;
                                Txt_Nombre_Empleado.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMovimientos()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = @"SELECT 
                                            m.id_planilla,
                                            m.id_empleado,
                                            m.id_concepto,
                                            c.nombre_concepto AS Concepto,
                                            m.cantidad_mov AS Cantidad,
                                            m.monto_mov AS Monto,
                                            m.descripcion_mov AS Descripcion
                                        FROM tbl_movimientos_planilla m
                                        INNER JOIN tbl_conceptos_nomina c ON m.id_concepto = c.id_concepto
                                        INNER JOIN tbl_planillas p ON m.id_planilla = p.id_planilla
                                        WHERE m.id_empleado = @empleado
                                          AND p.fecha_inicio >= @inicio 
                                          AND p.fecha_fin <= @fin";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@empleado", idEmpleadoSeleccionado);
                        comando.Parameters.AddWithValue("@inicio", Dpt_Fecha_Inicio.Value.Date);
                        comando.Parameters.AddWithValue("@fin", Dpt_Fecha_Fin.Value.Date);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tabla = new DataTable();
                            adaptador.Fill(tabla);

                            Dgv_Movimientos.DataSource = tabla;

                            // Ocultar llaves en el DataGridView
                            if (Dgv_Movimientos.Columns.Contains("id_planilla")) Dgv_Movimientos.Columns["id_planilla"].Visible = false;
                            if (Dgv_Movimientos.Columns.Contains("id_empleado")) Dgv_Movimientos.Columns["id_empleado"].Visible = false;
                            if (Dgv_Movimientos.Columns.Contains("id_concepto")) Dgv_Movimientos.Columns["id_concepto"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar movimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarMovimiento()
        {
            if (idEmpleadoSeleccionado == 0)
            {
                MessageBox.Show("Primero busque un empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // Si idPlanillaSeleccionada no está definido, buscamos la planilla activa del empleado
                    if (idPlanillaSeleccionada == 0)
                    {
                        string sqlBuscarPlanilla = @"SELECT id_planilla 
                                             FROM tbl_planilla_detalle 
                                             WHERE id_empleado = @id_empleado 
                                             ORDER BY id_planilla DESC LIMIT 1";

                        using (MySqlCommand cmdPlanilla = new MySqlCommand(sqlBuscarPlanilla, conexion))
                        {
                            cmdPlanilla.Parameters.AddWithValue("@id_empleado", idEmpleadoSeleccionado);
                            object res = cmdPlanilla.ExecuteScalar();

                            if (res != null && res != DBNull.Value)
                            {
                                idPlanillaSeleccionada = Convert.ToInt32(res);
                            }
                            else
                            {
                                MessageBox.Show("El empleado seleccionado no está registrado en el detalle de ninguna planilla.", "Error de Referencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    string consulta = @"INSERT INTO tbl_movimientos_planilla
                                (id_planilla, id_empleado, id_concepto, cantidad_mov, monto_mov, descripcion_mov)
                                VALUES
                                (@id_planilla, @id_empleado, @id_concepto, @cantidad, @monto, @descripcion)";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_planilla", idPlanillaSeleccionada);
                        comando.Parameters.AddWithValue("@id_empleado", idEmpleadoSeleccionado);
                        comando.Parameters.AddWithValue("@id_concepto", Cbo_Tipo_Movimiento.SelectedValue);
                        comando.Parameters.AddWithValue("@cantidad", decimal.TryParse(Txt_Cantidad.Text, out decimal cant) ? cant : 0);
                        comando.Parameters.AddWithValue("@monto", decimal.TryParse(Txt_Monto.Text, out decimal monto) ? monto : 0);
                        comando.Parameters.AddWithValue("@descripcion", Txt_Descripcion.Text.Trim());

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Movimiento guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMovimientos();
                LimpiarCampos();
            }
            catch (MySqlException ex) when (ex.Number == 1062) // Captura error de duplicados (Duplicate Entry)
            {
                MessageBox.Show("Este concepto ya fue registrado para el empleado en la planilla seleccionada.\n\nSi desea modificar la cantidad o el monto, seleccione el registro de la lista y haga clic en 'Modificar'.",
                                "Concepto Ya Existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlException ex) when (ex.Number == 1452) // Captura error de clave foránea
            {
                MessageBox.Show("No se pudo guardar el movimiento. La combinación de 'id_planilla' e 'id_empleado' no existe en 'tbl_planilla_detalle'.", "Error de Referencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el movimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarMovimiento()
        {
            if (idEmpleadoSeleccionado == 0 || idConceptoSeleccionado == 0 || idPlanillaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione un movimiento primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = @"UPDATE tbl_movimientos_planilla
                                        SET cantidad_mov = @cantidad,
                                            monto_mov = @monto,
                                            descripcion_mov = @descripcion
                                        WHERE id_planilla = @id_planilla 
                                          AND id_empleado = @id_empleado 
                                          AND id_concepto = @id_concepto";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@cantidad", decimal.TryParse(Txt_Cantidad.Text, out decimal cant) ? cant : 0);
                        comando.Parameters.AddWithValue("@monto", decimal.TryParse(Txt_Monto.Text, out decimal monto) ? monto : 0);
                        comando.Parameters.AddWithValue("@descripcion", Txt_Descripcion.Text.Trim());
                        comando.Parameters.AddWithValue("@id_planilla", idPlanillaSeleccionada);
                        comando.Parameters.AddWithValue("@id_empleado", idEmpleadoSeleccionado);
                        comando.Parameters.AddWithValue("@id_concepto", idConceptoSeleccionado);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Movimiento modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMovimientos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarMovimiento()
        {
            if (idEmpleadoSeleccionado == 0 || idConceptoSeleccionado == 0 || idPlanillaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione un movimiento primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar este movimiento?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No) return;

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = @"DELETE FROM tbl_movimientos_planilla
                                        WHERE id_planilla = @id_planilla 
                                          AND id_empleado = @id_empleado 
                                          AND id_concepto = @id_concepto";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_planilla", idPlanillaSeleccionada);
                        comando.Parameters.AddWithValue("@id_empleado", idEmpleadoSeleccionado);
                        comando.Parameters.AddWithValue("@id_concepto", idConceptoSeleccionado);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Movimiento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMovimientos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            Txt_Cantidad.Clear();
            Txt_Monto.Clear();
            Txt_Descripcion.Clear();
            idConceptoSeleccionado = 0;
            idPlanillaSeleccionada = 0;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e) => BuscarEmpleado();

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un empleado primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CargarMovimientos();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e) => GuardarMovimiento();

        private void Btn_Modificar_Click(object sender, EventArgs e) => ModificarMovimiento();

        private void Btn_Eliminar_Click(object sender, EventArgs e) => EliminarMovimiento();

        private void Data_Movimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Movimientos.Rows[e.RowIndex];

                idPlanillaSeleccionada = Convert.ToInt32(fila.Cells["id_planilla"].Value);
                idConceptoSeleccionado = Convert.ToInt32(fila.Cells["id_concepto"].Value);

                Txt_Monto.Text = fila.Cells["Monto"].Value?.ToString() ?? "";
                Txt_Descripcion.Text = fila.Cells["Descripcion"].Value?.ToString() ?? "";
                Txt_Cantidad.Text = fila.Cells["Cantidad"].Value?.ToString() ?? "";

                Cbo_Tipo_Movimiento.SelectedValue = idConceptoSeleccionado;
            }
        }

        // Métodos de apoyo requeridos para prevenir errores CS1061 del Diseñador
        private void Lbl_Periodo_Click(object sender, EventArgs e) { }
        private void Txt_Monto_TextChanged(object sender, EventArgs e) { }

        private void Lbl_Codigo_Empleado_Click(object sender, EventArgs e)
        {

        }

        private void Redondear(Control control, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(control.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(control.Width - radio, control.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, control.Height - radio, radio, radio, 90, 90);

            path.CloseAllFigures();

            control.Region = new Region(path);
        }
    }
}