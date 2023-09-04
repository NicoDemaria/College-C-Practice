using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altura = 0;
            double peso = 0;
            double imc = 0;


            altura = Convert.ToDouble( textBoxAltura.Text);

            peso = Convert.ToDouble(textBoxPeso.Text);

            imc = peso / (altura * altura);

            labelResultadoIMC.Text = imc.ToString();


        }

        private void textBoxPeso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
