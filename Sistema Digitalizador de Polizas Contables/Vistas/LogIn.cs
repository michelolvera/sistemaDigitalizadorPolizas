using System;
using System.Windows.Forms;
using Entidades;
using Logica_de_Negocio;

namespace Sistema_Digitalizador_de_Polizas_Contables
{
    public partial class FormLogin : Form
    {
        public FormLogin()
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
                ProcesosUsuario procesosUsuario = new ProcesosUsuario(usuario);
                if (procesosUsuario.IniciarSesion())
                {
                    //Inicia sesion
                    new ExpedientesP(procesosUsuario).Show();
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

        private void BotonCancelarLogAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxbIDUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
