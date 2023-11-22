using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace EXAMEN_PARCIAL___DemariaNicolas___Cooperativa
{
    internal class claseSocios
    {

        public static OleDbConnection conexion = new OleDbConnection();
        public static OleDbCommand command = new OleDbCommand();
        public static OleDbDataAdapter adaptador = new OleDbDataAdapter(command);



        public static string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=COOPERATIVA.mdb";
        public static string Tabla = "Socios";


        public static void cargarCombo(ComboBox combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion; 
                conexion.Open(); 

                command.Connection = conexion; 
                command.CommandType = CommandType.TableDirect; 
                command.CommandText = Tabla; 

                adaptador = new OleDbDataAdapter(command);
                DataSet DS = new DataSet();

                

                adaptador.Fill(DS); 


                combo.DisplayMember = "Socio";
                combo.ValueMember = "Cuenta";

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
