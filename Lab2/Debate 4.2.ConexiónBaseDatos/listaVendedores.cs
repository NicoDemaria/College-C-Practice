using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_4._2.ConexiónBaseDatos
{
    public partial class listaVendedores : Form
    {
        public listaVendedores()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            claseCliente claseCliente = new claseCliente();

           // claseCliente.listar(Grilla);



            claseCliente.ListarDeudores(Grilla);


            labelCantidad.Text = claseCliente.cantidadDeudores.ToString();
            labelTotalDeuda.Text = claseCliente.totalDeuda.ToString();
            label1.Text = claseCliente.promedio.ToString();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            claseCliente claseCliente = new claseCliente();


            claseCliente.generarReporteClientes();
            MessageBox.Show("Reporte generado correctamente");
        }
    }
}
