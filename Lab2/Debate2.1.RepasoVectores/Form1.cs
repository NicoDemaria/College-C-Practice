using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate2._1.RepasoVectores
{
    public partial class Form1 : Form
    {
        string[] alumnos = new string[10];
        int indice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCargarNombre_Click(object sender, EventArgs e)
        {
            if (indice <= alumnos.Length)
            {
                alumnos[indice] = textBoxNombre.Text;
                indice++;
                textBoxNombre.Clear();
                textBoxNombre.Text = "";
                
            }
            else
            {
                MessageBox.Show("No se puede cargar");
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonFor_Click(object sender, EventArgs e)
            
        {
            Listar();
  
        }
        private void Listar()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < indice; i++)
            {
                listBox1.Items.Add(alumnos[i]);
            }
        }

        private void buttonWhile_Click(object sender, EventArgs e)



        {
            listBox1.Items.Clear();
            int i = 0;

            while (i < alumnos.Length && alumnos[i] != null)
            {
                {
                    listBox1.Items.Add(alumnos[i]);
                    i++;
                }
            }
        }
    }
}
