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
    public partial class Listado_general_de_contribuyentes : Form
    {
        public Listado_general_de_contribuyentes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            data.cargarGrilla(dataGridView1);
            (int,decimal,decimal) var = data.calcularTotales();

            labelCantidad.Text = var.Item1.ToString();
            labelTotalDeuda.Text = var.Item2.ToString();
            labelTotalIntereses.Text = var.Item3.ToString();


        }
    }
}
