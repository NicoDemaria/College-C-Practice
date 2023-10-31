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
    public partial class Consulta_de_datos_de_un_empleado : Form
    {
        public Consulta_de_datos_de_un_empleado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Consulta_de_datos_de_un_empleado_Load(object sender, EventArgs e)
        {
             data.cargarComboEmpleados(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (int,string,decimal) var = data.consultarEmpleado(comboBox1);

            labelCodigo.Text = var.Item1.ToString();
            labelCategoria.Text = var.Item2.ToString();
            labelSueldo.Text = var.Item3.ToString();
        }
    }
}
