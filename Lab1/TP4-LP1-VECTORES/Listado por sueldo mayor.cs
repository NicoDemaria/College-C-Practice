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
    public partial class Listado_por_sueldo_mayor : Form
    {
        public Listado_por_sueldo_mayor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            (decimal, decimal) var = data.ListarPorSueldo(dataGridView3,textBoxsueldo.Text);

            labelTotalSueldo.Text = var.Item1.ToString();
            labelCantidadEmpleados.Text = var.Item2.ToString();
        }
    }
}
