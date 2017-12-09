using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_de_Negocio;

namespace Sistema_Digitalizador_de_Polizas_Contables
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            //Inicializar datos de los componentes
            ManejarConfiguracion manejarConfiguracion = new ManejarConfiguracion();
            //Mensaje de ejemplo, borrar
            MessageBox.Show(manejarConfiguracion.ObtenerConfiguracionPorNombre("server"), "Alerta");

            //Consultar base de datos en busca de IDs de Usuario para el combobox? O ellos lo escriben?

        }

        private void botonAccesoAdmin_Click(object sender, EventArgs e)
        {
            //Obtener datos del formulario
            int userID = Int32.Parse(cmbIDUsuario.SelectedText);
            String userName = txbNombreUsuario.Text;
            String userPass = txbPassword.Text;

            //Verifica identidad

            new expedientesP().Show();
            this.SetVisibleCore(false);
            this.Dispose(); //Limpiar memoria
        }

        private void botonCancelarLogAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
