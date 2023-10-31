using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_7._6.Vector_constituido_por_registros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      


        private void cargarVector()
        {
            int i = 0;
            while (Convert.ToInt32(textBoxCodigo.Text) != datosGlobales.RegClientes[i].codigo && i < datosGlobales.ind)
            {
                i++;
            }
            if (i == datosGlobales.ind)
            {
                {
                    datosGlobales.RegClientes[datosGlobales.ind].codigo = Convert.ToInt32(textBoxCodigo.Text);
                    datosGlobales.RegClientes[datosGlobales.ind].nombre = textBoxNombre.Text;
                    datosGlobales.RegClientes[datosGlobales.ind].deuda = Convert.ToDecimal(textBoxDeuda.Text);
                    datosGlobales.RegClientes[datosGlobales.ind].limite = Convert.ToDecimal(textBoxLimite.Text);
                    datosGlobales.ind++;
                    textBoxCodigo.Text = "";
                    textBoxNombre.Text = "";
                    textBoxDeuda.Text = "";
                    textBoxLimite.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Codigo repetido,porfavor ingrese uno diferente.");
                textBoxCodigo.Text = "";
            }

        }


        private void listarClientesDeudores()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < datosGlobales.ind; i++)
            {
                if (datosGlobales.RegClientes[i].deuda > 0)
                {
                    dataGridView1.Rows.Add(datosGlobales.RegClientes[i].codigo, datosGlobales.RegClientes[i].nombre, datosGlobales.RegClientes[i].deuda, datosGlobales.RegClientes[i].limite);

                }

            }


        }
        private void listarClientes()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < datosGlobales.ind; i++)
            {
                
                
                    dataGridView1.Rows.Add(datosGlobales.RegClientes[i].codigo, datosGlobales.RegClientes[i].nombre, datosGlobales.RegClientes[i].deuda, datosGlobales.RegClientes[i].limite);

                

            }


        }

        private decimal calcularTotal()
        {
            decimal total = 0;

            for (int i = 0; i < datosGlobales.RegClientes.Length; i++)
            {
                total += datosGlobales.RegClientes[i].deuda;
            }
            return total;
        }


        private void buttonCargar_Click(object sender, EventArgs e)
        {
            cargarVector();
            listarClientes();
            labelTotalDeuda.Text =  calcularTotal().ToString();


        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text != "")
            {
                textBoxNombre.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxCodigo.Enabled = true;
            textBoxNombre.Enabled = false;
            textBoxDeuda.Enabled = false;
            textBoxLimite.Enabled = false;
            buttonCargar.Enabled = false;
            
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "")
            {
                textBoxDeuda.Enabled = true;
            }
        }

        private void textBoxDeuda_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDeuda.Text != "")
            {
                textBoxLimite.Enabled = true;
            }
        }

        private void textBoxLimite_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLimite.Text != "")
            {
                buttonCargar.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listarClientesDeudores();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listarClientes();
        }
    }
}
