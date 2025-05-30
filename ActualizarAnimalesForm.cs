using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundacion_Animales
{
    public partial class ActualizarAnimalesForm : Form
    {
        SqlConnection con = new SqlConnection();
        Animal CapturarDatos;
        public ActualizarAnimalesForm()
        {

            InitializeComponent();
        }

        public ActualizarAnimalesForm(Animal capturarDatos)
        {
            CapturarDatos = new Animal();


            CapturarDatos.Id_animal = capturarDatos.Id_animal;
            CapturarDatos.Nombre = capturarDatos.Nombre;
            CapturarDatos.Especie = capturarDatos.Especie;
            CapturarDatos.Raza = capturarDatos.Raza;
            CapturarDatos.Sexo = capturarDatos.Sexo;
            CapturarDatos.Fecha_nacimiento = capturarDatos.Fecha_nacimiento;
            CapturarDatos.Fecha_ingreso = capturarDatos.Fecha_ingreso;
            CapturarDatos.Estado = capturarDatos.Estado;
            CapturarDatos.Foto = capturarDatos.Foto;
            InitializeComponent();
            cboEspecie.Items.Add("Perro");
            cboEspecie.Items.Add("Gato");

            cboEstado.Items.Add("Disponible");
            cboEstado.Items.Add("Adoptado");
            cboEstado.Items.Add("Fallecido");

            cboSexo.Items.Add("M");
            cboSexo.Items.Add("H");

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream MS = new System.IO.MemoryStream();
            ptbImagen.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);

            string nombre = txtNombre.Text;
            string especie = Convert.ToString(cboEspecie.SelectedItem);
            string raza = txtRaza.Text;
            string sexo = Convert.ToString(cboSexo.SelectedItem);
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            DateTime fechaIngreso = dtpFechaIngreso.Value;
            string estado = Convert.ToString(cboEstado.SelectedItem);
            byte[] foto = MS.GetBuffer();

            CapturarDatos.GuardarDatos(nombre, especie, raza, sexo, fechaNacimiento, fechaIngreso, estado, foto);
            if (Regex.IsMatch(txtNombre.Text, @"\d"))
            {
                MessageBox.Show("El nombre no puede contener números");
                return;
            }
            else if (Regex.IsMatch(txtRaza.Text, @"\d"))
            {
                MessageBox.Show("El nombre no puede contener números");
                return;
            }
            else if (!dtpFechaIngreso.Checked)
            {
                MessageBox.Show("Debe seleccionar una fecha de ingreso.");
                return;
            }
            // Verifica que la fecha no esté en el futuro
            else if (fechaIngreso >= DateTime.Today)
            {
                MessageBox.Show("La fecha de ingreso no puede ser en el futuro.");
                return;
            }
            // Verifica que la fecha no sea demasiado antigua (por ejemplo, antes del año 2000)
            else if (fechaIngreso < new DateTime(2000, 1, 1))
            {
                MessageBox.Show("La fecha de ingreso es demasiado antigua para ser válida.");
                return;
            }
            else if (cboEspecie.SelectedItem == null || cboSexo.SelectedItem == null || cboEstado.SelectedItem == null
                  || string.IsNullOrEmpty(cboEspecie.SelectedItem.ToString())
                  || string.IsNullOrEmpty(cboSexo.SelectedItem.ToString())
                  || string.IsNullOrEmpty(cboEstado.SelectedItem.ToString())
                  || string.IsNullOrEmpty(txtNombre.Text)
                  || string.IsNullOrEmpty(txtRaza.Text))
            {
                MessageBox.Show("Verifique que todos los datos esten bien copiados");

            }
            else
            {

                SqlCommand proc = new SqlCommand("sp_ActualizarAnimal", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@id_animal", CapturarDatos.Id_animal);
                proc.Parameters.AddWithValue("@nombre", CapturarDatos.Nombre);
                proc.Parameters.AddWithValue("@especie", CapturarDatos.Especie);
                proc.Parameters.AddWithValue("@raza", CapturarDatos.Raza);
                proc.Parameters.AddWithValue("@sexo", CapturarDatos.Sexo);
                proc.Parameters.AddWithValue("@fecha_nacimiento", CapturarDatos.Fecha_nacimiento);
                proc.Parameters.AddWithValue("@fecha_ingreso", CapturarDatos.Fecha_ingreso);
                proc.Parameters.AddWithValue("@estado", CapturarDatos.Estado);
                proc.Parameters.AddWithValue("@foto", CapturarDatos.Foto); //(SqlDbType.Image).value = animal.foto
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

        private void ActualizarAnimalesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            try {
                int id = CapturarDatos.Id_animal;
                txtNombre.Text = CapturarDatos.Nombre;
                cboEspecie.Text = CapturarDatos.Especie;
                txtRaza.Text = CapturarDatos.Raza;
                cboSexo.Text = CapturarDatos.Sexo;
                dtpFechaNacimiento.Value = CapturarDatos.Fecha_nacimiento;
                dtpFechaIngreso.Value = CapturarDatos.Fecha_ingreso;
                cboEstado.Text = CapturarDatos.Estado;
                System.IO.MemoryStream MS = new System.IO.MemoryStream(CapturarDatos.Foto);
                ptbImagen.Image = Image.FromStream(MS);
            }
            catch (Exception ex)
            {
               
               this.Close();
          
                MessageBox.Show("seleccione una fila" + ex.Message);
                
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
          
            this.Close();

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
    }
}
