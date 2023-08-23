using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sp4Ejercicio
{

    
    public partial class Form1 : Form


        
    {
        
        private float[,] ventas;
        

        public Form1()
        {
            InitializeComponent();
            ventas = new float[5, 5]; // Crear el arreglo con el tamaño adecuado

            // Asignar el evento CellEndEdit al DataGridView
                dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;

            // Codigo para agregar filas

            void AgregarFilas()

            {
                for (int i = 0; i < 4; i++)
                {
                    dataGridView1.Rows.Add();
                }
            }

            AgregarFilas();

            // Supongamos que esta función se llama después de haber agregado las filas al DataGridView
             void AgregarNombresAColumna()
            {
                // Lista de nombres que quieres agregar
                List<string> nombres = new List<string>
                            {
                                "Julio",
                                "Esteban",
                                "Javier",
                                "Gonza",
                                "Alberto"
                            };

                // Itera a través de las filas y agrega nombres a la columna "Name"
                for (int i = 0; i < nombres.Count && i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["Names"].Value = nombres[i];
                }
            }
                  AgregarNombresAColumna();





        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1 && e.ColumnIndex <= 4) // Verificar que estamos en una celda editable
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                float.TryParse(cell.Value?.ToString(), out float valor); // Intentar convertir el valor a float
                ventas[e.RowIndex, e.ColumnIndex - 1] = valor; // Actualizar el valor en el arreglo

                if (valor >= 0) // Verificar si el valor es no negativo
                {
                    cell.Style.BackColor = dataGridView1.DefaultCellStyle.BackColor; // Restaurar el color de fondo original
                }
                else
                {
                    cell.Style.BackColor = Color.Red; // Cambiar el color de fondo de la celda inválida
                }

                if (!float.TryParse(cell.Value?.ToString(), out _)) // Verificar si el valor no se pudo convertir a float
                {
                    cell.Style.BackColor = Color.Red; // Cambiar el color de fondo de la celda inválida
                }
            }
        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            bool todosDatosNumericos = true; // Suponemos que todos los datos son numéricos al principio

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex >= 1 && cell.ColumnIndex <= 4) // Ignorar la columna "Names"
                    {
                        if (float.TryParse(cell.Value?.ToString(), out _))
                        {
                            // La conversión fue exitosa, lo que significa que el valor es numérico
                            // No necesitas hacer nada aquí
                        }
                        else
                        {
                            // La conversión falló, lo que significa que el valor no es numérico
                            todosDatosNumericos = false;
                            break; // No es necesario seguir verificando, ya sabemos que hay un dato no numérico
                        }

                    }
                }
                if (!todosDatosNumericos)
                {
                    break; // No es necesario seguir verificando, ya sabemos que hay un dato no numérico
                }
            }

            if (!todosDatosNumericos)
            {
                MessageBox.Show("Por favor, ingrese solo valores numéricos en todas las celdas de importes.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMozoDia.Enabled = false;
                btnTotales.Enabled = false;
            }
            else
            {
                MessageBox.Show("Datos correctos.", "Verificacion", MessageBoxButtons.OK, MessageBoxIcon.None);
                btnMozoDia.Enabled = true;
                btnTotales.Enabled = true;
            }
        }

        private void btnMozoDia_Click(object sender, EventArgs e)
        {
            {
                int mozoIndex = -1; // Índice del mozo con mayor importe
                float maxImporte = float.MinValue; // Valor máximo de importe

                for (int row = 0; row < ventas.GetLength(0); row++)
                {
                    float importeMozo = 0;

                    for (int col = 0; col < ventas.GetLength(1); col++)
                    {
                        importeMozo += ventas[row, col];
                    }

                    if (importeMozo > maxImporte)
                    {
                        maxImporte = importeMozo;
                        mozoIndex = row;
                    }
                }

                if (mozoIndex >= 0)
                {
                    string nombreMozo = dataGridView1.Rows[mozoIndex].Cells["Names"].Value.ToString();
                    MozoDia.Text = "Mozo del Día: " + nombreMozo;
                    textBoxNombreMozo.Text = maxImporte.ToString("C");
                }
                else
                {
                    MozoDia.Text = "Mozo del Día: No disponible";
                    textBoxNombreMozo.Text = "";
                }
            }



        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            List<int> totalesComida = new List<int>();
            List<int> totalesBebiNoAlc = new List<int>();
            List<int> totalesBebiAlc = new List<int>();
            List<int> totalesPostre = new List<int>();

            int importeTotal = 0;

            for (int row = 0; row < ventas.GetLength(0); row++)
            {
                int totalFila = 0; // Total para la fila actual

                for (int col = 1; col <= 4; col++) // Ignoramos la columna 0 (Names)
                {
                    int valor = (int)ventas[row, col - 1]; // Convertir el valor de la celda a int

                    totalFila += valor; // Sumar al total de la fila

                    switch (col)
                    {
                        case 1: // Comidas
                            totalesComida.Add(valor);
                            break;
                        case 2: // Bebidas sin alcohol
                            totalesBebiNoAlc.Add(valor);
                            break;
                        case 3: // Bebidas con alcohol
                            totalesBebiAlc.Add(valor);
                            break;
                        case 4: // Postres
                            totalesPostre.Add(valor);
                            break;
                    }
                }

                importeTotal += totalFila; // Sumar al importe total
            }

            // Mostrar totales en controles TextBox o Label
            TotalDia.Text = importeTotal.ToString("C");

            TotalComida.Text = totalesComida.Sum().ToString("C");
            TotalBebidaNoAlcohol.Text = totalesBebiNoAlc.Sum().ToString("C");
            TotalBebidaAlcohol.Text = totalesBebiAlc.Sum().ToString("C");
            TotalPostre.Text = totalesPostre.Sum().ToString("C");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
