using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_7._5.Trabajando_con_dos_vectores___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] meses = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        decimal[] importes = new decimal[12];
        int ind =0;

        private void buttonCargar_Click(object sender, EventArgs e)
        {

            switch (comboBoxMeses.SelectedIndex)
            {
                case 0:
                    importes[0] += Convert.ToDecimal(textBoxImporte.Text); // Enero
                    break;
                case 1:
                    importes[1] += Convert.ToDecimal(textBoxImporte.Text); // Febrero
                    break;
                case 2:
                    importes[2] += Convert.ToDecimal(textBoxImporte.Text); // Marzo
                    break;
                case 3:
                    importes[3] += Convert.ToDecimal(textBoxImporte.Text); // Abril
                    break;
                case 4:
                    importes[4] += Convert.ToDecimal(textBoxImporte.Text); // Mayo
                    break;
                case 5:
                    importes[5] += Convert.ToDecimal(textBoxImporte.Text); // Junio
                    break;
                case 6:
                    importes[6] += Convert.ToDecimal(textBoxImporte.Text); // Julio
                    break;
                case 7:
                    importes[7] += Convert.ToDecimal(textBoxImporte.Text); // Agosto
                    break;
                case 8:
                    importes[8] += Convert.ToDecimal(textBoxImporte.Text); // Septiembre
                    break;
                case 9:
                    importes[9] += Convert.ToDecimal(textBoxImporte.Text); // Octubre
                    break;
                case 10:
                    importes[10] += Convert.ToDecimal(textBoxImporte.Text); // Noviembre
                    break;
                case 11:
                    importes[11] += Convert.ToDecimal(textBoxImporte.Text); // Diciembre
                    break;
                default:
                    // Este es el caso por defecto, si el índice no coincide con ningún caso previamente definido.
                    break;
            }


            Listar();
            textBoxImporte.Text = "";


        }







        private void Listar()
        {
            dataGridView1.Rows.Clear();


            for (int i = 0; i < importes.Length; i++)
            {
                dataGridView1.Rows.Add(meses[i], importes[i]);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < meses.Length ; i++)
            {
                comboBoxMeses.Items.Add(meses[i]);
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
        }
    }
}
