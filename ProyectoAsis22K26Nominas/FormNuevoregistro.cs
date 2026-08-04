using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

//Parte trabajada por: Jose Javier Torres Martinez - Carné: 0901-23-1091
//Curso: Análisis de Sistemas II
//Fecha de creación: 23-07-2026
//Fecha de última modificación: 03-08-2026

namespace ProyectoAsis22K26Nominas
{
    public partial class FormNuevoregistro : Form
    {
        private bool esEdicion = false;
        private bool esNuevo = false;
        private object comando;

        // 1. Relación Departamentos -> Puestos
        private readonly Dictionary<string, List<string>> mapaDepartamentosPuestos = new Dictionary<string, List<string>>()
        {
            { "Gerencia General", new List<string> { "Gerente", "Asistente", "Supervisor" } },
            { "Ventas", new List<string> { "Vendedor", "Supervisor", "Auxiliar" } },
            { "Tecnología", new List<string> { "Desarrollador", "Analista", "Asistente" } },
            { "Recursos Humanos", new List<string> { "Analista", "Gerente", "Auxiliar" } },
            { "Producción", new List<string> { "Operario", "Supervisor", "Auxiliar" } },
            { "Marketing", new List<string> { "Analista", "Asistente", "Auxiliar" } },
            { "Logística", new List<string> { "Supervisor", "Operario", "Auxiliar" } },
            { "Legal", new List<string> { "Analista", "Asistente" } },
            { "Contabilidad", new List<string> { "Contador", "Analista", "Auxiliar" } },
            { "Atención al Cliente", new List<string> { "Recepcionista", "Asistente", "Auxiliar" } }
        };

        // 2. Descripciones Automáticas para DEPARTAMENTOS
        private readonly Dictionary<string, string> descripcionesDepartamentos = new Dictionary<string, string>()
        {
            { "Gerencia General", "Dirección estratégica y toma de decisiones ejecutivas." },
            { "Ventas", "Gestión comercial, prospección y atención al cliente." },
            { "Tecnología", "Desarrollo y soporte de sistemas informáticos." },
            { "Recursos Humanos", "Gestión del talento humano, contratación y nóminas." },
            { "Producción", "Fabricación, ensamblaje y control de calidad." },
            { "Marketing", "Estrategias publicitarias y análisis de mercado." },
            { "Logística", "Gestión de inventarios, almacén y distribución." },
            { "Legal", "Asesoría jurídica, contratos y cumplimiento normativo." },
            { "Contabilidad", "Gestión financiera, auditoría y declaraciones fiscales." },
            { "Atención al Cliente", "Soporte postventa y resolución de requerimientos." }
        };

        // 3. Descripciones Automáticas para PUESTOS
        private readonly Dictionary<string, string> descripcionesPuestos = new Dictionary<string, string>()
        {
            { "Gerente", "Planificación, liderazgo y supervisión de metas globales." },
            { "Analista", "Analista de procesos, datos y optimización operativa." },
            { "Asistente", "Soporte administrativo y coordinación de agenda." },
            { "Contador", "Registro contable, estados financieros e impuestos." },
            { "Vendedor", "Atención directa, prospección y cierre de ventas." },
            { "Desarrollador", "Creación, arquitectura y mantenimiento de software." },
            { "Supervisor", "Control de calidad operativa y gestión del personal a cargo." },
            { "Operario", "Ejecución técnica en línea de producción y mantenimiento." },
            { "Recepcionista", "Atención al público, conmutador y recepción documental." },
            { "Auxiliar", "Apoyo en tareas operativas y logísticas secundarias." }
        };

        public FormNuevoregistro()
        {
            InitializeComponent();
        }

        private async void FormNuevoregistro_Load(object sender, EventArgs e)
        {
            CargarComboboxes();
            EstablecerEstadoInicial();
            await CargarTablaEmpleadosAsync();

            FormularioPermisos permiso = GestionarPermisos.ObtenerPermiso("FormNuevoregistro");

            if (!permiso.Ver)
            {
                MessageBox.Show("No tiene permiso para este formulario.");
                Close();
                return;
            }

            Btn_agregar.Enabled = permiso.Crear;
            Btn_guardar.Enabled = permiso.Modificar;
        }

