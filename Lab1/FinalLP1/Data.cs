using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalLP1.Data;

namespace FinalLP1
{
    internal class Data
    {
        public  struct RegistroGenero
        {
            public  int Codigo;
            public  string Nombre;
            public  string Descripcion;
        }
       public static  RegistroGenero[] VectorGenero = new RegistroGenero[11];
        public static int IND = 0;
        public static string[] meses = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo",
                                                 "Junio", "Julio", "Agosto", "Septiembre",
                                                 "Octubre", "Noviembre", "Diciembre" };
        public static int[,] matriz = new int[11, 12];

        
        public static void CargarDatos()
        {
            Data.VectorGenero[0] = new Data.RegistroGenero { Codigo = 1, Nombre = "Acción", Descripcion = "Películas llenas de emocionantes escenas de persecuciones, combates y situaciones de riesgo." };
            IND++;
            Data.VectorGenero[1] = new Data.RegistroGenero { Codigo = 2, Nombre = "Comedia", Descripcion = "Películas diseñadas para hacer reír al público con situaciones cómicas y humor." };
            IND++;
            Data.VectorGenero[2] = new Data.RegistroGenero { Codigo = 3, Nombre = "Drama", Descripcion = "Historias centradas en el desarrollo emocional de los personajes, a menudo explorando situaciones intensas." };
            IND++;
            Data.VectorGenero[3] = new Data.RegistroGenero { Codigo = 4, Nombre = "Ciencia Ficción", Descripcion = "Películas que presentan elementos de ciencia avanzada, tecnología futurista y conceptos imaginativos." };
            IND++;
            Data.VectorGenero[4] = new Data.RegistroGenero { Codigo = 5, Nombre = "Romántica", Descripcion = "Historias centradas en relaciones amorosas y emociones románticas." };
            IND++;
            Data.VectorGenero[5] = new Data.RegistroGenero { Codigo = 6, Nombre = "Terror", Descripcion = "Películas destinadas a asustar o provocar miedo en la audiencia." };
            IND++;
            Data.VectorGenero[6] = new Data.RegistroGenero { Codigo = 7, Nombre = "Fantasía", Descripcion = "Historias que incluyen elementos mágicos, criaturas extraordinarias y mundos imaginarios." };
            IND++;
            Data.VectorGenero[7] = new Data.RegistroGenero { Codigo = 8, Nombre = "Misterio", Descripcion = "Películas que involucran la resolución de un enigma o crimen." };
            IND++;
            Data.VectorGenero[8] = new Data.RegistroGenero { Codigo = 9, Nombre = "Aventura", Descripcion = "Narrativas emocionantes que siguen a los personajes en viajes y desafíos." };
            IND++;
            Data.VectorGenero[9] = new Data.RegistroGenero { Codigo = 10, Nombre = "Animación", Descripcion = "Películas que utilizan técnicas de animación para contar historias, generalmente dirigidas a un público más joven." };
            IND++;


            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Data.matriz[i, j] = random.Next(0, 100);
                }
            }
            MessageBox.Show("Datos cargados correctamente.");

        }

    }
}
