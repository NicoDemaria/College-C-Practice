using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct RegistroCliente
        {
            public int codigo;
            public string nombre;
            public decimal limite;
            public decimal deuda;
        }
        public static RegistroCliente[] Vector = new RegistroCliente[100];
        public static int IND = 0;

        static void AgregarEjemplos()
        {

            Vector[IND].codigo = 1;
            Vector[IND].nombre = "Cliente 1";
            Vector[IND].limite = 1000.0m;
            Vector[IND].deuda = 500.0m;
            IND++;

            Vector[IND].codigo = 5;
            Vector[IND].nombre = "Cliente 5";
            Vector[IND].limite = 511500.0m;
            Vector[IND].deuda = 51.0m;
            IND++;

            Vector[IND].codigo = 3;
            Vector[IND].nombre = "Cliente 3";
            Vector[IND].limite = 31500.0m;
            Vector[IND].deuda = 10.0m;
            IND++;

            Vector[IND].codigo = 2;
            Vector[IND].nombre = "Cliente 2";
            Vector[IND].limite = 1500.0m;
            Vector[IND].deuda = 200.0m;
            IND++;
            
            Vector[IND].codigo = 4;
            Vector[IND].nombre = "Cliente 4";
            Vector[IND].limite = 451500.0m;
            Vector[IND].deuda = 110.0m;
            IND++;
           

        }


        private void ordenarCodigoAsc()
        {
            RegistroCliente aux;
            for (int i = 0; i < IND - 1; i++)
            {
                for (int j = 0; j < IND - 1; j++)
                {
                    if (Vector[j].codigo > Vector[j + 1].codigo)
                    {
                        aux = Vector[j];
                        Vector[j] = Vector[j + 1];
                        Vector[j + 1] = aux;
                    }
                }
            }
        }

        private void ordenarCodigoDesc()
        {
            RegistroCliente aux;
            for (int i = 0; i < IND - 1; i++)
            {
                for (int j = 0; j < IND - 1; j++)
                {
                    if (Vector[j].codigo < Vector[j + 1].codigo)
                    {
                        aux = Vector[j];
                        Vector[j] = Vector[j + 1];
                        Vector[j + 1] = aux;
                    }
                }
            }
        }

        private void ordenarNombreAsc()
        {
            RegistroCliente aux;
            for (int i = 0; i < IND - 1; i++)
            {
                for (int j = 0; j < IND - 1; j++)
                {


                    //Compare nos devuelve un numero entero, si es mayor a 0 significa que el primer nombre es "mayor" al segundo nombre y lo mismo con el caso desc pero nos preguntamos si es menor
                    if (string.Compare(Vector[j].nombre, Vector[j + 1].nombre) > 0)
                    {
                        aux = Vector[j];
                        Vector[j] = Vector[j + 1];
                        Vector[j + 1] = aux;
                    }
                }
            }
        }

        private void ordenarNombreDesc()
        {
            RegistroCliente aux;
            for (int i = 0; i < IND - 1; i++)
            {
                for (int j = 0; j < IND - 1; j++)
                {
                    if (string.Compare(Vector[j].nombre, Vector[j + 1].nombre) < 0)
                    {
                        aux = Vector[j];
                        Vector[j] = Vector[j + 1];
                        Vector[j + 1] = aux;
                    }
                }
            }
        }

        private void ordenarLimiteAsc()
        {
            RegistroCliente aux;
            for (int i = 0; i < IND - 1; i++)
            {
                for (int j = 0; j < IND - 1; j++)
                {
                    if (Vector[j].limite > Vector[j + 1].limite)
                    {
                        aux = Vector[j];
                        Vector[j] = Vector[j + 1];
                        Vector[j + 1] = aux;
                    }
                }
            }
        }

        private void ordenarLimiteDesc()
        {
            RegistroCliente aux;
            for (int i = 0; i < IND - 1; i++)
            {
                for (int j = 0; j < IND - 1; j++)
                {
                    if (Vector[j].limite < Vector[j + 1].limite)
                    {
                        aux = Vector[j];
                        Vector[j] = Vector[j + 1];
                        Vector[j + 1] = aux;
                    }
                }
            }
        }

        private void ordenarDeudaAsc()
        {
            RegistroCliente aux;
            for (int i = 0; i < IND - 1; i++)
            {
                for (int j = 0; j < IND - 1; j++)
                {
                    if (Vector[j].deuda > Vector[j + 1].deuda)
                    {
                        aux = Vector[j];
                        Vector[j] = Vector[j + 1];
                        Vector[j + 1] = aux;
                    }
                }
            }
        }

        private void ordenarDeudaDesc()
        {
            RegistroCliente aux;
            for (int i = 0; i < IND - 1; i++)
            {
                for (int j = 0; j < IND - 1; j++)
                {
                    if (Vector[j].deuda < Vector[j + 1].deuda)
                    {
                        aux = Vector[j];
                        Vector[j] = Vector[j + 1];
                        Vector[j + 1] = aux;
                    }
                }
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
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
                        ordenarNombreAsc();
                    }

                    else
                    {
                        ordenarNombreDesc();
                    }
                    break;
                case 2:
                    if (comboBoxModo.SelectedIndex == 0)
                    {
                        ordenarLimiteAsc();
                    }
                    else
                    {
                        ordenarLimiteDesc();
                    }break;
                case 3:
                    if (comboBoxModo.SelectedIndex == 0)
                    {
                        ordenarDeudaAsc();
                    }
                    else
                    {
                        ordenarDeudaDesc();
                    }
                    break;




            }
            dataGridView1.Rows.Clear();

            for (int i = 0; i < IND; i++)
            {
                dataGridView1.Rows.Add(Vector[i].codigo, Vector[i].nombre, Vector[i].limite, Vector[i].deuda);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AgregarEjemplos();
            
        }
    }
}
