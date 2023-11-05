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
    internal class ClaseCiudad
    {


        private OleDbConnection conn = new OleDbConnection(); // objeto que nos sirve para conectarse
        private OleDbCommand cmd = new OleDbCommand(); // Objeto que nos sirve para enviar  un comenado
        private OleDbDataAdapter adaptador = new OleDbDataAdapter(); // Este objeto, adapta nuestros datos a datos 
                                                                     // que pueden ser leidos por .net


        private string cadenaConnecion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Clientes.mdb";
        private string tabla = "Ciudad";


        public void listar(DataGridView grilla)
        {

            try
            {
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

        public void listar(ComboBox combo)
        {

            try
            {
                conn.ConnectionString = cadenaConnecion;// Le decimos la base datos     
                conn.Open(); // Abrimos la coneccion

                cmd.Connection = conn; // le indicamos al comando cual es la coneccion a usar
                cmd.CommandType = CommandType.TableDirect; // El tipo de comando, tenemos varios [En este caso nos traemos la tabla directa] 
                cmd.CommandText = tabla; // Aca le indicamos el nombre de nuestra variable, es decir el nombre de la tabla

                adaptador = new OleDbDataAdapter(cmd);

                DataSet dataSet = new DataSet();
                adaptador.Fill(dataSet);

                combo.DataSource = dataSet.Tables[0];
                combo.DisplayMember = "Nombre"; // El nombre que tiene la columna que nosotros queremos mostrar
                combo.ValueMember = "idCiudad"; // Aca tienen los valores para cada nombre nombre de nuestra tabla



                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


        }//Procedimiento para listar datos en una grilla



    }
}
