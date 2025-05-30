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
    public partial class Registrarsefrm : Form
    {
        SqlConnection con = new SqlConnection();
        public Registrarsefrm()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            System.IO.MemoryStream MS = new System.IO.MemoryStream();
            ptnImagen.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);

            string nombreCompleto = txtNombreCompl.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string Contraseña = txtContraseña.Text;
            string Correo = txtCorreo.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            byte[] foto = MS.GetBuffer();
            string Rol = "Adoptante";
            string estado = "Activo";
            DateTime fechaCreacion = DateTime.Now;
            if (string.IsNullOrWhiteSpace(nombreCompleto) || nombreCompleto.Length < 3 ||
                string.IsNullOrWhiteSpace(nombreUsuario) || nombreUsuario.Length < 4 ||
                string.IsNullOrWhiteSpace(Contraseña) || Contraseña.Length < 6 ||
                string.IsNullOrWhiteSpace(Correo) || !Regex.IsMatch(Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") ||
                string.IsNullOrWhiteSpace(Direccion) || Direccion.Length < 5 ||
                string.IsNullOrWhiteSpace(Telefono) || !Regex.IsMatch(Telefono, @"^\d{7,10}$"))
            {
                MessageBox.Show("Verifique que todos los datos este bien copiados.");
                return;
            }
            else
            {

                usuario.GuardarDatos(nombreCompleto, nombreUsuario, Contraseña, Rol, estado, fechaCreacion, Correo, Direccion, Telefono, foto);
                SqlCommand proc = new SqlCommand("sp_InsertarUsuario", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@nombre_usuario", usuario.Nombre_usuario);
                proc.Parameters.AddWithValue("@loginName", usuario.LoginName);
                proc.Parameters.AddWithValue("@contrasena_hash", usuario.Contrasena_hash);
                proc.Parameters.AddWithValue("@rol", usuario.Rol);
                proc.Parameters.AddWithValue("@estado", usuario.Estado);
                proc.Parameters.AddWithValue("@correo", usuario.Correo);
                proc.Parameters.AddWithValue("@direccion", usuario.Direccion);
                proc.Parameters.AddWithValue("@telefono", usuario.Telefono);
                proc.Parameters.AddWithValue("@foto", usuario.Foto);
                try
                {
                    proc.ExecuteNonQuery();
                    MessageBox.Show("Se modificaron los datos correctamente");
                    this.Hide();
                    LOGIN lOGIN = new LOGIN();
                    lOGIN.ShowDialog();



                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificaron los datos: " + ex.Message);
                    MessageBox.Show("Revisa bien los datos ingresados");
                }

            }



        }

        private void label7_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
            if (rs == DialogResult.OK)
            {
                ptnImagen.Image = Image.FromFile(foto.FileName);
            }
        }

        private void Registrarsefrm_Load(object sender, EventArgs e)
        {

            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtNombreCompl_Enter(object sender, EventArgs e)
        {
            if (txtNombreCompl.Text == "Nombre Completo")
            {
                txtNombreCompl.Text = "";
                txtNombreCompl.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreCompl_Leave(object sender, EventArgs e)
        {
            if (txtNombreCompl.Text == "")
            {
                txtNombreCompl.Text = "Nombre Completo";
                txtNombreCompl.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            System.IO.MemoryStream MS = new System.IO.MemoryStream();
            ptnImagen.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);

            string nombreCompleto = txtNombreCompl.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string Contraseña = txtContraseña.Text;
            string Correo = txtCorreo.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            byte[] foto = MS.GetBuffer();
            string Rol = "Adoptante";
            string estado = "Activo";
            DateTime fechaCreacion = DateTime.Now;
            if (string.IsNullOrWhiteSpace(nombreCompleto) || nombreCompleto.Length < 3 ||
                string.IsNullOrWhiteSpace(nombreUsuario) || nombreUsuario.Length < 4 ||
                string.IsNullOrWhiteSpace(Contraseña) || Contraseña.Length < 6 ||
                string.IsNullOrWhiteSpace(Correo) || !Regex.IsMatch(Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") ||
                string.IsNullOrWhiteSpace(Direccion) || Direccion.Length < 5 ||
                string.IsNullOrWhiteSpace(Telefono) || !Regex.IsMatch(Telefono, @"^\d{7,10}$"))
            {
                MessageBox.Show("Verifique que todos los datos este bien copiados.");
                return;
            }
            else
            {

                usuario.GuardarDatos(nombreCompleto, nombreUsuario, Contraseña, Rol, estado, fechaCreacion, Correo, Direccion, Telefono, foto);
                SqlCommand proc = new SqlCommand("sp_InsertarUsuario", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@nombre_usuario", usuario.Nombre_usuario);
                proc.Parameters.AddWithValue("@loginName", usuario.LoginName);
                proc.Parameters.AddWithValue("@contrasena_hash", usuario.Contrasena_hash);
                proc.Parameters.AddWithValue("@rol", usuario.Rol);
                proc.Parameters.AddWithValue("@estado", usuario.Estado);
                proc.Parameters.AddWithValue("@correo", usuario.Correo);
                proc.Parameters.AddWithValue("@direccion", usuario.Direccion);
                proc.Parameters.AddWithValue("@telefono", usuario.Telefono);
                proc.Parameters.AddWithValue("@foto", usuario.Foto);
                try
                {
                    proc.ExecuteNonQuery();
                    MessageBox.Show("Se modificaron los datos correctamente");
                    this.Hide();
                    LOGIN lOGIN = new LOGIN();
                    lOGIN.ShowDialog();



                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificaron los datos: " + ex.Message);
                    MessageBox.Show("Revisa bien los datos ingresados");
                }

            }

        }

        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "Nombre Usuario")
            {
                txtNombreUsuario.Text = "";
                txtNombreUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                txtNombreUsuario.Text = "Nombre Usuario";
                txtNombreUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.LightGray;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Dirección";
                txtDireccion.ForeColor = Color.DimGray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.LightGray;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
                txtTelefono.ForeColor = Color.DimGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            this.Close();
            login.Show();

        }
    }
}
