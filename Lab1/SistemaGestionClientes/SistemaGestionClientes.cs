using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionClientes
{
    public partial class SistemaGestionClientes : Form
    {
        public SistemaGestionClientes()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarCliente cliente = new agregarCliente();
            cliente.ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           BusquedaCliente busquedaCliente = new BusquedaCliente();
            busquedaCliente.ShowDialog();   
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.ShowDialog();

        }

        private void SistemaGestionClientes_Load(object sender, EventArgs e)
        {
            data.testData();
        }

        private void listadoDeDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDeudores listadoDeudores = new ListadoDeudores();
            listadoDeudores.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCliente consultaCliente = new ConsultaCliente();
            consultaCliente.ShowDialog();
        }

        private void cargarUnaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargaVentas cargaVentas = new cargaVentas();
            cargaVentas.ShowDialog();
        }

        private void consultarUnaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarVenta consultarVenta = new ConsultarVenta();
            consultarVenta.ShowDialog();
        }

        private void adicionarUnValorAUnaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarValor adicionarValor = new AdicionarValor();
            adicionarValor.ShowDialog();
        }

        private void ventasDeUnaSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaDeUnaSucursal ventaDeUnaSucursal = new VentaDeUnaSucursal();
            ventaDeUnaSucursal.ShowDialog();
        }

        private void ventasDeunMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecorrerFila recorrerFila = new RecorrerFila();
            recorrerFila.ShowDialog();
        }

        private void borrarTodosLosDatosDeLaMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Meses.Length; i++)
            {
                for (int j = 0; j < data.sucursales.Length; j++)
                {
                    Matriz.ventas[i, j] = 0;
                }
            }
            MessageBox.Show("Matriz limpiada");
        }

        Random r = new Random();

        private void cargarDatosAleatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < data.Meses.Length; i++)
            {
                for (int j = 0; j < data.sucursales.Length; j++)
                {
                    Matriz.ventas[i, j] = r.Next(100,1000);
                }
            }
            MessageBox.Show("Datos aleatorios creados");
        }

        private void consultarTotalGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < data.Meses.Length; i++)
            {
                for (int j = 0; j < data.sucursales.Length; j++)
                {
                    total += Convert.ToInt32(Matriz.ventas[i, j]);
                }
            }
            MessageBox.Show("El total general es: " + total);
        }

        private void totalVentasPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalVentasSucursal totalVentasSucursal = new totalVentasSucursal();
            totalVentasSucursal.ShowDialog();
        }

        private void totalVentaPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalPorMes totalPorMes = new totalPorMes();
            totalPorMes.ShowDialog();
        }
    }
}
