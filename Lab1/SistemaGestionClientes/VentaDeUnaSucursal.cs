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
    public partial class VentaDeUnaSucursal : Form
    {
        public VentaDeUnaSucursal()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            int c = comboBox1.SelectedIndex;
            decimal total = 0;

            if (c == -1)
            {
                MessageBox.Show("Debe seleccionar una sucursal");
            }
            else
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < data.Meses.Length; i++)
                {
                    dataGridView1.Rows.Add(data.Meses[i], Matriz.ventas[i, c].ToString());
                    total += Matriz.ventas[i, c];

                }
            }
            labelTotalCli.Text = total.ToString();
            labelPromedioCli.Text = (total / data.Meses.Length).ToString();
        }

        private void VentaDeUnaSucursal_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = data.sucursales;

        }
    }
}
