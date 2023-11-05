using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Debate_4._1.Bases_de_Datos_en_Access
{
    internal class claseCiudad
    {

        public OleDbConnection conexion = new OleDbConnection(); // Nos permite la coneccion con la base
        public OleDbCommand command = new OleDbCommand();  // Con esto podemos mandar una orden a la base
        public OleDbDataAdapter adaptador = new OleDbDataAdapter(); // Adapta los datos para que los entienda .net


        public string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.mdb"; // Le decimos el nombre de la base 
        public string Tabla = "Ciudad"; //Le indicamos a cual de todas las tablas


       


        public void listar(ComboBox combo)
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
                combo.ValueMember = "idCiudad";
               
                combo.DataSource = DS.Tables[0];


                


                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }




        public void ListarForEach(DataGridView grilla)
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


                grilla.DataSource = DS.Tables[0];

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow dr in DS.Tables[Tabla].Rows)
                    {
                        grilla.Rows.Add(dr["idCiudad"], dr["Nombre"]);
                    }
                }

                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        


public string buscarCiudad(int idCiudad)
        {

            try
            {
                conexion.ConnectionString = CadenaConexion; //Le indicamos a donde esta la base de datos que tiene que abrir
                conexion.Open(); //Abrimos la coneccion

                command.Connection = conexion; // La coneccion abierta que esta arriba
                command.CommandType = CommandType.TableDirect; //Que tipo de comando queremos hacer
                command.CommandText = Tabla; // Nombre de la tabla

                //--------------------------------------------------------- NUEVO COMANDO
                OleDbDataReader DR = command.ExecuteReader(); // Lee toda la tabla de nuestra base y lo inserta en DR

                string resultado = "";

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == idCiudad)
                        {
                            resultado = DR.GetString(1);
                        }

                    }
                }
                 



                conexion.Close(); // Cerramos la coneccion
                return resultado;

            }
            catch (Exception ex)
            {

                 return ex.ToString();
            }



        }


    }
}
