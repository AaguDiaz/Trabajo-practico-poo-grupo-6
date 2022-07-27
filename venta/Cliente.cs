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
            string nombreUsuario = nl;
            dtgFaturas.Visible = false;
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
            if (txtFactura.Text == "" && ValidaFactura(txtFactura.Text) == false)
            {
                MessageBox.Show("falta cargar factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTipo.Text == "")
            {
                MessageBox.Show("falta especificar el tipo de factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 

                try
                {
                    ConexionSql f = new ConexionSql();
                    f.AgregarFactura2(txtFactura.Text,dpFecha.Text,cmbTipo.Text,lblUsuario.Text);
                    ConexionSql el = new ConexionSql();
                    dtgFaturas.DataSource = el.actualizartablaF(lblUsuario.Text);
                    dtgFaturas.Visible = true;
                    MessageBox.Show("La factura ha sido cargada con éxito");

                }
                catch (Exception ex)
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

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasHDataSet3.Facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter2.Fill(this.ventasHDataSet3.Facturas);

        }
        public void button1_Click(object sender, EventArgs e)//boton selecciona las facturas del usuario
        {
            dtgFaturas.Visible = true;
            string nombre = lblUsuario.Text;
            ConexionSql el = new ConexionSql();
            SeleccionarFactura();
            dtgFaturas.DataSource = el.actualizartablaF(nombre);
         }
        public void SeleccionarFactura()
        {

            using (SqlConnection conn = new SqlConnection("Data Source=W10NTBX-SLOTI;Initial Catalog=VentasH;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Facturas where IDfactura ='" + txtIdfactura.Text + "'", conn);
                SqlDataReader reg = cmd.ExecuteReader();
                if (reg.Read())
                {
                   txtFactura.Text =  reg["NumFactura"].ToString();
                   dpFecha.Text = reg["FechaEmision"].ToString();
                   cmbTipo.Text = reg["TipoFactura"].ToString();
                }
                ;

            }

        }
        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            dtgFaturas.Visible = true;
            ConexionSql el = new ConexionSql();
            el.eliminarFactura(txtIdfactura.Text);
            dtgFaturas.DataSource = el.actualizartablaF(lblUsuario.Text);
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            dtgFaturas.Visible = true;
            ConexionSql m = new ConexionSql();
            m.ModificarFactura(txtFactura.Text, dpFecha.Text, cmbTipo.Text,txtIdfactura.Text);
            dtgFaturas.DataSource = m.actualizartablaF(lblUsuario.Text);
        }
    }
}
