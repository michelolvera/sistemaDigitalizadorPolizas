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
    public class ProcesosUsuario
    {
        //Direccion de servidor
        private String nombreServidor = ConfigurationManager.AppSettings["server"];
        private String nombreBD = ConfigurationManager.AppSettings["dbname"];
        public SQLConexion Conexion { get; }
        public UsuarioInfo Usuario { get; }
        public ProcesosUsuario(UsuarioInfo Usuario)
        {
            this.Usuario = Usuario;
            Conexion = new SQLConexion(nombreServidor, nombreBD, this.Usuario.UserName, this.Usuario.UserPassword);
        }

        public bool IniciarSesion()
        {
            if (Conexion.AbrirConexion().Estado)
            {
                int userID = 0;
                SqlDataReader dataReader = Conexion.EjecutarConsulta("Execute SP_DIG_VALIDAR_USUARIO N\'" + Usuario.UserName+"\', N\'"+Usuario.UserPassword+"\'").Resultado;
                if(dataReader.HasRows && dataReader.Read())
                {
                    userID = dataReader.GetInt32(0);
                    Usuario.IdArea = dataReader.GetInt32(1); //Se recibe el ID de area, (Descomentar en cuanto el procedure lo retorne. DESCOMENTAR
                    Usuario.EsAdmin = dataReader.GetBoolean(2); // Se recibe si es admin o no.
                    dataReader.Close();
                }
                Conexion.CerrarConexion();
                //Validacion de datos
                if (userID == Usuario.UserID)
                    return true; //Verdadero en caso de login correcto
                else return false;
            }
            return false;
        }

        public Entidades.DataGridStyle LlenarTablaExpedientesPendientes(Entidades.DataGridStyle origenTabla)
        {
            //Ejemplo de llenado
            int i = 0;
            origenTabla.Rows.Add();
            origenTabla[0, i].Value = "1";
            origenTabla[1, i].Value = "1";
            origenTabla[2, i].Value = "Pólizas contables";
            origenTabla[3, i].Value = "Pólizas de Egresos";
            origenTabla[4, i].Value = "2017-12-10";
          //  origenTabla[5, i].Value = "0";
            i = 1;
            origenTabla.Rows.Add();
            origenTabla[0, i].Value = "1";
            origenTabla[1, i].Value = "1";
            origenTabla[2, i].Value = "Pólizas contables";
            origenTabla[3, i].Value = "Pólizas de Egresos";
            origenTabla[4, i].Value = "2017-12-10";
          //  origenTabla[5, i].Value = "0";

            return origenTabla;

            //Llenar tabla
            //SqlDataReader dataReader = Conexion.EjecutarConsulta("Execute SP_DIG_CONSULTA_EXPEDIENTE "+Usuario.IdArea).Resultado; //De aqui obtener resultados de tabla en cuanto se genere el procedure.
            /* SqlDataReader dataReader = Conexion.EjecutarConsulta("SELECT TOP(1000) E.[id_expediente,[id_area],[nombre_expediente],[nombre_categoria],E.[fecha_alta],[completo] FROM[digitalizador_procesos].[dbo].[TBL_DIG_EXPEDIENTES] as E inner join TBL_DIG_CATEGORIAS as C on e.id_expediente = c.id_expediente inner join TBL_DIG_DOCUMENTOS_CATEGORIA as DC on c.id_categoria = dc.id_categoria inner join TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS as RED on dc.id_documento = red.id_documento inner join TBL_DIG_REGISTRO_EXPEDIENTE as RE on red.id_registro = re.id_registro where id_area = "+Usuario.IdArea).Resultado;
             if (dataReader.HasRows && dataReader.Read())
             {
                 //while (dataReader.NextResult())
                 //{
                     int cont = 0;
                     origenTabla.Rows.Add();
                     origenTabla[0, cont].Value = dataReader.GetInt32(0);
                     origenTabla[1, cont].Value = dataReader.GetInt32(1);
                     origenTabla[2, cont].Value = dataReader.GetString(2);
                     origenTabla[3, cont].Value = dataReader.GetString(3);
                     origenTabla[4, cont].Value = dataReader.GetString(4);
                     origenTabla[5, cont].Value = dataReader.GetInt32(5);
                 //}
             }
             dataReader.Close();
             return origenTabla;
             */
        }
        
    }
}
