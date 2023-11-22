using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_Práctico_Nº_5
{
    public partial class Consultar_cantidad_producida_de_un_empleado : Form
    {
        public Consultar_cantidad_producida_de_un_empleado()
        {
            InitializeComponent();
            StartPosition   = FormStartPosition.CenterScreen;
        }

        private void Consultar_cantidad_producida_de_un_empleado_Load(object sender, EventArgs e)
        {

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            dataGridView1.Rows.Clear();
            for (int c = 0; c < data.empleados.Length; c++)
            {
               for (int f = 0; f < data.Maquina.Length; f++)
                {
                    total += Convert.ToDecimal(data.Matriz[c, f]);


                    
                }
                dataGridView1.Rows.Add(data.empleados[c], total);


            }
        }
    }
}
