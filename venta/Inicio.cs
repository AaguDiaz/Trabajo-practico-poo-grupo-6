using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controladora;
using System.Configuration;

namespace venta
{
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();

           
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))//solo letras
            {
                e.Handled = true;
            }
        }
        private void txtNomLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))//solo letras
                {
                    e.Handled = true;
                }
            
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = rbSi.Checked;
            txtNomLogin.Clear();
            txtContraLogin.Clear();
        }


        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = rbNo.Checked;
            txtDNI.Clear();
            txtNom.Clear();
            txtEmail.Clear();
            txtContra.Clear();
        }
        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            bool rta = validacionRegistrar();
            if (rta==true)
            {
                ConexionSql agregar = new ConexionSql();
                agregar.Agregar(txtDNI.Text, txtNom.Text, txtEmail.Text, txtContra.Text);
                MessageBox.Show("Registro con éxito");
                
            }
            bool validacionRegistrar()
            {
                if (txtNom.Text == "")
                {
                    MessageBox.Show("falta nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtContra.Text == "")
                {
                    MessageBox.Show("falta contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtDNI.Text == "")
                {
                    MessageBox.Show("falta DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("falta Mail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }

        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            string nombreAdmin, contraseñaAdmin, n = txtNom.Text, em = txtEmail.Text,d=txtDNI.Text,c=txtContra.Text,nl=txtNomLogin.Text,cl=txtContraLogin.Text;
            nombreAdmin = "Hernan";
            contraseñaAdmin = "adm123";
           
            bool rta = validacionLogin();
            if (rta == true) {
                if (txtNomLogin.Text==nombreAdmin||txtContraLogin.Text==contraseñaAdmin){
                    Admin frm = new Admin(n,em,d,c,cl,nl);
                    frm.Show();
                } else {
                    NombreLogin(txtNomLogin.Text, txtContraLogin.Text,n,em,d,c,cl,nl);  
                       }
            }
            bool validacionLogin()
            {
                if (txtNomLogin.Text == "")
                {
                    MessageBox.Show("falta nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtContraLogin.Text == "")
                {
                    MessageBox.Show("falta contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;

            }
        }
        public void NombreLogin(string nombre,string cont,string n,string em,string d,string c,string cl,string nl)
        {
            
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using(SqlConnection conn = new SqlConnection(cnn)){
                    using (SqlCommand cmd = new SqlCommand("Select Nombre, Contrasena from Usuarios where Nombre='" + nombre + "'and Contrasena='"+ cont+"'", conn))
                    {
                        conn.Open();
                        SqlDataReader dr= cmd.ExecuteReader();
                        if (dr.HasRows==true)
                        {
                            Cliente frm = new Cliente(n, em, d, c, cl, nl);
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Nombre y contraseña no coinciden ");
                        }
                    } 
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
