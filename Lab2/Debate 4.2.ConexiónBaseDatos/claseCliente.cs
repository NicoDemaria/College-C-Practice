using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//Agregamos estos espacios de nombre para poder trabajar con las basesa de datos

using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


namespace Debate_4._2.ConexiónBaseDatos
{
    internal class claseCliente
    {


        private OleDbConnection conn = new OleDbConnection(); // objeto que nos sirve para conectarse
        private OleDbCommand cmd = new OleDbCommand(); // Objeto que nos sirve para enviar  un comenado
        private OleDbDataAdapter adaptador = new OleDbDataAdapter(); // Este objeto, adapta nuestros datos a datos 
                                                                     // que pueden ser leidos por .net

        private string cadenaConnecion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Clientes.mdb";
        private string tabla = "Cliente";


        private int cantidad;
        private decimal deuda;

        public int cantidadDeudores // Propiedades publicas, pueden ser para leer o escribir, con las propiedades get y set
                                    // https://learn.microsoft.com/es-es/dotnet/csharp/programming-guide/classes-and-structs/properties
        {
            get
            {
                return cantidad;
            }
        }

        public decimal totalDeuda
        {
            get
            {
                return deuda;
            }
        }


        public void listar(DataGridView grilla)
        {

            try {
                conn.ConnectionString = cadenaConnecion;// Le decimos la base datos     
                conn.Open(); // Abrimos la coneccion

                cmd.Connection = conn; // le indicamos al comando cual es la coneccion a usar
                cmd.CommandType = CommandType.TableDirect; // El tipo de comando, tenemos varios [En este caso nos traemos la tabla directa] 
                cmd.CommandText = tabla; // Aca le indicamos el nombre de nuestra variable, es decir el nombre de la tabla

                adaptador = new OleDbDataAdapter(cmd);

                DataSet dataSet = new DataSet();
                adaptador.Fill(dataSet);

                grilla.DataSource = dataSet.Tables[0];



                conn.Close();

            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                
            }
            

        }//Procedimiento para listar datos en una grilla
        public void ListarDeudores(DataGridView grilla)// Procedimiento para especificar que datos queremos mostrar en nuestra grilla
        {
            try
            {

                conn.ConnectionString = cadenaConnecion;// Le decimos la base datos     
                conn.Open(); // Abrimos la coneccion

                cmd.Connection = conn; // le indicamos al comando cual es la coneccion a usar
                cmd.CommandType = CommandType.TableDirect; // El tipo de comando, tenemos varios [En este caso nos traemos la tabla directa] 
                cmd.CommandText = tabla; // Aca le indicamos el nombre de nuestra variable, es decir el nombre de la tabla

                /*adaptador = new OleDbDataAdapter(cmd);
                
                /DataSet dataSet = new DataSet();
                adaptador.Fill(dataSet);

                grilla.DataSource = dataSet.Tables[0];
                */

                cantidad = 0;
                deuda = 0;
                OleDbDataReader dr = cmd.ExecuteReader();
                grilla.Rows.Clear();
                while (dr.Read())


                    if (Convert.ToInt32(dr[2])  > 0)
                    {
                        cantidad++;
                        grilla.Rows.Add(dr[0], dr[1], dr[2]);
                        deuda += Convert.ToDecimal(dr[2]);
                    }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            
        }
    }
}
