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
    public partial class respuestaSolicitudFrm : Form
    {
        SqlConnection con = new SqlConnection();
        int ID;
        public respuestaSolicitudFrm(int id)
        {
            InitializeComponent();
            ID = id;

        }

        private void respuestaSolicitudFrm_Load(object sender, EventArgs e)
        {
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            llenarTablas();
        }

        public void llenarTablas()
        {
            string Consulta = "SELECT s.id_solicitud,   a.nombre AS nombre_animal,   a.especie,  s.fecha_solicitud, s.estado_solicitud,    s.motivo_adopcion,   s.tiene_otros_animales,   s.tiempo_libre  FROM SolicitudAdopcion s JOIN Animal a ON s.id_animal = a.id_animal WHERE s.id_usuario = '" + ID + "';";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta, con);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dgvSolicitudes.DataSource = dt;
            dgvSolicitudes.ClearSelection();
        }

        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Asegura que no se hizo clic en el encabezado
            {
                DataGridViewRow fila = dgvSolicitudes.Rows[e.RowIndex];
                string estadoSolicitud = fila.Cells["estado_solicitud"].Value.ToString();

                if (estadoSolicitud == "Rechazada")
                {
                    MessageBox.Show("La solicitud de adopción ha sido rechazada tras el proceso de evaluación. Agradecemos tu interés en brindar un hogar a nuestros animales.", "Adopción rechazada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (estadoSolicitud == "Aprobada")
                {
                    MessageBox.Show("¡Felicidades! Tu solicitud fue aceptada 🎉. ¡Ven a recoger a tu nuevo mejor amigo!", "Adopción Aprobada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Tu solicitud aún no ha sido revisada por un administrador. Por favor, espera una respuesta.", "Solicitud en revisión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
