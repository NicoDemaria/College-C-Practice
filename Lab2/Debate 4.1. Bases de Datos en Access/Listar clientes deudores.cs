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
    public partial class Listar_clientes_deudores : Form
    {
        public Listar_clientes_deudores()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            claseCliente  cliente = new claseCliente();
            cliente.listarDeudores(dataGridView2);

            labelTotal.Text = cliente.TotalDeuda.ToString("0.00");
            labelCantidad.Text= cliente.CantidadDeudores.ToString();
            Promedio.Text = cliente.calculoPromedio.ToString("0.00");
        }
    }
}
