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
        int index;
        ControlDirectorioArchivos GestionArchivos = new ControlDirectorioArchivos();
        public VisorDeDocumentos(int categoria)
        {

            InitializeComponent();
            
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
            for (int i = 0; i < 2; i++)
            {
                dgvDocumentos.Rows.Add();
                dgvDocumentos[0, i].Value = "1";
                dgvDocumentos[1, i].Value = "Pólizas contables";
                dgvDocumentos[2, i].Value = "2017-12-10";
                dgvDocumentos[3, i].Value = "0";
            }
            btnActualizarDocs.Enabled = false;
        }

        private void dgvDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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
                
                //GestionArchivos.CopiarArchivo( ) //Ruta para copiar archivo
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
