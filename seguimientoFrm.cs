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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fundacion_Animales
{
    public partial class seguimientoFrm : Form
    {
        SqlConnection con = new SqlConnection();
        int ID;
        public seguimientoFrm(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void seguimientoFrm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            llenarTablas();
        }

        public void llenarTablas()
        {
            string consulta = "SELECT  A.id_animal, A.nombre AS nombre_animal,A.especie,A.raza,A.sexo,A.tamaño,A.personalidad,A.estado AS estado_actual,AD.fecha_adopcion FROM    Usuario U JOIN    SolicitudAdopcion SA ON U.id_usuario = SA.id_usuario JOIN   Adopcion AD ON SA.id_solicitud = AD.id_solicitud JOIN   Animal A ON SA.id_animal = A.id_animal WHERE     AD.estado_adopcion = 'Completada' AND   U.id_usuario = @id_usuario;";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
            adaptador.SelectCommand.Parameters.AddWithValue("@id_usuario", ID);

            DataTable dt = new DataTable();

            try
            {
                adaptador.Fill(dt);

                dgvSeguimiento.DataSource = null;
                dgvSeguimiento.Rows.Clear();
                dgvSeguimiento.DataSource = dt;
                dgvSeguimiento.ClearSelection();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

            

      

        private void dgvSeguimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idanimal  = Convert.ToInt32(dgvSeguimiento.SelectedCells[0].Value);
            string consulta = "SELECT foto FROM Animal WHERE id_animal = '"+ idanimal + "'; ";
            SqlCommand comando = new SqlCommand(consulta, con);
            object result = comando.ExecuteScalar();
            byte[] foto = (byte[])result;

            try
            {
                System.IO.MemoryStream MS = new System.IO.MemoryStream(foto);
                ptnImage.Image = Image.FromStream(MS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("recuerda colocarte una foto de usuario.");
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int idAnimal = Convert.ToInt32(dgvSeguimiento.SelectedCells[0].Value);
            string descripcion = txtDescripcion.Text;
            string consulta = "SELECT AD.id_adopcion FROM Adopcion AD JOIN SolicitudAdopcion SA ON AD.id_solicitud = SA.id_solicitud WHERE SA.id_animal = '"+ID+"' AND SA.id_usuario = '"+ idAnimal + "';";
            SqlCommand comando = new SqlCommand(consulta, con);
            object result = comando.ExecuteScalar();
            int resultado = Convert.ToInt32(result);




            if (string.IsNullOrWhiteSpace(descripcion) || descripcion.Length > 255)
            {
                MessageBox.Show("La descripción no puede estar vacía ni exceder los 255 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                SqlCommand proc = new SqlCommand("InsertarSeguimientoAdopcion", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@id_adopcion", resultado);
                proc.Parameters.AddWithValue("@descripcion", descripcion);
                try
                {
                    proc.ExecuteNonQuery();
                    MessageBox.Show("Se modificaron los datos correctamente");
                    llenarTablas();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificaron los datos: " + ex.Message);
                    MessageBox.Show("Revisa bien los datos ingresados");
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvSeguimiento.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvSeguimiento.SelectedRows[0];
                string descripcion = txtDescripcion.Text;
                int id = Convert.ToInt32(fila.Cells["id_seguimiento"].Value);


                if (string.IsNullOrWhiteSpace(descripcion) || descripcion.Length > 255)
                {
                    MessageBox.Show("La descripción no puede estar vacía ni exceder los 255 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    SqlCommand proc = new SqlCommand("ActualizarSeguimientoAdopcion", con);
                    proc.CommandType = CommandType.StoredProcedure;
                    proc.Parameters.AddWithValue("@id_seguimiento", id);
                    proc.Parameters.AddWithValue("@descripcion", descripcion);
                    try
                    {
                        proc.ExecuteNonQuery();
                        MessageBox.Show("Se modificaron los datos correctamente");
                        llenarTablas();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificaron los datos: " + ex.Message);
                        MessageBox.Show("Revisa bien los datos ingresados");
                    }
                }
            }
            else
            {
                // No se ha seleccionado ninguna fila
                MessageBox.Show("Por favor, seleccione una fila.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSeguimiento.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvSeguimiento.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells["id_seguimiento"].Value);

                    SqlCommand proc = new SqlCommand("EliminarSeguimientoAdopcion", con);
                    proc.CommandType = CommandType.StoredProcedure;
                    proc.Parameters.AddWithValue("@id_seguimiento", id);
                    try
                    {
                        proc.ExecuteNonQuery();
                        MessageBox.Show("Se modificaron los datos correctamente");
                        llenarTablas();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificaron los datos: " + ex.Message);
                        MessageBox.Show("Revisa bien los datos ingresados");
                    }
                
            }
            else
            {
                // No se ha seleccionado ninguna fila
                MessageBox.Show("Por favor, seleccione una fila.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
