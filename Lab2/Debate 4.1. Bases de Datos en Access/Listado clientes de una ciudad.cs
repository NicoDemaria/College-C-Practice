using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_4._1.Bases_de_Datos_en_Access
{
    public partial class Listado_clientes_de_una_ciudad : Form
    {
        public Listado_clientes_de_una_ciudad()
        {
            InitializeComponent();
        }

        private void Listado_clientes_de_una_ciudad_Load(object sender, EventArgs e)
        {
            claseCiudad claseCiudad = new claseCiudad();
            claseCiudad.listar(comboBox2);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int idCiudad = Convert.ToInt32(comboBox2.SelectedValue);

            claseCliente claseCliente = new claseCliente(); 
            claseCliente.listarClientePorCiudad(dataGridView1,idCiudad);
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "Archivo CSV (*.csv)|*.csv"; //A la derecha mostamos los que se pueden abrir
                                                                       // comentario del tipo de archivo

            
            saveFileDialog1.ShowDialog();


            int idCiudad = Convert.ToInt32(comboBox2.SelectedValue);
            claseCliente claseCliente = new claseCliente();
            

            claseCliente.generarReportePorCiudadForEach(idCiudad,saveFileDialog1.FileName);
            MessageBox.Show("Reporte generado");
        }
    }
}
