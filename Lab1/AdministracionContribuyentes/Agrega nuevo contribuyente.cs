using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionContribuyentes
{
    public partial class Agrega_nuevo_contribuyente : Form
    {
        public Agrega_nuevo_contribuyente()
        {
            InitializeComponent();
        }

        private void Agrega_nuevo_contribuyente_Load(object sender, EventArgs e)
        {
            textBoxNombre.Enabled = false;
            textBoxDeuda.Enabled = false;
            buttonCargar.Enabled = false;
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text != "")
            {
                textBoxNombre.Enabled = true;
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "")
            {
                textBoxDeuda.Enabled = true;
            }
        }

        private void textBoxDeuda_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDeuda.Text != "")
            {
                buttonCargar.Enabled = true;
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            data.CargarDatos(Convert.ToInt32(textBoxCodigo.Text), textBoxNombre.Text, Convert.ToDecimal(textBoxDeuda.Text)) ;
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxDeuda.Text = "";
            textBoxNombre.Enabled = false;
            textBoxDeuda.Enabled = false;
            buttonCargar.Enabled = false;
            MessageBox.Show("Datos cargados correctamente");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
