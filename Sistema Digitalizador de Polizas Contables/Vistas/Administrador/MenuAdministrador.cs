﻿using Logica_de_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas.Administrador
{
    public partial class MenuAdministrador : Form
    {
        
        ProcesosAdministrador procesosAdministrador;
        List<DocumentosInfo> documentosEditados = new List<DocumentosInfo>();

        /// <summary>
        /// Constructor que inicializa todos los componentes necesarioa y agrega eventos.
        /// </summary>
        /// <param name="procesosAdministrador">Clase procesos administrador, contiene el funcionamiento.</param>
        public MenuAdministrador(ProcesosAdministrador procesosAdministrador)
        {
            InitializeComponent();
            this.procesosAdministrador = procesosAdministrador;
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

            //Eventos de ComboBox
            cmbArea.KeyUp += CmbArea_KeyUp;
            cmbExpediente.KeyUp += CmbExpediente_KeyUp;
            cmbCategoria.KeyUp += CmbCategoria_KeyUp;
        }

        /// <summary>
        /// Evento que detecta si se da enter en la categoria y crea la nueva o regresa a la normalidad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmbCategoria.DropDownStyle == ComboBoxStyle.Simple)
            {
                if (procesosAdministrador.ValidarLongitudCadena(cmbCategoria.Text))
                {
                    if (cmbCategoria.Text != String.Empty && MessageBox.Show("Se creara la categoria '" + cmbCategoria.Text + "' ¿Esta seguro?", "Alerta", MessageBoxButtons.OKCancel).ToString() == "OK")
                    {
                        if (!procesosAdministrador.CrearNuevoRegistro(2, cmbCategoria.Text, cmbExpediente.SelectedIndex))
                            MessageBox.Show("Se produjo un error mientras se creaba el registro.");
                    }
                    //Activar control
                    cmbArea.Enabled = true;
                    cmbExpediente.Enabled = true;

                    //Regresar control a la normalidad.
                    cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbCategoria = procesosAdministrador.LlenarCombo(cmbCategoria, 2, cmbExpediente.SelectedIndex);
                    cmbCategoria.Items.Add("< Nuevo >");
                }
                else
                    MessageBox.Show("El nombre no puede tener mas de 100 caracteres.");
            }
        }

        /// <summary>
        /// Evento que detecta si se da enter en Expediente y crea uno nuevo o regresa a la normalidad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbExpediente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmbExpediente.DropDownStyle == ComboBoxStyle.Simple)
            {
                if (procesosAdministrador.ValidarLongitudCadena(cmbExpediente.Text))
                {
                    if (cmbExpediente.Text != String.Empty && MessageBox.Show("Se creara el expediente '" + cmbExpediente.Text + "' ¿Esta seguro?", "Alerta", MessageBoxButtons.OKCancel).ToString() == "OK")
                    {
                        if (!procesosAdministrador.CrearNuevoRegistro(1, cmbExpediente.Text, cmbArea.SelectedIndex))
                            MessageBox.Show("Se produjo un error mientras se creaba el registro.");
                    }
                    //Activar control
                    cmbArea.Enabled = true;

                    //Regresar control a la normalidad.
                    cmbExpediente.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbExpediente = procesosAdministrador.LlenarCombo(cmbExpediente, 1, cmbArea.SelectedIndex);
                    cmbExpediente.Items.Add("< Nuevo >");
                }
                else
                    MessageBox.Show("El nombre no puede tener mas de 100 caracteres.");
            }
        }

        /// <summary>
        /// Evento que detecta si se da enter en Area y crea la nueva o regresa a la normalidad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbArea_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmbArea.DropDownStyle == ComboBoxStyle.Simple)
                {
                    if (procesosAdministrador.ValidarLongitudCadena(cmbArea.Text))
                    {
                        if (cmbArea.Text != String.Empty && MessageBox.Show("Se creara la categoria '" + cmbArea.Text + "' ¿Esta seguro?", "Alerta", MessageBoxButtons.OKCancel).ToString() == "OK")
                        {
                            if (!procesosAdministrador.CrearNuevoRegistro(0, cmbArea.Text, 0))
                                MessageBox.Show("Se produjo un error mientras se creaba el registro.");
                        }
                        //Regresar control a la normalidad.
                        cmbArea.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbArea = procesosAdministrador.LlenarCombo(cmbArea, 0, 0);
                        cmbArea.Items.Add("< Nuevo >");
                    }
                    else
                        MessageBox.Show("El nombre no puede tener mas de 100 caracteres.");
            }
            
        }

        /// <summary>
        /// Valida que no se dejaran cadenas vacias al momento de crear un nuevo registro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            else if (!procesosAdministrador.ValidarLongitudCadena(dgvDocumentos[0, e.RowIndex].Value.ToString()))
            {
                dgvDocumentos[0, e.RowIndex].ErrorText = "El nombre no puede ser mayor a 100 caracteres.";
                e.Cancel = true;
            }
            else
            {
                dgvDocumentos[0, e.RowIndex].ErrorText = String.Empty;
            }
        }
        /// <summary>
        /// Detecta que se ha entrado a una celda y comienza la edicion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvDocumentos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Editar nombre automaticamente al crear nueva celda.
            if (e.RowIndex == dgvDocumentos.NewRowIndex)
            {
                dgvDocumentos.CurrentCell = dgvDocumentos[e.ColumnIndex, e.RowIndex];
                dgvDocumentos.BeginEdit(true);
            }
        }

        /// <summary>
        /// Valida que todos los valores sean correctos para la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Metodo que llama a rellenar automaticamente los valores de una nueva fila.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvDocumentos_DefaultValuesNeeded(object sender,
        System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            //Auto rellenar valores de texto
            if (!procesosAdministrador.NuevoRegistroDefault(e))
                MessageBox.Show("Se ha presentado un error.");
        }

        /// <summary>
        /// Cambia el estado de activo del area en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Cambia el estado de activo del expediente en la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        

        /// <summary>
        /// Cambia el estado de activo de la categoria en la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Carga las areas automaticamente al cargar la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            //Obtener Areas
            cmbArea = procesosAdministrador.LlenarCombo(cmbArea, 0, 0);
            if (!procesosAdministrador.Usuario.Dios)
            {
                cmbArea.SelectedIndex = procesosAdministrador.ObtenerIndexArea(procesosAdministrador.Usuario.IdArea);
                cmbArea.Enabled = false;
            }
            else
            {
                cmbArea.Items.Add("< Nuevo >");
            }
        }

        /// <summary>
        /// Guarda los cambios en los documentos o crea los nuevos en la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (documentosEditados.Count > 0)
            {
                if (procesosAdministrador.ActualizarTablaDocumentos(documentosEditados))
                {
                    MessageBox.Show("Modificaciones insertadas con exito.", "Alerta");
                }
                else
                {
                    MessageBox.Show("Se produjo un error mientras se guardaban los cambios, intente de nuevo.", "Error");
                }
                documentosEditados.Clear();
                dgvDocumentos = procesosAdministrador.ObtenerTablaDocumentos(dgvDocumentos, cmbCategoria.SelectedIndex);
            }
            else
                MessageBox.Show("Usted no ha realizado ninguna modificacion.");
        }

        /// <summary>
        /// Detecta cuando se ha seleccionado una categoria y desactiva controles no necesarios
        /// tambien permite crear una nueva categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.Items.Count == cmbCategoria.SelectedIndex + 1)
            {
                //Descativar controles no necesarios
                dgvDocumentos.Enabled = false;
                cmbArea.Enabled = false;
                cmbExpediente.Enabled = false;

                //Modificar el comportamiento del combo
                cmbCategoria.Items.Clear();
                cmbCategoria.DropDownStyle = ComboBoxStyle.Simple;
                cmbCategoria.Text = String.Empty;
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

        /// <summary>
        /// Detecta cuando se ha seleccionado un area y desactiva controles no necesarios
        /// tambien permite crear una nueva area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbArea.Items.Count == cmbArea.SelectedIndex+1 && cmbArea.Text== "< Nuevo >")
            {
                //Desactivar controles no necesarios
                cmbExpediente.Enabled = false;
                cmbCategoria.Enabled = false;
                dgvDocumentos.Enabled = false;

                //Modificar el comportamiento del combo
                cmbArea.Items.Clear();
                cmbArea.DropDownStyle = ComboBoxStyle.Simple;
                cmbArea.Text = String.Empty;
            }
            else
            {
                //Desactivar controles no necesarios
                cmbCategoria.Enabled = false;
                cmbCategoria.Text = String.Empty;
                cmbExpediente.Text = String.Empty;
                dgvDocumentos.Enabled = false;
                btnGuardar.Enabled = false;
                ckbCategoria.Enabled = false;
                ckbExpediente.Enabled = false;
                //Obtener Expedientes
                cmbExpediente = procesosAdministrador.LlenarCombo(cmbExpediente, 1, cmbArea.SelectedIndex);
                cmbExpediente.Items.Add("< Nuevo >");
                //Activar controles necesarios
                ckbArea.Enabled = true;
                ckbArea.Checked = procesosAdministrador.GetActivo(0, cmbArea.SelectedIndex);
            }
        }

        /// <summary>
        /// Detecta cuando se ha seleccionado un expediente y desactiva controles no necesarios
        /// tambien permite crear un nuevo expediente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbExpediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExpediente.Items.Count == cmbExpediente.SelectedIndex + 1)
            {
                //Desactivar controles no necesarios
                cmbArea.Enabled = false;
                cmbCategoria.Enabled = false;
                dgvDocumentos.Enabled = false;

                //Modificar el comportamiento del combo.
                cmbExpediente.Items.Clear();
                cmbExpediente.DropDownStyle = ComboBoxStyle.Simple;
                cmbExpediente.Text = String.Empty;
            }
            else
            {
                //Desactivar controles no necesarios
                dgvDocumentos.Enabled = false;
                btnGuardar.Enabled = false;
                cmbCategoria.Text = String.Empty;
                ckbCategoria.Enabled = false;
                //Obtener categorias
                cmbCategoria = procesosAdministrador.LlenarCombo(cmbCategoria, 2, cmbExpediente.SelectedIndex);
                cmbCategoria.Items.Add("< Nuevo >");
                //Activar controles necesarios
                ckbExpediente.Enabled = true;
                ckbExpediente.Checked = procesosAdministrador.GetActivo(1, cmbExpediente.SelectedIndex);
            }

        }

        /// <summary>
        /// Oculta la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
        }

        /// <summary>
        /// Oculta la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
        }
    }
}
