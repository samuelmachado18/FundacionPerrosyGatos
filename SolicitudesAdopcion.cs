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
    public partial class SolicitudesAdopcion : Form
    {
        SqlConnection con = new SqlConnection();
        public SolicitudesAdopcion()
        {
            InitializeComponent();
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            llenarTablas();
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

            string Consulta = "select * from SolicitudAdopcion;";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta, con);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dgvSolicitudes.DataSource = dt;
            dgvSolicitudes.ClearSelection();
            dgvSolicitudes.DefaultCellStyle.ForeColor = Color.Black;    // Texto negro
            dgvSolicitudes.DefaultCellStyle.BackColor = Color.White;    // Fondo blanco
            dgvSolicitudes.DefaultCellStyle.SelectionBackColor = Color.LightBlue; // Fondo cuando seleccionas
            dgvSolicitudes.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSolicitudes.Columns["estado_solicitud"].ReadOnly = false;
            dgvSolicitudes.Columns["observaciones_admin"].ReadOnly = false;

            foreach (DataGridViewColumn col in dgvSolicitudes.Columns)
            {
                if (col.Name != "estado_solicitud" && col.Name != "observaciones_admin")
                {
                    col.ReadOnly = true;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            // Verificar que haya al menos una fila seleccionada
            if (dgvSolicitudes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una fila para actualizar.");
                return;
            }

            // Obtener el índice de la fila seleccionada
            int fila = dgvSolicitudes.CurrentRow.Index;

            // Extraer los datos
            string estado_solicitud = dgvSolicitudes.Rows[fila].Cells["estado_solicitud"].Value?.ToString();
            string observaciones_admin = dgvSolicitudes.Rows[fila].Cells["observaciones_admin"].Value?.ToString();
            int id = Convert.ToInt32(dgvSolicitudes.Rows[fila].Cells["id_solicitud"].Value);

            // Validación de datos
            if (string.IsNullOrWhiteSpace(estado_solicitud) || id <= 0)
            {
                MessageBox.Show("Uno o más campos no son válidos. Verifica estado, observaciones, fecha o ID.");
                return;
            }

            // Ejecutar procedimiento almacenado
            try
            {
                SqlCommand proc = new SqlCommand("sp_ActualizarEstadoSolicitudAdopcion", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@id_solicitud", id);
                proc.Parameters.AddWithValue("@estado_solicitud", estado_solicitud); // 🔧 corregido aquí
                proc.Parameters.AddWithValue("@observaciones_admin", observaciones_admin); // 🔧 y aquí

                proc.ExecuteNonQuery();
                MessageBox.Show("Se modificaron los datos correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar los datos: " + ex.Message);
            }

        }







        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.CurrentRow != null)
            {
                int id_solicitud = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells[0].Value);

                string consulta = "SELECT id_adopcion FROM Adopcion WHERE id_solicitud = '"+id_solicitud+"';";
                SqlCommand comando = new SqlCommand(consulta, con);
                object result = comando.ExecuteScalar();
                int idAdopcion = Convert.ToInt32(result);


               

                    SqlCommand proc = new SqlCommand("sp_EliminarAdopcion", con);
                    proc.CommandType = CommandType.StoredProcedure;
                    proc.Parameters.AddWithValue("@id_adopcion", idAdopcion);
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSolicitudes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void SolicitudesAdopcion_Resize(object sender, EventArgs e)
        {
            if (this.Width < 935)
            {
                btnActualizar.Location = new Point(248, btnActualizar.Location.Y);
                btnReporte.Location = new Point(95, btnReporte.Location.Y);
                btnEliminar.Location = new Point(399, btnEliminar.Location.Y);
                dgvSolicitudes.Location = new Point(27, dgvSolicitudes.Location.Y);
                btnRegresar.Location = new Point(553, btnRegresar.Location.Y); 


                btnActualizar.Width = 146;
                btnReporte.Width = 146;
                btnEliminar.Width = 146;
                dgvSolicitudes.Width = 722;
                btnRegresar.Width = 146;
            }
            else {
                dgvSolicitudes.Width = 837;
                btnRegresar.Width = 159;
                btnActualizar.Width = 159;
                btnReporte.Width = 159;
                btnEliminar.Width = 159;
                btnActualizar.Location = new Point(308, btnActualizar.Location.Y);
                btnReporte.Location = new Point(133, btnReporte.Location.Y);
                btnEliminar.Location = new Point(482, btnEliminar.Location.Y);
                dgvSolicitudes.Location = new Point(46, dgvSolicitudes.Location.Y);
                btnRegresar.Location = new Point(657, btnRegresar.Location.Y);

            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }
    }
}

