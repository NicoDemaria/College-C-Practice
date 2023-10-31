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
    public partial class SistemaGestionClientes : Form
    {
        public SistemaGestionClientes()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarCliente cliente = new agregarCliente();
            cliente.ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           BusquedaCliente busquedaCliente = new BusquedaCliente();
            busquedaCliente.ShowDialog();   
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.ShowDialog();

        }

        private void SistemaGestionClientes_Load(object sender, EventArgs e)
        {
            data.testData();
        }

        private void listadoDeDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDeudores listadoDeudores = new ListadoDeudores();
            listadoDeudores.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCliente consultaCliente = new ConsultaCliente();
            consultaCliente.ShowDialog();
        }
    }
}
