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
using AxAcroPDFLib;
using System.Windows.Forms;

namespace Logica_de_Negocio
{   //Comunicacion y formateo de datos con SQL Server 2008
    public class ProcesosUsuario
    {
        //Direccion de servidor
        private String nombreServidor = ConfigurationManager.AppSettings["server"];
        private String nombreBD = ConfigurationManager.AppSettings["dbname"];
        public SQLConexion Conexion { get; }
        public UsuarioInfo Usuario { get; }
        private DatosArchivo datosArchivo=null;
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
                SqlDataReader dataReader = Conexion.EjecutarConsulta("Execute SP_DIG_VALIDAR_USUARIO '" + Usuario.UserName+"\', '"+Usuario.UserPassword+"'").Resultado;
                if(dataReader.HasRows && dataReader.Read())
                {
                    userID = dataReader.GetInt32(0);
                    Usuario.IdArea = dataReader.GetInt32(1); //Se recibe el ID de area, (Descomentar en cuanto el procedure lo retorne. DESCOMENTAR
                    Usuario.EsAdmin = dataReader.GetBoolean(2); // Se recibe si es admin o no.
                    Usuario.Nombre = dataReader.GetString(3);
                    Usuario.ApellidoPaterno = dataReader.GetString(4);
                    Usuario.ApellidoMaterno = dataReader.GetString(5);
                    Usuario.Dios = dataReader.GetBoolean(6);
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
                sQLEstado = Conexion.EjecutarConsulta("Execute SP_DIG_OBTENER_DATOS_EXPEDIENTE " + Usuario.IdArea );
            else
                sQLEstado = Conexion.EjecutarConsulta("Execute SP_DIG_OBTENER_DATOS_EXPEDIENTE2 " + Usuario.IdArea);

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
                sQLEstado = Conexion.EjecutarConsulta("Execute SP_DIG_OBTENER_DOC_PENDIENTES " + expediente);
            else
                sQLEstado = Conexion.EjecutarConsulta("Execute SP_DIG_OBTENER_DOC_PENDIENTES2 " + expediente);

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
            Console.WriteLine(digitalizado);
            return Conexion.EjecutarSentencia("Execute SP_DIG_ACTUALIZAR_DIGITALIZADO " + (digitalizado ? 1 : 0) +", "+ documentoDigId[rowIndex]).Estado;
        }

        //
        ///---------------- Gestion de Rutas y Archivos -----------------///
        //

        private String directorioDatos = ConfigurationManager.AppSettings["savepath"];//Directorio en donde se guardaran los archivos

        public bool CopiarArchivo(String pathArchivo)
        {
            if (datosArchivo != null)
            {
                if (Directory.Exists(datosArchivo.Ruta))
                {
                    if (!File.Exists(datosArchivo.Ruta + "\\" + datosArchivo.NombreArchivo))
                    {
                        using (FileStream sourceDocumento = new FileStream(pathArchivo, FileMode.Open, FileAccess.Read))
                        {
                            byte[] bytes = new byte[sourceDocumento.Length];
                            int numeroBytes = (int)sourceDocumento.Length;
                            int indiceBytes = 0;
                            while (numeroBytes > 0)
                            {
                                int n = sourceDocumento.Read(bytes,indiceBytes,numeroBytes);
                                if (n == 0) break;
                                indiceBytes += n;
                                numeroBytes -= n;
                            }
                            numeroBytes = bytes.Length;
                            using(FileStream destinoDocumento = new FileStream(datosArchivo.Ruta + "\\" + datosArchivo.NombreArchivo, FileMode.Create, FileAccess.Write))
                            {
                                destinoDocumento.Write(bytes, 0, numeroBytes);
                            }
                        }
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Archivo existente");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("El directorio no existe. Creando...");
                    Directory.CreateDirectory(datosArchivo.Ruta);
                    Console.WriteLine("Directorio Creado");
                    if (!File.Exists(datosArchivo.Ruta + "\\" + datosArchivo.NombreArchivo))
                    {
                        using (FileStream sourceDocumento = new FileStream(pathArchivo, FileMode.Open, FileAccess.Read))
                        {
                            byte[] bytes = new byte[sourceDocumento.Length];
                            int numeroBytes = (int)sourceDocumento.Length;
                            int indiceBytes = 0;
                            while (numeroBytes > 0)
                            {
                                int n = sourceDocumento.Read(bytes, indiceBytes, numeroBytes);
                                if (n == 0) break;
                                indiceBytes += n;
                                numeroBytes -= n;
                            }
                            numeroBytes = bytes.Length;
                            using (FileStream destinoDocumento = new FileStream(datosArchivo.Ruta + "\\" + datosArchivo.NombreArchivo, FileMode.Create, FileAccess.Write))
                            {
                                destinoDocumento.Write(bytes, 0, numeroBytes);
                            }
                        }
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Archivo existente");
                        return false;
                    }
                }
            }
            return false;
        }
        public bool EliminarArchivo()
        {
            if (Directory.Exists(datosArchivo.Ruta))
            {
                if (File.Exists(datosArchivo.Ruta + "\\" + datosArchivo.NombreArchivo))
                {
                    try
                    {
                        File.Delete(datosArchivo.Ruta + "\\" + datosArchivo.NombreArchivo);
                        Console.WriteLine("Elimiando");
                        return true;
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine("Cierre el documento antes de tratar de modificarlo" + e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("El archivo no existe");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("El directorio no existe.");
                return false;
            }
            return false;
        }

        public void ConstruirRuta(int row)
        {
            datosArchivo = new DatosArchivo();
            SQLEstado sQLEstado;
            sQLEstado = Conexion.EjecutarConsulta("Execute SP_DIG_OBTENER_DATOS_RUTA "+ documentoDigId[row]);
            if (sQLEstado.Estado && sQLEstado.Resultado.HasRows && sQLEstado.Resultado.Read())
            {
                datosArchivo.Ruta = directorioDatos + "\\"+
                                    sQLEstado.Resultado.GetString(0) + "\\" +
                                    sQLEstado.Resultado.GetString(1) + "\\" +
                                    sQLEstado.Resultado.GetString(2) + "\\" +
                                    sQLEstado.Resultado.GetString(3);
                datosArchivo.NombreArchivo = sQLEstado.Resultado.GetString(4)+".pdf";
                sQLEstado.Resultado.Close();
            }
        }
        public bool MostrarPDF(AxAcroPDF axAcroPDF)
        {
            String source = datosArchivo.Ruta + "\\" + datosArchivo.NombreArchivo;
            if (File.Exists(source))
            {
                axAcroPDF.src = source;
                axAcroPDF.Visible = true;
                return true;
            }
            else
            {
                MessageBox.Show("Archivo no encontrado!\n\nBuscamos: "+source+"\n\nPISTA: Si cuenta con el archivo, llevelo a la ubicación correcta y vuelva intente abrirlo. Caso contrario vuelva a escanear el documento.", "ARCHIVO NO ENCONTRADO!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }
        }
        
        public bool ValidarLongitudCadena(string cadena)
        {
            //Si la cadena excede los 100 caracteres regresa false, de lo contrario y por lo tanto de 100 o menos caracteres retorna true
            return cadena.Length > 100 ? false : true;
        }
    }
}
