using System;
using System.Drawing;
using System.Windows.Forms;

namespace Debate_4._1.Alternativa___if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1 = 0;
      
        Random r = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = r.Next(1,7);
            

            switch (num1)
            {

                case 1:
                 
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Desktop-PC\\Desktop\\College C# Practice\\Lab1\\Debate 4.1. Alternativa - if\\Resources\\527560a9ce32f-dado1.png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Desktop-PC\\Desktop\\College C# Practice\\Lab1\\Debate 4.1. Alternativa - if\\Resources\\527560a9d15f6-dado2.png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Desktop-PC\\Desktop\\College C# Practice\\Lab1\\Debate 4.1. Alternativa - if\\Resources\\527560a9d48bd-dado3.png");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Desktop-PC\\Desktop\\College C# Practice\\Lab1\\Debate 4.1. Alternativa - if\\Resources\\527560a9d7bc5-dado4.png");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Desktop-PC\\Desktop\\College C# Practice\\Lab1\\Debate 4.1. Alternativa - if\\Resources\\527560a9daa7f-dado5.png");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Desktop-PC\\Desktop\\College C# Practice\\Lab1\\Debate 4.1. Alternativa - if\\Resources\\527560a9ddd30-dado6.png");
                    break;


            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
