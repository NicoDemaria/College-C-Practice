using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionContribuyentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Acerca_de acerca = new Acerca_de();
            acerca.ShowDialog();    
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agrega_nuevo_contribuyente agrega_Nuevo_Contribuyente = new Agrega_nuevo_contribuyente();
            agrega_Nuevo_Contribuyente.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.datosPrueba();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_general_de_contribuyentes listado_General_De_Contribuyentes = new Listado_general_de_contribuyentes();
            listado_General_De_Contribuyentes.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_de_datos_de_un_contribuyente consulta_De_Datos_De_Un_Contribuyente = new Consulta_de_datos_de_un_contribuyente();
            consulta_De_Datos_De_Un_Contribuyente.ShowDialog();
        }
    }
}
