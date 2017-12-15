using Acceso_a_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_Negocio
{   //Comunicacion y formateo de datos con SQL Server 2008
    public class SQLFormat
    {
        //Direccion de servidor
        private String nombreServidor = ConfigurationManager.AppSettings["server"];
        private String nombreBD = ConfigurationManager.AppSettings["dbname"];
        SQLConexion conexion;
        public UsuarioInfo Usuario { get; }
        public SQLFormat(UsuarioInfo Usuario)
        {
            this.Usuario = Usuario;
            conexion = new SQLConexion(nombreServidor, nombreBD, this.Usuario.UserName, this.Usuario.UserPassword);
        }

        public bool IniciarSesion()
        {
            if (conexion.AbrirConexion().Estado)
            {
                int userID = 0;
                SqlDataReader dataReader = conexion.EjecutarConsulta("Execute SP_DIG_VALIDAR_USUARIO N\'" + Usuario.UserName+"\', N\'"+Usuario.UserPassword+"\'").Resultado;
                if(dataReader.HasRows && dataReader.Read())
                {
                    userID = dataReader.GetInt32(0);
                    //Usuario.IdArea = dataReader.GetInt32(1); //Se recibe el ID de area, (Descomentar en cuanto el procedure lo retorne.
                    dataReader.Close();
                }
                conexion.CerrarConexion();
                //Validacion de datos
                if (userID == Usuario.UserID)
                    return true; //Verdadero en caso de login correcto
                else return false;
            }
            return false;
        }

        public System.Windows.Forms.DataGridView LlenarTabla(System.Windows.Forms.DataGridView origenTabla)
        {
            /*Ejemplo de llenado
            for(int i = 0; i < 5; i++)
            {
                dgvExpedientes.Rows.Add();
                dgvExpedientes[0, i].Value = ""+(i+1);
                dgvExpedientes[1, i].Value = "hola ";
                dgvExpedientes[2, i].Value = "caca";
                dgvExpedientes[3, i].Value = "32-02-3017";
            }*/

            //Llenar tabla
            SqlDataReader dataReader = conexion.EjecutarConsulta("Execute SP_DIG_CONSULTA_EXPEDIENTE "+Usuario.IdArea).Resultado; //De aqui obtener resultados de tabla en cuanto se genere el procedure.
            return origenTabla;
        }
    }
}
