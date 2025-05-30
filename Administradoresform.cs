using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fundacion_Animales
{
    public partial class Administradoresform : Form
    {
        SqlConnection con = new SqlConnection();
        public Administradoresform()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.Controls.Count > 0)
                this.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            this.Tag = f;
            f.Show();

        }

        public void llenarTablas()
        {

            string Consulta = "select * from Usuario where rol = 'Administrador';";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta, con);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dgvAdministradores.DataSource = dt;



        }
        private void ConfigurarDataGridView()
        {
            dgvAdministradores.ReadOnly = true;
            dgvAdministradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdministradores.MultiSelect = false;
            dgvAdministradores.AllowUserToAddRows = false;
            dgvAdministradores.AllowUserToDeleteRows = false;
            dgvAdministradores.AllowUserToResizeRows = false;
            dgvAdministradores.AllowUserToResizeColumns = false;
            dgvAdministradores.Enabled = true;

            dgvAdministradores.ClearSelection();
        }

        private void Administradoresform_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            llenarTablas();
            ConfigurarDataGridView();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AgregarAdministradorForm agregarAdmin = new AgregarAdministradorForm();
            loadForm(agregarAdmin);
        }



        //esta parte del codigo esta bugueada 
        private void btnActualiar_Click(object sender, EventArgs e)
        {
            if (dgvAdministradores.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow fila = dgvAdministradores.SelectedRows[0];

                    int id = Convert.ToInt32(fila.Cells["id_usuario"].Value);
                    string nombre_usuario = fila.Cells["nombre_usuario"].Value.ToString();
                    string loginName = fila.Cells["loginName"].Value.ToString();
                    string contraseña = fila.Cells["contrasena_hash"].Value.ToString();
                    string rol = fila.Cells["rol"].Value.ToString();
                    string estado = fila.Cells["estado"].Value.ToString();
                    DateTime fechaCreacion = fila.Cells["fecha_creacion"].Value != DBNull.Value ? Convert.ToDateTime(fila.Cells["fecha_creacion"].Value) : DateTime.MinValue;
                    string Correo = fila.Cells["correo"].Value.ToString();
                    string direccion = fila.Cells["direccion"].Value.ToString();
                    string telefono = fila.Cells["telefono"].Value.ToString();
                    byte[] foto = fila.Cells["foto"].Value != DBNull.Value ? (byte[])fila.Cells["foto"].Value : null;

                    Usuarios CapturarDatos = new Usuarios();
                    CapturarDatos.GuardarDatos(id, nombre_usuario, loginName, contraseña, rol, estado, fechaCreacion, Correo, direccion, telefono, foto);

                    ActualizarAdministradoresform actualizarFORM = new ActualizarAdministradoresform(CapturarDatos);
                    actualizarFORM.FormClosed += (s, args) =>
                    {
                        // Recargas el formulario que quieras mostrar después
                        administracion_animalesForm formInicio = new administracion_animalesForm();
                        loadForm(formInicio);
                    };
                    loadForm(actualizarFORM);



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar los datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
                this.Close();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAdministradores.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvAdministradores.SelectedRows[0];

                int id_usuario = Convert.ToInt32(fila.Cells["id_usuario"].Value);
                string nombre_usuario = fila.Cells["nombre_usuario"].Value.ToString();
                string loginName = fila.Cells["loginName"].Value.ToString();
                string contrasena_hash = fila.Cells["contrasena_hash"].Value.ToString();
                string rol = fila.Cells["rol"].Value.ToString();
                string estado = fila.Cells["estado"].Value.ToString();
                DateTime fecha_creacion = DateTime.Now;
                string correo = fila.Cells["correo"].Value.ToString();
                string direccion = fila.Cells["direccion"].Value.ToString();
                string telefono = fila.Cells["telefono"].Value.ToString();
                byte[] foto = fila.Cells["foto"].Value as byte[];

                Usuarios usuarios = new Usuarios();
                usuarios.GuardarDatos(id_usuario, nombre_usuario, loginName, contrasena_hash, rol, estado, fecha_creacion, correo, direccion, telefono, foto);

                SqlCommand proc = new SqlCommand("sp_EliminarUsuario", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@id_usuario", usuarios.Id_usuario);

                try
                {
                    proc.ExecuteNonQuery();
                    MessageBox.Show("Se modificaron los datos correctamente");
                    llenarTablas();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificaron los datos: " + ex.Message);
                    MessageBox.Show("Revisa bien los datos ingresados");
                }

            }
            else
            {
                // No se ha seleccionado ninguna fila
                MessageBox.Show("Por favor, seleccione una fila.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
