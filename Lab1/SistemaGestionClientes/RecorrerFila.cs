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
    public partial class RecorrerFila : Form
    {
        public RecorrerFila()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            int f = comboBox1.SelectedIndex;
            decimal total = 0;

            if (f == -1)
            {
                MessageBox.Show("Debe seleccionar un mes");
            }
            else
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < data.Meses.Length; i++)
                {
                    dataGridView1.Rows.Add(data.Meses[i], Matriz.ventas[i, f].ToString());
                    total += Matriz.ventas[i, f];

                }
            }
            labelTotalCli.Text = total.ToString();
            labelPromedioCli.Text = (total / data.Meses.Length).ToString();
        }

        private void RecorrerFila_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = data.Meses;
        }
    }
}
