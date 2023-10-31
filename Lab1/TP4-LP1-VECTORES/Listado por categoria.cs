using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LP1_VECTORES
{
    public partial class Listado_por_categoria : Form
    {
        public Listado_por_categoria()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Listado_por_categoria_Load(object sender, EventArgs e)
        {
            textBoxCategoria.Text = "IT";
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            
            
            (decimal,decimal) var =data.ListarPorCategoria(dataGridView2,textBoxCategoria.Text);

            labelTotalSueldo.Text = var.Item1.ToString();
            labelCantidadEmpleados.Text = var.Item2.ToString();


        }
    }
}
