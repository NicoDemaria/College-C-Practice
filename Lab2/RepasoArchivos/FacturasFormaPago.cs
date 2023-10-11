using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoArchivos
{
    public partial class FacturasFormaPago : Form
    {
        public FacturasFormaPago()
        {
            InitializeComponent();
        }

        private void FacturasFormaPago_Load(object sender, EventArgs e)
        {
            funciones.cargarCombo(comboClientes);
        }
    }
}
