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
    public partial class Visualizaciones_de_un_género : Form
    {
        public Visualizaciones_de_un_género()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Visualizaciones_de_un_género_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.VectorGenero.Length; i++)
            {
                comboBox1.Items.Add(Data.VectorGenero[i].Nombre);
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string genero = comboBox1.SelectedItem.ToString();
            decimal total = 0;
            decimal max = 0;
            decimal min = 0;

            for (int j = 0; j < Data.VectorGenero.Length; j++)
            {
                if (Data.VectorGenero[j].Nombre == genero)
                {
                    for (int i = 0; i < Data.meses.Length; i++)
                    {
                        dataGridView1.Rows.Add(Data.meses[i], Data.matriz[comboBox1.SelectedIndex,i ]);
                        total += Data.matriz[comboBox1.SelectedIndex, i ];
                        if (i == 0)
                        {
                            max = Data.matriz[comboBox1.SelectedIndex, i];
                            min = Data.matriz[comboBox1.SelectedIndex, i];
                        }
                        else
                        {
                            if (Data.matriz[comboBox1.SelectedIndex, i] > max)
                            {
                                max = Data.matriz[comboBox1.SelectedIndex, i];
                            }
                            if (Data.matriz[comboBox1.SelectedIndex, i] < min)
                            {
                                min = Data.matriz[comboBox1.SelectedIndex, i];
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
