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
    public partial class ConsultarVenta : Form
    {
        public ConsultarVenta()
        {
            InitializeComponent();
        }

        private void ConsultarVenta_Load(object sender, EventArgs e)
        {
           

            comboBox2.DataSource = data.sucursales;
            comboBox1.DataSource = data.Meses;
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

            int f = comboBox1.SelectedIndex;
            int c = comboBox2.SelectedIndex;

            if (f == -1 || c == -1)
            {
                MessageBox.Show("Debe seleccionar una sucursal y un mes");
            }
            else
            {
                labelVenta.Text = Convert.ToString(Matriz.ventas[f, c]);
            }

        }
    }
}
