using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

//Parte trabajada por: Jose Javier Torres Martinez - Carné: 0901-23-1091
//Curso: Análisis de Sistemas II
//Fecha de creación: 23-07-2026
//Fecha de última modificación: 31-07-2026

namespace ProyectoAsis22K26Nominas
{
    public partial class FormNuevoregistro : Form
    {
        private bool esEdicion = false;
        private bool esNuevo = false;

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
            Cbo_estado.Items.Add("Activo");
            Cbo_estado.Items.Add("Inactivo");
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
                                        e.cmp_id_empleado AS 'ID', 
                                        e.cmp_dpi AS 'DPI',
                                        e.cmp_nit AS 'NIT',
                                        e.cmp_nombre AS 'Nombre', 
                                        e.cmp_apellido AS 'Apellido', 
                                        e.cmp_estado AS 'Estado',
                                        d.cmp_nombre AS 'Departamento',
                                        p.cmp_nombre AS 'Puesto',
                                        p.cmp_salario_base AS 'Salario'
                                     FROM tbl_Empleados e
                                     INNER JOIN tbl_Departamentos d ON e.cmp_id_departamento = d.cmp_id_departamento
                                     INNER JOIN tbl_Puestos p ON e.cmp_id_puesto = p.cmp_id_puesto";

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

        /// <summary>
        /// Método asignador que llena todos los controles del formulario con los parámetros provistos.
        /// </summary>
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

        /// <summary>
        /// Obtiene el teléfono del empleado desde la tabla tbl_Telefonos.
        /// </summary>
        private async Task<string> ObtenerTelefonoEmpleadoAsync(int idEmpleado, MySqlConnection con)
        {
            string query = "SELECT cmp_telefono FROM tbl_Telefonos WHERE cmp_id_empleado = @id LIMIT 1;";
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", idEmpleado);
                object result = await cmd.ExecuteScalarAsync();
                return result != null && result != DBNull.Value ? result.ToString() : string.Empty;
            }
        }

        /// <summary>
        /// Obtiene el correo del empleado desde la tabla tbl_Correos.
        /// </summary>
        private async Task<string> ObtenerCorreoEmpleadoAsync(int idEmpleado, MySqlConnection con)
        {
            string query = "SELECT cmp_correo FROM tbl_Correos WHERE cmp_id_empleado = @id LIMIT 1;";
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

        /// <summary>
        /// Valida que TODOS los TextBox del formulario contengan datos.
        /// </summary>
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
            // Se realiza la validación completa de todos los campos de texto
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
                                                IFNULL((SELECT MAX(cmp_id_empleado) FROM tbl_Empleados), 0),
                                                IFNULL((SELECT MAX(cmp_id_departamento) FROM tbl_Departamentos), 0),
                                                IFNULL((SELECT MAX(cmp_id_puesto) FROM tbl_Puestos), 0)
                                               ) + 1;";

