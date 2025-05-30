using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundacion_Animales
{
    public partial class MostrarAnimalesfrm : Form
    {
        SqlConnection con = new SqlConnection();
        int ID;
      
        public MostrarAnimalesfrm(int iD)
        {
            InitializeComponent();
            ID = iD;

        }

        private void MostrarAnimalesfrm_Load(object sender, EventArgs e)
        {
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            string consulta = "SELECT id_animal,nombre, especie, raza, sexo,fecha_nacimiento,estado,foto FROM Animal WHERE id_animal = @id";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.Parameters.AddWithValue("@id", ID);

            SqlDataReader reader = comando.ExecuteReader();

            int id;
            string nombre;
            string especie;
            string raza;
            string sexo;
            DateTime fecha_nacimiento;
            string estado;
            byte[] foto;

            if (reader.Read())
            {
                id = Convert.ToInt32(reader["id_animal"]);
                nombre = reader["nombre"].ToString();
                especie = reader["especie"].ToString();
                raza = reader["raza"].ToString();
                sexo = reader["sexo"].ToString();
                fecha_nacimiento = Convert.ToDateTime(reader["fecha_nacimiento"]);
                estado = reader["estado"].ToString();
                foto = reader["foto"] as byte[];

          

                try
                {
                    using (MemoryStream MS = new MemoryStream(foto))
                    {
                        ptbImagen.Image = Image.FromStream(MS);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("recuerda agregar tu foto de usuario");
                }

                txtID.Text = "ID: " + Convert.ToString(id);
                txtNombre.Text = "Nombre: " + Convert.ToString(nombre);
                txtEspecie.Text = "Especie: " + Convert.ToString(especie);
                txtRaza.Text = "Raza: " + Convert.ToString(raza);
                if (sexo == "H")
                {
                    sexo = "Sexo: Hembra";
                    txtSexo.Text = Convert.ToString(sexo);
                }
                else
                {
                    sexo = "Sexo: Masculino";
                    txtSexo.Text = Convert.ToString(sexo);
                }
                txtFechaNacimiento.Text = $"Fecha Nacimiento: {fecha_nacimiento.ToString("dd/MM/yyyy")}";
                txtEstado.Text = $"Estado: "+ Convert.ToString(estado);

            }


            reader.Close();




        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
