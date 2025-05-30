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
    public partial class ActualizarAdministradoresform : Form
    {
        SqlConnection con = new SqlConnection();
        Usuarios usuario = new Usuarios();
        public ActualizarAdministradoresform()
        {
            InitializeComponent();
        }

        public ActualizarAdministradoresform(Usuarios datosCapturados)
        {
            usuario.Id_usuario = datosCapturados.Id_usuario;
            usuario.Nombre_usuario = datosCapturados.Nombre_usuario;
            usuario.LoginName = datosCapturados.LoginName;
            usuario.Contrasena_hash = datosCapturados.Contrasena_hash;
            usuario.Rol = datosCapturados.Rol;
            usuario.Estado = datosCapturados.Estado;
            usuario.Fecha_creacion = datosCapturados.Fecha_creacion;
            usuario.Correo = datosCapturados.Correo;
            usuario.Direccion = datosCapturados.Direccion;
            usuario.Telefono = datosCapturados.Telefono;
            usuario.Foto = datosCapturados.Foto;
            InitializeComponent();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            System.IO.MemoryStream MS = new System.IO.MemoryStream();
            ptbImagen.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);

            string Nombre_usuario = txtNombre.Text;
            string LoginName = txtNombreUsuario.Text;
            string Contrasena_hash = txtContraseña.Text;
            string Estado = Convert.ToString(cboEstado.SelectedItem);
            string Correo = txtCorreo.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            byte[] foto = MS.GetBuffer();

            usuario.GuardarDatos(Nombre_usuario, LoginName, Contrasena_hash, usuario.Rol, Estado, usuario.Fecha_creacion, Correo, Direccion, Telefono, foto);

            if (string.IsNullOrWhiteSpace(Nombre_usuario) ||
            string.IsNullOrWhiteSpace(LoginName) ||
            string.IsNullOrWhiteSpace(Contrasena_hash) || Contrasena_hash.Length < 6 ||
            string.IsNullOrWhiteSpace(Estado) ||
            string.IsNullOrWhiteSpace(Correo) || !System.Text.RegularExpressions.Regex.IsMatch(Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") ||
            string.IsNullOrWhiteSpace(Direccion) ||
            string.IsNullOrWhiteSpace(Telefono) || !Telefono.All(char.IsDigit) || Telefono.Length < 7 ||
            foto == null || foto.Length < 10)
            {
                MessageBox.Show("Uno o más campos contienen datos inválidos. Verifique e intente nuevamente.");
            }
            else
            {
                SqlCommand proc = new SqlCommand("sp_ActualizarUsuario", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@id_usuario", usuario.Id_usuario);
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

        private void ActualizarAdministradoresform_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            try
            {
                txtNombre.Text = usuario.Nombre_usuario;
                txtNombreUsuario.Text = usuario.LoginName;
                txtContraseña.Text = usuario.Contrasena_hash;
                txtDireccion.Text = usuario.Direccion;
                cboEstado.Text = usuario.Estado;
                txtCorreo.Text = usuario.Correo;
                txtTelefono.Text = usuario.Telefono;
                System.IO.MemoryStream MS = new System.IO.MemoryStream(usuario.Foto);
                ptbImagen.Image = Image.FromStream(MS);
            }
            catch (Exception ex)
            {
                Administradoresform administrar = new Administradoresform();
                this.FormClosed += (s, args) =>
                {
                    // Recargas el formulario que quieras mostrar después
                    Administradoresform administrar = new Administradoresform();
                    loadForm(administrar);
                };


                MessageBox.Show("seleccione una fila" + ex.Message);
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

        private void ActualizarAdministradoresform_Resize(object sender, EventArgs e)
        {
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
