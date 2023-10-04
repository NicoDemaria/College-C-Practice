using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace Debate_3._1
{
    internal class claseArchivo
    {

        public string nombreArchivo = "palabras.txt";




        public void Cargar(string palabra)
        {
            

            StreamWriter AD = new StreamWriter(nombreArchivo,true); //Abrir
            AD.WriteLine(palabra); // Cargar palabara en el arcchivo de texto
            AD.Close();//Cerrar el ad
            AD.Dispose();


        }
        public void Listar(ListBox lista)
        {
            string Auxiliar;
           StreamReader AD  = new StreamReader(nombreArchivo);
           Auxiliar = AD.ReadLine();

            lista.Items.Clear();
            while (Auxiliar != null)

            {
                lista.Items.Add(Auxiliar);
                Auxiliar = AD.ReadLine();

                
            }
            AD.Close();
            AD.Dispose ();


        }

    }
}
