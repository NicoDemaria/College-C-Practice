using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLP1
{
    public partial class Registrar_Vizualizaciones : Form
    {
        public Registrar_Vizualizaciones()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Registrar_Vizualizaciones_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            for (int i = 0; i < Data.VectorGenero.Length; i++)
            {
                comboBox1.Items.Add(Data.VectorGenero[i].Nombre);
            }
            for (int i = 0; i < Data.meses.Length; i++)
            {
                comboBox2.Items.Add(Data.meses[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int genero = comboBox1.SelectedIndex;
            int mes = comboBox2.SelectedIndex;
            int valorIngresado = Convert.ToInt32(textBox1.Text) ;


            if (textBox1.Text != "")
            {
                Data.matriz[genero, mes] += valorIngresado;
                MessageBox.Show("Valor ingresado correctamente");
                textBox1.Text = "";
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                button1.Enabled = false;

            }
            else
            {
                MessageBox.Show("Ingrese un valor valido");
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }
    }
}
