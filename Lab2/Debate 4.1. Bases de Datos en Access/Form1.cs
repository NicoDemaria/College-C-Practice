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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_todos_los_clientes todosClientes = new Listado_todos_los_clientes();
            todosClientes.ShowDialog();
        }

        private void listarDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_clientes_deudores deudores = new Listar_clientes_deudores();
            deudores.ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarCliente = new BuscarCliente();
            buscarCliente.ShowDialog();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo_cliente nuevo_Cliente = new nuevo_cliente();
            nuevo_Cliente.ShowDialog();
        }

        private void listadoClientePorCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_clientes_de_una_ciudad listado_Clientes_De_Una_Ciudad = new Listado_clientes_de_una_ciudad();
            listado_Clientes_De_Una_Ciudad.ShowDialog();    
        }
    }
}
