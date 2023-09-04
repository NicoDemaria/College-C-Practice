using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debate_2._3
{
    internal class datosGlobales
    {
        // Declarar registro

        public struct RegistroCliente
        {
            public Int32 codigo;
            public string nombre;
            public decimal credito;
            public decimal deuda;

        };
        // Declarar el vector
        static public RegistroCliente[] Clientes = new RegistroCliente[100];
        //Declarar un indice para poder trabajar con el vector
        static public Int32 IND = 0;
    }
}
