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
    public partial class AgregarAdministradorForm : Form
    {
        SqlConnection con = new SqlConnection();
        Usuarios usuario = new Usuarios();
        public AgregarAdministradorForm()
        {
            InitializeComponent();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {



            System.IO.MemoryStream MS = new System.IO.MemoryStream();
            ptbImagen.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);

            string Nombre = txtNombre.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            string rol = "Administrador";
            string direccion = txtDireccion.Text;
            string estado = "Activo";
            DateTime fechaCreacion = DateTime.Now;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            byte[] foto = MS.GetBuffer();


            usuario.GuardarDatos(Nombre, nombreUsuario, contraseña, rol, estado, fechaCreacion, correo, direccion, telefono, foto);

            if (string.IsNullOrWhiteSpace(Nombre) ||
            string.IsNullOrWhiteSpace(nombreUsuario) ||
            string.IsNullOrWhiteSpace(contraseña) || contraseña.Length < 6 ||
            string.IsNullOrWhiteSpace(correo) || !System.Text.RegularExpressions.Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") ||
            string.IsNullOrWhiteSpace(direccion) ||
            string.IsNullOrWhiteSpace(telefono) || !telefono.All(char.IsDigit) || telefono.Length < 7 ||
            foto == null || foto.Length < 10)
            {
                MessageBox.Show("Uno o más campos contienen datos inválidos. Verifique e intente nuevamente.");
            }
            else
            {
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
                proc.Parameters.AddWithValue("@foto", usuario.Foto); //(SqlDbType.Image).value = animal.foto
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


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AgregarAdministradorForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
        }
    }
}
