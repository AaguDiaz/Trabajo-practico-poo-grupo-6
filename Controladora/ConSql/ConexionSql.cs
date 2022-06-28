using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Controladora
{
    public class ConexionSql
    {
        private string CadenaConexion = "Data Source=W10NTBX-SLOTI;Initial Catalog=VentasH;Integrated Security=True";

        public void Agregar(string dni, string Nombre, string email, string con)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("Insert into Usuarios(Dni,Nombre,Email,Contrasena) values ('" + dni + "','" + Nombre + "','" + email + "','" + con + "')", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                actualizartabla();
            }
        }
        public void Modificar(string Nombre, string dni, string e, string c, string id)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("update Usuarios set Dni= '" + dni + "', Nombre='" + Nombre + "', Email='" + e + "',Contrasena='" + c + "'where Id='" + id + "'", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                actualizartabla();
            }
        }
        public void eliminar(string id)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("delete from Usuarios where Id =" + id, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                
            }
        }
        public DataTable actualizartabla()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Usuarios", conn);
                da.SelectCommand.CommandType = CommandType.Text;
                conn.Open();
                da.Fill(dt);
                return dt;
            }
        }

        public bool NombreLogin(string nombre)
        {
            SqlConnection conn = new SqlConnection(CadenaConexion);
            try
            {

                SqlCommand user = new SqlCommand("Select * from Usuarios where Nombre='" + nombre + "'", conn);
                SqlDataReader rta;
                rta = user.ExecuteReader();
                if (rta.Read())
                {
                    return true;
                }
                rta.Close();
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool ContraLogin(string contra)
        {
            SqlConnection conn = new SqlConnection(CadenaConexion);
            try
            {

                SqlCommand pass = new SqlCommand("Select * from Usuarios where Contrasena='" + contra + "'", conn);
                SqlDataReader rta;
                rta = pass.ExecuteReader();
                if (rta.Read())
                {
                    return true;
                }
                rta.Close();
                return false;
            }
            catch
            {
                return false;
            }
        }
        public void AgregarFactura(string Factura)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("Insert into Facturas(NumFactura) values ('" + Factura + "')", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
