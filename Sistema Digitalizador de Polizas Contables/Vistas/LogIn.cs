using System;
using System.Windows.Forms;
using Entidades;
using Logica_de_Negocio;

namespace Sistema_Digitalizador_de_Polizas_Contables
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void botonAccesoAdmin_Click(object sender, EventArgs e)
        {
            //Obtener datos del formulario en objeto UsuarioInfo
            if (int.TryParse(txbIDUsuario.Text, out int userID))
            {
                UsuarioInfo usuario = new UsuarioInfo(userID, txbNombreUsuario.Text, txbPassword.Text);
            }
            else
            {
                MessageBox.Show("Solo se permite usar numeros en el campo ID.", "Error");
            }

            //Verifica identidad


            //Inicia sesion
            new expedientesP().Show();
            this.SetVisibleCore(false);
        }

        private void botonCancelarLogAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
