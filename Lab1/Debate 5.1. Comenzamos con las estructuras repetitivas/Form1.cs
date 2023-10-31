using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_5._1.Comenzamos_con_las_estructuras_repetitivas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            int i = 0;
            comboBox1.Items.Clear();
            while (i <= 12)
            {
                {
                    comboBox1.Items.Add(i);
                }
                i++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i <= 12; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
