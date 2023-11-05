using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionContribuyentes
{
    internal class data
    {

        public  struct Contribuyente
        {

            public int id;
            public string nombre;
            public decimal deuda;
            
        }
        public static  int ind;
        public static Contribuyente[] RegistroContribuyente = new Contribuyente[100];
        



        public static void CargarDatos(int codigo, string nombre, decimal deuda)
        {

            RegistroContribuyente[ind].id = codigo;
            RegistroContribuyente[ind].nombre = nombre;
            RegistroContribuyente[ind].deuda = deuda;
            ind++;


        }


        public static void datosPrueba()
        {
            RegistroContribuyente[0].id = 1;
            RegistroContribuyente[0].nombre = "Juan Perez";
            RegistroContribuyente[0].deuda = 1000;
            ind++;

            RegistroContribuyente[1].id = 2;
            RegistroContribuyente[1].nombre = "Maria Lopez";
            RegistroContribuyente[1].deuda = 2000;
            ind++;

            RegistroContribuyente[2].id = 3;
            RegistroContribuyente[2].nombre = "Pedro Martinez";
            RegistroContribuyente[2].deuda = 3000;
            ind++;


        }

        public static void cargarGrilla(DataGridView grilla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < ind; i++)
            {
                grilla.Rows.Add(RegistroContribuyente[i].id, RegistroContribuyente[i].nombre, RegistroContribuyente[i].deuda, RegistroContribuyente[i].deuda * Convert.ToDecimal(1.15));
            }   
        }

        public static (int,decimal,decimal) calcularTotales()
        {
            decimal totalDeuda = 0;
            int cantidad = 0;
            decimal totalConInteres = 0;

            for (int i = 0; i < ind; i++)
            {
                totalDeuda += RegistroContribuyente[i].deuda;
                cantidad++;
                totalConInteres += RegistroContribuyente[i].deuda * Convert.ToDecimal(1.15);
            }

            return (cantidad,totalDeuda,totalConInteres);

        }

        public static void cargarCombo(ComboBox combo)
        {
            combo.Items.Clear();
            for (int i = 0; i < ind; i++)
            {
                combo.Items.Add(RegistroContribuyente[i].nombre);
            }
        }

        public static (int,decimal) consultarCliente(ComboBox combo)
        {
            int codigo = 0;
            decimal deuda = 0;
            if (combo.SelectedItem != null)
            {

                string nombre = combo.SelectedItem.ToString();

                for (int i = 0; i < RegistroContribuyente.Length; i++)
                {
                    if (nombre == RegistroContribuyente[i].nombre)
                    {
                        codigo = RegistroContribuyente[i].id;
                        deuda = RegistroContribuyente[i].deuda;
                    }



                }


            }
            return (codigo, deuda);


        }
    }
}