        #region Configuración de Estado y Controles

        private void CargarComboboxes()
        {
            Cbo_Departamento.Items.Clear();
            foreach (var depto in mapaDepartamentosPuestos.Keys)
            {
                Cbo_Departamento.Items.Add(depto);
            }

            if (Cbo_Departamento.Items.Count > 0)
            {
                Cbo_Departamento.SelectedIndex = 0;
            }

            Cbo_estado.Items.Clear();
            Cbo_estado.Items.Add("activo");
            Cbo_estado.Items.Add("inactivo");
            Cbo_estado.SelectedIndex = 0;
        }

        private void BloquearControles(bool bloquear)
        {
            bool habilitado = !bloquear;

            Txt_idempleado.Enabled = habilitado;
            Txt_identificacion.Enabled = habilitado;
            Txt_nit.Enabled = habilitado;
            Txt_nombre.Enabled = habilitado;
            Txt_apellidos.Enabled = habilitado;
            Txt_telefono.Enabled = habilitado;
            Txt_direccion.Enabled = habilitado;
            Txt_correo.Enabled = habilitado;
            Txt_salario.Enabled = habilitado;

            Txt_idpuesto.Enabled = false;
            Txt_iddepartamento.Enabled = false;

            Cbo_Departamento.Enabled = habilitado;
            Cbo_puesto.Enabled = habilitado;
            Cbo_estado.Enabled = habilitado;

            Dtp_fechnacimiento.Enabled = habilitado;
            Dtp_fechcontratacion.Enabled = habilitado;

            Btn_guardar.Enabled = habilitado;
        }

        private void EstablecerEstadoInicial()
        {
            esEdicion = false;
            esNuevo = false;

            LimpiarCampos();
            BloquearControles(true);

            Btn_agregar.Enabled = true;
        }

        private void LimpiarCampos()
        {
            Txt_idempleado.Clear();
            Txt_identificacion.Clear();
            Txt_nit.Clear();
            Txt_nombre.Clear();
            Txt_apellidos.Clear();
            Txt_telefono.Clear();
            Txt_direccion.Clear();
            Txt_correo.Clear();
            Txt_salario.Clear();
            Txt_idpuesto.Clear();
            Txt_iddepartamento.Clear();

            Dtp_fechnacimiento.Value = DateTime.Now;
            Dtp_fechcontratacion.Value = DateTime.Now;

            if (Cbo_Departamento.Items.Count > 0) Cbo_Departamento.SelectedIndex = 0;
            if (Cbo_estado.Items.Count > 0) Cbo_estado.SelectedIndex = 0;
        }

        private async Task CargarTablaEmpleadosAsync()
        {
            try
            {
                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    await con.OpenAsync();
                    string query = @"SELECT 
                                        e.id_empleado AS 'ID', 
                                        e.dpi_emp AS 'DPI',
                                        e.nit_emp AS 'NIT',
                                        e.nombre_emp AS 'Nombre', 
                                        e.apellido_emp AS 'Apellido', 
                                        e.estado_emp AS 'Estado',
                                        d.nombre_depto AS 'Departamento',
                                        p.nombre_puesto AS 'Puesto',
                                        p.salario_base AS 'Salario'
                                     FROM tbl_empleados e
                                     INNER JOIN tbl_puestos p ON e.id_puesto = p.id_puesto
                                     INNER JOIN tbl_departamentos d ON p.id_departamento = d.id_departamento";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            Dgv_empleados.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla de empleados: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Métodos para Obtener y Llenar Campos

        private void LlenarCamposFormulario(
            string id, string dpi, string nit, string nombre, string apellido,
            string direccion, string salario, DateTime fechaNac, DateTime fechaCont,
            string depto, string puesto, string estado, string telefono, string correo)
        {
            Txt_idempleado.Text = id;
            Txt_idempleado.Enabled = false;

            Txt_identificacion.Text = dpi;
            Txt_nit.Text = nit;
            Txt_nombre.Text = nombre;
            Txt_apellidos.Text = apellido;
            Txt_direccion.Text = direccion;
            Txt_salario.Text = salario;
            Txt_telefono.Text = telefono;
            Txt_correo.Text = correo;

            Dtp_fechnacimiento.Value = fechaNac;
            Dtp_fechcontratacion.Value = fechaCont;

            if (Cbo_Departamento.Items.Contains(depto))
                Cbo_Departamento.SelectedItem = depto;

            if (Cbo_puesto.Items.Contains(puesto))
                Cbo_puesto.SelectedItem = puesto;

            if (Cbo_estado.Items.Contains(estado))
                Cbo_estado.SelectedItem = estado;
        }

        private async Task<string> ObtenerTelefonoEmpleadoAsync(int idEmpleado, MySqlConnection con)
        {
            string query = "SELECT numero_tel FROM tbl_telefonos WHERE id_empleado = @id LIMIT 1;";
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", idEmpleado);
                object result = await cmd.ExecuteScalarAsync();
                return result != null && result != DBNull.Value ? result.ToString() : string.Empty;
            }
        }

        private async Task<string> ObtenerCorreoEmpleadoAsync(int idEmpleado, MySqlConnection con)
        {
            string query = "SELECT correo FROM tbl_correos WHERE id_empleado = @id LIMIT 1;";
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", idEmpleado);
                object result = await cmd.ExecuteScalarAsync();
                return result != null && result != DBNull.Value ? result.ToString() : string.Empty;
            }
        }

