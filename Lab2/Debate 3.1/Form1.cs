using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        claseArchivo var = new claseArchivo();

        private void buttonGuardar_Click(object sender, EventArgs e)


        {
            var.Cargar(textBox1.Text);
            MessageBox.Show("Palabra cargada correctamente");
            textBox1.Text = string.Empty;
            buttonGuardar.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                buttonGuardar.Enabled = true;
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            var.Listar(listBox1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
