using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora.Conexion
{
   public class ConexionSql
    {
        private string CadenaConexion = "Data Source=W10NTBX-SLOTI;Initial Catalog=VentasH;Integrated Security=True";
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            return this.Conexion;
        }

        public bool PruebaConectar() {
            try {
                
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "SELECT * FROM Usuarios";
                Cmd.Connection = this.EstablecerConexion();
                Conexion.Open();
                Cmd.ExecuteNonQuery();
                Conexion.Close();
                return true;
                 } catch { 
            return false;
            }
            }
    }
}
