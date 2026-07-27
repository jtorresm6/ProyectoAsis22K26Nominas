using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//Parte trabajada por: Natali Sofia Montenegro Portillo - Carné: 0901-23-10017
//Curso:Análsis de Sistemas II
//Fecha de creación: 25-07-2026
//Fecha de última modificación: 27-07-2026


namespace ProyectoAsis22K26Nominas
{
        public partial class FormMantenimientoEmpleado : Form
    {
        private int codigoEmpleado = 0;
        public FormMantenimientoEmpleado()
        {
            InitializeComponent();
        }

        // Colocar características a los elementos del formulario al momento de cargarlo, para que por ejemplo
        // los botones de modificar o guardar no puedan ser presionados hasta que se busque un empleado
        // o se tenga información en los campos.
        private void FormMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            Cbo_Busqueda.Items.Clear();

            Cbo_Busqueda.Items.Add("Código");
            Cbo_Busqueda.Items.Add("DPI");
            Cbo_Busqueda.Items.Add("NIT");

            Cbo_Busqueda.SelectedIndex = 0;
            Cbo_Busqueda.DropDownStyle = ComboBoxStyle.DropDownList;

            Dtp_Fecha_Nac.Format = DateTimePickerFormat.Custom;
            Dtp_Fecha_Nac.CustomFormat = "yyyy-MM-dd";

            Dtp_Fecha_Cont.Format = DateTimePickerFormat.Custom;
            Dtp_Fecha_Cont.CustomFormat = "yyyy-MM-dd";

            Btn_Actu.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Bajas.Enabled = false;
            Btn_Reactivar.Enabled = false;

            Txt_Estado.ReadOnly = true;

        }

            private void label1_Click(object sender, EventArgs e)
            {
            }

            private void label3_Click(object sender, EventArgs e)
            {
            }

            private void label4_Click(object sender, EventArgs e)
            {
            }

          private void dataGridView1_CellContentClick_1(
                object sender,
                DataGridViewCellEventArgs e)
            {
            }

        //Habilitar campos o mostrarlos cuando se presiona el botón de buscar
        private void button2_Click(object sender, EventArgs e)
        {
            if (codigoEmpleado == 0)
            {
                MessageBox.Show("Primero debe buscar un empleado.");
                return;
            }

            Txt_DPI.Enabled = true;
            Txt_NIT.Enabled = true;
            Txt_Nombre.Enabled = true;
            Txt_Apellido.Enabled = true;
            Dtp_Fecha_Nac.Enabled = true;
            Txt_Dir.Enabled = true;
            Txt_Tel.Enabled = true;
            Txt_Corr.Enabled = true;
            Dtp_Fecha_Cont.Enabled = true;
            Txt_Dep.Enabled = true;
            Txt_Puesto.Enabled = true;

            // Estos campos no se pueden modificar, aparecerán deshabilitados. 
            // Solo estado puede ser modificado mediante los botones de dar de baja o reactivar.
            Txt_Cod.Enabled = false;
            Txt_Estado.Enabled = false;


            Btn_Guardar.Enabled = true;
            Btn_Actu.Enabled = false;
            Btn_Bajas.Enabled = false;
            Btn_Reactivar.Enabled = false;

            Txt_DPI.Focus();

            MessageBox.Show("Ahora se pueden modificar los datos del empleado.");
        }


