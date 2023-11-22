using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_PARCIAL___DemariaNicolas___Cooperativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void comboBoxSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            claseSocios.cargarCombo(comboBoxSocios);
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {

            claseFacturas.cargarGrilla(dataGridView1, Convert.ToInt32(comboBoxSocios.SelectedValue));
            labelCantidad.Text = claseFacturas.devolverCantidad.ToString();
            labelTotal.Text = claseFacturas.devolverTotal.ToString();
            labelPromedio.Text = claseFacturas.devolverPromedio.ToString();
        }

        private void buttonGenerarTXT_Click(object sender, EventArgs e)
        {
            claseFacturas.generarReporte(Convert.ToInt32(comboBoxSocios.SelectedValue));
            MessageBox.Show("Reporte generado con exito");
        }
    }
}
