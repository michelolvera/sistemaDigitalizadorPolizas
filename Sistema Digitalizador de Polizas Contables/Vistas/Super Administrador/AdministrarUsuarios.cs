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
using Entidades;

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas.Super_Administrador
{
    public partial class AdministrarUsuarios : Form
    {
        ProcesosUsuario procesosUsuario;
        ProcesosAdministrador procesosAdministrador;
        public AdministrarUsuarios(ProcesosAdministrador procesosAdministrador)
        {
            InitializeComponent();
            this.procesosAdministrador = procesosAdministrador;
            cmbUsuario.KeyUp += cmbUsuario_KeyUp;

        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            txtContrasena.Enabled = false;
            cmbArea.Enabled = false;
            txtbNombre.Enabled = false;
            txtbApellidoP.Enabled = false;
            txtbApellidoMaterno.Enabled = false;
            checkBoxAdmin.Enabled = false;
            checkBoxDios.Enabled = false;
            cmbUsuario = procesosAdministrador.LlenarCombo(cmbUsuario, 3, 0);
            cmbUsuario.Items.Add("< Nuevo >");
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUsuarioSeleccionado.Text =  cmbUsuario.Text;
            txtContrasena.Enabled = true;
            txtContrasena.Text = "*****";
            cmbArea.Enabled = true;
            cmbArea = procesosAdministrador.LlenarCombo(cmbArea, 0, 0);

        }

        private void cmbUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmbUsuario.DropDownStyle == ComboBoxStyle.Simple)
            {
                if (procesosAdministrador.ValidarLongitudCadena(cmbUsuario.Text))
                {
                    if (cmbUsuario.Text != String.Empty)
                    {
                       /* if (!procesosAdministrador.CrearNuevoRegistro(2, cmbUsuario.Text, cmbExpediente.SelectedIndex))
                            MessageBox.Show("Se produjo un error mientras se creaba el registro.");*/
                    }
                    //Activar control
                    cmbUsuario.Enabled = true;

                    //Regresar control a la normalidad.
                    cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbUsuario = procesosAdministrador.LlenarCombo(cmbUsuario, 3, cmbUsuario.SelectedIndex);
                    cmbUsuario.Items.Add("< Nuevo >");
                }
                else
                    MessageBox.Show("El nombre no puede tener mas de 100 caracteres.");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbUsuario_TextUpdate(object sender, EventArgs e)
        {
            lblUsuarioSeleccionado.Text = cmbUsuario.SelectedText;
        }
    }
}
