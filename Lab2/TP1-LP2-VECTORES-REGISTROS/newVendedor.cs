using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_LP2_VECTORES_REGISTROS
{
    public partial class newVendedor : Form
    {
        public newVendedor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Consulta de vendedor";
        }

        private void ButtonCargar_Click(object sender, EventArgs e)
        {
     
           
           
            if (datos.IND < datos.Vendedor.Length)
            {

                int i = 0;

                while (datos.Vendedor[i].codigo != Convert.ToInt32(textBoxCodigo.Text) && i < datos.IND) {

                    i++;
                }

            if (i == datos.IND)
                {

                    datos.Vendedor[i].codigo = Convert.ToInt32(textBoxCodigo.Text);
                    datos.Vendedor[i].nombre = textBoxNombre.Text;
                    datos.Vendedor[i].sueldo = Convert.ToInt32(textBoxSueldo.Text);
                    datos.IND++;
                    MessageBox.Show("Vendedor cargador correctamente!");

                    textBoxCodigo.Clear();
                    textBoxNombre.Clear();
                    textBoxSueldo.Clear();
                    textBoxNombre.Enabled = false;
                    textBoxSueldo.Enabled = false;
                    ButtonCargar.Enabled = false;


                }
            else
                {
                    MessageBox.Show("No se pudo cargar, codigo repetido");
                    textBoxCodigo.Clear();
                }

            }
        }

        private void newVendedor_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            textBoxNombre.Enabled = false;
            textBoxSueldo.Enabled   = false;
            ButtonCargar.Enabled = false;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "")
            {
                textBoxSueldo.Enabled=true;
            }
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text != "")
            {
                textBoxNombre.Enabled = true;
            }
        }

        private void textBoxSueldo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSueldo.Text != "")
            {
                ButtonCargar.Enabled=true;
            }
        }
    }
}
