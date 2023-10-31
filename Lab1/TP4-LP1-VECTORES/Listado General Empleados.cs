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
    public partial class Listado_General_Empleados : Form
    {
        public Listado_General_Empleados()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Listado_General_Empleados_Load(object sender, EventArgs e)
        {
            (decimal, decimal) var  = data.ListarGeneral(dataGridView1);

            labelTotalSueldo.Text = var.Item1.ToString();
            labelCantidadEmpleados.Text = var.Item2.ToString();
        }
    }
}
