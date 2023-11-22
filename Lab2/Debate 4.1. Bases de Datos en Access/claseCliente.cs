using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//estos 3 imports son importantes para poder trabajar con bases de datos

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.Common;
using System.Drawing.Printing;
using System.Drawing;   

namespace Debate_4._1.Bases_de_Datos_en_Access
{
    internal class claseCliente
    {

        // Estos objetos los tenemos que instanciar

        public OleDbConnection conexion = new OleDbConnection(); // Nos permite la coneccion con la base
        public OleDbCommand command = new OleDbCommand();  // Con esto podemos mandar una orden a la base
        public OleDbDataAdapter adaptador = new OleDbDataAdapter(); // Adapta los datos para que los entienda .net


        public string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.mdb"; // Le decimos el nombre de la base 
        public string Tabla = "Cliente"; //Le indicamos a cual de todas las tablas


        decimal deuda = 0;
        int cantidad = 0;
        

        int idCli = 0;
        string nom = "";
        decimal deu = 0;
        int idciu = 0;
        decimal limite = 0;


        public int devolverIdCliente
        {

            get { return idCli; }
            set
            {
                idCli = value;
            }
        }

        public string devolverNombreCliente
        {
            get { return nom; }
            set { nom = value; }
        }

        public decimal devolverDeuda
        {
            get
            {
                return deu;
            }
            set
            { deu = value; }
        }

        public int devolveridCiudad
        {

            get { return idciu; }
            set
            {
                idciu = value;
            }
        }

        public decimal devolverlimite
        {
            get
            {
                return limite;
            }
            set
            { limite = value; }
        }









        public decimal TotalDeuda
        {
            get { return deuda; }

        }
        public int CantidadDeudores
        {
            get
            {
                return cantidad;
            }
        }
        public decimal calculoPromedio
        {
            get
            {
                if (TotalDeuda > 0 && CantidadDeudores > 0 )
                {
                    return TotalDeuda / cantidad;
                }
                else
                {
                    return 0;
                }

            }
        }



        public  void Listar(DataGridView grilla)
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

              
                
                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
           

             
        }


        public void listarDeudores (DataGridView grilla)
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


