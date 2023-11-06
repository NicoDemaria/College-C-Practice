using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace RepasoPrevioParcial
{
    internal class claseIdioma
    {


        public static  OleDbConnection conexion = new OleDbConnection(); 
        public static OleDbCommand command = new OleDbCommand(); 
        public static OleDbDataAdapter adaptador = new OleDbDataAdapter();



        public static string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.accdb";         
        public static string Tabla = "Idioma";



        public static  void cargarComboIdioma(ComboBox combo)
        {

            try
            {
                conexion.ConnectionString = CadenaConexion; //Le indicamos a donde esta la base de datos que tiene que abrir
                conexion.Open(); //Abrimos la coneccion

                command.Connection = conexion; // La coneccion abierta que esta arriba
                command.CommandType = CommandType.TableDirect; //Que tipo de comando queremos hacer
                command.CommandText = Tabla; // Nombre de la tabla

                adaptador = new OleDbDataAdapter(command);
                DataSet DS = new DataSet();
                adaptador.Fill(DS); //llenamos el data set con los datos que trae nuestro comando mediante el adaptador


                combo.DisplayMember = "Nombre";
                combo.ValueMember = "IdIdioma";

                combo.DataSource = DS.Tables[0];





                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
    }
}
