using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionClientes
{
    internal class data
    {
        //Structura
       public struct Cliente
        {
            public int codigo;
            public string nombre;
            public decimal deuda;
            public decimal limite;
        }
        //indice
        public static int ind = 0;

        //Vector tipo cliente

         static public Cliente[] vectorCliente = new Cliente[100];

        public static string[] Meses = new string[12]
{
    "Enero",
    "Febrero",
    "Marzo",
    "Abril",
    "Mayo",
    "Junio",
    "Julio",
    "Agosto",
    "Septiembre",
    "Octubre",
    "Noviembre",
    "Diciembre"
};

        public static string[] sucursales = new string[4] { "Sur","Norte","Central","Oriental" };



        //Procedimiento para cargar datos al vector vectorCliente

        public static void cargarVectorCliente(int c, string n, decimal d, decimal l)
        {
            int i = 0;
            while (vectorCliente[i].codigo != c && i < ind)
            {
                i++;
            }

            if (ind == i)
            {
                vectorCliente[ind].codigo = c;
                vectorCliente[ind].nombre = n;
                vectorCliente[ind].deuda = d;
                vectorCliente[ind].limite = l;
                ind++;
                MessageBox.Show("Cliente cargado correctamente");
                
            }
            else
            {
                MessageBox.Show("Codigo repetido, porfavor ingrese uno distinto");
                
            }

        }


        //Funcion para mostrar todos los clientes como tambien la cantidad, su deuda, y el promedio de deuda por cliente
        public static (decimal,decimal,decimal) mostrarClientes(DataGridView grilla)
        {
            grilla.Rows.Clear();
            decimal total = 0;
            decimal cantidad = 0;

            for (int i = 0; i < data.ind; i++)
            {
                grilla.Rows.Add(vectorCliente[i].codigo, vectorCliente[i].nombre, vectorCliente[i].deuda, vectorCliente[i].limite);
                cantidad++;
                total += vectorCliente[i].deuda;
            }

            decimal promedio = total / cantidad;

            return (total, cantidad,promedio);


        }

        //Funcion para mostrar todos los clientes como tambien la cantidad, su deuda, y el promedio de deuda por cliente SOLO DE LOS DEUDORES

        public static (decimal, decimal, decimal) mostrarClientesDeudores(DataGridView grilla)
        {
            grilla.Rows.Clear();
            decimal total = 0;
            decimal cantidad = 0;

            
            for (int i = 0; i < ind; i++)
            {
                if (vectorCliente[i].deuda > 0)
                {
                    grilla.Rows.Add(vectorCliente[i].codigo, vectorCliente[i].nombre, vectorCliente[i].deuda, vectorCliente[i].limite);
                    cantidad++;
                    total += vectorCliente[i].deuda;
                }
               
            }

            decimal promedio = total / cantidad;

            return (total, cantidad, promedio);


        }


        //Funcion para consultar un cliente

        public static (decimal,decimal) consultarCliente(ComboBox combo)
        {


            decimal deuda = 0;
            decimal limite = 0;

            if (combo.SelectedItem != null)
            {
                string nombreSeleccionado = combo.SelectedItem.ToString();  

                for (int i = 0; i < vectorCliente.Length; i++)
                {
                    if (nombreSeleccionado == vectorCliente[i].nombre)
                    {
                        deuda = vectorCliente[i].deuda;
                        limite = vectorCliente[i].limite;

                    }


                }
            }

            return (deuda, limite);




        }












        //Datos de prueba
        public static void testData()
        {
            ind++;
            ind++;
            ind++;


            vectorCliente[0].codigo = 1;
            vectorCliente[0].nombre = "Nicolas Demaria";
            vectorCliente[0].deuda = 1000;
            vectorCliente[0].limite = 100000000;
            


            vectorCliente[1].codigo = 2;
            vectorCliente[1].nombre = "Juan Perez";
            vectorCliente[1].deuda = 10;
            vectorCliente[1].limite = 100;
          

            vectorCliente[2].codigo = 3;
            vectorCliente[2].nombre = "NO DEUDOR TEST";
            vectorCliente[2].deuda = 0;
            vectorCliente[2].limite = 100;
           




        }






    }
}
