using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LP1_VECTORES
{
    public partial class Nuevo_Empleado : Form
    {
        public Nuevo_Empleado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {
            data.cargarDatosEmpleado(Convert.ToInt32(textBoxCodigo.Text),textBoxNombre.Text,textBoxCategoria.Text, Convert.ToInt32(textBoxSueldo.Text));
            textBoxCategoria.Clear();
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxSueldo.Clear();
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text != "")
            {
                textBoxNombre.Enabled = true;
            }
        }

        private void Nuevo_Empleado_Load(object sender, EventArgs e)
        {
            textBoxNombre.Enabled = false;
            textBoxCategoria.Enabled = false;
            textBoxSueldo.Enabled = false; 
            buttonCargarDatos.Enabled = false;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "")
            {
                textBoxCategoria.Enabled = true;
            }
        }

        private void textBoxCategoria_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCategoria.Text != "")
            {
                textBoxSueldo.Enabled = true;
            }
        }

        private void textBoxSueldo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSueldo.Text != "")
            {
                buttonCargarDatos.Enabled = true;
            }
        }
    }
}
