using System;
using System.Windows.Forms;
using Entidades;
using Logica_de_Negocio;

namespace Sistema_Digitalizador_de_Polizas_Contables
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void BotonAccesoAdmin_Click(object sender, EventArgs e)
        {

            //Obtener datos del formulario en objeto UsuarioInfo
            if (int.TryParse(txbIDUsuario.Text, out int userID) && !txbNombreUsuario.Text.Equals("") && !txbPassword.Text.Equals(""))
            {
                UsuarioInfo usuario = new UsuarioInfo(userID, txbNombreUsuario.Text, txbPassword.Text);
                //Verifica identidad
                SQLFormat formatos = new SQLFormat(usuario);
                if (formatos.IniciarSesion())
                {
                    //Inicia sesion
                    new ExpedientesP(formatos.Usuario).Show();
                    this.SetVisibleCore(false);
                }
                else
                {
                    MessageBox.Show("Error al iniciar sesion, validar datos.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Credenciales no validas", "Error");
            }
        }

        private void botonCancelarLogAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txbIDUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}
