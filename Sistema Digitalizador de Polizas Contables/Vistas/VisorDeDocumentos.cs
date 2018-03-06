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
    public partial class VisorDeDocumentos : Form
    {
        DatosArchivo datosArchivo = new DatosArchivo();
        private ProcesosUsuario procesosUsuario;
        private int expedienteActual;
        
        public VisorDeDocumentos(ProcesosUsuario procesosUsuario, int expedienteActual, string registroActual)
        {
            InitializeComponent();
            toolTipBotones.SetToolTip(btnMerge, "Añadir escaner al documento");
            toolTipBotones.SetToolTip(btnReemplazarDoc, "Reemplazar docuemnto ");
            toolTipBotones.SetToolTip(btnEliminarDoc, "Eliminar documento");
            toolTipBotones.SetToolTip(btnMerge, "Actualizar");
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

        private void BtnReemplazarDoc_Click(object sender, EventArgs e)
        {

            if (procesosUsuario.Usuario.Administrador && MessageBox.Show("Se pretende eliminar el Documento seleccionado  ¿Esta seguro?", "Alerta", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                procesosUsuario.EliminarArchivo();
                
            }
            else if (!procesosUsuario.Usuario.Administrador)
            {
                MessageBox.Show("No tienes los privilegios para poder eliminar documentos");
                //Loguear para que pueda eliminar el documento
            }
        }

        private void BtnActualizarLista_Click(object sender, EventArgs e)
        {
            dgvDocumentos = procesosUsuario.LlenarTablaDocumentosPendientes(dgvDocumentos, expedienteActual, checkBoxDigitalizadosVisor.Checked);
        }

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
            }
            fuente.Dispose();
        }

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

        private void CheckBoxDigitalizadosVisor_CheckedChanged(object sender, EventArgs e)
        {
            procesosUsuario.LlenarTablaDocumentosPendientes(dgvDocumentos, expedienteActual, checkBoxDigitalizadosVisor.Checked);
        }

        private void VisorDeDocumentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            new ExpedientesP(procesosUsuario).Show();
        }

        private void DgvDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                btnEliminarDoc.Enabled = true;
                btnReemplazarDoc.Enabled = true;
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
                    }
                 }
            }
            catch (ArgumentOutOfRangeException)
            {
                btnEliminarDoc.Enabled = false;
                btnReemplazarDoc.Enabled = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            procesosUsuario.Buscar(dgvDocumentos, txbBusqueda);
        }

        private void toolTipBotones_Popup(object sender, PopupEventArgs e)
        {
            toolTipBotones.SetToolTip(btnMerge, "Añadir escaner al documento");
            toolTipBotones.SetToolTip(btnReemplazarDoc, "Reemplazar docuemnto ");
            toolTipBotones.SetToolTip(btnEliminarDoc, "Eliminar documento");
            toolTipBotones.SetToolTip(btnMerge, "Actualizar");
        }
    }
}