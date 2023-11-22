using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_4._1.Bases_de_Datos_en_Access
{
    public partial class Listado_todos_los_clientes : Form
    {
        public Listado_todos_los_clientes()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            claseCliente cliente = new claseCliente();

            cliente.listarDeudoresOtraTabla(dataGridView1);

            labelTotal.Text = cliente.devolverDeuda.ToString();
            labelCantidad.Text = cliente.CantidadDeudores.ToString();
            kabelPromedio.Text = cliente.calculoPromedio.ToString();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            claseCliente cliente = new claseCliente();

            cliente.generarReporte();
            MessageBox.Show("Reporte generado con exito");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.PrinterSettings = printDialog1.PrinterSettings;
            printDocument1.Print();
            MessageBox.Show("Impresion realizada con exito");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           claseCliente cliente = new claseCliente();

            cliente.Imprimir(e);


        }
    }
}
