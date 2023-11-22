using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Práctico_Nº_5
{
    public partial class ListadoTotalPorMaquina : Form
    {
        public ListadoTotalPorMaquina()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListadoTotalPorMaquina_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = data.empleados;
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int f = 0; f < data.empleados.Length; f++)
            {
                for (int c = 0; c < data.Maquina.Length; c++)
                {
                    if (comboBox1.Text == data.empleados[f])
                    {
                        dataGridView1.Rows.Add(data.Maquina[c], data.Matriz[f, c]);
                    }
                }
            }
        }
    }
}