        //Este botón ayuda a editar el estado del empleado a "Activo" cuando se presiona el botón de reactivar,
        //en vez de escribirlo manual.
        private void button4_Click(object sender, EventArgs e)
        {
            if (codigoEmpleado == 0)
            {
                MessageBox.Show("Primero debe buscar un empleado.");
                return;
            }

            if (Txt_Estado.Text == "Activo")
            {
                MessageBox.Show("El empleado ya se encuentra activo.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de reactivar al empleado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            MySqlConnection conexion = ConexionBD.GetConnection();

            try
            {
                conexion.Open();

                string sql =
                    "UPDATE tbl_Empleados " +
                    "SET cmp_estado = 'Activo' " +
                    "WHERE cmp_id_empleado = @codigo";

                MySqlCommand comando =
                    new MySqlCommand(sql, conexion);

                comando.Parameters.AddWithValue(
                    "@codigo",
                    codigoEmpleado
                );

                comando.ExecuteNonQuery();

                Txt_Estado.Text = "Activo";

                MessageBox.Show(
                    "Empleado reactivado correctamente."
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al reactivar: " + ex.Message
                );
            }
            finally
            {
                conexion.Close();
            }
        }

        // Funcion para bloquear campos y que no puedan ser modificados hasta que se presione el botón de modificar.
        private void BloquearCampos()
        {
            Txt_Cod.Enabled = false;
            Txt_DPI.Enabled = false;
            Txt_NIT.Enabled = false;
            Txt_Nombre.Enabled = false;
            Txt_Apellido.Enabled = false;
            Dtp_Fecha_Nac.Enabled = false;
            Txt_Dir.Enabled = false;
            Txt_Tel.Enabled = false;
            Txt_Corr.Enabled = false;
            Dtp_Fecha_Cont.Enabled = false;
            Txt_Dep.Enabled = false;
            Txt_Puesto.Enabled = false;
            Txt_Estado.Enabled = false;
        }


        // Este botón ayuda a buscar un empleado mostrando sus datos que estén almacenados en la BD.
        // Para que funcione se debe seleccionar el tipo de dato que se desea buscar y manda a llamar un select a la BD
        // para que muestre los datos en los campos correspondientes. 

        //SI NO HAY DATOS QUE COINCIDAN CON BD, MUESTRA MENSAJE DE ERROR.
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Txt_Datos.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el dato que desea buscar.");
                return;
            }

            string campo = "";

            if (Cbo_Busqueda.Text == "Código")
            {
                campo = "e.cmp_id_empleado";
            }
            else if (Cbo_Busqueda.Text == "DPI")
            {
                campo = "e.cmp_dpi";
            }
            else if (Cbo_Busqueda.Text == "NIT")
            {
                campo = "e.cmp_nit";
            }

            string sql =
                "select e.*, d.cmp_nombre as Departamento, p.cmp_nombre as Puesto, t.cmp_telefono as Telefono, c.cmp_correo as Correo " +
                "from tbl_Empleados e " +
                "inner join tbl_Departamentos d on e.cmp_id_departamento = d.cmp_id_departamento " +
                "inner join tbl_Puestos p on e.cmp_id_puesto = p.cmp_id_puesto " +
                "left join tbl_Telefonos t on e.cmp_id_empleado = t.cmp_id_empleado " +
                "left join tbl_Correos c on e.cmp_id_empleado = c.cmp_id_empleado " +
                "where " + campo + " = @dato";

            MySqlConnection conexion = ConexionBD.GetConnection();

            try
            {
                conexion.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@dato", Txt_Datos.Text.Trim());

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    codigoEmpleado = Convert.ToInt32(
                        lector["cmp_id_empleado"]
                    );

                    Txt_Cod.Text =
                        lector["cmp_id_empleado"].ToString();

                    Txt_DPI.Text =
                        lector["cmp_dpi"].ToString();

                    Txt_NIT.Text =
                        lector["cmp_nit"].ToString();

                    Txt_Nombre.Text =
                        lector["cmp_nombre"].ToString();

                    Txt_Apellido.Text =
                        lector["cmp_apellido"].ToString();

                    Dtp_Fecha_Nac.Value =
                        Convert.ToDateTime(
                        lector["cmp_fecha_nacimiento"]
                        );

                    Txt_Dir.Text =
                        lector["cmp_direccion"].ToString();

                    Txt_Tel.Text =
                        lector["Telefono"].ToString();

                    Txt_Corr.Text =
                        lector["Correo"].ToString();

                    Dtp_Fecha_Cont.Value =
                        Convert.ToDateTime(
                        lector["cmp_fecha_contratacion"]
                    );

                    Txt_Dep.Text =
                        lector["Departamento"].ToString();

                    Txt_Puesto.Text =
                        lector["Puesto"].ToString();

                    Txt_Estado.Text =
                        lector["cmp_estado"].ToString();


                    BloquearCampos();

                    Btn_Actu.Enabled = true;
                    Btn_Bajas.Enabled = true;
                    Btn_Reactivar.Enabled = true;
                    Btn_Guardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado.");
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar al empleado: " + ex.Message
                );
            }
            finally
            {
                conexion.Close();
            }
        }

        // Boton que permite guardar los cambios realizados en los campos del formulario y de igualmanera
        // se modifica tambien en la BD.

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (codigoEmpleado == 0)
            {
                MessageBox.Show("No hay un empleado seleccionado.");
                return;
            }

            if (Txt_DPI.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el DPI.");
                Txt_DPI.Focus();
                return;
            }

            if (Txt_Nombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre.");
                Txt_Nombre.Focus();
                return;
            }

            if (Txt_Apellido.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el apellido.");
                Txt_Apellido.Focus();
                return;
            }

            if (Txt_Dep.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el departamento.");
                Txt_Dep.Focus();
                return;
            }

            if (Txt_Puesto.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el puesto.");
                Txt_Puesto.Focus();
                return;
            }

            string sqlEmpleado =
                "update tbl_Empleados set " +
                "cmp_dpi = @dpi, " +
                "cmp_nit = @nit, " +
                "cmp_nombre = @nombre, " +
                "cmp_apellido = @apellido, " +
                "cmp_fecha_nacimiento = @fechaNacimiento, " +
                "cmp_direccion = @direccion, " +
                "cmp_fecha_contratacion = @fechaContratacion, " +
                "cmp_id_departamento = (select cmp_id_departamento from tbl_Departamentos where cmp_nombre = @departamento), " +
                "cmp_id_puesto = (select cmp_id_puesto from tbl_Puestos where cmp_nombre = @puesto) " +
                "where cmp_id_empleado = @codigo";

            MySqlConnection conexion = ConexionBD.GetConnection();

            try
            {
                conexion.Open();

                MySqlCommand comando =
                    new MySqlCommand(sqlEmpleado, conexion);

                comando.Parameters.AddWithValue(
                    "@dpi",
                    Txt_DPI.Text.Trim()
                );

                comando.Parameters.AddWithValue(
                    "@nit",
                    Txt_NIT.Text.Trim()
                );

                comando.Parameters.AddWithValue(
                    "@nombre",
                    Txt_Nombre.Text.Trim()
                );

                comando.Parameters.AddWithValue(
                    "@apellido",
                    Txt_Apellido.Text.Trim()
                );

                comando.Parameters.AddWithValue(
                    "@fechaNacimiento",
                    Dtp_Fecha_Nac.Value.Date
                );

                comando.Parameters.AddWithValue(
                    "@direccion",
                    Txt_Dir.Text.Trim()
                );

                comando.Parameters.AddWithValue(
                    "@fechaContratacion",
                    Dtp_Fecha_Cont.Value.Date
                );

                comando.Parameters.AddWithValue(
                    "@departamento",
                    Txt_Dep.Text.Trim()
                );

                comando.Parameters.AddWithValue(
                    "@puesto",
                    Txt_Puesto.Text.Trim()
                );

                comando.Parameters.AddWithValue(
                    "@codigo",
                    codigoEmpleado
                );

                int filasModificadas = comando.ExecuteNonQuery();

                if (filasModificadas > 0)
                {
                    MessageBox.Show(
                        "Datos personales y laborales actualizados correctamente."
                    );

                    BloquearCampos();

                    Btn_Guardar.Enabled = false;
                    Btn_Actu.Enabled = true;

                    if (Txt_Estado.Text == "Activo")
                    {
                        Btn_Bajas.Enabled = true;
                        Btn_Reactivar.Enabled = false;
                    }
                    else
                    {
                        Btn_Bajas.Enabled = false;
                        Btn_Reactivar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No se modificó ningún registro."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar los cambios: " + ex.Message
                );
            }
            finally
            {
                conexion.Close();
            }
        }

        //Este botón, a diferencia, ayuda a editar el estado del empleado a "Inactivo" cuando se presiona el botón de dar de baja,
        //en vez de escribirlo manual.
        private void Btn_Bajas_Click(object sender, EventArgs e)
        {
            if (codigoEmpleado == 0)
            {
                MessageBox.Show("Primero debe buscar un empleado.");
                return;
            }

            if (Txt_Estado.Text == "Inactivo")
            {
                MessageBox.Show("El empleado ya se encuentra inactivo.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de dar de baja al empleado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            MySqlConnection conexion = ConexionBD.GetConnection();

            try
            {
                conexion.Open();

                string sql =
                    "UPDATE tbl_Empleados " +
                    "SET cmp_estado = 'Inactivo' " +
                    "WHERE cmp_id_empleado = @codigo";

                MySqlCommand comando =
                    new MySqlCommand(sql, conexion);

                comando.Parameters.AddWithValue(
                    "@codigo",
                    codigoEmpleado
                );

                comando.ExecuteNonQuery();

                Txt_Estado.Text = "Inactivo";

                MessageBox.Show(
                    "Empleado dado de baja correctamente."
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al dar de baja: " + ex.Message
                );
            }
            finally
            {
                conexion.Close();
            }
        }

        //Cancela la edición de los campos por si ocurre un error o no se deseaba cambiar los datos.
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            BloquearCampos();
            BloquearCampos();

            Btn_Guardar.Enabled = false;
            Btn_Actu.Enabled = true;

            if (Txt_Estado.Text == "Activo")
            {
                Btn_Bajas.Enabled = true;
                Btn_Reactivar.Enabled = false;
            }
            else
            {
                Btn_Bajas.Enabled = false;
                Btn_Reactivar.Enabled = true;
            }

            MessageBox.Show("Edición cancelada.");
        }

        //Limpia todos los campos del formulario y reinicia el estado de los botones.
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Datos.Clear();

            Txt_Cod.Clear();
            Txt_DPI.Clear();
            Txt_NIT.Clear();
            Txt_Nombre.Clear();
            Txt_Apellido.Clear();
            Txt_Dir.Clear();
            Txt_Tel.Clear();
            Txt_Corr.Clear();
            Txt_Dep.Clear();
            Txt_Puesto.Clear();
            Txt_Estado.Clear();

            codigoEmpleado = 0;

            Btn_Actu.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Bajas.Enabled = false;
            Btn_Reactivar.Enabled = false;

            Txt_Datos.Focus();
        }

        private void Txt_Dir_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Cod_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Dep_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dtp_Fecha_Nac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Corr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_DPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Puesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dtp_Fecha_Cont_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Info_Laboral_Click(object sender, EventArgs e)
        {

        }
    }
 }
    



      

    
