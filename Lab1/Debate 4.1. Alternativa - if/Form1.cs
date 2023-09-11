using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_4._1.Alternativa___if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1 = 0;
        int num2 = 0;
        

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            if (num1 > num2)
            {
                Resultado.Text = "El numero A es mas grande";
            }
            else if (num1 == num2)
            {
                Resultado.Text = "Los numeros son iguales";

            }
            else
            {
                Resultado.Text = "El numero B es mas grande";

            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button2.Enabled = true;

            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button2.Enabled = true;

            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}
