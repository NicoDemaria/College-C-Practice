using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_LP2_VECTORES_REGISTROS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca acerca = new Acerca();
            acerca.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarNuevoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newVendedor formVendedor = new newVendedor();
            formVendedor.ShowDialog();
            

        }

        private void listaVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaVendedores listaVendedoresForm = new listaVendedores();
            listaVendedoresForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void consultaDeVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaVendedor consultaVendedor = new consultaVendedor();
            consultaVendedor.ShowDialog();

        }
    }










}
