using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionClientes
{
    public partial class BusquedaCliente : Form
    {
        public BusquedaCliente()
        {
            InitializeComponent();
        }

        private void buttonConsultaBuscar_Click(object sender, EventArgs e)
        {
            buscarCliente( Convert.ToInt32(textBoxConsultaCodigo.Text));
        }
        public  void buscarCliente(int codigo)
        {
            for (int i = 0; i < data.vectorCliente.Length; i++)
            {

                if (data.vectorCliente[i].codigo == codigo)
                {
                    labelConsultaNombre.Text = data.vectorCliente[i].nombre;
                    labelConsultaDeuda.Text =  data.vectorCliente[i].deuda.ToString();
                }
                


            }
        }
    }
}
