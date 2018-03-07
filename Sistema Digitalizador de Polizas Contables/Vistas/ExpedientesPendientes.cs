using Entidades;
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
            DateTime Fechaactual = DateTime.Now;
            lblUsuarioActual.Text = "| " + procesosUsuario.Usuario.Nombre + " " + procesosUsuario.Usuario.ApellidoPaterno +" "+ procesosUsuario.Usuario.ApellidoMaterno +" |";
            lblFechaHora.Text = "| " +Fechaactual.ToLongDateString() + " |";
            this.procesosUsuario = procesosUsuario;
            
            
        }

        

        private void ExpedientesP_Load(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, null);
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, null);
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
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, null);
            
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
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, null);
            if (mostrarExpedientesCompletadosToolStripMenuItem.Checked)
            {
                lblVerActual.Text = "| Expedientes completados |";
            }
            else
            {
                lblVerActual.Text = "| Expedientes incompletos   |";
            }
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

        private void dgvExpedientes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                switch (e.ColumnIndex)
                {

                    case 0://identificador
                        
                        break;
                    case 1://fecha
                        
                        break;
                    case 2://nombre usuario
                        toolStripTextBoxUsuario.Focus();
                        break;
                    case 3://nombre expediente
                        //filtrarToolStripMenuItem
                        expToolStripMenuItem_Click(null,e);
                        break;
                    case 4://nobre categoria

                        toolStripTextBoxCategoria.Focus();
                        break;
                    case 5://completo

                        break;
                }
            }
            
        }

        private void toolStripTextBoxExpediente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && toolStripTextBoxExpediente.Text != null && toolStripTextBoxExpediente.Text != string.Empty)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, toolStripTextBoxExpediente.Text);
                toolStripTextBoxExpediente.Text = null;
                toolStripTextBoxUsuario.Enabled = false;
                toolStripTextBoxCategoria.Enabled = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, toolStripTextBoxExpediente.Text);
            }
        }

        private void toolStripTextBoxCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && toolStripTextBoxCategoria.Text != null && toolStripTextBoxCategoria.Text != string.Empty)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 2, toolStripTextBoxCategoria.Text);
                toolStripTextBoxCategoria.Text = null;
                toolStripTextBoxUsuario.Enabled = false;
                toolStripTextBoxExpediente.Enabled = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 2, toolStripTextBoxCategoria.Text);
            }
        }

        private void toolStripTextBoxUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && toolStripTextBoxUsuario.Text != null && toolStripTextBoxUsuario.Text != string.Empty)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 3, toolStripTextBoxUsuario.Text);
                toolStripTextBoxUsuario.Text = null;
                toolStripTextBoxExpediente.Enabled = false;
                toolStripTextBoxCategoria.Enabled = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 3, toolStripTextBoxUsuario.Text);
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBoxExpediente.Focus();
        }

        private void expedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void eliminarFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBoxCategoria.Text = null;
            toolStripTextBoxExpediente.Text = null;
            toolStripTextBoxUsuario.Text = null;
            toolStripTextBoxExpediente.Enabled = true;
            toolStripTextBoxCategoria.Enabled = true;
            toolStripTextBoxUsuario.Enabled = true;
            dgvExpedientes = procesosUsuario.LlenarTablaExpedientesPendientes(dgvExpedientes, mostrarExpedientesCompletadosToolStripMenuItem.Checked, 1, null);
        }

        private void expToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBoxExpediente.Focus();
        }

        private void catToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBoxCategoria.Focus();
        }

        private void usuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            toolStripTextBoxUsuario.Focus();
        }
    }
}
