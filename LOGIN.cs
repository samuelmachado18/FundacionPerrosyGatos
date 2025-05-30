using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundacion_Animales
{
    public partial class LOGIN : Form
    {
        SqlConnection con = new SqlConnection();
        public LOGIN()
        {
            InitializeComponent();
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConexionDB.CrearInstancia().CrearConexion())
            {
                con.Open();

                string consulta = "SELECT id_usuario, rol FROM Usuario WHERE loginName = @usuario AND contrasena_hash = @clave";
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@clave", txtPass.Text);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    int id = Convert.ToInt32(lector["id_usuario"]);
                    string rol = lector["rol"].ToString();
                    bool admin = rol == "Administrador";

                    lector.Close();
                    this.Hide();

                    Form1 form1 = new Form1(admin, id);
                    form1.FormClosed += (s, args) =>
                    {
                        LOGIN formInicio = new LOGIN();
                        formInicio.Show();
                    };
                    form1.StartPosition = FormStartPosition.CenterScreen;
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos");
                }
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registrarsefrm registrarsefrm = new Registrarsefrm();
            registrarsefrm.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

