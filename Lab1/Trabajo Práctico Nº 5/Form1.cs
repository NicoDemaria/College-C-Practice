using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Práctico_Nº_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cargaAutomaticaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void acercaDeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cargaDatosAutomaticamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.cargarDatosAutomaticamente();
            MessageBox.Show("Se han cargado los datos correctamente");
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            acercaDe acercaDe = new acercaDe();
            acercaDe.ShowDialog();
        }

        private void consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_cantidad_producida_de_un_empleado consultar_Cantidad_Producida_De_Un_Empleado = new Consultar_cantidad_producida_de_un_empleado();
            consultar_Cantidad_Producida_De_Un_Empleado.ShowDialog();
        }

        private void listarTotalProducidaEnCadaMaquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoTotalPorMaquina listadoTotalPorMaquina = new ListadoTotalPorMaquina();
            listadoTotalPorMaquina.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
