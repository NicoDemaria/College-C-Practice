using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormColores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBoxLetras_Enter(object sender, EventArgs e)
        {

        }

        private void FondoRojo_Enter(object sender, EventArgs e)
        {

        }

        private void letraVerde_CheckedChanged(object sender, EventArgs e)
        {
            labelTest.ForeColor = Color.Green;
        }

        private void letraRoja_CheckedChanged(object sender, EventArgs e)
        {
            labelTest.ForeColor = Color.Red;
        }

        private void letraAmarilla_CheckedChanged(object sender, EventArgs e)
        {
            labelTest.ForeColor = Color.Yellow;

        }

        private void fondoVerde_CheckedChanged(object sender, EventArgs e)
        {
            labelTest.BackColor = Color.Green;

        }

        private void RojoFondo_CheckedChanged(object sender, EventArgs e)
        {
            labelTest.BackColor = Color.Red;

        }

        private void FondoAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            labelTest.BackColor = Color.Yellow;

        }
    }
}
