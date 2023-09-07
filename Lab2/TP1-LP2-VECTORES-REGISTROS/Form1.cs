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



        public struct RegistroVendedor
        {

            public int codigo;
            public string nombre;
            public decimal sueldo;
        }
        int IND = 0;
        public RegistroVendedor[] Vendedor  = new RegistroVendedor[100];

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
    }










}
