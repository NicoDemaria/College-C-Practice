using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoPrevioParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            claseIdioma.cargarComboIdioma(comboBoxPaises);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {

            int idIdioma = Convert.ToInt32(comboBoxPaises.SelectedValue);
            claseLibro.listarGrilla(dataGridView1,idIdioma);


            labelCantidad.Text = claseLibro.cantidad.ToString();
            labelTotal.Text = claseLibro.devolverTotal.ToString();
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {
            int idIdioma = Convert.ToInt32(comboBoxPaises.SelectedValue);


            claseLibro.generarCSV(idIdioma);
            MessageBox.Show("Archivo generado");
        }

        private void buttontxt_Click(object sender, EventArgs e)
        {
            int idIdioma = Convert.ToInt32(comboBoxPaises.SelectedValue);


            claseLibro.generarTXT(idIdioma);
            MessageBox.Show("Archivo generado");
        }
    }
}
