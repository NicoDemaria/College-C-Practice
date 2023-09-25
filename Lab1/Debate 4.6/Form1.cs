using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonAuto.Checked)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        pictureBox1.Image = Properties.Resources.auto_azul;
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources.auto_rojo;
                        break;
                    default:
                        pictureBox1.Image = Properties.Resources.pregunta;
                        break;
                }
            }
            else if (radioButtonMascota.Checked) {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        pictureBox1.Image = Properties.Resources.animal_azul;
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources.animal_rojo;
                        break;
                    default:
                        pictureBox1.Image = Properties.Resources.pregunta;
                        break;
                }

            }
        }
    }
}
