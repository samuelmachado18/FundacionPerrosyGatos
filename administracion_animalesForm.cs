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

namespace Fundacion_Animales
{
    public partial class administracion_animalesForm : Form
    {
        SqlConnection con = new SqlConnection();

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
        public administracion_animalesForm()
        {
            InitializeComponent();

        }



        private void administracion_animalesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            llenarTablas();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            insertAnimalForm insertAnimalform = new insertAnimalForm();
            insertAnimalform.FormClosed += (s, args) =>
            {
                // Recargas el formulario que quieras mostrar después
                administracion_animalesForm formInicio = new administracion_animalesForm();
                loadForm(formInicio);
            };
            loadForm(insertAnimalform);


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void dgvAdministracionAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void llenarTablas()
        {

            string Consulta = "select * from Animal";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta, con);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dgvAdministracionAnimal.DataSource = dt;
            dgvAdministracionAnimal.ClearSelection();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAdministracionAnimal.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvAdministracionAnimal.SelectedRows[0];

                int id = Convert.ToInt32(fila.Cells["id_animal"].Value);
                string nombre = fila.Cells["nombre"].Value.ToString();
                string especie = fila.Cells["especie"].Value.ToString();
                string raza = fila.Cells["raza"].Value.ToString();
                string sexo = fila.Cells["sexo"].Value.ToString();
                DateTime fechaNacimiento = Convert.ToDateTime(fila.Cells["fecha_nacimiento"].Value);
                DateTime fechaIngreso = Convert.ToDateTime(fila.Cells["fecha_ingreso"].Value);
                string estado = fila.Cells["estado"].Value.ToString();
                byte[] foto = fila.Cells["foto"].Value as byte[];

                Animal CapturarDatos = new Animal();
                CapturarDatos.GuardarDatos(id, nombre, especie, raza, sexo, fechaNacimiento, fechaIngreso, estado, foto);

                ActualizarAnimalesForm actualizarFORM = new ActualizarAnimalesForm(CapturarDatos);
                actualizarFORM.FormClosed += (s, args) =>
                {
                    // Recargas el formulario que quieras mostrar después
                    administracion_animalesForm formInicio = new administracion_animalesForm();
                    loadForm(formInicio);
                };
                loadForm(actualizarFORM);
            }
            else
            {
                loadForm(new administracion_animalesForm());

                MessageBox.Show("Por favor, selecciona una fila.");
            }

        }

        private void pnBotonNuevo_Resize(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAdministracionAnimal.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvAdministracionAnimal.SelectedRows[0];

                int id = Convert.ToInt32(fila.Cells["id_animal"].Value);
                string nombre = fila.Cells["nombre"].Value.ToString();
                string especie = fila.Cells["especie"].Value.ToString();
                string raza = fila.Cells["raza"].Value.ToString();
                string sexo = fila.Cells["sexo"].Value.ToString();
                DateTime fechaNacimiento = Convert.ToDateTime(fila.Cells["fecha_nacimiento"].Value);
                DateTime fechaIngreso = Convert.ToDateTime(fila.Cells["fecha_ingreso"].Value);
                string estado = fila.Cells["estado"].Value.ToString();
                byte[] foto = fila.Cells["foto"].Value as byte[];

                Animal animal = new Animal();
                animal.GuardarDatos(id, nombre, especie, raza, sexo, fechaNacimiento, fechaIngreso, estado, foto);

                SqlCommand proc = new SqlCommand("sp_EliminarAnimal", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@id_animal", animal.Id_animal);

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

        
       
       
    }
}

