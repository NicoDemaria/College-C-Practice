using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                btnMozoDia.Enabled = true;
                btnTotales.Enabled = true;
            }
        }

        private void btnMozoDia_Click(object sender, EventArgs e)
        {
            //Los botones de las consultas se ubican en la parte inferior del formulario y son dos, el primero denominado
            //"Mozo del día" deberá determinar qué mozo tiene el mayor importe de venta total, considerando todas las categorías y mostrará su nombre e importe en controles de tipo 'TextBox' o 'Label' ubicados a la derecha del botón.
        }
    }
}
