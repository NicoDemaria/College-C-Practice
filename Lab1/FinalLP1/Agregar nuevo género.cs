using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLP1
{
    public partial class Agregar_nuevo_género_ : Form
    {
        public Agregar_nuevo_género_()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Agregar_nuevo_género__Load(object sender, EventArgs e)
        {
            textBoxNombre.Enabled = false;
            textBoxDesc.Enabled = false;
            buttonCargar.Enabled = false;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "")
            {
                textBoxDesc.Enabled = true;
            }
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text != "")
            {
                textBoxNombre.Enabled = true;
            }
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDesc.Text != "")
            {
                buttonCargar.Enabled = true;
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            
            Data.VectorGenero[Data.IND].Codigo = Convert.ToInt32(textBoxCodigo.Text);
            Data.VectorGenero[Data.IND].Nombre = textBoxNombre.Text;
            Data.VectorGenero[Data.IND].Descripcion = textBoxDesc.Text;
            Data.IND++;
            MessageBox.Show("Género cargado correctamente.");
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxDesc.Text = "";
            textBoxNombre.Enabled = false;
            textBoxDesc.Enabled = false;
            buttonCargar.Enabled = false;

        }
    }
}
