using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_7._1.Vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] jugadores = new string[10];
        int ind = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            
            
                if (ind < jugadores.Length && textBox1.Text != "")
                {
                    jugadores[ind] = textBox1.Text;

                    textBox1.Text = "";
                    ind++;


                    Listar();
                }
                else
                
                {
                    MessageBox.Show("No se puede cargar el dato");               
                }

               


            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") { button1.Enabled = true; }
                
        }

        private void Listar()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ind; i++)
            {
                listBox1.Items.Add(jugadores[i]);
            }
        }
    }
}
