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

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas.Administrador
{
    public partial class MenuAdministrador : Form
    {
        ProcesosAdministrador procesosAdministrador;
        
        public MenuAdministrador(ProcesosAdministrador procesosAdministrador)
        {
                InitializeComponent();
                this.procesosAdministrador = procesosAdministrador;
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            //Obtener Areas
            cmbArea = procesosAdministrador.LlenarComboArea(cmbArea, 0, null);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (procesosAdministrador.ActualizarTablaDocumentos())
            {
                MessageBox.Show("Modificaciones insertadas con exito.", "Alerta");
            }
            else
            {
                MessageBox.Show("Se produjo un error mientras se guardaban los cambios.", "Error");
            }
        }

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.Items.Count == cmbCategoria.SelectedIndex + 1)
            {
                String nombre = Microsoft.VisualBasic.Interaction.InputBox("Entrada", "Ingrese un nombre de categoria", "", -1, -1);
                if (nombre != null && nombre != "")
                {
                    if (procesosAdministrador.CrearNuevoRegistro(2, nombre, cmbExpediente.Text))
                        cmbCategoria = procesosAdministrador.LlenarComboArea(cmbCategoria, 2, cmbExpediente.Text);
                    else
                        MessageBox.Show("Error al crear registro.", "Error");
                }
                else
                    MessageBox.Show("Campo obligatorio.", "Error");
            }
            else {
                //Obtener tabla
                dgvDocumentos = procesosAdministrador.ObtenerTablaDocumentos(dgvDocumentos, cmbCategoria.Text);
                dgvDocumentos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //Activar controles necesarios
                dgvDocumentos.Enabled = true;
                ckbCategoria.Enabled = true;
                ckbCategoria.Checked = procesosAdministrador.GetActivo(2, cmbCategoria.Text);
                btnGuardar.Enabled = true;
            }
        }

        private void CmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbArea.Items.Count == cmbArea.SelectedIndex+1)
            {
                String nombre = Microsoft.VisualBasic.Interaction.InputBox("Entrada", "Ingrese un nombre de area", "", -1, -1);
                if (nombre != null && nombre != "")
                {
                    if (procesosAdministrador.CrearNuevoRegistro(0, nombre, null))
                        cmbArea = procesosAdministrador.LlenarComboArea(cmbArea, 0, null);
                    else
                        MessageBox.Show("Error al crear registro.", "Error");
                }   
                else
                    MessageBox.Show("Campo obligatorio.", "Error");
            }
            else
            {
                //Desactivar controles no necesarios
                cmbCategoria.Enabled = false;
                cmbCategoria.Text = "";
                cmbExpediente.Text = "";
                dgvDocumentos.Enabled = false;
                btnGuardar.Enabled = false;
                ckbCategoria.Enabled = false;
                ckbExpediente.Enabled = false;
                //Obtener Expedientes
                cmbExpediente = procesosAdministrador.LlenarComboArea(cmbExpediente, 1, cmbArea.Text);
                //Activar controles necesarios
                ckbArea.Enabled = true;
                ckbArea.Checked = procesosAdministrador.GetActivo(0, cmbArea.Text);
            }
        }

        private void CmbExpediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExpediente.Items.Count == cmbExpediente.SelectedIndex + 1)
            {
                String nombre = Microsoft.VisualBasic.Interaction.InputBox("Entrada", "Ingrese un nombre de expediente", "", -1, -1);
                if (nombre != null && nombre != "")
                {
                    if (procesosAdministrador.CrearNuevoRegistro(1, nombre, cmbArea.Text))
                        cmbExpediente = procesosAdministrador.LlenarComboArea(cmbExpediente, 1, cmbArea.Text);
                    else
                        MessageBox.Show("Error al crear registro.", "Error");
                }
                else
                    MessageBox.Show("Campo obligatorio.", "Error");
            }
            else
            {
                //Desactivar controles no necesarios
                dgvDocumentos.Enabled = false;
                btnGuardar.Enabled = false;
                cmbCategoria.Text = "";
                ckbCategoria.Enabled = false;
                //Obtener categorias
                cmbCategoria = procesosAdministrador.LlenarComboArea(cmbCategoria, 2, cmbExpediente.Text);
                //Activar controles necesarios
                ckbExpediente.Enabled = true;
                ckbExpediente.Checked = procesosAdministrador.GetActivo(1, cmbExpediente.Text);
            }

        }

        private void DgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CkbArea_CheckedChanged(object sender, EventArgs e)
        {
            if (!procesosAdministrador.ActivarDesactivar(0, cmbArea.Text, ckbArea.Checked))
            {
                MessageBox.Show("Error al cambiar el estado del area.");
            }
        }

        private void CkbExpediente_CheckedChanged(object sender, EventArgs e)
        {
            if (!procesosAdministrador.ActivarDesactivar(1, cmbExpediente.Text, ckbExpediente.Checked))
            {
                MessageBox.Show("Error al cambiar el estado del expediente.");
            }
        }

        private void CkbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (!procesosAdministrador.ActivarDesactivar(2, cmbCategoria.Text, ckbCategoria.Checked))
            {
                MessageBox.Show("Error al cambiar el estado de la categoria.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
        }
    }
}
