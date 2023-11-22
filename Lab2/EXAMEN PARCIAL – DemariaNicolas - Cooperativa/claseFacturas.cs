using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EXAMEN_PARCIAL___DemariaNicolas___Cooperativa
{
    internal class claseFacturas
    {

        public static OleDbConnection conexion = new OleDbConnection();
        public static OleDbCommand command = new OleDbCommand();
        public static OleDbDataAdapter adaptador = new OleDbDataAdapter(command);

        public static string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=COOPERATIVA.mdb";
        public static string Tabla = "FacturasPagadas";


        public static int cantidad = 1;
        public static decimal importeTotal = 0;
        


        public  static int devolverCantidad
        {

            get
            {
                return cantidad;
            }
        }

        public static decimal devolverTotal
        {

            get
            {
                return importeTotal;
            }
        }

        public static decimal devolverPromedio
        {

            get
            {
                return importeTotal / cantidad;
            }
        }




        public static void cargarGrilla(DataGridView grilla,int codigoSocio)
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
                importeTotal = 0;
                adaptador.Fill(DS, Tabla);
                grilla.Rows.Clear();
                if (DS.Tables[Tabla].Rows.Count > 0)
                {


                    foreach (DataRow dr in DS.Tables[Tabla].Rows)
                    {

                        if (codigoSocio == Convert.ToInt32(dr["Cuenta"]))
                        {
                            grilla.Rows.Add(dr["Factura"], dr["Fecha"], dr["Importe"]);
                            cantidad++;
                            importeTotal += Convert.ToDecimal(dr["Importe"]);



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

        public static void generarReporte ( int codigoSocio)
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
                StreamWriter AD = new StreamWriter("Facturas.txt",false);

                cantidad = 0;
                importeTotal = 0;

                adaptador.Fill(DS, Tabla);
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    

                    foreach (DataRow dr in DS.Tables[Tabla].Rows)
                    {

                        if (codigoSocio == Convert.ToInt32(dr["Cuenta"]))
                        {
                            
                            AD.Write("Factura:");
                            AD.Write(dr["Factura"]);
                            AD.Write("");
                            AD.Write(", Fecha:");
                            AD.Write(dr["Fecha"]);
                            AD.Write("");
                            AD.Write(", Importe:");
                            AD.WriteLine(dr["Importe"]);
                            cantidad++;
                            importeTotal += Convert.ToDecimal(dr["Importe"]);



                        }
                    }
                    AD.Write("Cantidad:  ");
                    AD.WriteLine(cantidad);
                    AD.Write("Total: ");
                    AD.WriteLine(importeTotal);

                }
                AD.Close();
                AD.Dispose();
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

    }
}
