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

namespace venta
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(string n, string em, string d, string c, string cl, string nl)
        {
            InitializeComponent();

        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasHDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.ventasHDataSet.Usuarios);
        }
       
        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            
            ConexionSql agregar = new ConexionSql();
            agregar.Agregar(txtDNI.Text, txtNombre.Text, txtEmail.Text,txtContra.Text);
            dtgUsuarios.DataSource = agregar.actualizartabla();
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            ConexionSql m = new ConexionSql();
            m.Modificar(txtNombre.Text,txtDNI.Text,txtEmail.Text,txtContra.Text,txtID.Text);
            dtgUsuarios.DataSource = m.actualizartabla();
        }
        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            ConexionSql el  = new ConexionSql();
            el.eliminar(txtID.Text);
            dtgUsuarios.DataSource = el.actualizartabla();
        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ConexionSql el = new ConexionSql();
            SeleccionarFactura();
            dtgUsuarios.DataSource = el.actualizartabla();
        }
        public void SeleccionarFactura()
        {

            using (SqlConnection conn = new SqlConnection("Data Source=W10NTBX-SLOTI;Initial Catalog=VentasH;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Usuarios where Id ='" + txtID.Text + "'", conn);
                SqlDataReader reg = cmd.ExecuteReader();
                if (reg.Read())
                {
                    txtNombre.Text = reg["Nombre"].ToString();
                    txtContra.Text = reg["Contrasena"].ToString();
                    txtDNI.Text = reg["Dni"].ToString();
                    txtEmail.Text = reg["Email"].ToString();
                }
                ;

            }

        }
    }
}
