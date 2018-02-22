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
    public partial class ManualInsert : Form
    {
        ProcesosAdministrador procesosAdministrador;
        public ManualInsert(ProcesosAdministrador procesosAdministrador)
        {
            InitializeComponent();
            this.procesosAdministrador = procesosAdministrador;
        }

        private void ManualInsert_Load(object sender, EventArgs e)
        {
            CmbArea = procesosAdministrador.LlenarCombo(CmbArea, 0, 0);
        }

        private void CmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Desactivar Controles no Necesarios
            CmbCategoria.Enabled = false;
            TxtNombre.Enabled = false;
            TxtNombre.Text = "";
            BtnGuardar.Enabled = false;

            CmbExpediente = procesosAdministrador.LlenarCombo(CmbExpediente, 1, CmbArea.SelectedIndex);
        }

        private void CmbExpediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Desactivar controles no Necesarios
            TxtNombre.Text = "";
            BtnGuardar.Enabled = false;
            TxtNombre.Enabled = false;

            CmbCategoria = procesosAdministrador.LlenarCombo(CmbCategoria, 2, CmbExpediente.SelectedIndex);
            
        }

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
            BtnGuardar.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombre != null && TxtNombre.Text != String.Empty)
            {
                if (procesosAdministrador.ValidarLongitudCadena(TxtNombre.Text))
                {
                    if (procesosAdministrador.RegistrarManual(TxtNombre.Text, CmbCategoria.SelectedIndex))
                    {
                        MessageBox.Show("El registro se creeo de manera correcta.");
                        TxtNombre.Text = "";
                    }
                    else
                        MessageBox.Show("Se presento un error al insertar el registro, intentelo de nuevo.");
                }else
                    MessageBox.Show("El identificador no puede exceder mas de 100 caracteres.");
            }
            else
            {
                MessageBox.Show("El nombre no puede estar vacio.");
            }
        }
    }
}