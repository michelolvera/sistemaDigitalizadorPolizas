﻿using Entidades;
using Logica_de_Negocio;
using Sistema_Digitalizador_de_Polizas_Contables.Vistas.Administrador;
using Sistema_Digitalizador_de_Polizas_Contables.Vistas.Super_Administrador;
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
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            MainMenuStrip.ForeColor = Color.White;
            menuStrip1.ForeColor = Color.White;
            DateTime Fechaactual = DateTime.Now;
            lblUsuarioActual.Text = "| " + procesosUsuario.Usuario.Nombre + " " + procesosUsuario.Usuario.ApellidoPaterno +" "+ procesosUsuario.Usuario.ApellidoMaterno +" |";
            lblFechaHora.Text = "| " +Fechaactual.ToLongDateString() + " |";
            this.procesosUsuario = procesosUsuario;
            txbFiltro.KeyUp += TxbFiltro_KeyUp;
        }

        private void TxbFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txbFiltro.Text != null && txbFiltro.Text != string.Empty)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, cmbFiltro.SelectedIndex + 1, txbFiltro.Text);
            }else if (e.KeyCode == Keys.Enter)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, cmbFiltro.SelectedIndex + 1, txbFiltro.Text);
            }
        }

        private void ExpedientesP_Load(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, cmbFiltro.SelectedIndex + 1, txbFiltro.Text);
            cmbFiltro.SelectedIndex = 0;
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, cmbFiltro.SelectedIndex + 1, txbFiltro.Text);
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
            if (procesosUsuario.Usuario.Administrador)
                new MenuAdministrador(new ProcesosAdministrador(procesosUsuario.Usuario)).Show();
            else
                MessageBox.Show("Usted no cuenta con los privilegios necesarios para gestionar este sistema.", "Error");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mostrarExpedientesCompletadosToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, cmbFiltro.SelectedIndex + 1, txbFiltro.Text);

        }

        private void TxbBusqueda_TextChanged(object sender, EventArgs e)
        {
            procesosUsuario.Buscar(dgvExpedientes, txbBusqueda);
        }

        private void InsertarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (procesosUsuario.Usuario.Administrador)
                new ManualInsert(new ProcesosAdministrador(procesosUsuario.Usuario)).Show();
            else
                MessageBox.Show("Usted no cuenta con los privilegios necesarios para gestionar este sistema.", "Error");
        }

        private void MostrarExpedientesCompletadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarExpedientesCompletadosToolStripMenuItem.Checked = !mostrarExpedientesCompletadosToolStripMenuItem.Checked;
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, cmbFiltro.SelectedIndex + 1, txbFiltro.Text);
        }

        private void pctBoxSalir_Click(object sender, EventArgs e)
        {
            ExpedientesP_FormClosed(sender,null);
        }

        private void pctBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ExpedientesP_FormClosed(sender, null);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (procesosUsuario.Usuario.Dios)
                new AdministrarUsuarios(new ProcesosDios(procesosUsuario.Usuario)).Show();
            else
                MessageBox.Show("Usted no cuenta con los privilegios necesarios para gestionar este sistema.", "Error");
        }

        
    }
}
