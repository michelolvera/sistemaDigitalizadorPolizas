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
using Logica_de_Negocio;
using Entidades;

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas
{
    public partial class VisorDeDocumentos : Form
    {
        String ruta;
        String nombreArchivo;
        ControlDirectorioArchivos controlArchivos = new ControlDirectorioArchivos();
        private ProcesosUsuario procesosUsuario;
        private int expedienteActual;

        public VisorDeDocumentos(ProcesosUsuario procesosUsuario, int expedienteActual, string registroActual)
        {
            InitializeComponent();
            
            this.procesosUsuario = procesosUsuario;
            this.expedienteActual = procesosUsuario.ObtenerRegistroId(expedienteActual);
            lblRegistroActual.Text += registroActual;
            dgvDocumentos = this.procesosUsuario.LlenarTablaDocumentosPendientes(dgvDocumentos, this.expedienteActual, checkBoxDigitalizadosVisor.Checked);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReemplazarDoc_Click(object sender, EventArgs e)
        {
            controlArchivos.EliminarArchivo(ruta, nombreArchivo);
            btnDigitalizar_Click(sender, null);
        }

        private void btnActualizarDocs_Click(object sender, EventArgs e)
        {

        }

        private void dgvDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DatosArchivo datosArchivo = procesosUsuario.ObtenerNombreArchivo(dgvDocumentos.SelectedRows[0].Index);

            Console.WriteLine(datosArchivo.Area + datosArchivo.Expediente + datosArchivo.Categoria + datosArchivo.Documento + datosArchivo.Registro);

            //index = dgvDocumentos.SelectedRows[0].Index;
            ruta = datosArchivo.Area + "\\" + datosArchivo.Expediente + "\\" + datosArchivo.Categoria + "\\" + datosArchivo.Registro;
            nombreArchivo = datosArchivo.Documento + ".pdf";
            Console.WriteLine("C:\\saves\\" + ruta + "\\" + nombreArchivo);
            if (File.Exists("C:\\saves\\"+ruta + "\\" + nombreArchivo))
            {
                axAcroPDF1.Visible = true;
                labelNoDigitalizado.Visible = false;
                btnDigitalizar.Visible = false;
                axAcroPDF1.src = "C:\\saves\\" + ruta + "\\" + nombreArchivo;
            }
            else
            {
                axAcroPDF1.Visible = false;
                labelNoDigitalizado.Visible = true;
                btnDigitalizar.Visible = true;
                //MessageBox.Show("Archivo no digitalizado");
            }
        }

        private void btnDigitalizar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fuente = new OpenFileDialog();
            fuente.Filter = " Archivos PDF(*.pdf)|*.pdf";
            if (fuente.ShowDialog() == DialogResult.OK)
            {
                string source = fuente.FileName;
                controlArchivos.CopiarArchivo(ruta, source, nombreArchivo);
            }
            fuente.Dispose();
            dgvDocumentos_CellDoubleClick(sender, null);

            //Aqui se envia el Update a la base de datos del documento ya digitalizado
            //procesosUsuario.ActualizarDigitalizado(dgvDocumentos.SelectedRows[0].Index, true);
        }

        private void btnEliminarDoc_Click(object sender, EventArgs e)
        {
            controlArchivos.EliminarArchivo(ruta, nombreArchivo);

        }

        private void CheckBoxDigitalizadosVisor_CheckedChanged(object sender, EventArgs e)
        {
            procesosUsuario.LlenarTablaDocumentosPendientes(dgvDocumentos, expedienteActual, checkBoxDigitalizadosVisor.Checked);
        }

        private void VisorDeDocumentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            new ExpedientesP(procesosUsuario).Show();
        }
    }
}