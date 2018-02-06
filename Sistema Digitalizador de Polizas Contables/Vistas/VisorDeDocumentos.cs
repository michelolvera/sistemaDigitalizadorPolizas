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

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas
{
    public partial class VisorDeDocumentos : Form
    {
        int index; //Hay que cambiar el nombre de esta variable a algo mas especifico.
        private ProcesosUsuario procesosUsuario;
        private int expedienteActual;

        public VisorDeDocumentos(ProcesosUsuario procesosUsuario, int expedienteActual, string registroActual)
        {
            InitializeComponent();
            this.procesosUsuario = procesosUsuario;
            this.expedienteActual = expedienteActual;
            lblRegistroActual.Text += registroActual;
            dgvDocumentos = this.procesosUsuario.LlenarTablaDocumentosPendientes(dgvDocumentos, this.expedienteActual, checkBoxDigitalizadosVisor.Checked);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReemplazarDoc_Click(object sender, EventArgs e)
        {
            if (File.Exists("c:\\saves\\100000" + index + ".pdf"))
            {
                File.Delete("c:\\saves\\100000" + index + ".pdf");
                dgvDocumentos[3, index].Value = "0";
            }
            btnDigitalizar_Click(sender, null);
        }

        private void btnActualizarDocs_Click(object sender, EventArgs e)
        {

        }

        private void dgvDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtener ID de documento seleccionado
            String res = dgvDocumentos.Rows[dgvDocumentos.SelectedRows[0].Index].Cells[0].Value + "";
            int idSeleccionado = Int32.Parse(res);

            index = dgvDocumentos.SelectedRows[0].Index;
            String ruta = "C:\\saves\\100000"+index+".pdf";
            if (File.Exists(ruta))
            {
                axAcroPDF1.Visible = true;
                labelNoDigitalizado.Visible = false;
                btnDigitalizar.Visible = false;
                axAcroPDF1.src = ruta;
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
                File.Copy(source, "c:\\saves\\100000" + index + ".pdf");
                dgvDocumentos[3, index].Value = "1";

            }
            fuente.Dispose();
            dgvDocumentos_CellDoubleClick(sender, null);


        }

        private void btnEliminarDoc_Click(object sender, EventArgs e)
        {
            if (File.Exists("c:\\saves\\100000" + index + ".pdf")){
                File.Delete("c:\\saves\\100000" + index + ".pdf");
                dgvDocumentos[3, index].Value = "0";
                dgvDocumentos_CellDoubleClick(sender, null);
            }

        }
    }
}