                            using (MySqlCommand cmdNext = new MySqlCommand(qNextId, con, tran))
                            {
                                idComun = Convert.ToInt32(await cmdNext.ExecuteScalarAsync());
                            }
                        }

                        // Verificación de duplicados (ID y DPI)
                        string queryCheck = @"SELECT 
                                                (SELECT COUNT(*) FROM tbl_Empleados WHERE cmp_id_empleado = @idCheck) +
                                                (SELECT COUNT(*) FROM tbl_Departamentos WHERE cmp_id_departamento = @idCheck) +
                                                (SELECT COUNT(*) FROM tbl_Puestos WHERE cmp_id_puesto = @idCheck) +
                                                (SELECT COUNT(*) FROM tbl_Empleados WHERE cmp_dpi = @dpiCheck) AS Total;";

                        using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, con, tran))
                        {
                            cmdCheck.Parameters.AddWithValue("@idCheck", idComun);
                            cmdCheck.Parameters.AddWithValue("@dpiCheck", Txt_identificacion.Text.Trim());

                            long totalCoincidencias = Convert.ToInt64(await cmdCheck.ExecuteScalarAsync());

                            if (totalCoincidencias > 0)
                            {
                                MessageBox.Show($"El ID ({idComun}) o el DPI ya existen en la base de datos. Ingrese otro.", "Registro Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        // 1. Insertar en tbl_Departamentos
                        string queryDepto = "INSERT INTO tbl_Departamentos (cmp_id_departamento, cmp_nombre, cmp_descripcion) VALUES (@idDepto, @nombreDepto, @descDepto);";
                        using (MySqlCommand cmdD = new MySqlCommand(queryDepto, con, tran))
                        {
                            cmdD.Parameters.AddWithValue("@idDepto", idComun);
                            cmdD.Parameters.AddWithValue("@nombreDepto", deptoNombre);
                            cmdD.Parameters.AddWithValue("@descDepto", descDepto);
                            await cmdD.ExecuteNonQueryAsync();
                        }

                        // 2. Insertar en tbl_Puestos
                        string queryPuesto = "INSERT INTO tbl_Puestos (cmp_id_puesto, cmp_nombre, cmp_descripcion, cmp_salario_base) VALUES (@idPuesto, @nombrePuesto, @descPuesto, @salarioPuesto);";
                        using (MySqlCommand cmdP = new MySqlCommand(queryPuesto, con, tran))
                        {
                            cmdP.Parameters.AddWithValue("@idPuesto", idComun);
                            cmdP.Parameters.AddWithValue("@nombrePuesto", puestoNombre);
                            cmdP.Parameters.AddWithValue("@descPuesto", descPuesto);
                            cmdP.Parameters.AddWithValue("@salarioPuesto", salarioBase);
                            await cmdP.ExecuteNonQueryAsync();
                        }

                        // 3. Insertar en tbl_Empleados
                        string queryEmp = @"INSERT INTO tbl_Empleados 
                                           (cmp_id_empleado, cmp_dpi, cmp_nit, cmp_nombre, cmp_apellido, cmp_fecha_nacimiento, cmp_direccion, cmp_fecha_contratacion, cmp_estado, cmp_id_departamento, cmp_id_puesto) 
                                           VALUES (@idEmp, @dpi, @nit, @nombre, @apellido, @fNac, @direccion, @fCont, @estado, @idDeptoEmp, @idPuestoEmp);";

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
                            cmdE.Parameters.AddWithValue("@estado", Cbo_estado.SelectedItem?.ToString() ?? "Activo");
                            cmdE.Parameters.AddWithValue("@idDeptoEmp", idComun);
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
                            $"Empleado, Departamento y Puesto guardados con éxito con el ID común: {idComun}",
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

                        // 1. Actualizar tbl_Departamentos
                        string qDepto = "UPDATE tbl_Departamentos SET cmp_nombre = @nombre, cmp_descripcion = @desc WHERE cmp_id_departamento = @id";
                        using (MySqlCommand cmdD = new MySqlCommand(qDepto, con, tran))
                        {
                            cmdD.Parameters.AddWithValue("@nombre", deptoNombre);
                            cmdD.Parameters.AddWithValue("@desc", descDepto);
                            cmdD.Parameters.AddWithValue("@id", idComun);
                            await cmdD.ExecuteNonQueryAsync();
                        }

                        // 2. Actualizar tbl_Puestos
                        string qPuesto = "UPDATE tbl_Puestos SET cmp_nombre = @nombre, cmp_descripcion = @desc, cmp_salario_base = @salario WHERE cmp_id_puesto = @id";
                        using (MySqlCommand cmdP = new MySqlCommand(qPuesto, con, tran))
                        {
                            cmdP.Parameters.AddWithValue("@nombre", puestoNombre);
                            cmdP.Parameters.AddWithValue("@desc", descPuesto);
                            cmdP.Parameters.AddWithValue("@salario", salarioBase);
                            cmdP.Parameters.AddWithValue("@id", idComun);
                            await cmdP.ExecuteNonQueryAsync();
                        }

                        // 3. Actualizar tbl_Empleados
                        string qEmp = @"UPDATE tbl_Empleados 
                                        SET cmp_dpi = @dpi,
                                            cmp_nit = @nit,
                                            cmp_nombre = @nombre,
                                            cmp_apellido = @apellido,
                                            cmp_fecha_nacimiento = @fNac,
                                            cmp_direccion = @direccion,
                                            cmp_fecha_contratacion = @fCont,
                                            cmp_estado = @estado,
                                            cmp_id_departamento = @idDepto,
                                            cmp_id_puesto = @idPuesto
                                        WHERE cmp_id_empleado = @idEmp";

                        using (MySqlCommand cmdE = new MySqlCommand(qEmp, con, tran))
                        {
                            cmdE.Parameters.AddWithValue("@dpi", Txt_identificacion.Text.Trim());
                            cmdE.Parameters.AddWithValue("@nit", Txt_nit.Text.Trim());
                            cmdE.Parameters.AddWithValue("@nombre", Txt_nombre.Text.Trim());
                            cmdE.Parameters.AddWithValue("@apellido", Txt_apellidos.Text.Trim());
                            cmdE.Parameters.AddWithValue("@fNac", Dtp_fechnacimiento.Value.ToString("yyyy-MM-dd"));
                            cmdE.Parameters.AddWithValue("@direccion", Txt_direccion.Text.Trim());
                            cmdE.Parameters.AddWithValue("@fCont", Dtp_fechcontratacion.Value.ToString("yyyy-MM-dd"));
                            cmdE.Parameters.AddWithValue("@estado", Cbo_estado.SelectedItem?.ToString() ?? "Activo");
                            cmdE.Parameters.AddWithValue("@idDepto", idComun);
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
                string queryTel = "INSERT INTO tbl_Telefonos (cmp_telefono, cmp_id_empleado) VALUES (@tel, @idEmp)";
                using (MySqlCommand cmd = new MySqlCommand(queryTel, con, tran))
                {
                    cmd.Parameters.AddWithValue("@tel", Txt_telefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@idEmp", idEmpleado);
                    await cmd.ExecuteNonQueryAsync();
                }
            }

            if (!string.IsNullOrEmpty(Txt_correo.Text.Trim()))
            {
                string queryCor = "INSERT INTO tbl_Correos (cmp_correo, cmp_id_empleado) VALUES (@correo, @idEmp)";
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
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_Telefonos WHERE cmp_id_empleado = @id", con, tran))
            {
                cmd.Parameters.AddWithValue("@id", idEmpleado);
                await cmd.ExecuteNonQueryAsync();
            }

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_Correos WHERE cmp_id_empleado = @id", con, tran))
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
                    string query = @"SELECT e.*, d.cmp_nombre AS departamento, p.cmp_nombre AS puesto, p.cmp_salario_base AS salario
                                     FROM tbl_Empleados e
                                     INNER JOIN tbl_Departamentos d ON e.cmp_id_departamento = d.cmp_id_departamento
                                     INNER JOIN tbl_Puestos p ON e.cmp_id_puesto = p.cmp_id_puesto
                                     WHERE e.cmp_id_empleado = @id";

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
                                idStr = reader["cmp_id_empleado"].ToString();
                                dpi = reader["cmp_dpi"].ToString();
                                nit = reader["cmp_nit"] != DBNull.Value ? reader["cmp_nit"].ToString() : "";
                                nombre = reader["cmp_nombre"].ToString();
                                apellido = reader["cmp_apellido"].ToString();
                                direccion = reader["cmp_direccion"].ToString();
                                salario = reader["salario"].ToString();

                                if (reader["cmp_fecha_nacimiento"] != DBNull.Value)
                                    fNac = Convert.ToDateTime(reader["cmp_fecha_nacimiento"]);

                                if (reader["cmp_fecha_contratacion"] != DBNull.Value)
                                    fCont = Convert.ToDateTime(reader["cmp_fecha_contratacion"]);

                                depto = reader["departamento"].ToString();
                                puesto = reader["puesto"].ToString();
                                estado = reader["cmp_estado"] != DBNull.Value ? reader["cmp_estado"].ToString() : "Activo";

                                encontrado = true;
                            }
                        }
                    }

                    if (encontrado)
                    {
                        // Obtiene teléfono y correo llamando a sus respectivos métodos
                        string telefono = await ObtenerTelefonoEmpleadoAsync(idEmpleado, con);
                        string correo = await ObtenerCorreoEmpleadoAsync(idEmpleado, con);

                        BloquearControles(false);

                        // Llena todos los campos usando el método centralizado
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
    }
}