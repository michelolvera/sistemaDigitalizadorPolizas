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
        ProcesosDios procesosDios;
        private UsuarioInfo Usuario;
        public AdministrarUsuarios(ProcesosDios procesosDios)
        {
            InitializeComponent();
            this.procesosDios = procesosDios;
            cmbUsuario.KeyUp += CmbUsuario_KeyUp;
        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            //Lista de usuarios
            cmbUsuario = procesosDios.LlenarCombo(cmbUsuario, 1, 0);
            cmbUsuario.Items.Add("< Nuevo >");
        }

        private void CmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            cmbArea.Enabled = true;
            cmbArea = procesosDios.LlenarCombo(cmbArea, 0, 0);
            if (cmbUsuario.Items.Count == cmbUsuario.SelectedIndex + 1 && cmbUsuario.Text == "< Nuevo >")// crear nuevo usuario
            {
                //Crear nuevo usuario
                txtbIdUsuario.Text = String.Empty;
                cmbUsuario.Items.Clear();
                cmbUsuario.DropDownStyle = ComboBoxStyle.Simple;
            }
            else
            {
                //Seleccionar usuario existente
                Usuario = procesosDios.ObtenerUsuario(cmbUsuario.SelectedIndex);
                if (Usuario == null)
                {
                    MessageBox.Show("Se produjo un error al seleccionar el Usuario.");
                }
                txtbIdUsuario.Text = Usuario.Id.ToString();
                txtContrasena.Text = Usuario.Contraseña;
                cmbArea.SelectedIndex = procesosDios.ObtenerIndexArea(Usuario.IdArea);
                txtbNombre.Text = Usuario.Nombre;
                txtbApellidoPaterno.Text = Usuario.ApellidoPaterno;
                txtbApellidoMaterno.Text = Usuario.ApellidoMaterno;
                checkBoxAdmin.Checked = Usuario.Administrador;
                checkBoxDios.Checked = Usuario.Dios;
            }
        }

        private void CmbUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmbUsuario.DropDownStyle == ComboBoxStyle.Simple)
            {
                if (procesosDios.ValidarLongitudCadena(cmbUsuario.Text))
                {

                }
                else
                    MessageBox.Show("El nombre no puede tener mas de 100 caracteres.");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.Text != String.Empty) 
            {
                if (txtContrasena.Text != String.Empty)
                {
                    if (cmbArea.Text != String.Empty)
                    {
                        if (txtbNombre.Text != String.Empty)
                        {
                            if(txtbApellidoPaterno.Text != String.Empty)
                            {
                                if (txtbApellidoMaterno.Text != String.Empty)
                                {
                                    if (cmbUsuario.DropDownStyle == ComboBoxStyle.Simple)
                                    {
                                        //Nuevo Usuario
                                        Usuario = new UsuarioInfo(0, cmbUsuario.Text, txtContrasena.Text)
                                        {
                                            Nombre = txtbNombre.Text,
                                            ApellidoPaterno = txtbApellidoPaterno.Text,
                                            ApellidoMaterno = txtbApellidoMaterno.Text,
                                            IdArea = cmbArea.SelectedIndex,
                                            Administrador = checkBoxAdmin.Checked,
                                            Dios = checkBoxDios.Checked
                                        };
                                        if(procesosDios.RegistroUsuario(true, Usuario))
                                        {
                                            MessageBox.Show("El usuario se ha creado.");
                                            //Regresar controles a la normalidad
                                            RegresarControles();
                                        }
                                        else
                                            MessageBox.Show("Hubo un error al registrar este usuario.");
                                    }
                                    else
                                    {
                                        //Actualizar Usuario
                                        Usuario.Contraseña = txtContrasena.Text;
                                        Usuario.Nombre = txtbNombre.Text;
                                        Usuario.ApellidoPaterno = txtbApellidoPaterno.Text;
                                        Usuario.ApellidoMaterno = txtbApellidoMaterno.Text;
                                        Usuario.IdArea = cmbArea.SelectedIndex;
                                        Usuario.Administrador = checkBoxAdmin.Checked;
                                        Usuario.Dios = checkBoxDios.Checked;
                                        if (procesosDios.RegistroUsuario(false, Usuario))
                                        {
                                            MessageBox.Show("El usuario se ha actualizado.");
                                            //Regresar controles a la normalidad
                                            RegresarControles();
                                        }
                                        else
                                            MessageBox.Show("Hubo un error al registrar este usuario.");
                                    }
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

        void RegresarControles()
        {
            tabControlUsuarios.SelectedIndex = 0;
            txtContrasena.Text = String.Empty;
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario = procesosDios.LlenarCombo(cmbUsuario, 1, 0);
            cmbUsuario.Items.Add("< Nuevo >");
            btnGuardar.Enabled = false;
            txtbApellidoMaterno.Text = String.Empty;
            txtbApellidoPaterno.Text = String.Empty;
            txtbIdUsuario.Text = String.Empty;
            txtbNombre.Text = String.Empty;
            checkBoxAdmin.Checked = false;
            checkBoxDios.Checked = false;
            cmbArea.Items.Clear();
            cmbArea.Enabled = false;
        }
    }
}
