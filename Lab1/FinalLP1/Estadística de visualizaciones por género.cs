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
    public partial class Estadística_de_visualizaciones_por_género : Form
    {
        public Estadística_de_visualizaciones_por_género()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Estadística_de_visualizaciones_por_género_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                dataGridView1.Rows.Clear();

                for (int j = 0; j < Data.VectorGenero.Length; j++)
                {
                    decimal total = 0;
                    decimal max = 0;
                    decimal min = 0;
                    int ind = 0;
                    for (int i = 0; i < Data.meses.Length; i++)
                    {
                        total += Data.matriz[j, i];
                        if (i == 0)
                        {
                            max = Data.matriz[j, i];
                            min = Data.matriz[j, i];
                        }
                        else
                        {
                            if (Data.matriz[j, i] < max)
                            {
                                max = Data.matriz[j, i];
                                ind = i;
                            }
                            if (Data.matriz[j, i] > min)
                            {
                                min = Data.matriz[j, i];
                            }
                        }

                    }
                    dataGridView1.Rows.Add(Data.VectorGenero[j].Nombre, total, total / 12, min, max);




                }


            }
        }
    }
}
