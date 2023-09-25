using System;
using System.Windows.Forms;

namespace Trabajo_Práctico_Nº_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int numero1 = 0;
        int numero2 = 0;
        int contador = 0;

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            pictureBoxCocoWelcome.Visible = false;

            buttonMenor.Visible = true;
            buttonMayor.Visible = true;
            buttonIgual.Visible = true;
            buttonJugar.Visible = false;
            numero1 = r.Next(1,10);
            numero2 = r.Next(1,10);
            pictureBoxCorrectaError.Image = null;
            pictureBoxMedio.Image = null;
            
           

            switch (numero1)
            {
                case 0:
                    pictureBoxDerecha.Image = Properties.Resources._0;
                    break;
                case 1:
                    pictureBoxDerecha.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBoxDerecha.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBoxDerecha.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBoxDerecha.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBoxDerecha.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBoxDerecha.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBoxDerecha.Image = Properties.Resources._7;
                    break;
                case 8:
                    pictureBoxDerecha.Image = Properties.Resources._8;
                    break;
                case 9:
                    pictureBoxDerecha.Image = Properties.Resources._9;
                    break;
            }
            switch (numero2)
            {
                case 0:
                    pictureBoxIzquierda.Image = Properties.Resources._0;
                    break;
                case 1:
                    pictureBoxIzquierda.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBoxIzquierda.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBoxIzquierda.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBoxIzquierda.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBoxIzquierda.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBoxIzquierda.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBoxIzquierda.Image = Properties.Resources._7;
                    break;
                case 8:
                    pictureBoxIzquierda.Image = Properties.Resources._8;
                    break;
                case 9:
                    pictureBoxIzquierda.Image = Properties.Resources._9;
                    break;
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonMenor.Visible = false;
            buttonMayor.Visible = false;
            buttonIgual.Visible = false;
            pictureBoxCocoWelcome.Image = Properties.Resources.Coco;
        }

        private void buttonMayor_Click(object sender, EventArgs e)
        {
            pictureBoxMedio.Image = Properties.Resources.Mayor;
            buttonMenor.Visible = false;
            buttonIgual.Visible = false;
            buttonMayor.Visible = false;
            buttonJugar.Visible = true;
            if (numero1 > numero2)
            {
                
                pictureBoxCorrectaError.Image = Properties.Resources.Bien;
                contador += 2;
            }
            else
            {
                pictureBoxCorrectaError.Image = Properties.Resources.Mal;
                contador -= 1;

            }
            textBox1.Text = Convert.ToString(contador);

            if (contador >= 10)

            {
                MessageBox.Show("Felicitaciones Ganaste");
                pictureBoxCocoWelcome.Visible = true;
                contador = 0;
                pictureBoxMedio.Image = Properties.Resources.CocoFeliz;
                textBox1.Text = Convert.ToString(contador);

            }
            else if (contador < 0)

            {

                MessageBox.Show("Lo siento mucho, perdiste");
                pictureBoxCocoWelcome.Visible = true;
                contador = 0;
                pictureBoxCocoWelcome.Image = Properties.Resources.CocoTriste;
                pictureBoxCorrectaError.Image = null;
                textBox1.Text = Convert.ToString(contador);


            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            pictureBoxMedio.Image = Properties.Resources.Igual;
            buttonMenor.Visible = false;
            buttonIgual.Visible = false;
            buttonMayor.Visible = false;
            buttonJugar.Visible = true;


            if (numero1 == numero2)
            {

                pictureBoxCorrectaError.Image = Properties.Resources.Bien;
                contador += 2;
            }
            else
            {
                pictureBoxCorrectaError.Image = Properties.Resources.Mal;
                contador -= 1;

            }
            textBox1.Text = Convert.ToString(contador);

            if (contador >= 10)

            {
               

                MessageBox.Show("Felicitaciones Ganaste");
                pictureBoxCocoWelcome.Visible = true;
                contador = 0;
                pictureBoxCocoWelcome.Image = Properties.Resources.CocoFeliz;
                textBox1.Text = Convert.ToString(contador);

            }
            else if (contador < 0)
            {
                

                MessageBox.Show("Lo siento mucho, perdiste");
                pictureBoxCocoWelcome.Visible = true;
                contador = 0;
                pictureBoxCocoWelcome.Image = Properties.Resources.CocoTriste;
                pictureBoxCorrectaError.Image = null;
                textBox1.Text = Convert.ToString(contador);







            }



        }

        private void buttonMenor_Click(object sender, EventArgs e)
        {
            pictureBoxMedio.Image = Properties.Resources.Menor;
            buttonMenor.Visible = false;
            buttonIgual.Visible = false;
            buttonMayor.Visible = false;
            buttonJugar.Visible = true;


            if (numero1 < numero2)
            {

                pictureBoxCorrectaError.Image = Properties.Resources.Bien;
                contador += 2;
            }
            else
            {
                pictureBoxCorrectaError.Image = Properties.Resources.Mal;
                contador -= 1;

            }

            textBox1.Text = Convert.ToString(contador);
            if (contador >= 10)

            {
                MessageBox.Show("Felicitaciones Ganaste");
                pictureBoxCocoWelcome.Visible = true;
                contador = 0;
                pictureBoxCocoWelcome.Image = Properties.Resources.CocoFeliz;
                textBox1.Text = Convert.ToString(contador);

            }

            else if (contador < 0)
            {

                MessageBox.Show("Lo siento mucho, perdiste");
                pictureBoxCocoWelcome.Visible = true;
                contador = 0;
                pictureBoxCocoWelcome.Image = Properties.Resources.CocoTriste;
                textBox1.Text = Convert.ToString(contador);




            }




        }

    }
}
