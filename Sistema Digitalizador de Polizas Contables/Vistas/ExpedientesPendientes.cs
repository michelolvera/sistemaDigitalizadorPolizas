﻿using Entidades;
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
            dgvExpedientes = this.procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, checkBoxDigitalizadosPend.Checked);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExpedientesP_Load(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, checkBoxDigitalizadosPend.Checked);
            cmbBusqueda.SelectedIndex = 0;
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, checkBoxDigitalizadosPend.Checked);
        }


        private void DgvExpedientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new Vistas.VisorDeDocumentos(procesosUsuario, e.RowIndex, dgvExpedientes[0, e.RowIndex].Value.ToString()).Show();
            this.Hide();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkBoxDigitalizadosPend_CheckedChanged(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, checkBoxDigitalizadosPend.Checked);
        }

        private void TxbBusqueda_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvExpedientes.RowCount; i++)
            {
                if (dgvExpedientes[cmbBusqueda.SelectedIndex, i].Value.ToString().ToLower().Contains(txbBusqueda.Text.ToLower()))
                    dgvExpedientes.Rows[i].Visible = true;
                else
                    dgvExpedientes.Rows[i].Visible = false;
            }
        }

        private void InsertarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (procesosUsuario.Usuario.EsAdmin)
                new ManualInsert(new ProcesosAdministrador(procesosUsuario.Usuario)).Show();
            else
                MessageBox.Show("Usted no cuenta con los privilegios necesarios para gestionar este sistema.", "Error");
        }
    }
}
