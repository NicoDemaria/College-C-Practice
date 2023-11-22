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
    public partial class cargaVentas : Form
    {
        public cargaVentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = comboBox1.SelectedIndex;
            int c = comboBox2.SelectedIndex;

            if (f == -1 || c == -1)
            {
                MessageBox.Show("Debe seleccionar una sucursal y un mes");
            }
            else
            {
                Matriz.ventas[f, c] = Convert.ToDecimal(textBox2.Text);
                MessageBox.Show("Venta cargada");
                textBox2.Text = "";
                comboBox2.SelectedIndex = 0;
                comboBox1.SelectedIndex = 0;

            }

            
        }

        private void cargaVentas_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = data.sucursales;
            comboBox1.DataSource = data.Meses;

         
        }
    }
}
