using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fundacion_Animales
{
    public partial class perroForm : Form
    {
        int ID;
        SqlConnection con = new SqlConnection();
        public perroForm()
        {
            InitializeComponent();


        }
        public perroForm(int id)
        {
            ID = id;
            InitializeComponent();



        }

        private void btnAdoptar_Click(object sender, EventArgs e)
        {


        }

        private void perroForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            llenarTablas();

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


            cboTamaño.Items.Add("Tamaño pequeño");
            cboTamaño.Items.Add("Tamaño mediano");
            cboTamaño.Items.Add("Tamaño grande");

            cboPelaje.Items.Add("Pelaje corto");
            cboPelaje.Items.Add("Pelaje largo");




        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarTablas()
        {

            string Consulta = "select * from Vista_Perro";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta, con);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dgvPerros.DataSource = dt;
            dgvPerros.ClearSelection();
        }

        private void btnAdoptar_Click_1(object sender, EventArgs e)
        {
            if (dgvPerros.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvPerros.SelectedRows[0];
                int idAnima = Convert.ToInt32(fila.Cells["id_animal"].Value);

                string consulta = "SELECT u.id_usuario, COUNT(*) AS cantidad_solicitudes_perros FROM Usuario u JOIN SolicitudAdopcion s ON u.id_usuario = s.id_usuario JOIN Animal a ON s.id_animal = a.id_animal WHERE a.especie = 'Perro' AND u.id_usuario = @idUsuario GROUP BY u.id_usuario HAVING COUNT(*) >= 3;";
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.Parameters.AddWithValue("@idUsuario", ID);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    MessageBox.Show("¡Gracias por querer adoptar! Recuerda que solo se permite adoptar máximo 3 perros por usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (fila.Cells["estado"].Value.ToString().Trim().Equals("Adoptado", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Lo sentimos, el perro que elegiste ya no está disponible.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        this.Hide();
                        SolicitudForm s = new SolicitudForm(ID, idAnima);
                        s.ShowDialog();

                        

                    }
                }

                lector.Close(); // Cierra el lector si vas a seguir usando la conexión
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }


        }

        private void perroForm_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarInfo_Click_1(object sender, EventArgs e)
        {
            if (dgvPerros.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvPerros.SelectedRows[0];
                int idAnima = Convert.ToInt32(fila.Cells["id_animal"].Value);

                MostrarAnimalesfrm s = new MostrarAnimalesfrm(idAnima);
                s.FormClosed += (s, args) =>
                {
                    // Recargas el formulario que quieras mostrar después
                    perroForm formInicio = new perroForm();
                    loadForm(formInicio);
                };
                loadForm(s);

            }
            else
            {


                MessageBox.Show("Por favor, selecciona una fila.");
            }
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

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void cboTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = ConexionDB.CrearInstancia().CrearConexion();

            if (cboTamaño.SelectedIndex >= 0)
            {
                cboPersonalidad.SelectedIndex = -1;
                cboPelaje.SelectedIndex = -1;
                cboCaracteristicas.SelectedIndex = -1;

            }

            if (cboTamaño.SelectedItem == null)
            {
                string Consulta = "select * from Vista_Perro";
                SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta, con);
                DataTable dt = new DataTable();
                Adaptador.Fill(dt);
                dgvPerros.DataSource = dt;
                dgvPerros.ClearSelection();

            }
            else
            {
                string tamaño = cboTamaño.SelectedItem.ToString();
                string consulta = "SELECT * FROM Animal WHERE tamaño = @tamaño AND especie = 'Perro'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                adaptador.SelectCommand.Parameters.AddWithValue("@tamaño", tamaño);

                DataTable dt = new DataTable();

                try
                {
                    con.Open();
                    adaptador.Fill(dt);

                    dgvPerros.DataSource = null;
                    dgvPerros.Rows.Clear();
                    dgvPerros.DataSource = dt;
                    dgvPerros.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }

            }



        }

        private void cboPersonalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = ConexionDB.CrearInstancia().CrearConexion();

            if (cboPersonalidad.SelectedIndex >= 0)
            {
                cboTamaño.SelectedIndex = -1;
                cboPelaje.SelectedIndex = -1;
                cboCaracteristicas.SelectedIndex = -1;

            }

            if (cboPersonalidad.SelectedItem == null)
            {
                string Consulta = "select * from Vista_Perro";
                SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta, con);
                DataTable dt = new DataTable();
                Adaptador.Fill(dt);
                dgvPerros.DataSource = dt;
                dgvPerros.ClearSelection();

            }
            else
            {
                string personalidad = cboPersonalidad.SelectedItem.ToString();
                string consulta = "SELECT * FROM Animal WHERE personalidad = @personalidad  AND especie = 'Perro'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                adaptador.SelectCommand.Parameters.AddWithValue("@personalidad", personalidad);

                DataTable dt = new DataTable();

                try
                {
                    con.Open();
                    adaptador.Fill(dt);

                    dgvPerros.DataSource = null;
                    dgvPerros.Rows.Clear();
                    dgvPerros.DataSource = dt;
                    dgvPerros.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }

            }


        }

        private void cboCaracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = ConexionDB.CrearInstancia().CrearConexion();

            if (cboCaracteristicas.SelectedIndex >= 0)
            {
                cboTamaño.SelectedIndex = -1;
                cboPelaje.SelectedIndex = -1;
                cboPersonalidad.SelectedIndex = -1;

            }

            if (cboCaracteristicas.SelectedItem == null)
            {
                string Consulta = "select * from Vista_Perro";
                SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta, con);
                DataTable dt = new DataTable();
                Adaptador.Fill(dt);
                dgvPerros.DataSource = dt;
                dgvPerros.ClearSelection();

            }
            else
            {
                string caracteristicas = cboCaracteristicas.SelectedItem.ToString();
                string consulta = "SELECT * FROM Animal WHERE caracteriticas = @caracteriticas AND especie = 'Perro'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                adaptador.SelectCommand.Parameters.AddWithValue("@caracteriticas", caracteristicas);

                DataTable dt = new DataTable();

                try
                {
                    con.Open();
                    adaptador.Fill(dt);

                    dgvPerros.DataSource = null;
                    dgvPerros.Rows.Clear();
                    dgvPerros.DataSource = dt;
                    dgvPerros.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }

            }

        }

        private void cboPelaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = ConexionDB.CrearInstancia().CrearConexion();

            if (cboPelaje.SelectedIndex >= 0)
            {
                cboTamaño.SelectedIndex = -1;
                cboCaracteristicas.SelectedIndex = -1;
                cboPersonalidad.SelectedIndex = -1;

            }

            if (string.IsNullOrEmpty(cboPelaje.SelectedItem?.ToString()))
            {
                llenarTablas();

            }
            else
            {
                string pelaje = cboPelaje.SelectedItem.ToString();
                string consulta = "SELECT * FROM Animal WHERE pelaje = @pelaje AND especie = 'Perro'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                adaptador.SelectCommand.Parameters.AddWithValue("@pelaje", pelaje);

                DataTable dt = new DataTable();

                try
                {
                    con.Open();
                    adaptador.Fill(dt);

                    dgvPerros.DataSource = null;
                    dgvPerros.Rows.Clear();
                    dgvPerros.DataSource = dt;
                    dgvPerros.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }

            }
        }
    }
}
