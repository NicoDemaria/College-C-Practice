using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RepasoArchivos
{
    internal class funciones
    {


        public static  void cargarCombo(ComboBox combo)
        {

            StreamReader AD = new StreamReader("FormaPago.csv");
            string datoLeido = "";
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                combo.Items.Add(datoLeido);
                datoLeido = AD.ReadLine();

            }
            AD.Close();
        }




    }
}
