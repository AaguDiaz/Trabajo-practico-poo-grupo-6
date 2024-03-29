﻿using System;
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
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace venta
{
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();
            rbSi.Checked = true;
            errorProvider1.SetError(txtNom, "Por favor ingrese su nombre");
            errorProvider1.SetError(txtEmail, "Por favor ingrese su Email");
            errorProvider1.SetError(txtDNI, "Por favor ingrese su DNI");
            errorProvider1.SetError(txtContra, "Por favor ingrese una contraseña");

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
            groupBox2.Visible = rbNo.Checked;
            txtNomLogin.Clear();
            txtContraLogin.Clear();            
            txtDNI.Clear();
            txtNom.Clear();
            txtEmail.Clear();
            txtContra.Clear();
            errorProvider1.SetError(txtNom, "Por favor ingrese su nombre");
            errorProvider1.SetError(txtEmail, "Por favor ingrese su Email");
            errorProvider1.SetError(txtDNI, "Por favor ingrese su DNI");
            errorProvider1.SetError(txtContra, "Por favor ingrese una contraseña");
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
                if (txtNom.Text == string.Empty)
                {
                    MessageBox.Show("falta nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtContra.Text == string.Empty)
                {
                    MessageBox.Show("falta contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtDNI.Text == string.Empty || ValidaDNI(txtDNI.Text) == false)
                {
                    MessageBox.Show("falta DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (ValidacionEMAIL(txtEmail.Text) == false)
                {
                    MessageBox.Show("falta Mail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                bool ValidaDNI(string dni)
                {

                    if (Regex.Match(dni, @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$").Success == true)
                    {
                        //dni correcto
                        return true;
                    }
                    else
                    {
                        //dni incorrecto
                        return false;
                    }
                }
                bool ValidacionEMAIL(string Mail)//validacion formato de direccion de e-mail
                {

                    Regex mRegxExpression;

                    if (Mail.Trim() != string.Empty)
                    {

                        mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                        if (!mRegxExpression.IsMatch(Mail.Trim()))
                        {
                            //no es correcta
                            return false;
                        }
                        else
                        {
                            //es correcta
                            return true;
                        }

                    }
                    else
                    {
                        //no es correcta, esta vacia
                        return false;
                    }
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
                if (txtNomLogin.Text==nombreAdmin && txtContraLogin.Text==contraseñaAdmin){
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
       

        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            if (txtNom.Text == string.Empty)
            {
                
                errorProvider1.SetError(txtNom, "Por favor ingrese su nombre");
                errorProvider2.SetError(txtNom, "");
                errorProvider3.SetError(txtNom, "");
            }
            else
            {
                errorProvider1.SetError(txtNom, "");
                errorProvider2.SetError(txtNom, "");
                errorProvider3.SetError(txtNom, "Correcto");
            }
        }

        


        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = new EmailAddressAttribute();
            if (ValidacionEMAIL(txtEmail.Text)==false)
            {

                errorProvider1.SetError(txtEmail, "");
                errorProvider2.SetError(txtEmail, "Por favor ingrese un email valido");
                errorProvider3.SetError(txtEmail, "");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
                errorProvider2.SetError(txtEmail, "");
                errorProvider3.SetError(txtEmail, "Correcto");
            }

            bool ValidacionEMAIL(string Mail)//validacion formato de direccion de e-mail
            {

                Regex mRegxExpression;

                if (Mail.Trim() != string.Empty)
                {

                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(Mail.Trim()))
                    {
                        //no es correcta
                        return false;
                    }
                    else
                    {
                        //es correcta
                        return true;
                    }

                }
                else
                {
                    //no es correcta, esta vacia
                    return false;
                }
            }
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            if (txtDNI.Text == string.Empty || ValidaDNI(txtDNI.Text) == false)
            {

                errorProvider1.SetError(txtDNI, "");
                errorProvider2.SetError(txtDNI, "Por favor ingrese un DNI valido");
                errorProvider3.SetError(txtDNI, "");
            }
            else
            {
                errorProvider1.SetError(txtDNI, "");
                errorProvider2.SetError(txtDNI, "");
                errorProvider3.SetError(txtDNI, "Correcto");
            }

            bool ValidaDNI(string dni)
            {

                if (Regex.Match(dni, @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$").Success == true)
                {
                    //dni correcto
                    return true;
                }
                else
                {
                    //dni incorrecto
                    return false;
                }
            }
        }

        private void txtContra_MouseUp(object sender, MouseEventArgs e)
        {            
            txtContra.PasswordChar = '\0';         
        }

        private void txtContra_MouseLeave(object sender, EventArgs e) 
        {
            txtContra.PasswordChar = '*';
        }

        private void txtContra_Validating(object sender, CancelEventArgs e)
        {
            if (txtContra.Text == string.Empty)
            {

                errorProvider1.SetError(txtContra, "Por favor ingrese una contraseña");
                errorProvider2.SetError(txtContra, "");
                errorProvider3.SetError(txtContra, "");
            }
            else
            {
                errorProvider1.SetError(txtContra, "");
                errorProvider2.SetError(txtContra, "");
                errorProvider3.SetError(txtContra, "Correcto");
            }
        }
    }
}
