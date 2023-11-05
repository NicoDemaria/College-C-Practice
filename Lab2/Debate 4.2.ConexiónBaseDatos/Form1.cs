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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listaVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaVendedores listaVendedoresForm = new listaVendedores();
            listaVendedoresForm.ShowDialog();
        }

        private void buscarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_vendedor buscar_Vendedor = new Buscar_vendedor();
            buscar_Vendedor.ShowDialog();
        }

        private void agregarNuevoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_Nuevo_cliente nuevoCliente = new agregar_Nuevo_cliente();
            nuevoCliente.ShowDialog();
        }
    }
}
