using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionClientes
{
    public partial class agregarCliente : Form
    {
        public agregarCliente()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonCargar_Click(object sender, EventArgs e)
        {
            data.cargarVectorCliente(Convert.ToInt32(textBoxCodigo.Text),textBoxNombre.Text,Convert.ToDecimal(textBoxDeuda.Text),Convert.ToDecimal(textBoxLimite.Text));
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxDeuda.Clear();
            textBoxLimite.Clear();
        }

        private void agregarCliente_Load(object sender, EventArgs e)
        {
            textBoxNombre.Enabled = false;
            textBoxDeuda.Enabled = false;  
            textBoxLimite   .Enabled = false;
            ButtonCargar.Enabled = false;
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
                textBoxLimite.Enabled = true;
            }
        }

        private void textBoxLimite_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDeuda.Text != "")
            {
                ButtonCargar.Enabled = true;
            }
        }
    }
}
