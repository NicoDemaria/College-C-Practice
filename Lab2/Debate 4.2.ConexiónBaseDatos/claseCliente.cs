using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;




//Agregamos estos espacios de nombre para poder trabajar con las basesa de datos

using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


namespace Debate_4._2.ConexiónBaseDatos
{
    internal class claseCliente
    {


        private  OleDbConnection conn = new OleDbConnection(); // objeto que nos sirve para conectarse
        private OleDbCommand cmd = new OleDbCommand(); // Objeto que nos sirve para enviar  un comenado
        private OleDbDataAdapter adaptador = new OleDbDataAdapter(); // Este objeto, adapta nuestros datos a datos 
                                                                     // que pueden ser leidos por .net

        private string cadenaConnecion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Clientes.mdb";
        private string tabla = "Cliente";


        private int cantidad;
        private decimal deuda;



        private int idClient = 0;
        private string name = "";
        private decimal deu = 0;
        private decimal idCiu = 0;

        public int IdCliente {
            get { return idClient; } 
            set { idClient = value; }
                }

        public string nom
        {
            get { return name; }
            set { name = value; }
        }
        public decimal deud
        {
            get { return deu; }
            set { deu = value; }

        }

        public decimal ciudad
        {
            get { return idCiu; }
            set { idCiu = value; }
        }






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
        public decimal promedio
        {
            get
            {
                return deuda/ cantidad;
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

                cantidad = 1;
                deuda = 1;
                OleDbDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())


                        if (Convert.ToInt32(dr[2]) > 0)
                        {
                            cantidad++;
                            grilla.Rows.Add(dr[0], dr[1], dr[2]);
                            deuda += Convert.ToDecimal(dr[2]);
                        }
                }

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


                if (dr.HasRows)
                {
                    while (dr.Read())


                        if (Convert.ToInt32(dr[2]) > 0)
                        {
                            cantidad++;
                            grilla.Rows.Add(dr[0], dr[1], dr[2]);
                            deuda += Convert.ToDecimal(dr[2]);
                        }
                }
                conn.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            
        }



        public void generarReporteClientes()// Procedimiento para especificar que datos queremos mostrar en nuestra grilla
        {
            try
            {

                conn.ConnectionString = cadenaConnecion;// Le decimos la base datos     
                conn.Open(); // Abrimos la coneccion

                cmd.Connection = conn; // le indicamos al comando cual es la coneccion a usar
                cmd.CommandType = CommandType.TableDirect; // El tipo de comando, tenemos varios [En este caso nos traemos la tabla directa] 
                cmd.CommandText = tabla; // Aca le indicamos el nombre de nuestra variable, es decir el nombre de la tabla
                OleDbDataReader dr = cmd.ExecuteReader();



                /*adaptador = new OleDbDataAdapter(cmd);
                
                /DataSet dataSet = new DataSet();
                adaptador.Fill(dataSet);

                grilla.DataSource = dataSet.Tables[0];
                */


                StreamWriter AD = new StreamWriter("reporteClientes.csv", false);
                AD.WriteLine("Listado de clientes /n");
                AD.WriteLine("Codigo;Nombre;Deuda");



                cantidad = 0;
                deuda = 0;


                if (dr.HasRows)
                {
                    while (dr.Read())

                    {

                        //Aca preguntamos si la columna dos de la tabla clientes es mayor a 0
                       // if (Convert.ToInt32(dr[2]) > 0)
                        //{

                            AD.Write(Convert.ToInt32(dr[0]));
                            AD.Write(";");
                            AD.Write(Convert.ToString(dr[1]));
                            AD.Write(";");
                            AD.WriteLine(Convert.ToInt32(dr[2]));
                            cantidad++;
                            deuda += Convert.ToDecimal(dr[2]);
                        //}
                    }

                    AD.Write("Cantidad de clientes:;");
                    AD.WriteLine(cantidad);
                    AD.Write("Total:;");
                    AD.WriteLine(deuda);


                }
                AD.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }



        }




        public  void  buscarCliente(int codigo)// Procedimiento para especificar que datos queremos mostrar en nuestra grilla
        {
            try
            {

                conn.ConnectionString = cadenaConnecion;// Le decimos la base datos     
                conn.Open(); // Abrimos la coneccion

                cmd.Connection = conn; // le indicamos al comando cual es la coneccion a usar
                cmd.CommandType = CommandType.TableDirect; // El tipo de comando, tenemos varios [En este caso nos traemos la tabla directa] 
                cmd.CommandText = tabla; // Aca le indicamos el nombre de nuestra variable, es decir el nombre de la tabla
                OleDbDataReader dr = cmd.ExecuteReader(); // usamos esta clase para poder leer



                /*adaptador = new OleDbDataAdapter(cmd);
                
                /DataSet dataSet = new DataSet();
                adaptador.Fill(dataSet);

                grilla.DataSource = dataSet.Tables[0];
                */
                cantidad = 0;
                deuda = 0;


                if (dr.HasRows)
                {
                    while (dr.Read())

                    {
                        if (Convert.ToInt32(dr[0]) == codigo)
                        {
                             idClient = dr.GetInt32(0);
                                 name = dr.GetString(1);
                               deu = dr.GetDecimal(2);
                               idCiu = dr.GetInt32(3);
    }

                    }

                   


                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }



        }

        public void Agregar(string nom, int idCiu )
        {


            try
            {
                conn.ConnectionString = cadenaConnecion;
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = tabla;
                adaptador = new OleDbDataAdapter(cmd);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, tabla);
                DataTable Tabla = DS.Tables[tabla]; //Recibe todo lo que tiene el dataset en la tabla selecionada
                                                    //En nuestro caso Cliente
                DataRow fila = Tabla.NewRow();// Creamos una nueva fila dentro de nuestra tabla

                //llenamos con los datos nuevos
                fila["Nombre"] = nom;
                fila["Deuda"] = 0;
                fila["idCiudad"] = 3;
                Tabla.Rows.Add(fila);

                //Concilia los cambios entre la ram y la base de datos
                OleDbCommandBuilder ConciliaCambios =  new OleDbCommandBuilder(adaptador);

                //Aca hacemos el update de el data set
                adaptador.Update(DS, tabla);
                //Por uiltimo cerramos la coneccion
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

    }


}
