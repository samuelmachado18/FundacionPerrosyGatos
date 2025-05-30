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
    public partial class seguimientoAdminfrom : Form
    {
        SqlConnection con = new SqlConnection();
        public seguimientoAdminfrom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seguimientoAdminfrom_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            llenarTabla();

        }

        public void llenarTabla()
        {
            string consulta = "select * from SeguimientoAdopcion;";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            dgvSeguimiento.DataSource = null;
            dgvSeguimiento.Rows.Clear();
            dgvSeguimiento.DataSource = dt;
            dgvSeguimiento.ClearSelection();
        }

        private void dgvSeguimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idAdopcion = Convert.ToInt32(dgvSeguimiento.SelectedCells[1].Value);
                string consulta = "SELECT A.foto FROM Adopcion AD JOIN SolicitudAdopcion SA ON AD.id_solicitud = SA.id_solicitud JOIN Animal A ON SA.id_animal = A.id_animal WHERE AD.id_adopcion = '" + idAdopcion + "'; ";
                SqlCommand comando = new SqlCommand(consulta, con);
                object result = comando.ExecuteScalar();
                byte[] foto = (byte[])result;

                try
                {
                    System.IO.MemoryStream MS = new System.IO.MemoryStream(foto);
                    ptnImagen.Image = Image.FromStream(MS);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("recuerda colocarte una foto de usuario.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Esta fila esta vacia.");
            
            }


        }
    }
}
