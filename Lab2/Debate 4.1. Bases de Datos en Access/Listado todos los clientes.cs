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
    }
}
