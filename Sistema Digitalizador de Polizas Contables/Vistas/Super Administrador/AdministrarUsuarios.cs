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

namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas.Super_Administrador
{
    public partial class AdministrarUsuarios : Form
    {
        public AdministrarUsuarios(ProcesosAdministrador procesosAdministrador)
        {
            InitializeComponent();
        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUsuarioSeleccionado.Text = cmbUsuario.SelectedText;
        }

        private void cmbUsuario_KeyUp(object sender, KeyEventArgs e)
        {
           /* if (e.KeyCode == Keys.Enter && cmbUsuario.DropDownStyle == ComboBoxStyle.Simple)
            {
                if (procesosAdministrador.ValidarLongitudCadena(cmbUsuario.Text))
                {
                    if (cmbUsuario.Text != String.Empty && MessageBox.Show("Se creara la categoria '" + cmbUsuario.Text + "' ¿Esta seguro?", "Alerta", MessageBoxButtons.OKCancel).ToString() == "OK")
                    {
                        if (!procesosAdministrador.CrearNuevoRegistro(2, cmbUsuario.Text, cmbExpediente.SelectedIndex))
                            MessageBox.Show("Se produjo un error mientras se creaba el registro.");
                    }
                    //Activar control
                    cmbArea.Enabled = true;
                    cmbExpediente.Enabled = true;

                    //Regresar control a la normalidad.
                    cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbUsuario = procesosAdministrador.LlenarCombo(cmbUsuario, 2, cmbExpediente.SelectedIndex);
                    cmbUsuario.Items.Add("< Nuevo >");
                }
                else
                    MessageBox.Show("El nombre no puede tener mas de 100 caracteres.");
            }*/
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
