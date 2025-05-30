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
    public partial class SolicitudForm : Form
    {
        int ID;
        int idANIMAL;
        byte[] foto;
        SqlConnection con = new SqlConnection();
        public SolicitudForm()
        {
            InitializeComponent();


        }
        public SolicitudForm(int idUsuario, int idAnimal)
        {
            ID = idUsuario;
            idANIMAL = idAnimal;    
            InitializeComponent();
           
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string respuesta1 = txtRespuesta1.Text;
            string respuesta2 = txtRespuesta2.Text;
            string respuesta3 = txtRespuesta3.Text;
            string respuesta4 = txtRespuesta4.Text;
            string respuesta5 = txtRespuesta5.Text;
            DateTime fecha_solicitud = DateTime.Now;
            string estado = "Pendiente";
            string observaciones = null;
            DateTime fechaRevision = DateTime.MinValue;



            if (string.IsNullOrWhiteSpace(respuesta1) ||
            string.IsNullOrWhiteSpace(respuesta2) ||
            string.IsNullOrWhiteSpace(respuesta3) ||
            string.IsNullOrWhiteSpace(respuesta4) ||
            string.IsNullOrWhiteSpace(respuesta5))
            {
                MessageBox.Show("Por favor, complete todas las respuestas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {



                Solicitud solicitud = new Solicitud(ID, idANIMAL, fecha_solicitud, respuesta1, respuesta2, respuesta3, respuesta4, respuesta5, estado, observaciones, fechaRevision);
                SqlCommand proc = new SqlCommand("sp_InsertarSolicitudAdopcion", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@id_usuario",solicitud.Id_usuario);
                proc.Parameters.AddWithValue("@id_animal",solicitud.Id_animal);
                proc.Parameters.AddWithValue("@alergias_familiares", solicitud.Alégias_familiares);
                proc.Parameters.AddWithValue("@motivo_adopcion",solicitud.Motivo_adopcion);
                proc.Parameters.AddWithValue("@habitat_animal",solicitud.Habitat_Animal);
                proc.Parameters.AddWithValue("@tiene_otros_animales",solicitud.Tiene_otros_animales);
                proc.Parameters.AddWithValue("@tiempo_libre",solicitud.Tiempo_libre);
                try
                {
                    proc.ExecuteNonQuery();
                    MessageBox.Show(
                    "¡Gracias por completar el cuestionario!\n\nTu solicitud de adopción ha sido enviada exitosamente. Un administrador revisara tu solicitud pronto.",
                    "Solicitud Enviada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                    this.Close();


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificaron los datos: " + ex.Message);
                    MessageBox.Show("Revisa bien los datos ingresados");
                }

            }
        }

        private void SolicitudForm_Load(object sender, EventArgs e)
        {
           
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();

            string consulta = "select foto from Usuario where id_usuario ='" + ID + "' ";
            SqlCommand comando = new SqlCommand(consulta, con);
            object result = comando.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                foto = (byte[])result;

                try
                {
                    using (MemoryStream MS = new MemoryStream(foto))
                    {
                        ptbFoto.Image = Image.FromStream(MS);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Este usuario aún no tiene foto registrada.");
            }


        }

        public void cargarImagen()
        {
           
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
