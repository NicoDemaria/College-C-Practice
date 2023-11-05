using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_4._1.Bases_de_Datos_en_Access
{
    public partial class nuevo_cliente : Form
    {
        public nuevo_cliente()
        {
            InitializeComponent();
        }

        private void nuevo_cliente_Load(object sender, EventArgs e)
        {
            claseCiudad claseCiudad = new claseCiudad();
            claseCiudad.listar(comboBox1);
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            claseCliente claseCliente = new claseCliente();

            claseCliente.devolverlimite = Convert.ToDecimal(textBoxLimCredito.Text);
            claseCliente.devolverNombreCliente = textBoxNombre.Text;
            claseCliente.devolveridCiudad = Convert.ToInt32(comboBox1.SelectedValue);

            claseCliente.Agregar();
            MessageBox.Show("Cliente cargado");

            textBoxNombre.Clear();
            textBoxLimCredito.Clear();
            comboBox1.SelectedIndex = 0;

            
        }

        private void buttonCargarSql_Click(object sender, EventArgs e)
        {
            claseCliente claseCliente = new claseCliente();

            claseCliente.devolverNombreCliente = textBoxNombre.Text;
            claseCliente.devolverlimite = Convert.ToDecimal(textBoxLimCredito.Text);
            claseCliente.devolveridCiudad = Convert.ToInt32(comboBox1.SelectedValue);

            claseCliente.agregarConSQL();

            MessageBox.Show("Cliente cargado");
            textBoxLimCredito.Clear();
            textBoxNombre.Clear();
            comboBox1.SelectedIndex = 0;
        }
    }
}
