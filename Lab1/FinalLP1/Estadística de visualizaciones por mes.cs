using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalLP1
{
    public partial class Estadística_de_visualizaciones_por_mes : Form
    {
        public Estadística_de_visualizaciones_por_mes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Estadística_de_visualizaciones_por_mes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
           
            for (int j = 0; j < Data.meses.Length; j++)
            {
                 decimal total = 0;
            decimal max = 0;
            decimal min = 0;
            int ind = 0;
                for (int i = 0; i < Data.VectorGenero.Length; i++)
                {
                    total += Data.matriz[i, j];
                    if (i == 0)
                    {
                        max = Data.matriz[i, j];
                        min = Data.matriz[i, j];
                    }
                    else
                    {
                        if (Data.matriz[i, j] > max)
                        {
                            max = Data.matriz[i, j];
                            ind = i;
                        }
                        if (Data.matriz[i, j] < min)
                        {
                            min = Data.matriz[i, j];
                        }
                    }

                }
                dataGridView1.Rows.Add(Data.meses[j], total, total / 12, max, min);




            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
