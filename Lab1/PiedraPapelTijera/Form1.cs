using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiedraPapelTijera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        public int j = 0;
        public int m = 0;
        public int partidasJugadas = 0;
        public int partidaGanadas = 0;
        public int partidaPerdidas = 0;





        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPiedra_Click(object sender, EventArgs e)
        {
            pictureBoxJug.Image = PiedraPapelTijera.Properties.Resources.piedra;
            int x = r.Next(1, 4);

            switch (x)
            {

                case 1:
                    pictureBoxPc.Image = PiedraPapelTijera.Properties.Resources.piedra;
                    MessageBox.Show("Empataste");

                    break;
                case 2:
                    pictureBoxPc.Image = PiedraPapelTijera.Properties.Resources.Papel;
                    MessageBox.Show("Perdiste");
                    m++;

                    break;
                case 3:
                    pictureBoxPc.Image = PiedraPapelTijera.Properties.Resources.Tijera;
                    MessageBox.Show("Ganaste");
                    j++;

                    break;

            }
            if (j == 3)
            {
                MessageBox.Show("Gana el jugador");
                j = 0;
                m = 0;
                partidaGanadas++;
                labelPartidaGanada.Text = partidaGanadas.ToString();
                partidasJugadas++;
            }
            else if (m == 3)
            {
                MessageBox.Show("Gana la maquina");
                j = 0;
                m = 0;
                partidaPerdidas++;
                labelPartidaPerdida.Text = Convert.ToString(partidaPerdidas);
                partidasJugadas++;

            }

            labelPuntosMaquina.Text = Convert.ToString(m);
            labelPuntosJug.Text = Convert.ToString(j);
            labelPartidasJugada.Text = Convert.ToString(partidasJugadas);


        }

        private void buttonPapel_Click(object sender, EventArgs e)
        {
            {
                pictureBoxJug.Image = PiedraPapelTijera.Properties.Resources.Papel;
                int x = r.Next(1, 4);

                switch (x)
                {

                    case 1:
                        pictureBoxPc.Image = PiedraPapelTijera.Properties.Resources.piedra;
                        MessageBox.Show("Ganaste");
                        j++;
                        break;
                    case 2:
                        pictureBoxPc.Image = PiedraPapelTijera.Properties.Resources.Papel;
                        MessageBox.Show("Empataste");
                        

                        break;
                    case 3:
                        pictureBoxPc.Image = PiedraPapelTijera.Properties.Resources.Tijera;
                        MessageBox.Show("Perdiste");
                        m++;


                        break;

                }
                if (j == 3)
                {
                    MessageBox.Show("Gana el jugador");
                    j = 0;
                    m = 0;
                    partidaGanadas++;
                    labelPartidaGanada.Text = partidaGanadas.ToString();
                    partidasJugadas++;
                }
                else if (m == 3)
                {
                    MessageBox.Show("Gana la maquina");
                    j = 0;
                    m = 0;
                    partidaPerdidas++;
                    labelPartidaPerdida.Text = Convert.ToString(partidaPerdidas);
                    partidasJugadas++;

                }

                labelPuntosMaquina.Text = Convert.ToString(m);
                labelPuntosJug.Text = Convert.ToString(j);
                labelPartidasJugada.Text = Convert.ToString(partidasJugadas);



            }
        }

        private void buttonTijera_Click(object sender, EventArgs e)
        {
            

            pictureBoxJug.Image = PiedraPapelTijera.Properties.Resources.Tijera;
            int x = r.Next(1, 4);
            

            switch (x)
            {

                case 1:
                    pictureBoxPc.Image = PiedraPapelTijera.Properties.Resources.piedra;
                    MessageBox.Show("Perdiste");
                    
                    m++;
                    break;
                case 2:
                    pictureBoxPc.Image = PiedraPapelTijera.Properties.Resources.Papel;
                    MessageBox.Show("Ganaste");
                    j++;

                    break;
                case 3:
                    pictureBoxPc.Image = PiedraPapelTijera.Properties.Resources.Tijera;
                    MessageBox.Show("Empataste");

                    break;

            }

            if (j == 3)
            {
                MessageBox.Show("Gana el jugador");
                j = 0;
                m = 0;
                partidaGanadas++;
                labelPartidaGanada.Text = partidaGanadas.ToString();
                partidasJugadas++;
            }
            else if (m == 3)
            {
                MessageBox.Show("Gana la maquina");
                j = 0;
                m = 0;
                partidaPerdidas++;
                labelPartidaPerdida.Text = Convert.ToString(partidaPerdidas);
                partidasJugadas++;

            }

            labelPuntosMaquina.Text = Convert.ToString(m);
            labelPuntosJug.Text = Convert.ToString(j);
            labelPartidasJugada.Text = Convert.ToString(partidasJugadas);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelPartidaGanada.Text = "";
            labelPartidaPerdida.Text = "";
            labelPartidasJugada.Text = "";
            partidaGanadas = 0;
            partidaPerdidas = 0;
            partidasJugadas = 0;
            j = 0;
            m = 0;
            
        }
    }
}
