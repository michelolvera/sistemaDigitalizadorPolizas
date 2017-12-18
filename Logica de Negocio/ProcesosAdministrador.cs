using Acceso_a_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica_de_Negocio
{
    
    public class ProcesosAdministrador : ProcesosUsuario
    {
        private SQLAdministrador SqlAdministrador = new SQLAdministrador();
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        SQLEstado estado;
        public ProcesosAdministrador(UsuarioInfo Usuario) : base (Usuario)
        {
            
        }

        public DataGridView ObtenerTablaDocumentos(DataGridView origenTabla)
        {
            SQLEstado estado = Conexion.ObtenerTabla("SELECT * FROM dbo.TBL_DIG_DOCUMENTOS_CATEGORIA;");
            if (estado.Estado)
            {
                origenTabla.DataSource = bindingSource;
                bindingSource.DataSource = SqlAdministrador.SQLTablaDocumentos(estado.Tabla);
                return origenTabla;
            }
            return null;
        }
        public bool ActualizarTablaDocumentos()
        {
            return SqlAdministrador.UpdateTablaDocumentos(bindingSource);
        }

        public ComboBox LlenarComboArea(ComboBox origenCombo)
        {
            estado = Conexion.EjecutarConsulta("SELECT nombre_area FROM dbo.TBL_DIG_AREAS;");
            if (estado.Estado)
            {
                origenCombo.Items.Clear();
                SqlDataReader sqlDataReader = estado.Resultado;
                while (sqlDataReader.HasRows && sqlDataReader.Read())
                {
                    origenCombo.Items.Add(sqlDataReader.GetString(0));
                }
                origenCombo.Enabled = true;
            }
            return origenCombo;
        }

        public ComboBox LlenarComboExpediente(ComboBox origenCombo, int idArea)
        {
            estado = Conexion.EjecutarConsulta("SELECT nombre_area FROM dbo.TBL_DIG_EXPEDIENTE;");
            if (estado.Estado)
            {
                origenCombo.Items.Clear();
                SqlDataReader sqlDataReader = estado.Resultado;
                while (sqlDataReader.HasRows && sqlDataReader.Read())
                {
                    origenCombo.Items.Add(sqlDataReader.GetString(0));
                }
                origenCombo.Enabled = true;
            }
            return origenCombo;
        }

    }
}
