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
            cmbArea.Enabled = true;
            cmbArea = procesosAdministrador.LlenarCombo(cmbArea, 0, 0);
            if (cmbUsuario.Items.Count == cmbArea.SelectedIndex + 1 && cmbUsuario.Text == "< Nuevo >")// crear nuevo usuario
            {
                
                txtContrasena.Enabled = true;
                cmbArea.Enabled = true;
                txtbNombre.Enabled = true;
                txtbApellidoP.Enabled = true;
                txtbApellidoMaterno.Enabled = true;
                checkBoxAdmin.Enabled = true;
                checkBoxDios.Enabled = true;
                cmbUsuario.DropDownStyle = ComboBoxStyle.Simple;
                cmbUsuario.Text = "";
            }
            else  //seleccionar un usuario
            {
                txtContrasena.Enabled = true;
                cmbArea.Enabled = true;
                txtbNombre.Enabled = true;
                txtbApellidoP.Enabled = true;
                txtbApellidoMaterno.Enabled = true;
                checkBoxAdmin.Enabled = true;
                checkBoxDios.Enabled = true;
                lblUsuarioSeleccionado.Text = cmbUsuario.Text;
                usuarioSeleccionado.UserName = cmbUsuario.Text;
                cmbArea.SelectedIndex = cmbArea.FindStringExact(procesosAdministrador.Usuario.Area);
                usuarioSeleccionado = procesosAdministrador.UsuarioSeleccionado(usuarioSeleccionado);
                txtbIdUsuario.Text = ""+usuarioSeleccionado.UserID;
                cmbArea.SelectedIndex = cmbArea.FindStringExact(usuarioSeleccionado.Area);
                txtbNombre.Text = usuarioSeleccionado.Nombre;
                txtbApellidoP.Text = usuarioSeleccionado.ApellidoPaterno;
                txtbApellidoMaterno.Text = usuarioSeleccionado.ApellidoMaterno;
                checkBoxAdmin.Checked = usuarioSeleccionado.EsAdmin;
                checkBoxDios.Checked = usuarioSeleccionado.Dios;
                txtContrasena.Text = "*****";
            }
        }

        private void cmbUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmbUsuario.DropDownStyle == ComboBoxStyle.Simple)
            {
                if (procesosAdministrador.ValidarLongitudCadena(cmbUsuario.Text))
                {
                    if (listaUsuarios.Exists(nom => nom == cmbUsuario.Text))
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
            if (cmbUsuario.Text != "") 
            {
                if (txtContrasena.Text != "")
                {
                    if (cmbArea.Text != "")
                    {
                        if (txtbNombre.Text != "")
                        {
                            if(txtbApellidoP.Text != "")
                            {
                                if (txtbApellidoMaterno.Text != "")
                                {
                                    
                                            if (listaUsuarios.Exists(x => x == cmbUsuario.Text))//si es update
                                            {

                                            }
                                            else //si es nuevo
                                            {
                                                usuarioSeleccionado.Area = cmbArea.Text;
                                                usuarioSeleccionado.Nombre = txtbNombre.Text;
                                                usuarioSeleccionado.ApellidoPaterno = txtbApellidoP.Text;
                                                usuarioSeleccionado.ApellidoMaterno = txtbApellidoMaterno.Text;
                                                usuarioSeleccionado.EsAdmin = checkBoxAdmin.Checked;
                                                usuarioSeleccionado.Dios = checkBoxDios.Checked;
                                                if (!procesosAdministrador.CrearNuevoRegistro(3, cmbUsuario.Text, cmbUsuario.SelectedIndex, usuarioSeleccionado, txtContrasena.Text))
                                                    MessageBox.Show("Se produjo un error mientras se creaba el registro.");
                                            }

                                            AdministrarUsuarios_Load(e, null);
                                        
                                    
                                }else
                                    MessageBox.Show("El apellido materno no puede estar vacio");
                            }
                            else
                                MessageBox.Show("El apellido paterno no puede estar vacio");
                        }
                        else
                            MessageBox.Show("El nombre no puede estar vacio");
                    }
                    else
                        MessageBox.Show("El area no puede estar vacio");
                }
                else
                    MessageBox.Show("La constrseña no puede estar vacia");
            }
            else
                MessageBox.Show("El nombre de usuario no puede estar vacio");
        }
    }
}
