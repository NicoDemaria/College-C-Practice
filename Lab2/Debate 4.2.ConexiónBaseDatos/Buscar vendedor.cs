using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_4._2.ConexiónBaseDatos
{
    public partial class Buscar_vendedor : Form
    {
        public Buscar_vendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            claseCliente clase = new claseCliente();



            clase.buscarCliente(Convert.ToInt32(textBox1.Text));



            if (clase.IdCliente != 0)
            {
                labelCodigo.Text = clase.IdCliente.ToString();
                labelNombre.Text = clase.nom.ToString();
                labelDeuda.Text = clase.deud.ToString();
                labelCiudad.Text = clase.ciudad.ToString();
            }
            else
            {
                MessageBox.Show("Cliente no encontrado, ingrese un codigo valido");
                textBox1.Clear();
                labelCodigo.Text = "";
                labelNombre.Text = "";
                labelDeuda.Text = "";
                labelCiudad.Text = "";
            }


        }
    }
}
