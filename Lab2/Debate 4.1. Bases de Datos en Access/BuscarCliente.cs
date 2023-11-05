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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            claseCliente cliente = new claseCliente();

            cliente.buscarCliente(Convert.ToInt32(textBoxBuscar.Text));

            if (cliente.devolverIdCliente != 0)
            {
                labelNombre.Text = cliente.devolverNombreCliente.ToString();
                labelDeuda.Text = cliente.devolverDeuda.ToString();
                labelLimite.Text = cliente.devolverlimite.ToString();
            }
            else
            {
                MessageBox.Show("No se encontro ese codigo, ingrese uno valido");
                textBoxBuscar.Clear();
                labelDeuda.Text = "";
                labelNombre.Text = "";
                labelLimite.Text = "";
                
            }






        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonGuardar.Enabled = true;
            labelLimite.ReadOnly = false;
        }

        private void Limpiar()
        {
            textBoxBuscar.Clear();
            labelDeuda.Text = "";
            labelNombre.Text = "";
            labelLimite.Text = "";
           
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            claseCliente claseCliente = new claseCliente();

            claseCliente.devolverlimite =Convert.ToDecimal(labelLimite.Text);
            claseCliente.Modificar(Convert.ToInt32(textBoxBuscar.Text));
            MessageBox.Show("Cliente modificado");
            Limpiar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            claseCliente cliente = new claseCliente();


            cliente.Eliminar(Convert.ToInt32(textBoxBuscar.Text));
            MessageBox.Show("Cliente eliminado");

            buttonModificar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonGuardar.Enabled = true;
            labelLimite.ReadOnly = false;
            Limpiar();
        }
    }
}
