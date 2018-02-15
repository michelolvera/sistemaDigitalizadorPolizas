using Acceso_a_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
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

        List<int> registroId = new List<int>();
        List<int> documentoDigId = new List<int>();

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
            registroId.Clear();
            origenTabla.Rows.Clear();
            SQLEstado sQLEstado;
            if (completado)
                sQLEstado = Conexion.EjecutarConsulta("SELECT id_registro, identificador_registro, DBO.TBL_DIG_REGISTRO_EXPEDIENTE.fecha_alta, nombre_usuario, nombre_expediente, nombre_categoria, completo FROM DBO.TBL_DIG_REGISTRO_EXPEDIENTE INNER JOIN dbo.TBL_DIG_USERS ON DBO.TBL_DIG_REGISTRO_EXPEDIENTE.id_usuario=dbo.TBL_DIG_USERS.id_usuario INNER JOIN DBO.TBL_DIG_CATEGORIAS ON DBO.TBL_DIG_REGISTRO_EXPEDIENTE.id_categoria=DBO.TBL_DIG_CATEGORIAS.id_categoria INNER JOIN DBO.TBL_DIG_EXPEDIENTES ON DBO.TBL_DIG_CATEGORIAS.id_expediente = DBO.TBL_DIG_EXPEDIENTES.id_expediente INNER JOIN DBO.TBL_DIG_AREAS ON DBO.TBL_DIG_EXPEDIENTES.id_area = DBO.TBL_DIG_AREAS.id_area WHERE DBO.TBL_DIG_AREAS.id_area = " + Usuario.IdArea + " AND DBO.TBL_DIG_CATEGORIAS.activo=1 AND DBO.TBL_DIG_EXPEDIENTES.activo=1 AND DBO.TBL_DIG_AREAS.activo=1;");
            else
                sQLEstado = Conexion.EjecutarConsulta("SELECT id_registro, identificador_registro, DBO.TBL_DIG_REGISTRO_EXPEDIENTE.fecha_alta, nombre_usuario, nombre_expediente, nombre_categoria, completo FROM DBO.TBL_DIG_REGISTRO_EXPEDIENTE INNER JOIN dbo.TBL_DIG_USERS ON DBO.TBL_DIG_REGISTRO_EXPEDIENTE.id_usuario=dbo.TBL_DIG_USERS.id_usuario INNER JOIN DBO.TBL_DIG_CATEGORIAS ON DBO.TBL_DIG_REGISTRO_EXPEDIENTE.id_categoria=DBO.TBL_DIG_CATEGORIAS.id_categoria INNER JOIN DBO.TBL_DIG_EXPEDIENTES ON DBO.TBL_DIG_CATEGORIAS.id_expediente = DBO.TBL_DIG_EXPEDIENTES.id_expediente INNER JOIN DBO.TBL_DIG_AREAS ON DBO.TBL_DIG_EXPEDIENTES.id_area = DBO.TBL_DIG_AREAS.id_area WHERE DBO.TBL_DIG_AREAS.id_area = " + Usuario.IdArea + " AND DBO.TBL_DIG_REGISTRO_EXPEDIENTE.completo='false' AND DBO.TBL_DIG_CATEGORIAS.activo=1 AND DBO.TBL_DIG_EXPEDIENTES.activo=1 AND DBO.TBL_DIG_AREAS.activo=1;");

            if (sQLEstado.Estado)
            {
                while (sQLEstado.Resultado.HasRows && sQLEstado.Resultado.Read())
                {
                    registroId.Add(sQLEstado.Resultado.GetInt32(0));
                    origenTabla.Rows.Add(sQLEstado.Resultado.GetString(1), sQLEstado.Resultado.GetDateTime(2), sQLEstado.Resultado.GetString(3), sQLEstado.Resultado.GetString(4), sQLEstado.Resultado.GetString(5), sQLEstado.Resultado.GetBoolean(6));
                }
                sQLEstado.Resultado.Close();
            }
            return origenTabla;
        }

        public Entidades.DataGridStyle LlenarTablaDocumentosPendientes(Entidades.DataGridStyle origenTabla, int expediente, bool completado)
        {
            documentoDigId.Clear();
            origenTabla.Rows.Clear();
            SQLEstado sQLEstado;
            if (completado)
                sQLEstado = Conexion.EjecutarConsulta("SELECT id_documento_dig, nombre_documento, fecha_digitalizado FROM dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS INNER JOIN dbo.TBL_DIG_DOCUMENTOS_CATEGORIA ON dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS.id_documento=dbo.TBL_DIG_DOCUMENTOS_CATEGORIA.id_documento WHERE id_registro=" + expediente + ";");
            else
                sQLEstado = Conexion.EjecutarConsulta("SELECT id_documento_dig, nombre_documento, fecha_digitalizado FROM dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS INNER JOIN dbo.TBL_DIG_DOCUMENTOS_CATEGORIA ON dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS.id_documento=dbo.TBL_DIG_DOCUMENTOS_CATEGORIA.id_documento WHERE id_registro=" + expediente + " AND digitalizado=0;");

            if (sQLEstado.Estado)
            {
                while (sQLEstado.Resultado.HasRows && sQLEstado.Resultado.Read())
                {
                    documentoDigId.Add(sQLEstado.Resultado.GetInt32(0));
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
                    origenTabla.Rows.Add(sQLEstado.Resultado.GetString(1), fechaTexto);
                }
                sQLEstado.Resultado.Close();
            }
            return origenTabla;
        }

        public int ObtenerRegistroId(int index)
        {
            return registroId[index];
        }

        public bool ActualizarDigitalizado(int rowIndex, bool digitalizado)
        {
            return Conexion.EjecutarSentencia("UPDATE dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS SET digitalizado='" + digitalizado + "', fecha_digitalizado=" + (digitalizado ? "CURRENT_TIMESTAMP" : "null") + " WHERE id_documento_dig=" + documentoDigId[rowIndex] + ";").Estado;
        }

        //
        ///---------------- Gestion de Rutas y Archivos -----------------///
        //

        private String directorioDatos = ConfigurationManager.AppSettings["savepath"];//Directorio en donde se guardaran los archivos

        public void CopiarArchivo(String pathDirectorio, String pathArchivo, String nombreArchivo)
        {
            if (Directory.Exists(pathDirectorio))
            {
                if (!File.Exists(pathDirectorio + "\\" + nombreArchivo))
                {
                    File.Copy(pathArchivo, pathDirectorio + "\\" + nombreArchivo);
                }
                else
                {
                    Console.WriteLine("Archivo existente");
                }
            }
            else
            {
                Console.WriteLine("El directorio no existe. Creando...");
                Directory.CreateDirectory(pathDirectorio);
                Console.WriteLine("Directorio Creado");
                if (!File.Exists(pathDirectorio + "\\" + nombreArchivo))
                {
                    File.Copy(pathArchivo, pathDirectorio + "\\" + nombreArchivo);
                }
                else
                {
                    Console.WriteLine("Archivo existente");
                }
            }
        }
        public void EliminarArchivo(String pathDirectorio, String nombreArchivo)
        {
            if (Directory.Exists(pathDirectorio))
            {
                if (File.Exists(pathDirectorio + "\\" + nombreArchivo))
                {
                    try
                    {
                        File.Delete(pathDirectorio + "\\" + nombreArchivo);
                        Console.WriteLine("Elimiando");
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine("Cierre el documento antes de tratar de modificarlo" + e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("El archivo no existe");
                }
            }
            else
            {
                Console.WriteLine("El directorio no existe.");
            }
        }

        public DatosArchivo ContruirRuta(int row)
        {
            DatosArchivo datosArchivo = new DatosArchivo();
            SQLEstado sQLEstado;
            sQLEstado = Conexion.EjecutarConsulta("SELECT nombre_area, nombre_expediente, nombre_categoria, identificador_registro, nombre_documento FROM dbo.TBL_DIG_AREAS INNER JOIN dbo.TBL_DIG_EXPEDIENTES ON dbo.TBL_DIG_AREAS.id_area=dbo.TBL_DIG_EXPEDIENTES.id_area INNER JOIN dbo.TBL_DIG_CATEGORIAS ON dbo.TBL_DIG_EXPEDIENTES.id_expediente=dbo.TBL_DIG_CATEGORIAS.id_expediente INNER JOIN dbo.TBL_DIG_DOCUMENTOS_CATEGORIA ON dbo.TBL_DIG_CATEGORIAS.id_categoria=dbo.TBL_DIG_DOCUMENTOS_CATEGORIA.id_categoria INNER JOIN dbo.TBL_DIG_REGISTRO_EXPEDIENTE ON dbo.TBL_DIG_REGISTRO_EXPEDIENTE.id_categoria=TBL_DIG_DOCUMENTOS_CATEGORIA.id_categoria INNER JOIN dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS ON dbo.TBL_DIG_DOCUMENTOS_CATEGORIA.id_documento=dbo.TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS.id_documento WHERE id_documento_dig=" +row + ";");
            if (sQLEstado.Estado && sQLEstado.Resultado.HasRows && sQLEstado.Resultado.Read())
            {
                datosArchivo.Ruta = directorioDatos + "\\"+
                                    sQLEstado.Resultado.GetString(0) + "\\" +
                                    sQLEstado.Resultado.GetString(1) + "\\" +
                                    sQLEstado.Resultado.GetString(2) + "\\" +
                                    sQLEstado.Resultado.GetString(3) + "\\";
                datosArchivo.NombreArchivo = sQLEstado.Resultado.GetString(4)+".pdf";
                sQLEstado.Resultado.Close();
            }

            return datosArchivo; 
        }


    }
}
