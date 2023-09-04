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

        private void button1_Click(object sender, EventArgs e)
        {

            
            double tempc = 0;
            double resultRankine = 0;
            double resultFahe = 0;
            double resultKelvin = 0;
            tempc = Convert.ToDouble(textBox1.Text);

            resultFahe = (tempc * 1.8) + 32;

            resultRankine = resultFahe + 459.67;
            resultKelvin = resultRankine / 1.8;








            labelRankine.Text = resultRankine.ToString();
            labelFahe.Text = resultFahe.ToString();
            labelKelvin.Text = resultKelvin.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(10);
        }
    }
}
    