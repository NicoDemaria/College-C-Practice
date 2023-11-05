using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionContribuyentes
{
    public partial class Consulta_de_datos_de_un_contribuyente : Form
    {
        public Consulta_de_datos_de_un_contribuyente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

            (int,decimal) var = data.consultarCliente(comboBox1);

            labelCod.Text = var.Item1.ToString();
            labeldeu.Text = var.Item2.ToString();
        }

        private void Consulta_de_datos_de_un_contribuyente_Load(object sender, EventArgs e)
        {
            data.cargarCombo(comboBox1);
        }
    }
}
