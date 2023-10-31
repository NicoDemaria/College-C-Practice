using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debate_7._6.Vector_constituido_por_registros
{
    internal class datosGlobales
    {


        public struct clientes
        {

            public int codigo;
            public string nombre;
            public decimal deuda;
            public decimal limite;
        }

        public static clientes[] RegClientes = new clientes[10];
        public static int ind = 0;

        //Expliacion de static
        //https://es.stackoverflow.com/questions/152642/static-que-es-y-para-que-sirve
    }
}
