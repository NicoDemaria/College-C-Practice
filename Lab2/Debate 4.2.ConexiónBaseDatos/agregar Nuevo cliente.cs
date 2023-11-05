using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debate_4._2.ConexiónBaseDatos
{
    public partial class agregar_Nuevo_cliente : Form
    {
        public agregar_Nuevo_cliente()
        {
            InitializeComponent();
        }

        private void agregar_Nuevo_cliente_Load(object sender, EventArgs e)
        {
            ClaseCiudad claseCiuad = new ClaseCiudad();

            claseCiuad.listar(comboBoxIdCiudad);
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            claseCliente cliente = new claseCliente();

            cliente.Agregar(textBoxNombre.Text,comboBoxIdCiudad.SelectedIndex);

            MessageBox.Show("Datos agregados correctamente");
        }

        private void textBoxCredito_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