                cantidad = 0;
                deuda = 0;
                grilla.Rows.Clear();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetDecimal(2) > 0)
                        {
                            grilla.Rows.Add(Convert.ToInt32(DR[0]), DR.GetString(1), DR.GetDecimal(2), DR.GetInt32(3), DR.GetInt32(4));
                            cantidad++;
                            deuda += DR.GetDecimal(2);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No tiene filas");
                    
                }



                conexion.Close(); // Cerramos la coneccion

            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("El argumento brindado es nulo");
            }
        }




        public void listarClientePorCiudad(DataGridView grilla, int idCiudad)
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

            claseCiudad ciudad = new claseCiudad(); 
                string nombreCiudad = "";


                grilla.Rows.Clear();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        nombreCiudad = ciudad.buscarCiudad(DR.GetInt32(3));
                        if (idCiudad == (DR.GetInt32(3)))
                        {
                            grilla.Rows.Add(Convert.ToInt32(DR[0]), DR.GetString(1), DR.GetDecimal(2), nombreCiudad, DR.GetInt32(4));
                            
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No tiene filas");

                }



                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }


        public void generarReporte()
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
                StreamWriter AD = new StreamWriter("Reporte.csv",false);


                AD.WriteLine("Codigo;Nombre;Deuda");
                cantidad = 0;
                deuda = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        

                            AD.Write(DR.GetInt32(0));
                            AD.Write(";");
                            AD.Write(DR.GetString(1));
                            AD.Write(";");
                            AD.WriteLine(DR.GetDecimal(2));


                            cantidad++;
                            deuda += DR.GetDecimal(2);
                        

                    }

                    AD.Write("Total deuda:;");
                    AD.WriteLine(deuda);

                    AD.Write("Cantidad:;");
                    AD.WriteLine(cantidad);

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

        public void generarReportePorCiudad(int codigoCiudad)
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
                StreamWriter AD = new StreamWriter("ReportePorCiudad.csv", false);


                AD.WriteLine("Codigo;Nombre");
                cantidad = 0;
                deuda = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {


                        if (DR.GetInt32(3) == codigoCiudad)
                        {
                            AD.Write(DR.GetInt32(0));
                            AD.Write(";");
                            AD.WriteLine(DR.GetString(1));


                            cantidad++;
                        }


                    }

                  

                    AD.Write("Cantidad:;");
                    AD.WriteLine(cantidad);

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
        public void generarReportePorCiudadForEach(int codigoCiudad, string nombreArchivo)
        {
            try
            {

                conexion.ConnectionString = CadenaConexion; //Le indicamos a donde esta la base de datos que tiene que abrir
                conexion.Open(); //Abrimos la coneccion

                command.Connection = conexion; // La coneccion abierta que esta arriba
                command.CommandType = CommandType.TableDirect; //Que tipo de comando queremos hacer
                command.CommandText = Tabla; // Nombre de la tabla

                //--------------------------------------------------------- NUEVO COMANDO


                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(command);

                adaptador.Fill(DS, Tabla);
                StreamWriter AD = new StreamWriter(nombreArchivo, false);


                AD.WriteLine("Codigo;Nombre");
                cantidad = 0;
                deuda = 0;

                

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {


                        if (Convert.ToInt32( fila["idCiudad"]) == codigoCiudad)
                        {
                            AD.Write(fila["idCliente"]) ;
                            AD.Write(";");
                            AD.WriteLine(fila["Nombre"]);


                            cantidad++;
                        }


                    }



                    AD.Write("Cantidad:;");
                    AD.WriteLine(cantidad);

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


        public void buscarCliente(int codigo)
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

              
                
                if (DR.HasRows)
                {


                    while (DR.Read())
                    {

                        if (codigo == DR.GetInt32(0))
                        {

                             idCli = DR.GetInt32(0);
                             nom = DR.GetString(1);
                            deu = DR.GetDecimal(2);
                             idciu = DR.GetInt32(3);
                             limite = DR.GetInt32(4);

                        }

                       


                    }

                   

                }
                else
                {
                    MessageBox.Show("No tiene filas");

                }


                
                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void Agregar()
        {
            try
            {

                conexion.ConnectionString = CadenaConexion; //Le indicamos a donde esta la base de datos que tiene que abrir
                conexion.Open(); //Abrimos la coneccion

                command.Connection = conexion; // La coneccion abierta que esta arriba
                command.CommandType = CommandType.TableDirect; //Que tipo de comando queremos hacer
                command.CommandText = Tabla; // Nombre de la tabla

                //--------------------------------------------------------- NUEVO COMANDO
                  
                adaptador = new OleDbDataAdapter(command);

                DataSet ds = new DataSet();

                adaptador.Fill(ds,Tabla);

                //Nuevos objetos 

                //Le indicamos la nuestra tabla mediante la variable Tabla que declaramos mas arriba
                DataTable tabla =  ds.Tables[Tabla];
                //Le indicamos que  queremos crear una variable de tipo DataRow indicandole la tabla
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = nom;
                fila["Deuda"] = 0;
                fila["idCiudad"] = idciu;
                fila["Limite"] = limite;

                tabla.Rows.Add(fila);

                OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder(adaptador);
                adaptador.Update(ds,Tabla);
                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void Modificar(int id)
        {

            try
            {
                string sql = "";

                sql = "UPDATE Cliente SET Limite ="+limite.ToString() +
                    " WHERE idCliente =" +id.ToString();




                conexion.ConnectionString = CadenaConexion; //Le indicamos a donde esta la base de datos que tiene que abrir
                conexion.Open(); //Abrimos la coneccion

                command.Connection = conexion; // La coneccion abierta que esta arriba
                command.CommandType = CommandType.Text; //Que tipo de comando queremos hacer
                command.CommandText = sql; // Nombre de la tabla
                command.ExecuteNonQuery();
                    
                   


                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        public  void Eliminar(int id)
        {

            try
            {
                string sql = "DELETE  FROM Cliente WHERE idCliente =  " + id.ToString();

                conexion.ConnectionString = CadenaConexion; //Le indicamos a donde esta la base de datos que tiene que abrir
                conexion.Open(); //Abrimos la coneccion

                command.Connection = conexion; // La coneccion abierta que esta arriba
                command.CommandType = CommandType.Text; //Que tipo de comando queremos hacer
                command.CommandText = sql; 

                command.ExecuteNonQuery();


                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        public void agregarConSQL()
        {

            try
            {
                string sql = "INSERT INTO Cliente (Nombre,Deuda,idCiudad,Limite)";
                sql = sql + "VALUES ('" + nom + "'," + deu.ToString() + "," + idciu.ToString() + "," + limite.ToString() + ")";




                conexion.ConnectionString = CadenaConexion; //Le indicamos a donde esta la base de datos que tiene que abrir
                conexion.Open(); //Abrimos la coneccion

                command.Connection = conexion; // La coneccion abierta que esta arriba
                command.CommandType = CommandType.Text; //Que tipo de comando queremos hacer
                command.CommandText = sql; // Nombre de la tabla

               command.ExecuteNonQuery();


                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }


        public void listarDeudoresOtraTabla(DataGridView grilla)
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

                claseCiudad ciudad = new claseCiudad();

                cantidad = 0;
                deuda = 0;
                string nombreCiudad = "";
                grilla.Rows.Clear();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {

                        nombreCiudad = ciudad.buscarCiudad(DR.GetInt32(3));


                        grilla.Rows.Add(Convert.ToInt32(DR[0]), DR.GetString(1), DR.GetDecimal(2), nombreCiudad, DR.GetInt32(4));
                            cantidad++;
                            deuda += DR.GetDecimal(2);
                        

                    }
                }
                else
                {
                    MessageBox.Show("No tiene filas");

                }



                conexion.Close(); // Cerramos la coneccion

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void Imprimir(PrintPageEventArgs reporte)
        {
            try
            {
                Font LetraTitulo1 = new Font("Arial", 20);
                Font LetraTitulo2 = new Font("Arial", 12);
                Font LetraTexto = new Font("Arial", 8);
                Int32 f = 200;
                reporte.Graphics.DrawString("Listado de Clientes",LetraTitulo1,Brushes.Red,100, 100);
               
                reporte.Graphics.DrawString("Código", LetraTitulo2,
               Brushes.Blue, 100, 180);
                reporte.Graphics.DrawString("Nombre del Clientes",
               LetraTitulo2, Brushes.Blue, 150, 180);
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                command.Connection = conexion;
                command.CommandType = CommandType.TableDirect;
                command.CommandText = Tabla;
                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(command);
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        reporte.Graphics.DrawString(fila["IdCliente"].ToString
                       (), LetraTexto, Brushes.Black, 100, f);
                        reporte.Graphics.DrawString(fila["Nombre"].ToString(),
                       LetraTexto, Brushes.Black, 150, f);
                        f = f + 12;
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }






    }
}
