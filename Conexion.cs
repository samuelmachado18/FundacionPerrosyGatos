using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fundacion_Animales
{
   public class ConexionDB
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;


        public static ConexionDB con = null;

        private ConexionDB()
        {
            this.Base = "FundacionAnimales"; 
            this.Servidor = "DESKTOP-HRMH4OH";
            this.Usuario = string.Empty;
            this.Clave = string.Empty;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Data Source=" + this.Servidor +
                                          "; Initial Catalog=" + this.Base +
                                          "; Integrated Security=True; trustservercertificate=true";
            }
            catch (Exception ex)
            {
                cadena = null;
                MessageBox.Show("no se conecto a la base de datos");
                throw ex;
            }
            return cadena;
        }

        public static ConexionDB CrearInstancia()
        {
            if (con == null)
            {
                con = new ConexionDB();
            }
            return con;

        }

    }
}
