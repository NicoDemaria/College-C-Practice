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
    public partial class Busqueda_de_Empleado : Form
    {
        public Busqueda_de_Empleado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Busqueda_de_Empleado_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            (int, string,string) var = data.busquedaEmpleado( Convert.ToInt32(textBoxCodigoBuscar.Text));

            labelCodigo.Text = var.Item1.ToString();
            labelCategoria.Text = var.Item2.ToString();
            labelNombre.Text = var.Item3.ToString();
        }
    }
}
