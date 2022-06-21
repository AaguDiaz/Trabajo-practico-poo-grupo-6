using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = rbSi.Checked;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = rbNo.Checked;
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            

        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
            nombre = "Hernan";
            contraseña = "adm123";
            if (txtNomLogin.Text==nombre||txtContraLogin.Text==contraseña)
            {
                this.Hide();

                Form2 frm = new Form2();

                frm.Show();

            }
            else
            {
                MessageBox.Show("Nombre y contraseña no coinciden ");
            }
        }
    }
}
