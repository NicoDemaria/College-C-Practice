using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void facturasPorTituToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormAcercaDe formAcercaDe = new FormAcercaDe();
            formAcercaDe.ShowDialog();
        }

        private void facturasPorFormaDePagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FacturasFormaPago facturasFormaPago = new FacturasFormaPago();
            facturasFormaPago.ShowDialog();
        }
    }
}
