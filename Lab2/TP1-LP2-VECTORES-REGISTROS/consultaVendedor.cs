using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_LP2_VECTORES_REGISTROS
{
    public partial class consultaVendedor : Form
    {
        public consultaVendedor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Consulta de datos de un vendedor...";

        }

        int codigoBuscar = 0;

        private void consultaVendedor_Load(object sender, EventArgs e)
        {

        }

        private void buttonConsultaBuscar_Click(object sender, EventArgs e)
        {

            codigoBuscar = Convert.ToInt32(textBoxConsultaCodigo.Text);


            for (int i = 0; i < datos.Vendedor.Length ; i++)
            {
                if (codigoBuscar == datos.Vendedor[i].codigo )
                {
                    labelConsultaNombre.Text = datos.Vendedor[i].nombre;
                    labelConsultaSueldo.Text = Convert.ToString(datos.Vendedor[i].sueldo);
                    


                }
                

                
            }

        }

    }
}
