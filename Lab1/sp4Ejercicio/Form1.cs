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
                if (cell.Value is int value && value >= 0)
                {
                    
                    cell.Style.BackColor = dataGridView1.DefaultCellStyle.BackColor; // Restaurar el color de fondo original
                }
                else
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
           
            

        }

    }
}
