using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_3._2
{
    public partial class Form1 : Form
    {

        archivoClientes archivoClientes = new archivoClientes();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            archivoClientes.grabar(textBoxCodigo.Text, textBoxNombre.Text, textDeuda.Text, textLimite.Text);
            MessageBox.Show("Datos cargados correctamente");



            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textDeuda.Text = "";
            textLimite.Text = "";


           



        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            archivoClientes.listarDeudores(dataGridView1);


            labelCantidadRegistros.Text = Convert.ToString(archivoClientes.contarClientesDeudores());

            labelTotal.Text = Convert.ToString(archivoClientes.calcularTotalDeudaDeudores());
            labelPromedio.Text = Convert.ToString(archivoClientes.calcularPromedioDeudores());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            archivoClientes.listar(dataGridView1);


            labelCantidadRegistros.Text = Convert.ToString(archivoClientes.contarClientes());

            labelTotal.Text = Convert.ToString(archivoClientes.calcularTotalDeuda());
            labelPromedio.Text = Convert.ToString(archivoClientes.calcularPromedio());
        }

        private void buttonGenerarReporte_Click(object sender, EventArgs e)
        {
            archivoClientes.generarReporte();
            MessageBox.Show("reporte ok");
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            archivoClientes.ordenarDatos();
            archivoClientes.listar(dataGridView1);


        }
    }
}
