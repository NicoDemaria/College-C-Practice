using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_LP2_VECTORES_REGISTROS
{
    internal class datos
    {

        public struct RegistroVendedor
        {

            public int codigo;
            public string nombre;
            public decimal sueldo;
        }
        static public int IND = 0;
        static public RegistroVendedor[] Vendedor = new RegistroVendedor[100];
    }
}
