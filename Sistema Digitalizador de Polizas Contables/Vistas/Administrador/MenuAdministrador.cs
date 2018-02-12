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
using Entidades;

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas.Administrador
{
    public partial class MenuAdministrador : Form
    {
        ProcesosAdministrador procesosAdministrador;
        List<DocumentosInfo> documentosEditados = new List<DocumentosInfo>();
        public MenuAdministrador(ProcesosAdministrador procesosAdministrador)
        {
            InitializeComponent();
            this.procesosAdministrador = procesosAdministrador;
            InputBox.SetLanguage(InputBox.Language.Spanish); //Esto se puede cambiar para editar en el mismo Combo! Checar esto.

            //Eventos de DataGrid
            dgvDocumentos.AllowUserToAddRows = true;
            dgvDocumentos.ReadOnly = false;
            dgvDocumentos.DefaultValuesNeeded += new DataGridViewRowEventHandler(this.DgvDocumentos_DefaultValuesNeeded);
            dgvDocumentos.CellEnter += DgvDocumentos_CellEnter;
            dgvDocumentos.CellParsing += DgvDocumentos_CellParsing;
            dgvDocumentos.RowValidating += DgvDocumentos_RowValidating;

            //Eventos de check box
            ckbArea.MouseClick += new MouseEventHandler(this.CkbArea_MouseClick);
            ckbExpediente.MouseClick += new MouseEventHandler(this.CkbExpediente_MouseClick);
            ckbCategoria.MouseClick += new MouseEventHandler(this.CkbCategoria_MouseClick);
        }

        private void DgvDocumentos_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvDocumentos[0, e.RowIndex].Value == null || dgvDocumentos[0, e.RowIndex].Value.ToString() == string.Empty)
            {
                if (e.RowIndex == dgvDocumentos.NewRowIndex)
                {
                    //Usuario creo una nueva fila pero no comenso la edicion de esta nombre a esta
                    dgvDocumentos.Rows[e.RowIndex].Cells["NombreUsuario"].Value = null;
                    dgvDocumentos.Rows[e.RowIndex].Cells["FechaAlta"].Value = null;
                    dgvDocumentos.Rows[e.RowIndex].Cells["Activo"].Value = null;
                }
                else
                {
                    dgvDocumentos[0, e.RowIndex].ErrorText = "El valor no puede estar vacio.";
                    e.Cancel = true;
                }
            }
            else
            {
                dgvDocumentos[0, e.RowIndex].ErrorText = String.Empty;
            }
        }

        private void DgvDocumentos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Editar nombre automaticamente al crear nueva celda.
            if (e.RowIndex == dgvDocumentos.NewRowIndex)
            {
                dgvDocumentos.CurrentCell = dgvDocumentos[e.ColumnIndex, e.RowIndex];
                dgvDocumentos.BeginEdit(true);
            }
        }

        private void DgvDocumentos_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            //Eliminar las ediciones antiguas de la lista.
            documentosEditados.RemoveAll(delegate (DocumentosInfo doc) { return doc.PosIndex == e.RowIndex; });
            //Agregar a lista de pendientes a enviar a la BD
            if (e.ColumnIndex == 0)
            {
                documentosEditados.Add(new DocumentosInfo(e.RowIndex, e.Value.ToString(), (bool)dgvDocumentos[3, e.RowIndex].Value, cmbCategoria.SelectedIndex));
            }
            else if(e.ColumnIndex == 3)
            {
                documentosEditados.Add(new DocumentosInfo(e.RowIndex, dgvDocumentos[0, e.RowIndex].Value.ToString(), (bool) e.Value, cmbCategoria.SelectedIndex));
            }
        }

        private void DgvDocumentos_DefaultValuesNeeded(object sender,
        System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            //Auto rellenar valores de texto
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
            if (procesosAdministrador.ActualizarTablaDocumentos(documentosEditados))
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
    }
}
