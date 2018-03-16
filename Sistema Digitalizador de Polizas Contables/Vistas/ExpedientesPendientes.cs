using Entidades;
using Logica_de_Negocio;
using Sistema_Digitalizador_de_Polizas_Contables.Vistas.Administrador;
using Sistema_Digitalizador_de_Polizas_Contables.Vistas.Super_Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Digitalizador_de_Polizas_Contables
{
    /// <summary>
    /// La clase de expedientes pendientes contiene todos los elementos y eventos de eta ventn, aqui mismo conteneos un DataGridView 
    /// que muestra los expedientes para digitalizar o ya digitalizados y completos{
    /// De aqui los eventos correspondientes nos darán acceso a las demas ventanas , podriamos decir que esta es la case central
    /// </summary>
    public partial class ExpedientesP : Form
    {
        ProcesosUsuario procesosUsuario;
        /// <summary>
        /// En el constructor recibimos de parametro el procesosUsuario para verificar datos de usuario que acaba de ingresar
        /// Datos como su nombre completo, y el area
        /// </summary>
        /// <param name="procesosUsuario"></param>
        public ExpedientesP(ProcesosUsuario procesosUsuario)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            DateTime Fechaactual = DateTime.Now;
            lblUsuarioActual.Text = "| " + procesosUsuario.Usuario.Nombre + " " + procesosUsuario.Usuario.ApellidoPaterno +" "+ procesosUsuario.Usuario.ApellidoMaterno +" |";
            lblFechaHora.Text = "| " +Fechaactual.ToLongDateString() + " |";
            this.procesosUsuario = procesosUsuario;
            menuStrip1.ForeColor = Color.White;
        }

        /// <summary>
        /// El evento de carga de a ventana, aqui llenamos el grid view con los datos d los expedients del area del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ExpedientesP_Load(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, null);
        }

        /// <summary>
        /// En el evento del boton de actualizar volvemos a llenar el grid view con los datos de los expedientes del area del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, null);
        }

        /// <summary>
        /// Evento de click dentro de una celda del DataGridView para abir la vista del visor de documentos, mandandole los datos que requiere su constructor para abrir el visor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvExpedientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new Vistas.VisorDeDocumentos(procesosUsuario, e.RowIndex, dgvExpedientes[0, e.RowIndex].Value.ToString()).Show();
            this.Hide();
        }
        /// <summary>
        /// Evento al cerrar la ventana, nos aseguramos finalize la aplicacion completa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpedientesP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Del menu, al hacer click en la opcion de Gestionar documentos verificamos los permisos del usuari a travez de prcesos administrador
        /// En caso de que el usuario  no cuente con los permisos se mostrara un mensaje correspondiente y la vista no se mostrará
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdministrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (procesosUsuario.Usuario.Administrador)
                new MenuAdministrador(new ProcesosAdministrador(procesosUsuario.Usuario)).Show();
            else
                MessageBox.Show("Usted no cuenta con los privilegios necesarios para gestionar este sistema.", "Error");
        }
        /// <summary>
        /// Evento que ocurre al existir un cambio en el checkbox de ver dodumentos completos o incompletos
        /// Al ocurrir volvemos a llenar el gridview correspondiente a lo solicitado por el checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarExpedientesCompletadosToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, null);
        }
        /// <summary>
        /// Evento de que sucedio un cambio el en el valor del texto de la busqueda, con cada cambio ejecutamos el metodo de buscar de procesos usuario  enviando el gridView y el txtBox de busqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbBusqueda_TextChanged(object sender, EventArgs e)
        {
            procesosUsuario.Buscar(dgvExpedientes, txbBusqueda);
        }
        /// <summary>
        /// Evento del click en la opcion de Insertar registro en el menu, donde verificamos los permisos de administradr del usuario, que en caso de no contarlo se muestra un mensaje y no se abre la vista solicitada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (procesosUsuario.Usuario.Administrador)
                new ManualInsert(new ProcesosAdministrador(procesosUsuario.Usuario)).Show();
            else
                MessageBox.Show("Usted no cuenta con los privilegios necesarios para gestionar este sistema.", "Error");
        }
        /// <summary>
        /// Evento del click de la opcion de mostrar expedientes completados para aquí cambiar el texto del título
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarExpedientesCompletadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarExpedientesCompletadosToolStripMenuItem.Checked = !mostrarExpedientesCompletadosToolStripMenuItem.Checked;
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, null);
            if (mostrarExpedientesCompletadosToolStripMenuItem.Checked)
            {
                lblVerActual.Text = "| Expedientes completados |";
            }
            else
            {
                lblVerActual.Text = "| Expedientes incompletos   |";
            }
        }
        /// <summary>
        /// Evento del click del boton de cerrar, para cerrar la ventana y la aplicacion al llamar al evento de cierre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ExpedientesP_FormClosed(sender, null);
        }
        /// <summary>
        /// Evento del click del boton de minimizar para minimizar la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Evento del click en la opcion de administrar ususarios, se verifica los permisos de superadministrador para mostrar la vista 
        /// En caso de no contar con los permisos se muestra el mensaje y no abre la vista solicitada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Este evento que se lanza cuando da un click en alguna de las columnas verificamos que haya sido un click secundario
        /// y validamos que sea solo sea en las columnas donde podemos filtrar ya que una vez ocurre el click mandamos desplegar la opcion de filtrar correspondiente a la clumnda clickeada
        /// Todo esto como un atajo para filtrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvExpedientes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                switch (e.ColumnIndex)
                {
                    case 2://nombre usuario
                        filtrarToolStripMenuItem.Select();
                        filtrarToolStripMenuItem.ShowDropDown();
                        if (usuariosToolStripMenuItem.Enabled)
                        {
                            usuarioToolStripMenuItem.ShowDropDown();
                            usuarioToolStripMenuItem_Click_1(null, e);
                        }
                        break;
                    case 3://nombre expediente
                        filtrarToolStripMenuItem.Select();
                        filtrarToolStripMenuItem.ShowDropDown();
                        if (expToolStripMenuItem.Enabled)
                        {
                            expToolStripMenuItem.ShowDropDown();
                            expToolStripMenuItem_Click(null, e);
                        }
                        break;
                    case 4://nobre categoria
                        filtrarToolStripMenuItem.Select();
                        filtrarToolStripMenuItem.ShowDropDown();
                        if (catToolStripMenuItem.Enabled)
                        {
                            catToolStripMenuItem.ShowDropDown();
                            catToolStripMenuItem_Click(null, e);
                        }
                        break;
                    default:

                        break;
                }
            }
        }
        /// <summary>
        /// Evento al dar enter el el texto para filtrar por expediente para llenar el grid view correspondiente al filtro solicitado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxExpediente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && toolStripTextBoxExpediente.Text != null && toolStripTextBoxExpediente.Text != string.Empty)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, toolStripTextBoxExpediente.Text);
                toolStripTextBoxExpediente.Text = null;
                usuarioToolStripMenuItem.Enabled = false;
                catToolStripMenuItem.Enabled = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, toolStripTextBoxExpediente.Text);
            }
        }
        /// <summary>
        /// Evento al dar enter el el texto para filtrar por categoria para llenar el grid view correspondiente al filtro solicitado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && toolStripTextBoxCategoria.Text != null && toolStripTextBoxCategoria.Text != string.Empty)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 2, toolStripTextBoxCategoria.Text);
                toolStripTextBoxCategoria.Text = null;
                usuarioToolStripMenuItem.Enabled = false;
                expToolStripMenuItem.Enabled = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 2, toolStripTextBoxCategoria.Text);
            }
        }
        /// <summary>
        /// Evento al dar enter el el texto para filtrar por usuario para llenar el grid view correspondiente al filtro solicitado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && toolStripTextBoxUsuario.Text != null && toolStripTextBoxUsuario.Text != string.Empty)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 3, toolStripTextBoxUsuario.Text);
                toolStripTextBoxUsuario.Text = null;
                catToolStripMenuItem.Enabled = false;
                expToolStripMenuItem.Enabled = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 3, toolStripTextBoxUsuario.Text);
            }
        }
        /// <summary>
        /// Evento del click de la opcion de eliminar filtros del menu de filtrar
        /// Aquí eliminamos el filtro activado y volvemos a llenar el grid view si ningún filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBoxCategoria.Text = null;
            toolStripTextBoxExpediente.Text = null;
            toolStripTextBoxUsuario.Text = null;
            catToolStripMenuItem.Enabled = true;
            expToolStripMenuItem.Enabled = true;
            usuarioToolStripMenuItem.Enabled = true;
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, null);
        }
        /// <summary>
        /// Click de la opcion de expedientes de la opcion de filtrar del manu para llevar al foco directamente al textBox del filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void expToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBoxExpediente.Focus();
        }
        /// <summary>
        /// Click de la opcion de categoria de la opcion de filtrar del manu para llevar al foco directamente al textBox del filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void catToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBoxCategoria.Focus();
        }
        /// <summary>
        /// Click de la opcion de usuario de la opcion de filtrar del manu para llevar al foco directamente al textBox del filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            toolStripTextBoxUsuario.Focus();
        }
        /// <summary>
        /// Evento de click de la opcion de ver del menu para cambiar el color del texto a negro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.Black;
        }
        /// <summary>
        /// Evento de click de la opcion de filtrar del menu para cambiar el color del texto a negro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filtrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.Black;
        }
        /// <summary>
        /// Evento de click de la opcion de administrar del menu para cambiar el color del texto a negro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.Black;
        }
        /// <summary>
        /// Evento de que se cerro las demás opciones de administrar y regresar la fuente a su color blanco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void herramientasToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }
        /// <summary>
        /// Evento de que se cerro las demás opciones de filtrar y regresar la fuente a su color blanco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filtrarToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }
        /// <summary>
        /// Evento de que se cerro las demás opciones de ver y regresar la fuente a su color blanco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }
    }
}
