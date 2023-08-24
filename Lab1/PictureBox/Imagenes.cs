using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Imagenes : Form
    {
        public Imagenes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Thor_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxHeroes.Image = PictureBox.Properties.Resources.thor;
            label1.Text = "Thor";
            label1.ForeColor = Color.Blue;

        }

        private void SpiderMan_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxHeroes.Image = PictureBox.Properties.Resources.png_clipart_spider_man_comic_book_spider_man_comics_heroes;
            label1.Text = "Spider Man";
            label1.ForeColor = Color.Red;


        }

        private void Imagenes_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxHeroes.Image = PictureBox.Properties.Resources.rick;
            label1.Text = "Rick";
            label1.ForeColor = Color.Green;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxHeroes.Image = PictureBox.Properties.Resources.morty;
            label1.Text = "Morty";
            label1.ForeColor = Color.Purple;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxHeroes.Image = PictureBox.Properties.Resources.rick_and_morty_1604562846;
            label1.Text = "Rick and Morty";
            label1.ForeColor = Color.Orange;
        }
    }
}
