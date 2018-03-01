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
        UsuarioInfo usuarioSeleccionado;
        List<string> listaUsuarios;
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
            listaUsuarios = procesosAdministrador.listausuarios(cmbUsuario);
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtContrasena.Enabled = true;
            cmbArea.Enabled = true;
            cmbArea = procesosAdministrador.LlenarCombo(cmbArea, 0, 0);
            if (cmbUsuario.Text == "< Nuevo >")// crear nuevo usuario
            {
                cmbUsuario.Text = "";
                cmbUsuario.DropDownStyle = ComboBoxStyle.Simple;
                
            }
            else if(listaUsuarios.Exists(x => x == cmbUsuario.Text)) //seleccionar un usuario
            {
                lblUsuarioSeleccionado.Text = cmbUsuario.Text;
                txtContrasena.Text = "*****";
                //cmbArea.SelectedIndex = cmbArea.FindStringExact(usuarioSeleccionado.Area);
            }
        }

        private void cmbUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmbUsuario.DropDownStyle == ComboBoxStyle.Simple)
            {
                if (procesosAdministrador.ValidarLongitudCadena(cmbUsuario.Text))
                {
                    if (listaUsuarios.Exists(x => x == cmbUsuario.Text))
                    {//verificar que el usuario no se repita en la lista de los usuarios
                        MessageBox.Show("El usuario ya existe!");
                    }
                    else
                    {
                        cmbUsuario.Enabled = false;
                        lblUsuarioSeleccionado.Text = cmbUsuario.Text;
                    } 
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuarioSeleccionado.Area = cmbArea.Text;
            usuarioSeleccionado.Nombre = txtbNombre.Text;
            usuarioSeleccionado.ApellidoPaterno = txtbApellidoP.Text;
            usuarioSeleccionado.ApellidoMaterno = txtbApellidoMaterno.Text;
            usuarioSeleccionado.EsAdmin = checkBoxAdmin.Checked;
            usuarioSeleccionado.Dios = checkBoxDios.Checked;
            if (!procesosAdministrador.CrearNuevoRegistro(3, cmbUsuario.Text, cmbUsuario.SelectedIndex, usuarioSeleccionado, txtContrasena.Text))
                MessageBox.Show("Se produjo un error mientras se creaba el registro.");
            AdministrarUsuarios_Load(e,null);
        }
    }
}
