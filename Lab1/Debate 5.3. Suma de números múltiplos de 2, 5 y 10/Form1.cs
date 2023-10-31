using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_5._3.Suma_de_números_múltiplos_de_2__5_y_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal x = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            decimal numero = decimal.Parse(textBox1.Text);
            decimal total = 0;

            for (int i = 0; i <= numero; i++)
            {
                if (i % x == 0) 
                {
                    total += i;
                }
            }

            label3.Text = total.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            x = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            x = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            x = 5;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            x = 10;
        }


    }
}
