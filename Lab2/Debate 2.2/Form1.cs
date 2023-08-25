using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] meses = new string[12] {
        "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
        "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

        decimal[] importes = new decimal[12];

        int indice = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMeses.Items.Clear();    
            for (int i = 0; i < meses.Length; i++)
            {
                comboBoxMeses.Items.Add(meses[i]);
            }
            comboBoxMeses.SelectedIndex = 0;
            cargarMeses();

        }
        private void cargarMeses()
        {

            for (int i = 0; i < meses.Length; i++)
            {
                dataGridView1.Rows.Add(meses[i]);
            }
        }

        private void textBoxImporte_TextChanged(object sender, EventArgs e)
        {

           

        }
        
        public void cargarMonto()
        {
            {
                int i = comboBoxMeses.SelectedIndex;
                decimal importe = Convert.ToDecimal(textBoxImporte.Text);
                importes[i] = importe;

            }
        }

        private void agregarFilasYColumnas()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < meses.Length; i++)
            {
                dataGridView1.Rows.Add(meses[i], importes[i]);
            }
        }


        private void buttonCarga_Click(object sender, EventArgs e)
        {
            cargarMonto();
            agregarFilasYColumnas();
        }
    }
}
