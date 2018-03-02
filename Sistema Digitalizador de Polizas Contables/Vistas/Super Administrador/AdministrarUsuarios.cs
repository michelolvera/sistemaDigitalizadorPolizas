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
        public AdministrarUsuarios(ProcesosDios procesosDios)
        {
            InitializeComponent();
            this.procesosDios = procesosDios;
            cmbUsuario.KeyUp += CmbUsuario_KeyUp;
        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            //Lista de usuarios
            cmbUsuario = procesosDios.LlenarCombo(cmbUsuario, 3, 0);
        }

        private void CmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbArea.Enabled = true;
            cmbArea = procesosDios.LlenarCombo(cmbArea, 0, 0);
            if (cmbUsuario.Items.Count == cmbUsuario.SelectedIndex + 1 && cmbUsuario.Text == "< Nuevo >")// crear nuevo usuario
            {
                //Crear nuevo usuario
            }
            else
            {
                //Seleccionar usuario existente
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
                                    //Crear o modificar el usuario
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
