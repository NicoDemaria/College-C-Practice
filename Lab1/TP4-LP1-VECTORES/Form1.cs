using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LP1_VECTORES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Empleado nuevo_Empleado = new Nuevo_Empleado();
            nuevo_Empleado.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.CargaDataTest();
        }

        private void listadoGeneralDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_General_Empleados listado_General_Empleados = new Listado_General_Empleados();
            listado_General_Empleados.ShowDialog();
        }

        private void listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_por_categoria listado_Por_Categoria = new Listado_por_categoria();
            listado_Por_Categoria.ShowDialog();
        }

        private void listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_por_sueldo_mayor listado_Por_Sueldo_Mayor = new Listado_por_sueldo_mayor();
            listado_Por_Sueldo_Mayor.ShowDialog();
        }

        private void busquedaDeUnEmpeladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda_de_Empleado busqueda_De_Empleado = new Busqueda_de_Empleado();
            busqueda_De_Empleado.ShowDialog();
        }

        private void consultaDatosDeUnEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_de_datos_de_un_empleado consulta = new Consulta_de_datos_de_un_empleado();
            consulta.ShowDialog();
        }
    }
}
