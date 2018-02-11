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
using MsgBox;

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas.Administrador
{
    public partial class MenuAdministrador : Form
    {
        ProcesosAdministrador procesosAdministrador;
        public MenuAdministrador(ProcesosAdministrador procesosAdministrador)
        {
            InitializeComponent();
            this.procesosAdministrador = procesosAdministrador;
            dgvDocumentos.AllowUserToAddRows = true;
            dgvDocumentos.ReadOnly = false;
            dgvDocumentos.DefaultValuesNeeded += new DataGridViewRowEventHandler(this.DgvDocumentos_DefaultValuesNeeded);
            ckbArea.MouseClick += new MouseEventHandler(this.CkbArea_MouseClick);
            ckbExpediente.MouseClick += new MouseEventHandler(this.CkbExpediente_MouseClick);
            ckbCategoria.MouseClick += new MouseEventHandler(this.CkbCategoria_MouseClick);
            InputBox.SetLanguage(InputBox.Language.Spanish);
        }

        private void DgvDocumentos_DefaultValuesNeeded(object sender,
        System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            if (!procesosAdministrador.NuevoRegistroDefault(e))
                MessageBox.Show("Se ha presentado un error.");
        }

        private void CkbArea_MouseClick(object sender, EventArgs e)
        {
            if (!procesosAdministrador.ActivarDesactivar(0, cmbArea.SelectedIndex, ckbArea.Checked))
            {
                MessageBox.Show("Error al cambiar el estado del area.");
            }
            else
            {
                MessageBox.Show("Se ha cambiado el estado del area.");
            }
        }

        private void CkbExpediente_MouseClick(object sender, EventArgs e)
        {
            if (!procesosAdministrador.ActivarDesactivar(1, cmbExpediente.SelectedIndex, ckbExpediente.Checked))
            {
                MessageBox.Show("Error al cambiar el estado del expediente.");
            }
            else
            {
                MessageBox.Show("Se ha cambiado el estado del expediente.");
            }
        }

        private void CkbCategoria_MouseClick(object sender, EventArgs e)
        {
            if (!procesosAdministrador.ActivarDesactivar(2, cmbCategoria.SelectedIndex, ckbCategoria.Checked))
            {
                MessageBox.Show("Error al cambiar el estado de la categoria.");
            }
            else
            {
                MessageBox.Show("Se ha cambiado el estado de la categoria.");
            }
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            //Obtener Areas
            cmbArea = procesosAdministrador.LlenarComboArea(cmbArea, 0, 0);
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
                
                //Descativar controles no necesarios
                dgvDocumentos.Enabled = false;

                String nombre;
                DialogResult res = InputBox.ShowDialog("Untroduce el nombre: ", "Entrada",
                InputBox.Icon.Question,
                InputBox.Buttons.OkCancel,
                InputBox.Type.TextBox);
                if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
                {
                    nombre = InputBox.ResultValue;
                    if(nombre == "")
                        MessageBox.Show("Campo obligatorio.", "Error");
                    else if (procesosAdministrador.CrearNuevoRegistro(2, nombre, cmbExpediente.SelectedIndex))
                        cmbCategoria = procesosAdministrador.LlenarComboArea(cmbCategoria, 2, cmbExpediente.SelectedIndex);
                    else
                        MessageBox.Show("Error al crear registro.", "Error");
                }
                    
            }
            else {
                //Obtener tabla
                dgvDocumentos = procesosAdministrador.ObtenerTablaDocumentos(dgvDocumentos, cmbCategoria.SelectedIndex);
                dgvDocumentos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //Activar controles necesarios
                dgvDocumentos.Enabled = true;
                ckbCategoria.Enabled = true;
                ckbCategoria.Checked = procesosAdministrador.GetActivo(2, cmbCategoria.SelectedIndex);
                btnGuardar.Enabled = true;
            }
        }

        private void CmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbArea.Items.Count == cmbArea.SelectedIndex+1)
            {
                //Desactivar controles no necesarios
                cmbExpediente.Enabled = false;
                cmbCategoria.Enabled = false;
                dgvDocumentos.Enabled = false;

                String nombre;
                DialogResult res = InputBox.ShowDialog("Untroduce el nombre: ", "Entrada",
                InputBox.Icon.Question,
                InputBox.Buttons.OkCancel,
                InputBox.Type.TextBox);

                if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
                {
                    nombre = InputBox.ResultValue;
                    if (nombre == "")
                        MessageBox.Show("Campo obligatorio.", "Error");
                    else if (procesosAdministrador.CrearNuevoRegistro(0, nombre, 0))
                        cmbArea = procesosAdministrador.LlenarComboArea(cmbArea, 0, 0);
                    else
                        MessageBox.Show("Error al crear registro.", "Error");
                }
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
                cmbExpediente = procesosAdministrador.LlenarComboArea(cmbExpediente, 1, cmbArea.SelectedIndex);
                //Activar controles necesarios
                ckbArea.Enabled = true;
                ckbArea.Checked = procesosAdministrador.GetActivo(0, cmbArea.SelectedIndex);
            }
        }

        private void CmbExpediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExpediente.Items.Count == cmbExpediente.SelectedIndex + 1)
            {
                //Desactivar controles no necesarios
                cmbCategoria.Enabled = false;
                dgvDocumentos.Enabled = false;

                String nombre;
                DialogResult res = InputBox.ShowDialog("Untroduce el nombre: ", "Entrada",
                InputBox.Icon.Question,
                InputBox.Buttons.OkCancel,
                InputBox.Type.TextBox);
                if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
                {
                    nombre = InputBox.ResultValue;
                    if (nombre == "")
                        MessageBox.Show("Campo obligatorio.", "Error");
                    else if (procesosAdministrador.CrearNuevoRegistro(1, nombre, cmbArea.SelectedIndex))
                        cmbExpediente = procesosAdministrador.LlenarComboArea(cmbExpediente, 1, cmbArea.SelectedIndex);
                    else
                        MessageBox.Show("Error al crear registro.", "Error");
                }
            }
            else
            {
                //Desactivar controles no necesarios
                dgvDocumentos.Enabled = false;
                btnGuardar.Enabled = false;
                cmbCategoria.Text = "";
                ckbCategoria.Enabled = false;
                //Obtener categorias
                cmbCategoria = procesosAdministrador.LlenarComboArea(cmbCategoria, 2, cmbExpediente.SelectedIndex);
                //Activar controles necesarios
                ckbExpediente.Enabled = true;
                ckbExpediente.Checked = procesosAdministrador.GetActivo(1, cmbExpediente.SelectedIndex);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
        }

        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
