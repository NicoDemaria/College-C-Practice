using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de acerca = new Acerca_de();
            acerca.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargaAutomaticaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.CargarDatos();
              
        }

        private void agregarNuevoGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_nuevo_género_ agregar_Nuevo_Género_ = new Agregar_nuevo_género_();
            
            agregar_Nuevo_Género_.ShowDialog();
        }

        private void listadoGeneralDeGénerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_general_de_generos listado_General_De_Generos = new Listado_general_de_generos();
            listado_General_De_Generos.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void consultaDeDatosDeUnGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_de_datos_de_un_genero consulta_De_Datos_De_Un_Genero = new Consulta_de_datos_de_un_genero();   
            consulta_De_Datos_De_Un_Genero.ShowDialog();
        }

        private void registrarVisualizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_Vizualizaciones registrar_Vizualizaciones = new Registrar_Vizualizaciones();
            registrar_Vizualizaciones.ShowDialog();
        }

        private void consultaDeVisualizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_de_visualizaciones consulta_De_Visualizaciones = new Consulta_de_visualizaciones();
            consulta_De_Visualizaciones.ShowDialog();
        }

        private void visualizacionesDeUnMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizaciones_de_un_mes visualizaciones_De_Un_Mes = new Visualizaciones_de_un_mes();
            visualizaciones_De_Un_Mes.ShowDialog();
        }

        private void visualizacionesDeUnGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizaciones_de_un_género visualizaciones_De_Un_Género = new Visualizaciones_de_un_género();
            visualizaciones_De_Un_Género.ShowDialog();
            
        }

        private void estadísticaDeVisualizacionesPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadística_de_visualizaciones_por_mes estadística_De_Visualizaciones_Por_Mes = new Estadística_de_visualizaciones_por_mes();
            estadística_De_Visualizaciones_Por_Mes.ShowDialog();
        }

        private void estadísticaDeVisualizacionesPorGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadística_de_visualizaciones_por_género estadística_De_Visualizaciones_Por_Género = new Estadística_de_visualizaciones_por_género();
            estadística_De_Visualizaciones_Por_Género.ShowDialog();
        }
    }
}
