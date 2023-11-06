using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
using System.Security.Policy;

namespace RepasoPrevioParcial
{
    internal class claseLibro
    {
        public static OleDbConnection conexion = new OleDbConnection();
        public static OleDbCommand command = new OleDbCommand();
        public static OleDbDataAdapter adaptador = new OleDbDataAdapter(command);



        public static string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.accdb";
        public static string Tabla = "Libro";


        public static  int cantidad = 0;

        public static decimal totalLibros = 0;
        public static decimal totalLibrosTodos = 0;


        public  int devolverCantidad   {

            get { return cantidad; 
            } 
        }

        public static  decimal devolverTotal
        {

            get
            {
                return totalLibrosTodos;
            }
        }





        public static  void listarGrilla(DataGridView grilla,int codigo)
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

                cantidad = 0;

                adaptador.Fill(DS,Tabla); 
                grilla.Rows.Clear();
                if (DS.Tables[Tabla].Rows.Count > 0)
                {

                    totalLibrosTodos = 0;

                    foreach (DataRow dr in DS.Tables[Tabla].Rows)
                    {
                        totalLibros = 0;

                        if (codigo == Convert.ToInt32(dr["IdIdioma"]) )
                        {
                            totalLibros += Convert.ToInt32(dr["Cantidad"]) * Convert.ToInt32(dr["Precio"]);
                            totalLibrosTodos += Convert.ToInt32(dr["Cantidad"]) * Convert.ToInt32(dr["Precio"]);
                            cantidad++;
                            grilla.Rows.Add(dr["Titulo"], dr["Año"], dr["Cantidad"], dr["Precio"], totalLibros);



                        }
                    }
                       
                }

                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }


        public static  void generarCSV(int idIdioma)
        {
            try
            {

                conexion.ConnectionString = CadenaConexion; 

                command.Connection = conexion; 
                command.CommandType = CommandType.TableDirect; 
                command.CommandText = Tabla; 

               


                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(command);

                adaptador.Fill(DS, Tabla);

                string nombreArchivo = "ReporteLibros.csv";
                StreamWriter AD = new StreamWriter(nombreArchivo, false);


                AD.WriteLine("Titulo;Año;Cantidad;Precio;Total");
                cantidad = 0;

                totalLibros = 0;
                totalLibrosTodos = 0;


                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow dr in DS.Tables[Tabla].Rows)
                    {
                        totalLibros = 0;

                        if (idIdioma == Convert.ToInt32(dr["IdIdioma"]))
                        {
                            totalLibros += Convert.ToInt32(dr["Cantidad"]) * Convert.ToInt32(dr["Precio"]);
                            totalLibrosTodos += Convert.ToInt32(dr["Cantidad"]) * Convert.ToInt32(dr["Precio"]);



                            AD.Write(dr["Titulo"]);
                            AD.Write(";");
                            AD.Write(dr["Año"]);
                            AD.Write(";");
                            AD.Write(dr["Cantidad"]);
                            AD.Write(";");
                            AD.Write(dr["Precio"]);
                            AD.Write(";");
                            AD.WriteLine(totalLibros);


                            cantidad++;
                        }
                        
                        


                    }



                    AD.Write("Cantidad:;");
                    AD.WriteLine(cantidad);
                    AD.Write("Total:;");
                    AD.WriteLine(totalLibrosTodos);


                }
                else
                {
                    MessageBox.Show("No tiene filas");

                }


                AD.Close();
                AD.Dispose();
                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }


        public static void generarTXT(int idIdioma)
        {
            try
            {

                conexion.ConnectionString = CadenaConexion;

                command.Connection = conexion;
                command.CommandType = CommandType.TableDirect;
                command.CommandText = Tabla;




                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(command);

                adaptador.Fill(DS, Tabla);

                string nombreArchivo = "ReporteLibros.txt";
                StreamWriter AD = new StreamWriter(nombreArchivo, false);


                cantidad = 0;

                totalLibros = 0;

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow dr in DS.Tables[Tabla].Rows)
                    {
                        totalLibros = 0;

                        if (idIdioma == Convert.ToInt32(dr["IdIdioma"]))
                        {
                            totalLibros += Convert.ToInt32(dr["Cantidad"]) * Convert.ToInt32(dr["Precio"]);



                            AD.Write("Titulo:");
                            AD.Write(dr["Titulo"]); 
                            AD.Write("");
                            AD.Write(", Año:");
                            AD.Write(dr["Año"]);
                            AD.Write("");
                            AD.Write(", Cantidad:");
                            AD.Write(dr["Cantidad"]);
                            AD.Write("");
                            AD.Write(", Precio:");
                            AD.Write(dr["Precio"]);
                            AD.Write("");
                            AD.Write(", Total libros:") ;
                            AD.WriteLine(totalLibros);


                            cantidad++;
                        }




                    }



                    AD.Write("Cantidad:  ");
                    AD.WriteLine(cantidad);
                    AD.Write("Total: ");
                    AD.WriteLine(totalLibrosTodos);


                }
                else
                {
                    MessageBox.Show("No tiene filas");

                }


                AD.Close();
                AD.Dispose();
                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

    }
}
