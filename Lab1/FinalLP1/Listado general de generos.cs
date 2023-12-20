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
    public partial class Listado_general_de_generos : Form
    {
        public Listado_general_de_generos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Listado_general_de_generos_Load(object sender, EventArgs e)
        {

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Data.VectorGenero.Length; i++)
            {
                dataGridView1.Rows.Add(Data.VectorGenero[i].Codigo,Data.VectorGenero[i].Nombre, Data.VectorGenero[i].Descripcion);
            }
            labelCantidad.Text =  Data.VectorGenero.Length.ToString();
        }
    }
}
