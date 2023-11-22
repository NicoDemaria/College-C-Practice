using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_5._4.Calcular_la_potencia_de_un_número
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Calcular_Click(object sender, EventArgs e)
        {
            

            decimal numero = Convert.ToDecimal(textBox1.Text);

            decimal base1 = Convert.ToDecimal(textBox2.Text);
            decimal total = potencia(numero, base1);


           

            label4.Text = total.ToString();
            
        }

        private void controlarDatos()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Calcular.Enabled = true;
            }
            else { Calcular.Enabled = false; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controlarDatos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            controlarDatos();
        }


        private decimal potencia(decimal numero, decimal base1)
        {
            decimal total = 1;

            for (int i = 0; i < base1; i++)
            {

                total = total * numero;

            }

            return total;
        }
    }
}
