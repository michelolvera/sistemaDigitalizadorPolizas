using Entidades;
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

namespace Sistema_Digitalizador_de_Polizas_Contables
{
    public partial class ExpedientesP : Form
    {
        ProcesosUsuario formato;
        public ExpedientesP(ProcesosUsuario formato)
        {
            InitializeComponent();
            this.formato = formato;
            dgvExpedientes = formato.LlenarTabla(dgvExpedientes);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExpedientesP_Load(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void DgvExpedientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void ExpedientesP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
