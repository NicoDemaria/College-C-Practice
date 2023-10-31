using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_5._2.Sumando_números_secuenciales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal numero = Convert.ToDecimal(textBox1.Text);
            decimal resultado = 0;

            for (int i = 0; i <= numero; i++)
            {
                resultado += i;
            }

            label1.Text = resultado.ToString();
        }
    }
}
