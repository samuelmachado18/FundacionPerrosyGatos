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
    public partial class gatoForm : Form
    {
        int ID;
        SqlConnection con = new SqlConnection();
        public gatoForm(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void gatoForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            llenarTablas();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdoptar_Click(object sender, EventArgs e)
        {
            if (dgvGato.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvGato.SelectedRows[0];
                int idAnima = Convert.ToInt32(fila.Cells["id_animal"].Value);
                this.Hide();
                SolicitudForm s = new SolicitudForm(ID, idAnima);
                s.ShowDialog();
            }
            else
            {


                MessageBox.Show("Por favor, selecciona una fila.");
            }
        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            if (dgvGato.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvGato.SelectedRows[0];
                int idAnima = Convert.ToInt32(fila.Cells["id_animal"].Value);

                MostrarAnimalesfrm s = new MostrarAnimalesfrm(idAnima);
                s.FormClosed += (s, args) =>
                {
                    // Recargas el formulario que quieras mostrar después
                    gatoForm formInicio = new gatoForm(idAnima);
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

        public void llenarTablas()
        {

            string Consulta = "select * from Vista_Perro";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta, con);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dgvGato.DataSource = dt;
            dgvGato.ClearSelection();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
