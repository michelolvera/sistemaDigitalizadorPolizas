using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Digitalizador_de_Polizas_Contables
{
    public partial class expedientesP : Form
    {
        public expedientesP()
        {
            InitializeComponent();
            for(int i = 0; i < 5; i++)
            {
                dgvExpedientes.Rows.Add();
                dgvExpedientes[0, i].Value = ""+(i+1);
                dgvExpedientes[1, i].Value = "hola ";
                dgvExpedientes[2, i].Value = "caca";
                dgvExpedientes[3, i].Value = "32-02-3017";
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void expedientesP_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void dgvExpedientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new formPrincipal(this.dgvExpedientes.CurrentRow.Cells[0].Value.ToString()+ this.dgvExpedientes.CurrentRow.Cells[1].Value.ToString()+ this.dgvExpedientes.CurrentRow.Cells[2].Value.ToString()+ this.dgvExpedientes.CurrentRow.Cells[3].Value.ToString()).Show();
            this.SetVisibleCore(false);
        }
    }
}
