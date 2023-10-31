using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_7._3.Y_ahora_Caracteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();

            char[] frases = textBox1.Text.ToCharArray() ;
            char letra = Convert.ToChar(textBox2.Text.ToLower());

            int cantidad = 0;


            for (int i = 0; i < frases.Length; i++)
            {
                if (letra  == frases[i])
                {
                    cantidad++;

                    
                }
               
            }

            labelTotal.Text = cantidad.ToString();


            



        }

     

        
    }
}
