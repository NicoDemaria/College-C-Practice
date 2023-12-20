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
    public partial class Consulta_de_visualizaciones : Form
    {
        public Consulta_de_visualizaciones()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Consulta_de_visualizaciones_Load(object sender, EventArgs e)
        {
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
            labelCantidad.Text = Data.matriz[genero, mes].ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
