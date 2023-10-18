using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Práctica_2
{
    internal class funciones
    {

        public static void cargarCombo(ComboBox combo)
        {

            StreamReader AD = new StreamReader("RUBROS.csv");
            string datoLeido = "";
            datoLeido = AD.ReadLine();



            while (datoLeido != null)
            {
                combo.Items.Add(datoLeido);
                datoLeido = AD.ReadLine();

            }
            AD.Close();
            AD.Dispose();
        }


        public static void cargarGrilla(DataGridView grilla, ComboBox combo)//En resumen, static se usa para definir miembros que
                                                                            //pertenecen a la clase en lugar de a instancias individuales.
        {
            string categoriaSeleccionada = combo.SelectedItem.ToString();

            grilla.Rows.Clear();
            string datoLeido = "";
            string[] vector = new string[5];




            StreamReader AD = new StreamReader("ARTICULOS.csv");

            datoLeido = AD.ReadLine();
            //2 y 4
            while (datoLeido != null)
            {
                int Stock = 0;
                vector = datoLeido.Split(';');
                Stock = Convert.ToInt32(vector[2] ) * Convert.ToInt32(vector[4]);

                if (categoriaSeleccionada == Convert.ToString(vector[3]))
                {
                    grilla.Rows.Add(vector[0], vector[1], vector[2], vector[3], vector[4],Stock);

                }
                datoLeido = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();





        }
        public int CalcularTotal(DataGridView grilla, ComboBox combo) { 
            int total = 0;

            string categoriaSeleccionada = combo.SelectedItem.ToString();

            string datoLeido = "";
            string[] vector = new string[5];
            StreamReader AD = new StreamReader("ARTICULOS.csv");
            datoLeido = AD.ReadLine();


            while (datoLeido != null)
            {

                vector = datoLeido.Split(';');

                if (categoriaSeleccionada == Convert.ToString(vector[3]))
                {

                 
                    
                        total += Convert.ToInt32(vector[2]);
                    


                }
                datoLeido = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();
            


            return total;
            
        }
        public int contar(DataGridView grilla)
        {
            int contar = grilla.RowCount;
            return contar - 1;
        }

        public static void exportarGrilla(DataGridView grilla, ComboBox combo)//En resumen, static se usa para definir miembros que
                                                                              //pertenecen a la clase en lugar de a instancias individuales.
        {
            string categoriaSeleccionada = combo.SelectedItem.ToString();

            string datoLeido = "";
            string[] vector = new string[5];
            StreamReader AD = new StreamReader("ARTICULOS.csv");
            datoLeido = AD.ReadLine();


            StreamWriter reporte = new StreamWriter("Reporte.csv",false);




            reporte.Write("Codigo;Desc;Costo;Categoria;Stock;Valor Stock");
            reporte.WriteLine("");
            reporte.WriteLine("");

            while (datoLeido != null) 
            {
                int Stock = 0;

                vector = datoLeido.Split(';');
                Stock = Convert.ToInt32(vector[2]) * Convert.ToInt32(vector[4]);

                if (categoriaSeleccionada == Convert.ToString(vector[3]))
                {

                    reporte.Write(vector[0]);
                    reporte.Write(';');
                    reporte.Write(vector[1]);
                    reporte.Write(';');
                    reporte.Write(vector[2]);
                    reporte.Write(';');
                    reporte.Write(vector[3]);
                    reporte.Write(';');
                    reporte.Write(vector[4]);
                    reporte.Write(';');
                    reporte.WriteLine(Stock);


                }
                datoLeido = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();
            reporte.Close();
            reporte.Dispose();



        }
    }
}
