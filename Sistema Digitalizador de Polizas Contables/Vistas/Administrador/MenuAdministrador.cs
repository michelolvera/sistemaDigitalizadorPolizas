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
    public partial class MenuAdministrador : Form
    {
        ProcesosAdministrador procesosAdministrador;
        
        public MenuAdministrador(ProcesosAdministrador procesosAdministrador)
        {
            InitializeComponent();
            this.procesosAdministrador = procesosAdministrador;
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            //Obtener Areas
            cmbArea = procesosAdministrador.LlenarComboArea(cmbArea);
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
            dgvDocumentos = procesosAdministrador.ObtenerTablaDocumentos(dgvDocumentos);
            dgvDocumentos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void CmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
