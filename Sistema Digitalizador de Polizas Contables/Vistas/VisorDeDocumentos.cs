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
            
            this.procesosUsuario = procesosUsuario;
            this.expedienteActual = procesosUsuario.ObtenerRegistroId(expedienteActual);
            lblRegistroActual.Text += registroActual;
            dgvDocumentos.CellClick += DgvDocumentos_CellClick;
            dgvDocumentos = procesosUsuario.LlenarTablaDocumentosPendientes(dgvDocumentos, this.expedienteActual, checkBoxDigitalizadosVisor.Checked);
            btnEliminarDoc.Enabled = false;
            btnReemplazarDoc.Enabled = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReemplazarDoc_Click(object sender, EventArgs e)
        {

            if (procesosUsuario.Usuario.EsAdmin && MessageBox.Show("Se pretende eliminar el Documento seleccionado  ¿Esta seguro?", "Alerta", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                procesosUsuario.EliminarArchivo();
                //
            }
            else if (!procesosUsuario.Usuario.EsAdmin)
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
                datosArchivo = procesosUsuario.ConstruirRuta(actual);
                procesosUsuario.CopiarArchivo(source);

                //Aqui se envia el Update a la base de datos del documento ya digitalizado
                procesosUsuario.ActualizarDigitalizado(actual, true);

                //Actualizar Fecha
                dgvDocumentos[1,actual].Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                MostrarPDF();
                
            }
            fuente.Dispose();
        }

        private void BtnEliminarDoc_Click(object sender, EventArgs e)
        {
            if (procesosUsuario.Usuario.EsAdmin && MessageBox.Show("Se pretende eliminar el Documento seleccionado  ¿Esta seguro?", "Alerta", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                procesosUsuario.EliminarArchivo();
            }else if (!procesosUsuario.Usuario.EsAdmin)
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
            btnEliminarDoc.Enabled = true;
            btnReemplazarDoc.Enabled = true;
            if(dgvDocumentos[1, e.RowIndex].Value.ToString().Equals("No se ha digitalizado"))
            {
                axAcroPDF1.Visible = false;
                labelNoDigitalizado.Visible = true;
                btnDigitalizar.Visible = true;
                //MessageBox.Show("Archivo no digitalizado");
            }
            else
            {
                datosArchivo = procesosUsuario.ConstruirRuta(e.RowIndex);
                MostrarPDF();
            }
        }

        private void MostrarPDF()
        {
            axAcroPDF1.Visible = true;
            labelNoDigitalizado.Visible = false;
            btnDigitalizar.Visible = false;
            axAcroPDF1.src = datosArchivo.Ruta + "\\" + datosArchivo.NombreArchivo;
        }
    }
}