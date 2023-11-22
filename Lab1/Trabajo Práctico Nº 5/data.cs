using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_Nº_5


          
{
    internal class data
    {
        public static string[] empleados = new string[5] { "Garcia, Leonardo", "Perez, David", "Fernández, Franco", "Carrizo, Alejandra", "Ortega, Marina" };
        public static  string[] Maquina = new string[3] { "GH-156", "JM-25-80", "ZK-1900" };

        public static string[,] Matriz = new string[5, 3];

        public static Random r = new Random();

        public static void cargarDatosAutomaticamente() {

            for (int f= 0; f < empleados.Length; f++)
            {
                for (int c = 0; c < Maquina.Length; c++)
                {
                    Matriz[f, c] = r.Next(100).ToString();
                }
                
                
            }

        }
    }
}
