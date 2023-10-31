using System;
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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < data.vectorCliente.Length; i++)
           if (data.vectorCliente[i].nombre != null)
        {
            comboBox1.Items.Add(data.vectorCliente[i].nombre);
        }
        }

        private void buttonMostrar_Click(object sender, EventArgs e)

        {
            

            (decimal,decimal ) var = data.consultarCliente(comboBox1);

            labelDeuda.Text = var.Item1.ToString();
            labelLimite.Text = var.Item2.ToString();
        }
    }
}
