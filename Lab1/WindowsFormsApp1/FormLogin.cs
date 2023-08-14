using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        int intentos = 0; //Contador de intentos
        private void button1_Click(object sender, EventArgs e) // Evento Click del boton Aceptar
        {

            if ((txtUsuario.Text == "Administrador" && txtContrasenia.Text == "adm135$") || (txtUsuario.Text == "Operador" && txtContrasenia.Text == "ope246$"))
            {
                this.Hide(); // oculta este formualrio
                FormInicio f = new FormInicio(); // crea el frmInicio
                f.Text = txtUsuario.Text; // asigna el texto de título
                f.ShowDialog(); // visualiza y ejecuta el frmInicio
                this.Show(); // visualiza nuevamente este formulario
             }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado."); intentos++; 
                if (intentos == 3) // si es 3 se cierra el formulario
                 {
                    this.Close();
                 }
            }
            
        
        
        
        
        }
        // evento Click del botón "btnCancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra el formulario         }


        }
}
