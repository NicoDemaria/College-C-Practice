using System;
using System.Windows.Forms;

namespace Debate_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCargar_Click(object sender, EventArgs e)
 
            //Asignamos los valores a nuestro vector de tipo registro
        {

            if (datosGlobales.IND < datosGlobales.Clientes.Length)
            {
                Int32 i = 0;

                while (datosGlobales.Clientes[i].codigo != Convert.ToInt32(textBoxCodigo.Text) && i < datosGlobales.IND)
                {
                        

                    i++;
                }

                if (i == datosGlobales.IND)
                {

                    datosGlobales.Clientes[datosGlobales.IND].codigo = Convert.ToInt32(textBoxCodigo.Text);
                    datosGlobales.Clientes[datosGlobales.IND].nombre = textBoxName.Text;
                    datosGlobales.Clientes[datosGlobales.IND].credito = Convert.ToDecimal(textBoxLimCredito.Text);
                    datosGlobales.Clientes[datosGlobales.IND].deuda = Convert.ToDecimal(textBoxDeuda.Text);
                        MessageBox.Show("Dato cargado exitosamente.");

                        textBoxName.Enabled = false;
                        textBoxDeuda.Enabled = false;
                        textBoxLimCredito.Enabled = false;
                        buttonCargar.Enabled = false;

                        textBoxCodigo.Clear();
                        textBoxDeuda.Clear();
                        textBoxLimCredito.Clear();
                        textBoxName.Clear();
                        datosGlobales.IND++;
                        

                }
                else
                {

                    MessageBox.Show("No se pudo cargar, codigo existente");
                    textBoxCodigo.Clear();


                }

            }
            listar();
        }
        
        private void buttonListado_Click(object sender, EventArgs e)

        {
            decimal totalDeuda = 0;



            dataGridView1.Rows.Clear();
            for (int i2 = 0; i2 < datosGlobales.IND; i2++)
            {

                if (datosGlobales.Clientes[i2].deuda > 0)
                {
                    totalDeuda += Convert.ToDecimal(datosGlobales.Clientes[i2].deuda);

                    dataGridView1.Rows.Add(datosGlobales.Clientes[i2].codigo, datosGlobales.Clientes[i2].nombre, datosGlobales.Clientes[i2].credito, datosGlobales.Clientes[i2].deuda);
                }


            }
            textBoxTotalDeuda.Text = totalDeuda.ToString();


        }
        
        private void listar()
        {
            decimal totalDeuda = 0;



            dataGridView1.Rows.Clear();
            for (int i2 = 0; i2 < datosGlobales.IND; i2++)
            {

        
                
            totalDeuda += Convert.ToDecimal(datosGlobales.Clientes[i2].deuda);

            dataGridView1.Rows.Add(datosGlobales.Clientes[i2].codigo, datosGlobales.Clientes[i2].nombre, datosGlobales.Clientes[i2].credito, datosGlobales.Clientes[i2].deuda);



            }
            textBoxTotalDeuda.Text = totalDeuda.ToString();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
            {
                textBoxDeuda.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxName.Enabled = false;
            textBoxDeuda.Enabled = false;
            textBoxLimCredito.Enabled = false;
            buttonCargar.Enabled = false;
        }

        private void textBoxDeuda_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDeuda.Text != "")
            {
                textBoxLimCredito.Enabled = true;
            }
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text != "")
            {
                textBoxName.Enabled = true;
            }

        }

        private void textBoxLimCredito_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLimCredito.Text != "")
            {
                buttonCargar.Enabled = true;
            }
        }
    }
}
