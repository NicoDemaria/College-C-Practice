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
    public partial class totalVentasSucursal : Form
    {
        public totalVentasSucursal()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Decimal TotalGeneral = 0;
            for (Int32 c = 0; c < data.sucursales.Length; c++)
            {
                Decimal Total = 0;
                for (Int32 f = 0; f < data.Meses.Length; f++)
                {
                    Total = Total + Matriz.ventas[f, c];
                }
                dataGridView1.Rows.Add(data.Meses[c], Total); TotalGeneral = TotalGeneral + Total;
            }
            labelTotalCli.Text = TotalGeneral.ToString(); labelPromedioCli.Text = (TotalGeneral / 4).ToString("0.##");
        }
    }
}
