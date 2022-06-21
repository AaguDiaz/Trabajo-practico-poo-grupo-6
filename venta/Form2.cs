using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora.Usuarios;
using Controladora.Conexion;

namespace venta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecuperarInfo();
            ConexionSql conexion = new ConexionSql();
            MessageBox.Show("Conectando.." + conexion.PruebaConectar());
        }

        private void RecuperarInfo()
        {
            Usuario oUsuario = new Usuario();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            int DNI = 0; int.TryParse(txtDNI.Text, out DNI);
            oUsuario.ID = ID;
            oUsuario.Nombre = txtNombre.Text;
            oUsuario.Email = txtEmail.Text;
            oUsuario.Contraseña = txtContra.Text;
            oUsuario.DNI = DNI;
        }
    }
}
