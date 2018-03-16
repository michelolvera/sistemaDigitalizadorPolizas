using System;
using System.Windows.Forms;
using Entidades;
using Logica_de_Negocio;

namespace Sistema_Digitalizador_de_Polizas_Contables
{
    ///<summary>
    ///Clase que contiene los eventos de la ventana del login
    ///</summary>
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// evento de presionar el botón acceso
        /// Obtiene obtiene los datos del formulario en un objeto UsuarioInfo
        /// Verifica su identidad
        /// Si ingreso los datos correctos inicia sesión 
        /// Si no muestra un mensaje de error
        /// </summary>
        private void BotonAccesoAdmin_Click(object sender, EventArgs e)
        {
            //Obtener datos del formulario en objeto UsuarioInfo
            if (int.TryParse(txbIDUsuario.Text, out int userID) && !txbNombreUsuario.Text.Equals(String.Empty) && !txbPassword.Text.Equals(String.Empty))
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
        

        ///<summary>
        ///evento cuando se cierra la ventana del login
        ///</summary>
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
        ///<summary>
        ///Eventos de enter en  el text box manda llamar al boton acceso cuando se trate de un enter   
        ///</summary>
        private void txbIDUsuario_Enter(object sender, EventArgs e)
        {
            BotonAccesoAdmin_Click(sender, e);
        }

        ///<summary>
        ///Eventos de enter en  el text box y manda llamar al boton acceso cuando se trate de un enter       
        ///</summary>
        private void txbIDUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BotonAccesoAdmin_Click(sender, e);
            }
        }
        ///<summary>
        ///Eventos de enter en  el text box manda llamar al boton acceso cuando se trate de un enter         
        ///</summary>
        private void txbNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BotonAccesoAdmin_Click(sender, e);
            }
        }
        ///<summary>
        ///Eventos de enter en  el text box  manda llamar al boton acceso cuando se trate de un enter        
        ///</summary>
        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BotonAccesoAdmin_Click(sender, e);
            }
        }

        private void pctBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        ///<summary>
        ///evento del boton que cierra la ventana del login
        ///</summary>
        private void BtnCerrarLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
