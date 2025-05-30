using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlTypes;
using System.Runtime.Intrinsics.X86;
using System.Data.SqlClient;

namespace Fundacion_Animales
{
    public partial class insertAnimalForm : Form
    {
        SqlConnection con = new SqlConnection();
        public insertAnimalForm()
        {
            InitializeComponent();
       

            cboPersonalidad.Items.Add("Cariñoso");
            cboPersonalidad.Items.Add("Juguetón");
            cboPersonalidad.Items.Add("Tranquilo");
            cboPersonalidad.Items.Add("Sociable");
            cboPersonalidad.Items.Add("Tímido");
            cboPersonalidad.Items.Add("Independiente");
            cboPersonalidad.Items.Add("Curioso");
            cboPersonalidad.Items.Add("Inteligente");
            cboPersonalidad.Items.Add("Territorial");

            cboCaracteristicas.Items.Add("Convive con niños");
            cboCaracteristicas.Items.Add("Convive con otros animales");
            cboCaracteristicas.Items.Add("Ideal para departamento");
            cboCaracteristicas.Items.Add("Ideal para adultos mayores");

            cboEspecie.Items.Add("Perro");
            cboEspecie.Items.Add("Gato");
            cboTamaño.Items.Add("Tamaño pequeño");
            cboTamaño.Items.Add("Tamaño mediano");
            cboTamaño.Items.Add("Tamaño grande");

            cboPelaje.Items.Add("Pelaje corto");
            cboPelaje.Items.Add("Pelaje largo");


            cboSexo.Items.Add("M");
            cboSexo.Items.Add("H");
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {

            this.Close();

        }
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
            if (rs == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(foto.FileName);
            }
        }
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            Animal animal = new Animal();

            System.IO.MemoryStream MS = new System.IO.MemoryStream();
            ptbImagen.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);

            string nombre = txtNombre.Text;
            string especie = Convert.ToString(cboEspecie.SelectedItem);
            string raza = txtRaza.Text;
            string sexo = Convert.ToString(cboSexo.SelectedItem);
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            DateTime fechaIngreso = dtpFechaIngreso.Value;
            string estado = "Disponible";
            byte[] foto = MS.GetBuffer();
            string personalidad = Convert.ToString(cboPersonalidad.SelectedItem);
            string tamaño = Convert.ToString(cboTamaño.SelectedItem);
            string pelaje = Convert.ToString(cboPelaje.SelectedItem);
            string caracteristicas = Convert.ToString(cboCaracteristicas.SelectedItem);




            //verificaciones

            if (
                 Regex.IsMatch(nombre, @"\d") // Nombre con números
                 || Regex.IsMatch(raza, @"\d") // Raza con números
                 || !dtpFechaIngreso.Checked // Fecha ingreso no seleccionada
                 || fechaIngreso >= DateTime.Today // Fecha ingreso en futuro
                 || fechaIngreso < new DateTime(2000, 1, 1) // Fecha ingreso demasiado antigua
                 || cboEspecie.SelectedItem == null
                 || cboSexo.SelectedItem == null
                 || string.IsNullOrEmpty(especie)
                 || string.IsNullOrEmpty(sexo)
                 || string.IsNullOrEmpty(nombre)
                 || string.IsNullOrEmpty(raza)
               )
            {
                // Mostrar un mensaje más general o personalizado según el primer error encontrado
                if (Regex.IsMatch(nombre, @"\d"))
                    MessageBox.Show("El nombre no puede contener números.");
                else if (Regex.IsMatch(raza, @"\d"))
                    MessageBox.Show("La raza no puede contener números.");
                else if (!dtpFechaIngreso.Checked)
                    MessageBox.Show("Debe seleccionar una fecha de ingreso.");
                else if (fechaIngreso >= DateTime.Today)
                    MessageBox.Show("La fecha de ingreso no puede ser en el futuro.");
                else if (fechaIngreso < new DateTime(2000, 1, 1))
                    MessageBox.Show("La fecha de ingreso es demasiado antigua para ser válida.");
                else
                    MessageBox.Show("Verifique que todos los datos estén bien copiados.");

                return;
            }
            else
            {
                animal.GuardarDatos(nombre, especie, raza, sexo, fechaNacimiento, fechaIngreso, estado, foto);
                SqlCommand proc = new SqlCommand("sp_InsertarAnimal", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@nombre", animal.Nombre);
                proc.Parameters.AddWithValue("@especie", animal.Especie);
                proc.Parameters.AddWithValue("@raza", animal.Raza);
                proc.Parameters.AddWithValue("@sexo", animal.Sexo);
                proc.Parameters.AddWithValue("@fecha_nacimiento", animal.Fecha_nacimiento);
                proc.Parameters.AddWithValue("@fecha_ingreso", animal.Fecha_ingreso);
                proc.Parameters.AddWithValue("@personalidad", personalidad);
                proc.Parameters.AddWithValue("@tamaño", tamaño);
                proc.Parameters.AddWithValue("@caracteriticas", caracteristicas);
                proc.Parameters.AddWithValue("@pelaje", pelaje);
                proc.Parameters.AddWithValue("@estado", animal.Estado);
                proc.Parameters.AddWithValue("@foto", animal.Foto); //(SqlDbType.Image).value = animal.foto

      
                try
                {
                    proc.ExecuteNonQuery();
                    MessageBox.Show("Se modificaron los datos correctamente");

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificaron los datos: " + ex.Message);
                    MessageBox.Show("Revisa bien los datos ingresados");
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insertAnimalForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}