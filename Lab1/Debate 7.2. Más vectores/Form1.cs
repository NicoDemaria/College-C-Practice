using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_7._2.Más_vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] numeros = new int[100];
        int ind = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (ind < numeros.Length)
            {
                numeros[ind] = Convert.ToInt32(textBox1.Text);
                ind++;

                Listar();
            }
            else
            {
                MessageBox.Show("No se pudo cargar el dato");
            }

            labelTotal.Text = Convert.ToString(calcularTotal());


        }
        private int calcularTotal()
        {
            int total = 0;
            for (int i = 0; i < ind; i++)
            {
                total += numeros[i];
            }
            return total;

        }


        private void Listar()
        {
            listBox1.Items.Clear();

            for (int i = 0; i < ind; i++)
            {
                listBox1.Items.Add(numeros[i]);
            }
        }

       
            
    }
    
}
