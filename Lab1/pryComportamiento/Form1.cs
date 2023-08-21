using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComportamiento
{
    public partial class frmComportamiento : Form
    {
        public frmComportamiento()
        {
            InitializeComponent();
        }

      

        private void frmComportamiento_Load(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != " ")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != " ")
            { 
                txtApellido.Enabled = true;
            }
            else
            { txtNombre.Enabled = false;}
            
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " + txtNombre.Text + " Apellido: " + txtApellido.Text); // limpiar controles
            txtNombre.Text = " "; txtApellido.Text = " ";
            txtNombre.Focus();
        }
    }
}
