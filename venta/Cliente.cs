using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace venta
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        public Cliente(string n, string em, string d, string c, string cl, string nl)
        {
            InitializeComponent();
            lblUsuario.Text = nl;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void lblUsuario_Click(object sender, EventArgs e){}
        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            if (txtFactura.Text == "" || ValidaFactura(txtFactura.Text)==false)
            {
                MessageBox.Show("falta cargar factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ConexionSql f = new ConexionSql();
                    f.AgregarFactura(txtFactura.Text);
                    MessageBox.Show("La factura ha sido cargada con éxito");
                    
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            bool ValidaFactura(string factura)
            {

                if (Regex.Match(factura, @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$").Success == true)
                {
                    //factura correcto
                    return true;
                }
                else
                {
                    //factura incorrecto
                    return false;
                }
            }
        }
    }
}
