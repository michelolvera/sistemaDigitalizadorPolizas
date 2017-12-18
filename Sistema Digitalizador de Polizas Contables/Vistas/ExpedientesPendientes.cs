using Entidades;
using Logica_de_Negocio;
using Sistema_Digitalizador_de_Polizas_Contables.Vistas.Administrador;
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
        ProcesosUsuario procesosUsuario;
        public ExpedientesP(ProcesosUsuario procesosUsuario)
        {
            InitializeComponent();
            this.procesosUsuario = procesosUsuario;
            dgvExpedientes = this.procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExpedientesP_Load(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            new Vistas.VisorDeDocumentos(1).Show();
        }

        private void DgvExpedientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void ExpedientesP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdministrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (procesosUsuario.Usuario.EsAdmin)
                new MenuAdministrador(new ProcesosAdministrador(procesosUsuario.Usuario)).Show();
            else
                MessageBox.Show("Usted no cuenta con los privilegios necesarios para gestionar este sistema.", "Error");
        }
    }
}
