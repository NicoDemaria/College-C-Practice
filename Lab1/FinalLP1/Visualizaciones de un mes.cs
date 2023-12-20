using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLP1
{
    public partial class Visualizaciones_de_un_mes : Form
    {
        public Visualizaciones_de_un_mes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Visualizaciones_de_un_mes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.meses.Length; i++)
            {
                comboBox1.Items.Add(Data.meses[i]);
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string mes = comboBox1.SelectedItem.ToString();
            decimal total = 0;
            decimal max = 0;
            decimal min = 0;

            for (int j = 0; j < Data.meses.Length; j++)
            {
                if (Data.meses[j] == mes)
                {
                    for (int i = 0; i < Data.VectorGenero.Length; i++)
                    {
                        dataGridView1.Rows.Add(Data.VectorGenero[i].Nombre, Data.matriz[i, comboBox1.SelectedIndex]);
                        total += Data.matriz[i, comboBox1.SelectedIndex];
                        if (i == 0)
                        {
                            max = Data.matriz[i, comboBox1.SelectedIndex];
                            min = Data.matriz[i, comboBox1.SelectedIndex];
                        }
                        else
                        {
                            if (Data.matriz[i, comboBox1.SelectedIndex] > max)
                            {
                                max = Data.matriz[i, comboBox1.SelectedIndex];
                            }
                            if (Data.matriz[i, comboBox1.SelectedIndex] < min)
                            {
                                min = Data.matriz[i, comboBox1.SelectedIndex];
                            }
                        }
                        


                    }

                }
            }
            labelCantidad.Text = total.ToString();
            labelProm.Text = (total / 10).ToString();
            labelMax.Text = max.ToString();
            labelMin.Text = min.ToString();



        }
    }
}
