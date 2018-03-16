using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica_de_Negocio;

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas
{
    /// <summary>
    /// Clase que aloja los eventos que permiten la gestion y la visualizaion de docuemntos y asi mismo llamar a eventos para escanear
    /// </summary>
    public partial class VisorDeDocumentos : Form
    {
        DatosArchivo datosArchivo = new DatosArchivo();
        private ProcesosUsuario procesosUsuario;
        private int expedienteActual;
        /// <summary>
        /// Constructor de la clase que recibe el procesos usuario para conocer los detalles del usuario que ingreso 
        /// Un entero para conocer el identificador del expediente actual y desplegarlo en un label 
        /// y una cadena del registro actual
        /// Así mismo aquí se configura los elementos como botonos para deshabilitar los no necesarios
        /// </summary>
        /// <param name="procesosUsuario"></param>
        /// <param name="expedienteActual"></param>
        /// <param name="registroActual"></param>
        public VisorDeDocumentos(ProcesosUsuario procesosUsuario, int expedienteActual, string registroActual)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            DateTime Fechaactual = DateTime.Now;
            lblUsuarioActual.Text = "| " + procesosUsuario.Usuario.Nombre + " " + procesosUsuario.Usuario.ApellidoPaterno + " " + procesosUsuario.Usuario.ApellidoMaterno + " |";
            lblFechaHora.Text = "| " + Fechaactual.ToLongDateString() + " |";
            this.procesosUsuario = procesosUsuario;
            this.expedienteActual = procesosUsuario.ObtenerRegistroId(expedienteActual);
            lblRegistroActual.Text = "| Registro actual:  "+ registroActual+" |";
            dgvDocumentos.CellClick += DgvDocumentos_CellClick;
            dgvDocumentos = procesosUsuario.LlenarTablaDocumentosPendientes(dgvDocumentos, this.expedienteActual, checkBoxDigitalizadosVisor.Checked);
            btnEliminarDoc.Enabled = false;
            btnReemplazarDoc.Enabled = false;
            btnMerge.Enabled = false;
        }
        /// <summary>
        /// Evento del click del boton de reemplazar documento, aqui validamos que se tenga los permisos de administrador
        /// Si se tine los permisos llamamos a los eventos de eliminar y de digitalizar inmediatamente para obtener un reemplazo inmediato
        /// Caso contrario se muestra un mensaje que no cuenta con los privilegios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReemplazarDoc_Click(object sender, EventArgs e)
        {

            if (procesosUsuario.Usuario.Administrador && MessageBox.Show("Se pretende eliminar el Documento seleccionado  ¿Esta seguro?", "Alerta", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                procesosUsuario.EliminarArchivo();
                BtnDigitalizar_Click(e,null);
            }
            else if (!procesosUsuario.Usuario.Administrador)
            {
                MessageBox.Show("No tienes los privilegios para poder eliminar documentos");
                //Loguear para que pueda eliminar el documento
            }
        }
        /// <summary>
        /// Evento de click en el boton de actualizar, lo que se hace es llenar el grid view 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnActualizarLista_Click(object sender, EventArgs e)
        {
            dgvDocumentos = procesosUsuario.LlenarTablaDocumentosPendientes(dgvDocumentos, expedienteActual, checkBoxDigitalizadosVisor.Checked);
        }
        /// <summary>
        /// Evento del click del boton de digitalizar cuando esta visible
        /// Aqui se hace el proceso simulado de ecaneo, donde abrimos un filedialog buscando un archivo PDF
        /// Una vez tenemos la ruta del PDF la guardamos, ejecutamos el metodo de consruir ruta para guardar y si se hace bien la copia del archivo en la ruta
        /// Se muestra un mensaje de confirmacion de escaneo exitoso y se manda la fecha en que se realizo para actualizarla en el registro
        /// En caso de que no se haya realizado la copia por cualquier error se envia un mensaje correspondiente y no se actualiza la fecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDigitalizar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fuente = new OpenFileDialog {Filter = " Archivos PDF(*.pdf)|*.pdf"};
            if (fuente.ShowDialog() == DialogResult.OK)
            {
                string source = fuente.FileName;
                int actual = dgvDocumentos.SelectedRows[0].Index;

                //Obtener datos del documento
                procesosUsuario.ConstruirRuta(actual);
                if (procesosUsuario.CopiarArchivo(source))
                {
                    MessageBox.Show("Documento Digitalizado");
                    //Aqui se envia el Update a la base de datos del documento ya digitalizado
                    procesosUsuario.ActualizarDigitalizado(actual, true);
                    //Actualizar Fecha
                    dgvDocumentos[1, actual].Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    labelNoDigitalizado.Visible = false;
                    btnDigitalizar.Visible = false;
                    procesosUsuario.MostrarPDF(this.axAcroPDF1);
                }
                else
                {
                    MessageBox.Show("Documento no Digitalizado");
                }
                btnEliminarDoc.Enabled = true;
                btnReemplazarDoc.Enabled = true;
                btnMerge.Enabled = true;
            }
            fuente.Dispose();
        }
        /// <summary>
        /// Evento del click del botón de eliminar 
        /// Llamamos el metodo de procesos usuario para eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminarDoc_Click(object sender, EventArgs e)
        {
            if (procesosUsuario.Usuario.Administrador && MessageBox.Show("Se pretende eliminar el Documento seleccionado  ¿Esta seguro?", "Alerta", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                if (procesosUsuario.EliminarArchivo())
                {
                    MessageBox.Show("Documento Eliminado");
                }
                
                
            }else if (!procesosUsuario.Usuario.Administrador)
            {
                MessageBox.Show("No tienes los privilegios para poder eliminar documentos");
                //Loguear para que pueda eliminar el documento
            }
        }
        /// <summary>
        /// Evento del checkbox de visualizacion para mostrar los digitlizados o los que no y llenar el gridview asi mismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxDigitalizadosVisor_CheckedChanged(object sender, EventArgs e)
        {
            procesosUsuario.LlenarTablaDocumentosPendientes(dgvDocumentos, expedienteActual, checkBoxDigitalizadosVisor.Checked);
        }

        private void VisorDeDocumentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            new ExpedientesP(procesosUsuario).Show();
        }
        /// <summary>
        /// Evento del click de alguna celda para en caso de tener el documento digitalizado se muestre en el visro de PDFs o en caso contrari para digitalizarlo
        /// Dentro de un try para preveer errores de archivos 
        /// Habilitamos y deshabilitamos los controle necesarios para cada caso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                
                if (dgvDocumentos[1, e.RowIndex].Value.ToString().Equals("No se ha digitalizado"))
                {
                    axAcroPDF1.Visible = false;
                    labelNoDigitalizado.Visible = true;
                    btnDigitalizar.Visible = true;
                    btnEliminarDoc.Enabled = false;
                    btnReemplazarDoc.Enabled = false;
                    btnMerge.Enabled = false;
                }
                 else
                 {
                    labelNoDigitalizado.Visible = false;
                    btnDigitalizar.Visible = false;
                    btnEliminarDoc.Enabled = true;
                    btnReemplazarDoc.Enabled = true;
                    btnMerge.Enabled = true;
                    procesosUsuario.ConstruirRuta(e.RowIndex);
                    if (!procesosUsuario.MostrarPDF(this.axAcroPDF1))
                    {
                        labelNoDigitalizado.Visible = true;
                        btnDigitalizar.Visible = true;
                        axAcroPDF1.Visible = false;
                        btnEliminarDoc.Enabled = false;
                        btnReemplazarDoc.Enabled = false;
                        btnMerge.Enabled = false;
                    }
                 }
            }
            catch (ArgumentOutOfRangeException)
            {
                btnEliminarDoc.Enabled = false;
                btnReemplazarDoc.Enabled = false;
                btnMerge.Enabled = false;
            }
        }
        /// <summary>
        /// Evento del boton de cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento del boton de minimizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Evento del cambio de txto en el txto de busqueda para llamar el metodo de buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            procesosUsuario.Buscar(dgvDocumentos, txbBusqueda);
        }
        /// <summary>
        /// evento de mouse hover para cambiar el texto a la herramiena del boton actual y dar pista a lo que hace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMerge_MouseHover(object sender, EventArgs e)
        {
            lblAcciones.Text = "| Añadir y unir  |";
        }
        /// <summary>
        /// evento de mouse hover para cambiar el texto a la herramiena del boton actual y dar pista a lo que hace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReemplazarDoc_MouseHover(object sender, EventArgs e)
        {
            lblAcciones.Text = "| Reemplazar   |";
        }
        /// <summary>
        /// evento de mouse hover para cambiar el texto a la herramiena del boton actual y dar pista a lo que hace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarDoc_MouseHover(object sender, EventArgs e)
        {
            lblAcciones.Text = "|      Eliminar       |";
        }
        /// <summary>
        /// evento de mouse hover para cambiar el texto a la herramiena del boton actual y dar pista a lo que hace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarDocs_MouseHover(object sender, EventArgs e)
        {
            lblAcciones.Text = "|   Actualizar     |";
        }
        /// <summary>
        /// Evento de que el puntero del mouse ha dejado el boton y regresar al texto de pistas a Acciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMerge_MouseLeave(object sender, EventArgs e)
        {
            lblAcciones.Text = "|   Acciones:     |";
        }
        /// <summary>
        /// Evento de que el puntero del mouse ha dejado el boton y regresar al texto de pistas a Acciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReemplazarDoc_MouseLeave(object sender, EventArgs e)
        {
            lblAcciones.Text = "|   Acciones:     |";
        }
        /// <summary>
        /// Evento de que el puntero del mouse ha dejado el boton y regresar al texto de pistas a Acciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarDoc_MouseLeave(object sender, EventArgs e)
        {
            lblAcciones.Text = "|   Acciones:     |";
        }
        /// <summary>
        /// Evento de que el puntero del mouse ha dejado el boton y regresar al texto de pistas a Acciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarDocs_MouseLeave(object sender, EventArgs e)
        {
            lblAcciones.Text = "|   Acciones:     |";
        }
        /// <summary>
        /// Evento del click del botón Merge para unir dos PDFs, llamamos el metodo para unir de procesos usuario   
        /// y en caso de exito mostramos un mensaje y en caso de fracaso un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMerge_Click(object sender, EventArgs e)
        {
            int actual = dgvDocumentos.SelectedRows[0].Index;
            if (procesosUsuario.MezclarDocumento(actual))
            {
                MessageBox.Show("Unión exitosa");
                procesosUsuario.MostrarPDF(this.axAcroPDF1);
            }
            else
                MessageBox.Show("Hubo algun error al intentar unir la digitalización, intente de nuevo");
        }
    }
}