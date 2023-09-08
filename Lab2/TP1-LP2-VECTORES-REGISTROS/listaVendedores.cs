using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_LP2_VECTORES_REGISTROS
{
    public partial class listaVendedores : Form
    {
        public listaVendedores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lista de vendedores";

        }
        public decimal totalSueldos = 0;
        public int contador = 0;


        private void ordenarCodigoAsc()
        {
            datos.RegistroVendedor aux;
            for (int i = 0; i < datos.IND - 1; i++)
            {
                for (global::System.Int32 j = 0; j < datos.IND - 1; j++)
                {
                    if (datos.Vendedor[j].codigo > datos.Vendedor[j+1].codigo)
                    {
                        aux = datos.Vendedor[j];
                        datos.Vendedor[j] = datos.Vendedor[j + 1];
                        datos.Vendedor[j + 1] = aux;

                        
                    }
                }
            }
        }
        private void ordenarCodigoDesc()
        {
            datos.RegistroVendedor aux;
            for (int i = 0; i < datos.IND - 1; i++)
            {
                for (global::System.Int32 j = 0; j < datos.IND - 1; j++)
                {
                    if (datos.Vendedor[j].codigo < datos.Vendedor[j + 1].codigo)
                    {
                        aux = datos.Vendedor[j];
                        datos.Vendedor[j] = datos.Vendedor[j + 1];
                        datos.Vendedor[j + 1] = aux;


                    }
                }
            }
        }
        private void ordenarNameAsc()
        {
            datos.RegistroVendedor aux;
            for (int i = 0; i < datos.IND - 1; i++)
            {
                for (global::System.Int32 j = 0; j < datos.IND - 1; j++)
                {
                    if (string.Compare(datos.Vendedor[j].nombre, datos.Vendedor[j + 1].nombre) > 0 )
                    {
                        aux = datos.Vendedor[j];
                        datos.Vendedor[j] = datos.Vendedor[j + 1];
                        datos.Vendedor[j + 1] = aux;


                    }
                }
            }
        }
        private void ordenarNameDesc()
        {
            datos.RegistroVendedor aux;
            for (int i = 0; i < datos.IND - 1; i++)
            {
                for (global::System.Int32 j = 0; j < datos.IND - 1; j++)
                {
                    if (string.Compare(datos.Vendedor[j].nombre, datos.Vendedor[j + 1].nombre) < 0)
                    {
                        aux = datos.Vendedor[j];
                        datos.Vendedor[j] = datos.Vendedor[j + 1];
                        datos.Vendedor[j + 1] = aux;


                    }
                }
            }
        }

        private void ordenarSueldoAsc()
        {
            datos.RegistroVendedor aux;
            for (int i = 0; i < datos.IND - 1; i++)
            {
                for (global::System.Int32 j = 0; j < datos.IND - 1; j++)
                {
                    if (datos.Vendedor[j].sueldo > datos.Vendedor[j + 1].sueldo)
                    {
                        aux = datos.Vendedor[j];
                        datos.Vendedor[j] = datos.Vendedor[j + 1];
                        datos.Vendedor[j + 1] = aux;


                    }
                }
            }
        }
        private void ordenarSueldoDesc()
        {
            datos.RegistroVendedor aux;
            for (int i = 0; i < datos.IND - 1; i++)
            {
                for (global::System.Int32 j = 0; j < datos.IND - 1; j++)
                {
                    if (datos.Vendedor[j].sueldo < datos.Vendedor[j + 1].sueldo)
                    {
                        aux = datos.Vendedor[j];
                        datos.Vendedor[j] = datos.Vendedor[j + 1];
                        datos.Vendedor[j + 1] = aux;


                    }
                }
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)

        {
            totalSueldos = 0;
            contador = 0;



            switch (comboBoxCampo.SelectedIndex)
            {

                case 0:
                    if (comboBoxModo.SelectedIndex == 0)
                    {
                        ordenarCodigoAsc();
                    }
                    else
                    {
                        ordenarCodigoDesc();
                    }
                    break;
                case 1:
                    if (comboBoxModo.SelectedIndex == 0)
                    {
                        ordenarNameAsc();
                    }
                    else
                    {
                        ordenarNameDesc();
                    }
                    break;
                case 2:
                    if (comboBoxModo.SelectedIndex == 0)
                    {
                        ordenarSueldoAsc();
                    }
                    else
                    {
                        ordenarSueldoDesc();
                    }
                    break;
            }
            dataGridView1.Rows.Clear();

            for (int i = 0; i < datos.IND ; i++)
            {

               dataGridView1.Rows.Add(datos.Vendedor[i].codigo, datos.Vendedor[i].nombre, datos.Vendedor[i].sueldo);


                totalSueldos = totalSueldos + datos.Vendedor[i].sueldo;
                contador++;
                labelTotalSueldo.Text = totalSueldos.ToString();

                labelTotalVendedores.Text = contador.ToString();

            }



            



        }

        private void listaVendedores_Load(object sender, EventArgs e)
        {

        }
    }
}
