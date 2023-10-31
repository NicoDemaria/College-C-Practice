using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LP1_VECTORES
{
    internal class data
    {

        //Estructura empleado
        public struct Empleado {

            public int codigo;
            public string nombre;
            public string categoria;
            public decimal sueldo;

        }
        //Vector tipo Empleado

        public static Empleado[] vectorEmpleados = new Empleado[1000];
        public static int ind = 0;
        

        //Carga de datos de prueba
        public  static void CargaDataTest()
        {
            ind++;
            vectorEmpleados[0].codigo = 344511235;
            vectorEmpleados[0].nombre = "Nicolas Demaria";
            vectorEmpleados[0].categoria = "IT";
            vectorEmpleados[0].sueldo = 1000;

            ind++;
            vectorEmpleados[1].codigo = 67127812;
            vectorEmpleados[1].nombre = "Lionel Messi";
            vectorEmpleados[1].categoria = "Marketing";
            vectorEmpleados[1].sueldo = 100000000;

            ind++;
            vectorEmpleados[2].codigo = 1;
            vectorEmpleados[2].nombre = "Test nombre";
            vectorEmpleados[2].categoria = "Test categoria";
            vectorEmpleados[2].sueldo = 1;

            ind++;
            vectorEmpleados[3].codigo = 2;
            vectorEmpleados[3].nombre = "Mauro";
            vectorEmpleados[3].categoria = "IT";
            vectorEmpleados[3].sueldo = 2000;

        }

        //Carga de empleados
        public static  void cargarDatosEmpleado(int c, string n, string cat, decimal s)
        {
            int i = 0;
            while (vectorEmpleados[i].codigo != c && i < ind)
            {
                i++;
            }

            if (i == ind)
            {
                vectorEmpleados[ind].codigo = c;
                vectorEmpleados[ind].nombre = n;
                vectorEmpleados[ind].categoria = cat;
                vectorEmpleados[ind].sueldo=s;
                ind++;
                MessageBox.Show("Codigo cargado correctamente");
            }
            else
            {
                MessageBox.Show("Codigo existente, ingrese otro");
            }

        }

        //Listado automatico de los empleados

        public static  (decimal,decimal) ListarGeneral(DataGridView grilla)
        {
            grilla.Rows.Clear();

            decimal total = 0;

            decimal cantidad = 0;

            for (int i = 0; i < ind; i++)
            {
                grilla.Rows.Add(vectorEmpleados[i].codigo, vectorEmpleados[i].nombre, vectorEmpleados[i].categoria, vectorEmpleados[i].sueldo);


                total += vectorEmpleados[i].sueldo;

                cantidad++;
                

                
            }




            return (total, cantidad);
        }

        //Listado automatico de los empleados por categoria

        public static (decimal, decimal) ListarPorCategoria(DataGridView grilla, string categoria)
        {
            grilla.Rows.Clear();

            decimal total = 0;

            decimal cantidad = 0;

            for (int i = 0; i < ind; i++)
            {

                if (vectorEmpleados[i].categoria == categoria)
                {
                    grilla.Rows.Add(vectorEmpleados[i].codigo, vectorEmpleados[i].nombre, vectorEmpleados[i].categoria, vectorEmpleados[i].sueldo);


                    total += vectorEmpleados[i].sueldo;

                    cantidad++;
                }

            }




            return (total, cantidad);
        }

        //Listado automatico de los empleados por sueldo mayor a

        public static (decimal, decimal) ListarPorSueldo(DataGridView grilla, string sueldo)
        {
            grilla.Rows.Clear();

            decimal total = 0;

            decimal cantidad = 0;

            for (int i = 0; i < ind; i++)
            {

                if (vectorEmpleados[i].sueldo >=  Convert.ToDecimal(sueldo) )
                {
                    grilla.Rows.Add(vectorEmpleados[i].codigo, vectorEmpleados[i].nombre, vectorEmpleados[i].categoria, vectorEmpleados[i].sueldo);


                    total += vectorEmpleados[i].sueldo;

                    cantidad++;
                }

            }




            return (total, cantidad);
        }


        //Busqueda de un empleado por codigo

        public static (int, string,string) busquedaEmpleado(int codigo)
        {
            codigo = Convert.ToInt32(codigo);
            string cat = "";
            string nombre = "";

            for (int i = 0; i < ind; i++)
            {
                if (codigo == vectorEmpleados[i].codigo)
                {
                    cat = vectorEmpleados[i].categoria;
                    nombre = vectorEmpleados[i].nombre;

                }
            }
            return (codigo,cat,nombre );
        }


        //Consulta de un empleado por combo

        public static (int,string,decimal) consultarEmpleado(ComboBox combo)
        {
            int codigo = 0;
            string cat = "";
            decimal sueldo = 0;

            for (int i = 0; i < ind; i++)
            {
                if (combo.SelectedItem != null)
                {
                    string nombreSeleccionado = combo.SelectedItem.ToString();

                    if (nombreSeleccionado == vectorEmpleados[i].nombre)
                    {
                        codigo = vectorEmpleados[i].codigo;
                        cat = vectorEmpleados[i].categoria;
                        sueldo = vectorEmpleados[i].sueldo;
                    }
                }
            }
           

            return (codigo,cat,sueldo);
        }

        //Carga del combo con el nombre de los empleados
        
        public static void cargarComboEmpleados(ComboBox combo)
        {
            for (int i = 0; i < ind; i++)
            {
                combo.Items.Add(vectorEmpleados[i].nombre);
            }
        }
    }
}
