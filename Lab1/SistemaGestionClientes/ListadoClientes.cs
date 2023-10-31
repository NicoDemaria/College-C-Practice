﻿using System;
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
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            (decimal,decimal,decimal) var = data.mostrarClientes(dataGridView1);

            labelTotalCli.Text = var.Item1.ToString();
            labelCantidadCli.Text = var.Item2.ToString();
            labelPromedioCli.Text = var.Item3.ToString();



        }





    }
}
