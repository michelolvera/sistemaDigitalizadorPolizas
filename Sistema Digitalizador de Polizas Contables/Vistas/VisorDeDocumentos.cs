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

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas
{
    public partial class VisorDeDocumentos : Form
    {
        public VisorDeDocumentos(int categoria)
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            String ruta = "C:\\Users\\coke_\\Downloadsmm\\01 Sistemas Operativos - Introduccion a los sistemas operativos.pdf";
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

        private void btnReemplazarDoc_Click(object sender, EventArgs e)
        {
            String ruta = "C:\\Users\\coke_\\Downloads\\01 Sistemas Operativos - Introduccion a los sistemas operativos.pdf";
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
    }
}
