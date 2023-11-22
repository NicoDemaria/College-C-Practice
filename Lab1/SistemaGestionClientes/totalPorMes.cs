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
    public partial class totalPorMes : Form
    {
        public totalPorMes()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Decimal TotalGeneral = 0;
            for (Int32 c = 0; c < data.Meses.Length; c++)
            {
                Decimal Total = 0;
                for (Int32 f = 0; f < data.sucursales.Length; f++)
                {
                    Total = Total + Matriz.ventas[c, f];
                }
                TotalGeneral = TotalGeneral + Total;
                decimal promedio = Total / data.sucursales.Length;
                dataGridView1.Rows.Add(data.Meses[c],promedio, Total); 
            }
        }
    }
}
