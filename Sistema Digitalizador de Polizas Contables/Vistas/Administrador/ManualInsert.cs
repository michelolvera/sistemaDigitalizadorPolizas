using Logica_de_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas.Administrador
{
    /// <summary>
    /// Clase que loja la interfaz visual y metodos para manjear los elementos de la ventana de insercion manual 
    ///     para insertar nuevos expedientes manualmente.
    /// </summary>
    public partial class ManualInsert : Form
    {
        
        ProcesosAdministrador procesosAdministrador;
        /// <summary>
        /// El metodo constructor de la clase recibe como parametro el procesos administrador para comprobar los permisos de administrador a la ventana
        /// </summary>
        /// <param name="procesosAdministrador"></param>
        public ManualInsert(ProcesosAdministrador procesosAdministrador)
        {
            InitializeComponent();
            this.procesosAdministrador = procesosAdministrador;
        }
        /// <summary>
        /// Evento de carga de la ventana.
        /// Aqui revisamos el nive de administrador del usuario, en caso de solo ser administrador a nivel area, solo podra hacer inserciones en su misma area y se bloquea el cmbBox de area
        /// En caso de tener privilegios de super administrador (dios) se le da acceso al cmbBox del Area para insertar en el area que seleccione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManualInsert_Load(object sender, EventArgs e)
        {
            CmbArea = procesosAdministrador.LlenarCombo(CmbArea, 0, 0);
            if (!procesosAdministrador.Usuario.Dios)//si no es dios
            {
                CmbArea.SelectedIndex = procesosAdministrador.ObtenerIndexArea(procesosAdministrador.Usuario.IdArea);
                CmbArea.Enabled = false;
            }

        }
        /// <summary>
        /// El evento cuando ocurre un cambio de indice en el cmbArea para asi desactivar los controles no necearios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Desactivar Controles no Necesarios
            CmbCategoria.Enabled = false;
            TxtNombre.Enabled = false;
            TxtNombre.Text = String.Empty;
            BtnGuardar.Enabled = false;
            CmbExpediente = procesosAdministrador.LlenarCombo(CmbExpediente, 1, CmbArea.SelectedIndex);
        }
        /// <summary>
        /// El evento cuando ocurre un cambio de indice en el cmbExpediente para desactivar los controles no necesarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbExpediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Desactivar controles no Necesarios
            TxtNombre.Text = String.Empty;
            BtnGuardar.Enabled = false;
            TxtNombre.Enabled = false;

            CmbCategoria = procesosAdministrador.LlenarCombo(CmbCategoria, 2, CmbExpediente.SelectedIndex);
            
        }
        /// <summary>
        /// El evento cuando ocurre un cambio de indice en el cmbCategoria para habilitar los controles de txtNombre y el botón btnGuardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
            BtnGuardar.Enabled = true;
        }
        /// <summary>
        /// Evento del clic del boton de guardar, aqui validamos que el campo del nombre del identificador no este vacio, validamos la longitud de la cadena
        /// y si todo concuerda mandamos llamar el metodo de procesos Administrador para hacer la inserción
        /// En caso contrario, desplegamos mensaje de la validación no superada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombre != null && TxtNombre.Text != String.Empty)
            {
                if (procesosAdministrador.ValidarLongitudCadena(TxtNombre.Text))
                {
                    if (procesosAdministrador.RegistrarManual(TxtNombre.Text, CmbCategoria.SelectedIndex))
                    {
                        MessageBox.Show("El registro se creeo de manera correcta.");
                        TxtNombre.Text = String.Empty;
                    }
                    else
                        MessageBox.Show("Se presento un error al insertar el registro, intentelo de nuevo.");
                }else
                    MessageBox.Show("El identificador no puede exceder mas de 100 caracteres.");
            }
            else
            {
                MessageBox.Show("El nombre no puede estar vacio.");
            }
        }

        

        /// <summary>
        /// Boton de cerrar ventana, cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// Evento de tecla presionada, verificamos que haya sido un enter y si asi fue, llamamos el metodo del boton guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnGuardar_Click(sender, e);
            }
        }
    }
}