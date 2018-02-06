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
                //Validacion de datos
                if (userID == Usuario.UserID)
                    return true; //Verdadero en caso de login correcto
                else return false;
            }
            return false;
        }

        public Entidades.DataGridStyle LlenarTablaExpedientesPendientes(Entidades.DataGridStyle origenTabla, bool completado)
        {
            origenTabla.Rows.Clear();
            SQLEstado sQLEstado;
            if (completado)
                sQLEstado = Conexion.EjecutarConsulta("SELECT id_registro, identificador_registro, DBO.TBL_DIG_REGISTRO_EXPEDIENTE.fecha_alta, DBO.TBL_DIG_REGISTRO_EXPEDIENTE.id_usuario, nombre_expediente, nombre_categoria, completo FROM DBO.TBL_DIG_REGISTRO_EXPEDIENTE INNER JOIN DBO.TBL_DIG_CATEGORIAS ON DBO.TBL_DIG_REGISTRO_EXPEDIENTE.id_categoria=DBO.TBL_DIG_CATEGORIAS.id_categoria INNER JOIN DBO.TBL_DIG_EXPEDIENTES ON DBO.TBL_DIG_CATEGORIAS.id_expediente = DBO.TBL_DIG_EXPEDIENTES.id_expediente INNER JOIN DBO.TBL_DIG_AREAS ON DBO.TBL_DIG_EXPEDIENTES.id_area = DBO.TBL_DIG_AREAS.id_area WHERE DBO.TBL_DIG_AREAS.id_area = " + Usuario.IdArea + " AND DBO.TBL_DIG_CATEGORIAS.activo=1 AND DBO.TBL_DIG_EXPEDIENTES.activo=1 AND DBO.TBL_DIG_AREAS.activo=1;");
            else
                sQLEstado = Conexion.EjecutarConsulta("SELECT id_registro, identificador_registro, DBO.TBL_DIG_REGISTRO_EXPEDIENTE.fecha_alta, DBO.TBL_DIG_REGISTRO_EXPEDIENTE.id_usuario, nombre_expediente, nombre_categoria, completo FROM DBO.TBL_DIG_REGISTRO_EXPEDIENTE INNER JOIN DBO.TBL_DIG_CATEGORIAS ON DBO.TBL_DIG_REGISTRO_EXPEDIENTE.id_categoria=DBO.TBL_DIG_CATEGORIAS.id_categoria INNER JOIN DBO.TBL_DIG_EXPEDIENTES ON DBO.TBL_DIG_CATEGORIAS.id_expediente = DBO.TBL_DIG_EXPEDIENTES.id_expediente INNER JOIN DBO.TBL_DIG_AREAS ON DBO.TBL_DIG_EXPEDIENTES.id_area = DBO.TBL_DIG_AREAS.id_area WHERE DBO.TBL_DIG_AREAS.id_area = " + Usuario.IdArea + " AND DBO.TBL_DIG_REGISTRO_EXPEDIENTE.completo='false' AND DBO.TBL_DIG_CATEGORIAS.activo=1 AND DBO.TBL_DIG_EXPEDIENTES.activo=1 AND DBO.TBL_DIG_AREAS.activo=1;");

            if (sQLEstado.Estado)
            {
                while (sQLEstado.Resultado.HasRows && sQLEstado.Resultado.Read())
                {
                    origenTabla.Rows.Add(sQLEstado.Resultado.GetInt32(0), sQLEstado.Resultado.GetString(1), sQLEstado.Resultado.GetDateTime(2), sQLEstado.Resultado.GetInt32(3), sQLEstado.Resultado.GetString(4), sQLEstado.Resultado.GetString(5), sQLEstado.Resultado.GetBoolean(6));
                }
                sQLEstado.Resultado.Close();
            }
            return origenTabla;
        }

        public Entidades.DataGridStyle LlenarTablaDocumentosPendientes(Entidades.DataGridStyle origenTabla, int expediente, bool completado)
        {
            origenTabla.Rows.Clear();
            SQLEstado sQLEstado;
            if (completado)
                sQLEstado = Conexion.EjecutarConsulta("SELECT id_documento_dig, nombre_documento, fecha_digitalizado, digitalizado FROM dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS INNER JOIN dbo.TBL_DIG_DOCUMENTOS_CATEGORIA ON dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS.id_documento=dbo.TBL_DIG_DOCUMENTOS_CATEGORIA.id_documento WHERE id_registro=" + expediente + " AND activo=1;");
            else
                sQLEstado = Conexion.EjecutarConsulta("SELECT id_documento_dig, nombre_documento, fecha_digitalizado, digitalizado FROM dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS INNER JOIN dbo.TBL_DIG_DOCUMENTOS_CATEGORIA ON dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS.id_documento=dbo.TBL_DIG_DOCUMENTOS_CATEGORIA.id_documento WHERE id_registro=" + expediente + " AND digitalizado=0 AND activo=1;");

            if (sQLEstado.Estado)
            {
                while (sQLEstado.Resultado.HasRows && sQLEstado.Resultado.Read())
                {
                    DateTime fechaDigitalizado;
                    String fechaTexto;
                    try
                    {
                        fechaDigitalizado = sQLEstado.Resultado.GetDateTime(2);
                        fechaTexto = fechaDigitalizado.ToLongDateString();
                    }catch(Exception e)
                    {
                        fechaTexto = "No se ha digitalizado";
                        Console.WriteLine(e.Message);
                    }
                    origenTabla.Rows.Add(sQLEstado.Resultado.GetInt32(0), sQLEstado.Resultado.GetString(1), fechaTexto, sQLEstado.Resultado.GetBoolean(3));
                }
                sQLEstado.Resultado.Close();
            }
            return origenTabla;
        }

    }
}
