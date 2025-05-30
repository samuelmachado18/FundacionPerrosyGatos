using System.Data.SqlClient;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Fundacion_Animales
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();

        bool admin;
        int id;

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }



        public Form1()
        {

            InitializeComponent();


            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();

        }

        public Form1(bool admin, int id)
        {
            this.admin = admin;
            this.id = id;
            InitializeComponent();
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                loadForm(new SolicitudesAdopcion());
            }
            else
            {
                btnSolicitudes.Enabled = false;

            }
        }



        private void btnPerro_Click(object sender, EventArgs e)
        {
            loadForm(new perroForm(id));
        }

        private void button5_Click(object sender, EventArgs e)
        {


            loadForm(new gatoForm(id));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new ContactanosForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta3 = "SELECT a.id_adopcion FROM Usuario u JOIN SolicitudAdopcion s ON u.id_usuario = s.id_usuario JOIN Adopcion a ON s.id_solicitud = a.id_solicitud WHERE u.id_usuario = @id_usuario AND a.estado_adopcion = 'Completada';";
            SqlCommand comando3 = new SqlCommand(consulta3, con);
            comando3.Parameters.AddWithValue("@id_usuario", id);

            bool tieneAdopcion = false;

            using (SqlDataReader reader = comando3.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    loadForm(new seguimientoFrm(id));
                }
                else
                {
                    MessageBox.Show("primero tienes realizar una adopcion.");
                    button1.Enabled = false;
                }
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string consulta3 = "select foto from Usuario where id_usuario ='" + id + "'; ";
            SqlCommand comando3 = new SqlCommand(consulta3, con);
            object result = comando3.ExecuteScalar();
            try
            {
                byte[] resultado = (byte[])result;
                System.IO.MemoryStream MS = new System.IO.MemoryStream(resultado);
                ptnimagen.Image = Image.FromStream(MS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("recuerda colocarte una foto de usuario.");
            }




            if (admin == true)
            {
                flpAgregar.Enabled = true;
                flpAgregar.Visible = true;
            }
            else
            {
                flpAgregar.Enabled = false;
                flpAgregar.Visible = false;
            }
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {

            loadForm(new administracion_animalesForm());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                menuTransition.Start();
            }
            else
            {
                btnAgregar.Enabled = false;

            }

        }



        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            if (admin == false)
            {
                respuestaSolicitudFrm respuesta = new respuestaSolicitudFrm(id);
                respuesta.StartPosition = FormStartPosition.CenterScreen; 
                respuesta.ShowDialog();
            }
            else
            {
                btnSolicitud.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {

            loadForm(new Administradoresform());
        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flpAgregar.Height += 10;
                if (flpAgregar.Height >= 160)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flpAgregar.Height -= 10;
                if (flpAgregar.Height <= 54)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition2.Start();
        }
        bool menuExpand2 = false;
        private void menuTransition2_Tick(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 160)
                {
                    menuTransition2.Stop();
                    menuExpand2 = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 54)
                {
                    menuTransition2.Stop();
                    menuExpand2 = false;
                }
            }

        }

        private void ptnimagen_Click(object sender, EventArgs e)
        {

        }

        private void btnSegumientosMascotas_Click(object sender, EventArgs e)
        {
            loadForm(new seguimientoAdminfrom());
        }

        bool menuExpand3 = false;
        private void menuTransition3_Tick(object sender, EventArgs e)
        {
            if (menuExpand3 == false)
            {
                panelContenedor2.Height += 10;
                if (panelContenedor2.Height >= 160)
                {
                    menuTransition3.Stop();
                    menuExpand3 = true;
                }
            }
            else
            {
                panelContenedor2.Height -= 10;
                if (panelContenedor2.Height <= 54)
                {
                    menuTransition3.Stop();
                    menuExpand3 = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                menuTransition3.Start();
            }
            else 
            {
                button2.Enabled = false;
                MessageBox.Show("Este boton es solo para los administradores.");
            }
              
        }
    }
}