        #endregion

        #region Eventos de Controles y Sincronización de IDs

        private void Txt_idempleado_TextChanged(object sender, EventArgs e)
        {
            Txt_iddepartamento.Text = Txt_idempleado.Text;
            Txt_idpuesto.Text = Txt_idempleado.Text;
        }

        private void Cbo_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Departamento.SelectedItem == null) return;

            string deptoSeleccionado = Cbo_Departamento.SelectedItem.ToString();
            Cbo_puesto.Items.Clear();

            if (mapaDepartamentosPuestos.TryGetValue(deptoSeleccionado, out var puestos))
            {
                foreach (var puesto in puestos)
                {
                    Cbo_puesto.Items.Add(puesto);
                }

                if (Cbo_puesto.Items.Count > 0)
                {
                    Cbo_puesto.SelectedIndex = 0;
                }
            }
        }

        #endregion

        #region Métodos de Validación

        private bool CampoEstaVacio(TextBox campo, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                MessageBox.Show($"Debe ingresar {nombreCampo}.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.Focus();
                return true;
            }
            return false;
        }

        private bool ValidarCamposFormulario()
        {
            if (CampoEstaVacio(Txt_identificacion, "el DPI / Identificación")) return false;
            if (CampoEstaVacio(Txt_nit, "el NIT")) return false;
            if (CampoEstaVacio(Txt_nombre, "el Nombre")) return false;
            if (CampoEstaVacio(Txt_apellidos, "los Apellidos")) return false;
            if (CampoEstaVacio(Txt_telefono, "el Teléfono")) return false;
            if (CampoEstaVacio(Txt_direccion, "la Dirección")) return false;
            if (CampoEstaVacio(Txt_correo, "el Correo electrónico")) return false;
            if (CampoEstaVacio(Txt_salario, "el Salario Base")) return false;

            return true;
        }

        #endregion

        #region Botones de Acción y Operaciones CRUD

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearControles(false);

            esNuevo = true;
            esEdicion = false;

        }

        private async void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposFormulario()) return;

            if (esNuevo)
            {
                await InsertarEmpleadoAsync();
            }
            else if (esEdicion)
            {
                await ActualizarEmpleadoAsync();
            }


        }

        private async Task InsertarEmpleadoAsync()
        {
            using (MySqlConnection con = ConexionBD.ObtenerConexion())
            {
                await con.OpenAsync();
                using (MySqlTransaction tran = con.BeginTransaction())
                {
                    try
                    {
                        int idComun = 0;
                        int.TryParse(Txt_idempleado.Text.Trim(), out idComun);

                        if (idComun == 0)
                        {
                            string qNextId = @"SELECT GREATEST(
                                        IFNULL((SELECT MAX(id_empleado) FROM tbl_empleados), 0),
                                        IFNULL((SELECT MAX(id_departamento) FROM tbl_departamentos), 0),
                                        IFNULL((SELECT MAX(id_puesto) FROM tbl_puestos), 0)
                                       ) + 1;";

                            using (MySqlCommand cmdNext = new MySqlCommand(qNextId, con, tran))
                            {
                                idComun = Convert.ToInt32(await cmdNext.ExecuteScalarAsync());
                            }
                        }

                        // Verificación de duplicado únicamente por ID
                        string queryCheckId = @"SELECT 
                                        (SELECT COUNT(*) FROM tbl_empleados WHERE id_empleado = @idCheck) +
                                        (SELECT COUNT(*) FROM tbl_departamentos WHERE id_departamento = @idCheck) +
                                        (SELECT COUNT(*) FROM tbl_puestos WHERE id_puesto = @idCheck) AS Total;";

                        using (MySqlCommand cmdCheck = new MySqlCommand(queryCheckId, con, tran))
                        {
                            cmdCheck.Parameters.AddWithValue("@idCheck", idComun);

                            long totalCoincidencias = Convert.ToInt64(await cmdCheck.ExecuteScalarAsync());

                            if (totalCoincidencias > 0)
                            {
                                MessageBox.Show($"El ID {idComun} ya existe en la base de datos. Ingrese otro ID.", "ID Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tran.Rollback();
                                return;
                            }
                        }

                        Txt_idempleado.Text = idComun.ToString();
                        Txt_iddepartamento.Text = idComun.ToString();
                        Txt_idpuesto.Text = idComun.ToString();

                        string deptoNombre = Cbo_Departamento.SelectedItem?.ToString() ?? "General";
                        string puestoNombre = Cbo_puesto.SelectedItem?.ToString() ?? "General";

                        string descDepto = descripcionesDepartamentos.ContainsKey(deptoNombre) ? descripcionesDepartamentos[deptoNombre] : "Sin descripción";
                        string descPuesto = descripcionesPuestos.ContainsKey(puestoNombre) ? descripcionesPuestos[puestoNombre] : "Sin descripción";

                        decimal salarioBase = 0;
                        decimal.TryParse(Txt_salario.Text.Trim(), out salarioBase);

                        string queryDepto = "INSERT INTO tbl_departamentos (id_departamento, nombre_depto, descripcion_depto, estado_depto) VALUES (@idDepto, @nombreDepto, @descDepto, true);";
                        using (MySqlCommand cmdD = new MySqlCommand(queryDepto, con, tran))
                        {
                            cmdD.Parameters.AddWithValue("@idDepto", idComun);
                            cmdD.Parameters.AddWithValue("@nombreDepto", deptoNombre);
                            cmdD.Parameters.AddWithValue("@descDepto", descDepto);
                            await cmdD.ExecuteNonQueryAsync();
                        }

                        string queryPuesto = "INSERT INTO tbl_puestos (id_puesto, nombre_puesto, descripcion_puesto, salario_base, estado_puesto, id_departamento) VALUES (@idPuesto, @nombrePuesto, @descPuesto, @salarioPuesto, true, @idDepto);";
                        using (MySqlCommand cmdP = new MySqlCommand(queryPuesto, con, tran))
                        {
                            cmdP.Parameters.AddWithValue("@idPuesto", idComun);
                            cmdP.Parameters.AddWithValue("@nombrePuesto", puestoNombre);
                            cmdP.Parameters.AddWithValue("@descPuesto", descPuesto);
                            cmdP.Parameters.AddWithValue("@salarioPuesto", salarioBase);
                            cmdP.Parameters.AddWithValue("@idDepto", idComun);
                            await cmdP.ExecuteNonQueryAsync();
                        }

                        string queryEmp = @"INSERT INTO tbl_empleados 
                                   (id_empleado, dpi_emp, nit_emp, nombre_emp, apellido_emp, fecha_nacimiento, direccion_emp, fecha_contratacion, estado_emp, id_puesto) 
                                   VALUES (@idEmp, @dpi, @nit, @nombre, @apellido, @fNac, @direccion, @fCont, @estado, @idPuestoEmp);";

                        using (MySqlCommand cmdE = new MySqlCommand(queryEmp, con, tran))
                        {
                            cmdE.Parameters.AddWithValue("@idEmp", idComun);
                            cmdE.Parameters.AddWithValue("@dpi", Txt_identificacion.Text.Trim());
                            cmdE.Parameters.AddWithValue("@nit", Txt_nit.Text.Trim());
                            cmdE.Parameters.AddWithValue("@nombre", Txt_nombre.Text.Trim());
                            cmdE.Parameters.AddWithValue("@apellido", Txt_apellidos.Text.Trim());
                            cmdE.Parameters.AddWithValue("@fNac", Dtp_fechnacimiento.Value.ToString("yyyy-MM-dd"));
                            cmdE.Parameters.AddWithValue("@direccion", Txt_direccion.Text.Trim());
                            cmdE.Parameters.AddWithValue("@fCont", Dtp_fechcontratacion.Value.ToString("yyyy-MM-dd"));
                            cmdE.Parameters.AddWithValue("@estado", Cbo_estado.SelectedItem?.ToString() ?? "activo");
                            cmdE.Parameters.AddWithValue("@idPuestoEmp", idComun);

                            await cmdE.ExecuteNonQueryAsync();
                        }

                        await GuardarContactoAsync(con, tran, idComun);

                        tran.Commit();

                        Bitacora.Registrar(
                            "Registro de empleado",
                            SesionUsuario.Usuario +
                            " registró al empleado " +
                            Txt_nombre.Text.Trim() + " " +
                            Txt_apellidos.Text.Trim() +
                            " con ID " + idComun + "."
                        );

                        MessageBox.Show(
                            $"Empleado guardado con éxito con el ID: {idComun}",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        EstablecerEstadoInicial();
                        await CargarTablaEmpleadosAsync();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error al guardar en la BD: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private async Task ActualizarEmpleadoAsync()
        {
            using (MySqlConnection con = ConexionBD.ObtenerConexion())
            {
                await con.OpenAsync();
                using (MySqlTransaction tran = con.BeginTransaction())
                {
                    try
                    {
                        int idComun = Convert.ToInt32(Txt_idempleado.Text.Trim());

                        string deptoNombre = Cbo_Departamento.SelectedItem?.ToString() ?? "General";
                        string puestoNombre = Cbo_puesto.SelectedItem?.ToString() ?? "General";

                        string descDepto = descripcionesDepartamentos.ContainsKey(deptoNombre) ? descripcionesDepartamentos[deptoNombre] : "Sin descripción";
                        string descPuesto = descripcionesPuestos.ContainsKey(puestoNombre) ? descripcionesPuestos[puestoNombre] : "Sin descripción";

                        decimal salarioBase = 0;
                        decimal.TryParse(Txt_salario.Text.Trim(), out salarioBase);

                        // 1. Actualizar tbl_departamentos
                        string qDepto = "UPDATE tbl_departamentos SET nombre_depto = @nombre, descripcion_depto = @desc WHERE id_departamento = @id";
                        using (MySqlCommand cmdD = new MySqlCommand(qDepto, con, tran))
                        {
                            cmdD.Parameters.AddWithValue("@nombre", deptoNombre);
                            cmdD.Parameters.AddWithValue("@desc", descDepto);
                            cmdD.Parameters.AddWithValue("@id", idComun);
                            await cmdD.ExecuteNonQueryAsync();
                        }

                        // 2. Actualizar tbl_puestos
                        string qPuesto = "UPDATE tbl_puestos SET nombre_puesto = @nombre, descripcion_puesto = @desc, salario_base = @salario WHERE id_puesto = @id";
                        using (MySqlCommand cmdP = new MySqlCommand(qPuesto, con, tran))
                        {
                            cmdP.Parameters.AddWithValue("@nombre", puestoNombre);
                            cmdP.Parameters.AddWithValue("@desc", descPuesto);
                            cmdP.Parameters.AddWithValue("@salario", salarioBase);
                            cmdP.Parameters.AddWithValue("@id", idComun);
                            await cmdP.ExecuteNonQueryAsync();
                        }

                        // 3. Actualizar tbl_empleados
                        string qEmp = @"UPDATE tbl_empleados 
                                        SET dpi_emp = @dpi,
                                            nit_emp = @nit,
                                            nombre_emp = @nombre,
                                            apellido_emp = @apellido,
                                            fecha_nacimiento = @fNac,
                                            direccion_emp = @direccion,
                                            fecha_contratacion = @fCont,
                                            estado_emp = @estado,
                                            id_puesto = @idPuesto
                                        WHERE id_empleado = @idEmp";

                        using (MySqlCommand cmdE = new MySqlCommand(qEmp, con, tran))
                        {
                            cmdE.Parameters.AddWithValue("@dpi", Txt_identificacion.Text.Trim());
                            cmdE.Parameters.AddWithValue("@nit", Txt_nit.Text.Trim());
                            cmdE.Parameters.AddWithValue("@nombre", Txt_nombre.Text.Trim());
                            cmdE.Parameters.AddWithValue("@apellido", Txt_apellidos.Text.Trim());
                            cmdE.Parameters.AddWithValue("@fNac", Dtp_fechnacimiento.Value.ToString("yyyy-MM-dd"));
                            cmdE.Parameters.AddWithValue("@direccion", Txt_direccion.Text.Trim());
                            cmdE.Parameters.AddWithValue("@fCont", Dtp_fechcontratacion.Value.ToString("yyyy-MM-dd"));
                            cmdE.Parameters.AddWithValue("@estado", Cbo_estado.SelectedItem?.ToString() ?? "activo");
                            cmdE.Parameters.AddWithValue("@idPuesto", idComun);
                            cmdE.Parameters.AddWithValue("@idEmp", idComun);
                            await cmdE.ExecuteNonQueryAsync();
                        }

                        await ActualizarContactoAsync(con, tran, idComun);

                        tran.Commit();

                        Bitacora.Registrar(
                            "Modificación de empleado",
                            SesionUsuario.Usuario +
                            " modificó al empleado " +
                            Txt_nombre.Text.Trim() + " " +
                            Txt_apellidos.Text.Trim() +
                            " con ID " + idComun + "."
                        );

                        MessageBox.Show(
                            "Información del Empleado, Departamento y Puesto actualizada correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        EstablecerEstadoInicial();
                        await CargarTablaEmpleadosAsync();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error al actualizar en la BD: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async Task GuardarContactoAsync(MySqlConnection con, MySqlTransaction tran, int idEmpleado)
        {
            if (!string.IsNullOrEmpty(Txt_telefono.Text.Trim()))
            {
                string queryTel = "INSERT INTO tbl_telefonos (numero_tel, id_empleado) VALUES (@tel, @idEmp)";
                using (MySqlCommand cmd = new MySqlCommand(queryTel, con, tran))
                {
                    cmd.Parameters.AddWithValue("@tel", Txt_telefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@idEmp", idEmpleado);
                    await cmd.ExecuteNonQueryAsync();
                }
            }

            if (!string.IsNullOrEmpty(Txt_correo.Text.Trim()))
            {
                string queryCor = "INSERT INTO tbl_correos (correo, id_empleado) VALUES (@correo, @idEmp)";
                using (MySqlCommand cmd = new MySqlCommand(queryCor, con, tran))
                {
                    cmd.Parameters.AddWithValue("@correo", Txt_correo.Text.Trim());
                    cmd.Parameters.AddWithValue("@idEmp", idEmpleado);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        private async Task ActualizarContactoAsync(MySqlConnection con, MySqlTransaction tran, int idEmpleado)
        {
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_telefonos WHERE id_empleado = @id", con, tran))
            {
                cmd.Parameters.AddWithValue("@id", idEmpleado);
                await cmd.ExecuteNonQueryAsync();
            }

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_correos WHERE id_empleado = @id", con, tran))
            {
                cmd.Parameters.AddWithValue("@id", idEmpleado);
                await cmd.ExecuteNonQueryAsync();
            }

            await GuardarContactoAsync(con, tran, idEmpleado);
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            EstablecerEstadoInicial();
        }

        #endregion

        #region Carga de Detalles desde DataGridView

        private async void Dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Dgv_empleados.Rows[e.RowIndex];
                if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out int idEmpleado))
                {
                    await CargarDetallesEmpleadoAsync(idEmpleado);
                }
            }
        }

        private async Task CargarDetallesEmpleadoAsync(int idEmpleado)
        {
            try
            {
                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    await con.OpenAsync();
                    string query = @"SELECT e.*, d.nombre_depto AS departamento, p.nombre_puesto AS puesto, p.salario_base AS salario
                                     FROM tbl_empleados e
                                     INNER JOIN tbl_puestos p ON e.id_puesto = p.id_puesto
                                     INNER JOIN tbl_departamentos d ON p.id_departamento = d.id_departamento
                                     WHERE e.id_empleado = @id";

                    string idStr = "", dpi = "", nit = "", nombre = "", apellido = "", direccion = "", salario = "", depto = "", puesto = "", estado = "";
                    DateTime fNac = DateTime.Now, fCont = DateTime.Now;
                    bool encontrado = false;

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idEmpleado);
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                idStr = reader["id_empleado"].ToString();
                                dpi = reader["dpi_emp"].ToString();
                                nit = reader["nit_emp"] != DBNull.Value ? reader["nit_emp"].ToString() : "";
                                nombre = reader["nombre_emp"].ToString();
                                apellido = reader["apellido_emp"].ToString();
                                direccion = reader["direccion_emp"].ToString();
                                salario = reader["salario"].ToString();

                                if (reader["fecha_nacimiento"] != DBNull.Value)
                                    fNac = Convert.ToDateTime(reader["fecha_nacimiento"]);

                                if (reader["fecha_contratacion"] != DBNull.Value)
                                    fCont = Convert.ToDateTime(reader["fecha_contratacion"]);

                                depto = reader["departamento"].ToString();
                                puesto = reader["puesto"].ToString();
                                estado = reader["estado_emp"] != DBNull.Value ? reader["estado_emp"].ToString() : "activo";

                                encontrado = true;
                            }
                        }
                    }

                    if (encontrado)
                    {
                        string telefono = await ObtenerTelefonoEmpleadoAsync(idEmpleado, con);
                        string correo = await ObtenerCorreoEmpleadoAsync(idEmpleado, con);

                        BloquearControles(false);

                        LlenarCamposFormulario(
                            idStr, dpi, nit, nombre, apellido,
                            direccion, salario, fNac, fCont,
                            depto, puesto, estado, telefono, correo
                        );

                        esEdicion = true;
                        esNuevo = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener detalles del empleado: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos Vacíos

        private void Txt_nombre_TextChanged(object sender, EventArgs e) { }
        private void Txt_apellidos_TextChanged(object sender, EventArgs e) { }
        private void Txt_identificacion_TextChanged(object sender, EventArgs e) { }
        private void Txt_nit_TextChanged(object sender, EventArgs e) { }
        private void Txt_telefono_TextChanged(object sender, EventArgs e) { }
        private void Txt_direccion_TextChanged(object sender, EventArgs e) { }
        private void Txt_correo_TextChanged(object sender, EventArgs e) { }
        private void Txt_salario_TextChanged(object sender, EventArgs e) { }
        private void Dtp_fechnacimiento_ValueChanged(object sender, EventArgs e) { }
        private void Dtp_fechcontratacion_ValueChanged(object sender, EventArgs e) { }
        private void Lbl_departamento(object sender, EventArgs e) { }
        private void Txt_iddepartamento_TextChanged(object sender, EventArgs e) { }
        private void Txt_idpuesto_TextChanged(object sender, EventArgs e) { }
        private void Cbo_estado_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Cbo_puesto_SelectedIndexChanged(object sender, EventArgs e) { }

        #endregion

        private async void Btn_eliminar_Click(object sender, EventArgs e)
        {
            FormularioPermisos permiso = GestionarPermisos.ObtenerPermiso("FormNuevoregistro");
            if (!permiso.Eliminar)
            {
                MessageBox.Show("No tiene permisos para eliminar registros del sistema.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Si el cuadro de texto del ID está bloqueado o deshabilitado, se desbloquea para ingresar el ID
            if (!Txt_idempleado.Enabled || Txt_idempleado.ReadOnly)
            {
                Txt_idempleado.Enabled = true;
                Txt_idempleado.ReadOnly = false;
                Txt_idempleado.Clear();
                Txt_idempleado.Focus();
                MessageBox.Show("Ingrese el ID del empleado a eliminar y presione nuevamente el botón 'Eliminar'.", "Ingrese ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string inputId = Txt_idempleado.Text.Trim();

            if (string.IsNullOrWhiteSpace(inputId) || !int.TryParse(inputId, out int idEmpleado))
            {
                MessageBox.Show("Debe ingresar un ID de empleado válido.", "ID Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_idempleado.Focus();
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar al empleado con ID {idEmpleado}?\n\nEsta acción es permanente y no podrá recuperar los datos.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection con = ConexionBD.ObtenerConexion())
                {
                    await con.OpenAsync();
                    using (MySqlTransaction tran = con.BeginTransaction())
                    {
                        try
                        {
                            string qCheck = "SELECT nombre_emp, apellido_emp FROM tbl_empleados WHERE id_empleado = @id;";
                            string nombreCompleto = "";

                            using (MySqlCommand cmdCheck = new MySqlCommand(qCheck, con, tran))
                            {
                                cmdCheck.Parameters.AddWithValue("@id", idEmpleado);
                                using (var reader = await cmdCheck.ExecuteReaderAsync())
                                {
                                    if (await reader.ReadAsync())
                                    {
                                        nombreCompleto = $"{reader["nombre_emp"]} {reader["apellido_emp"]}";
                                    }
                                    else
                                    {
                                        MessageBox.Show($"No se encontró ningún empleado registrado con el ID {idEmpleado}.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        tran.Rollback();
                                        return;
                                    }
                                }
                            }

                            using (MySqlCommand cmdTel = new MySqlCommand("DELETE FROM tbl_telefonos WHERE id_empleado = @id;", con, tran))
                            {
                                cmdTel.Parameters.AddWithValue("@id", idEmpleado);
                                await cmdTel.ExecuteNonQueryAsync();
                            }

                            using (MySqlCommand cmdCor = new MySqlCommand("DELETE FROM tbl_correos WHERE id_empleado = @id;", con, tran))
                            {
                                cmdCor.Parameters.AddWithValue("@id", idEmpleado);
                                await cmdCor.ExecuteNonQueryAsync();
                            }

                            using (MySqlCommand cmdEmp = new MySqlCommand("DELETE FROM tbl_empleados WHERE id_empleado = @id;", con, tran))
                            {
                                cmdEmp.Parameters.AddWithValue("@id", idEmpleado);
                                await cmdEmp.ExecuteNonQueryAsync();
                            }

                            using (MySqlCommand cmdPuesto = new MySqlCommand("DELETE FROM tbl_puestos WHERE id_puesto = @id;", con, tran))
                            {
                                cmdPuesto.Parameters.AddWithValue("@id", idEmpleado);
                                await cmdPuesto.ExecuteNonQueryAsync();
                            }

                            using (MySqlCommand cmdDepto = new MySqlCommand("DELETE FROM tbl_departamentos WHERE id_departamento = @id;", con, tran))
                            {
                                cmdDepto.Parameters.AddWithValue("@id", idEmpleado);
                                await cmdDepto.ExecuteNonQueryAsync();
                            }

                            tran.Commit();

                            Bitacora.Registrar("Eliminación de empleado", $"{SesionUsuario.Usuario} eliminó al empleado {nombreCompleto} (ID: {idEmpleado}).");

                            MessageBox.Show($"El empleado '{nombreCompleto}' ha sido eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            EstablecerEstadoInicial();
                            await CargarTablaEmpleadosAsync();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lbl_direccion_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_fechnacimiento_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_fechcontartacion_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Departamento_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_idregistro_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_estado_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_nit_Click(object sender, EventArgs e)
        {

        }
    }
}