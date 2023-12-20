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
    public partial class Consulta_de_datos_de_un_genero : Form
    {
        public Consulta_de_datos_de_un_genero()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Consulta_de_datos_de_un_genero_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.VectorGenero.Length; i++)
            {
                comboBox1.Items.Add(Data.VectorGenero[i].Nombre);
            }
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.VectorGenero.Length; i++)
            {
                string nombre = comboBox1.SelectedItem.ToString();
                if (nombre == Data.VectorGenero[i].Nombre)
                {
                    labelCodigo.Text = Data.VectorGenero[i].Codigo.ToString();
                    labelDesc.Text = Data.VectorGenero[i].Descripcion;
                }

            }

        }
    }
}
