﻿using Acceso_a_Datos;
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
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace Logica_de_Negocio
{
    /// <summary>
    /// Clase que contiene todos los procesos que el usuario comun de la aplicacion,
    /// no administrador ni super administrador, puede ejecutar.
    /// Variables:
    /// nombreServidor: Contiene el nombre del servidor que obtiene automaticamente desde el archivo App.config
    /// nombreBD: Contiene el nombre de la base de datos obtiene automaticamente desde el archivo App.config
    /// Conexion: Instancia de SQLConexion que se inicializa con todos los datos de usuario
    /// Usuario: Instancia de UsuarioInfo que contiene toda la informacion del usuario.
    /// datosArchivo: Instancia de DatosArchivo que contiene toda la informacion del archivo que se digitalizara.
    /// registroId: Lista de IDs de la tabla [dbo].[TBL_DIG_REGISTRO_EXPEDIENTE]
    /// documentoDigId: Lista de IDs de la tabla [dbo].[TBL_DIG_REGISTRO_EXPEDIENTE_DOCUMENTOS]
    /// directorioDatos: String que contiene la ruta a la carpeta donde se guardan los documentos.
    /// </summary>
    public class ProcesosUsuario
    {
        protected String nombreServidor = ConfigurationManager.AppSettings["server"];
        protected String nombreBD = ConfigurationManager.AppSettings["dbname"];
        public SQLConexion Conexion { get; }
        public UsuarioInfo Usuario { get; }
        private DatosArchivo datosArchivo=null;
        List<int> registroId = new List<int>();
        List<int> documentoDigId = new List<int>();
        private String directorioDatos = ConfigurationManager.AppSettings["savepath"];//Directorio en donde se guardaran los archivos

        public ProcesosUsuario(UsuarioInfo Usuario)
        {
            this.Usuario = Usuario;
            Conexion = new SQLConexion(nombreServidor, nombreBD, this.Usuario.NombreUsuario, this.Usuario.Contraseña);
        }

        /// <summary>
        /// Meotodo que inicia la conexion con SQL Server, envia todos los parametros de usuario.
        /// </summary>
        /// <returns>Verdadero si la conexion se inicio, falso de lo contrario</returns>
        public bool IniciarSesion()
        {
            if (Conexion.AbrirConexion().Estado)
            {
                int userID = 0;
                try {
                    SqlDataReader dataReader = Conexion.EjecutarConsulta("Execute SP_DIG_VALIDAR_USUARIO '" + Usuario.NombreUsuario + "\', '" + Usuario.Contraseña + "'").Resultado;
                    if (dataReader.HasRows && dataReader.Read())
                    {
                        userID = dataReader.GetInt32(0);
                        Usuario.IdArea = dataReader.GetInt32(1); //Se recibe el ID de area, (Descomentar en cuanto el procedure lo retorne. DESCOMENTAR
                        Usuario.Administrador = dataReader.GetBoolean(2); // Se recibe si es admin o no.
                        Usuario.Nombre = dataReader.GetString(3);
                        Usuario.ApellidoPaterno = dataReader.GetString(4);
                        Usuario.ApellidoMaterno = dataReader.GetString(5);
                        Usuario.Dios = dataReader.GetBoolean(6);
                        dataReader.Close();
                        //Validacion de datos
                        if (userID == Usuario.Id)
                            return true; //Verdadero en caso de login correcto
                        else return false;
                    }
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Metodo que permite llenar el DataGridStyle que se ubica en la pantalla principal
        /// </summary>
        /// <param name="origenTabla">DataGridStyle de origen, sera vaciado y rellenado</param>
        /// <param name="completado">Indica si los registros deben estar completados o no</param>
        /// <param name="filtro">Undica si se filtrara eb la busqueda de la BD</param>
        /// <param name="clave">Palabra para incluir en el filtro</param>
        /// <returns>El mismo DataGridStyle pero con datos</returns>
        public Entidades.DataGridStyle LlenarTablaExpedientesPendientes(Entidades.DataGridStyle origenTabla, bool completado, int filtro, string clave)
        {
            if (clave == null || clave == string.Empty)
                filtro = 0;
            registroId.Clear();
            origenTabla.Rows.Clear();
            SQLEstado sQLEstado;
            sQLEstado = completado ? Conexion.EjecutarConsulta("Execute SP_DIG_OBTENER_DATOS_EXPEDIENTE " + Usuario.IdArea + ", 1, "+filtro+", '"+clave+"'") : Conexion.EjecutarConsulta("Execute SP_DIG_OBTENER_DATOS_EXPEDIENTE " + Usuario.IdArea + ", 0, " + filtro + ", '" + clave + "'");

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

        /// <summary>
        /// Meotodo que llena la tabla de documentos pendientes de digitalizar
        /// </summary>
        /// <param name="origenTabla">DataGridStyle de origen, sera vaciado y rellenado</param>
        /// <param name="expediente">ID del expediente al que deben perdenecer los documentos</param>
        /// <param name="completado">Indica si los documentos a mostrarse deben estar completados o no</param>
        /// <returns></returns>
        public Entidades.DataGridStyle LlenarTablaDocumentosPendientes(Entidades.DataGridStyle origenTabla, int expediente, bool completado)
        {
            documentoDigId.Clear();
            origenTabla.Rows.Clear();
            SQLEstado sQLEstado;
            sQLEstado = completado ? Conexion.EjecutarConsulta("Execute SP_DIG_OBTENER_DOC_PENDIENTES " + expediente + ", 1") : Conexion.EjecutarConsulta("Execute SP_DIG_OBTENER_DOC_PENDIENTES " + expediente + ", 0");

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

        /// <summary>
        /// Metodo que regresa el Id del registro acorde a su posicion en el combo box
        /// </summary>
        /// <param name="index">Indice de la la posicion de combo</param>
        /// <returns>ID del registro</returns>
        public int ObtenerRegistroId(int index)
        {
            return registroId[index];
        }

        /// <summary>
        /// Actualiza en la BD si el documento esta digitalizado o no
        /// </summary>
        /// <param name="rowIndex">Indice de posicion en el DataGridStyle</param>
        /// <param name="digitalizado">Booleano que indica el estado de digitalizado</param>
        /// <returns>Regresa un boleano que indica si la operacion fue exitosa</returns>
        public bool ActualizarDigitalizado(int rowIndex, bool digitalizado)
        {
            Console.WriteLine(digitalizado);
            return Conexion.EjecutarSentencia("Execute SP_DIG_ACTUALIZAR_DIGITALIZADO " + (digitalizado ? 1 : 0) +", "+ documentoDigId[rowIndex]).Estado;
        }

        /// <summary>
        /// Metodo que lee el archivo y lo escribe en la carpeta de documentos.
        /// </summary>
        /// <param name="pathArchivo">Directorio del archivo.</param>
        /// <returns>Booleano que indica si la operacion fue correcta.</returns>
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

        /// <summary>
        /// Metodo que copia el archivo secundario para realizar un merge de archivos
        /// </summary>
        /// <param name="pathArchivo">URL donde se encuentra el archivo</param>
        /// <returns>Booleano que indica si la operacion se realizo de manera correcta</returns>
        public bool CopiarArchivoTemporal(String pathArchivo)
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
                using (FileStream destinoDocumento = new FileStream(datosArchivo.Ruta + "\\" + datosArchivo.NombreArchivo + ".temp", FileMode.Create, FileAccess.Write))
                {
                    destinoDocumento.Write(bytes, 0, numeroBytes);
                }
            }
            return false;
        }

        /// <summary>
        /// Metodo que elimina un archivo de un directorio
        /// </summary>
        /// <returns>Booleano que indica si la operacion se realizo de manera correcta</returns>
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

        /// <summary>
        /// Metodo que construye una ruta do documento basandode en los datos del documento que se debe escanear
        /// </summary>
        /// <param name="row">Posicion del documento en el DataGridStyle</param>
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

        /// <summary>
        /// Metodo que hace bisible el plugin Adobe Reader para la visualizacion de documentos PDF
        /// </summary>
        /// <param name="axAcroPDF">Instancia que se mostrara</param>
        /// <returns>Booleano que indica si la operacion se realizo de manera correcta</returns>
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
        
        /// <summary>
        /// Cuenta los caracteres de una cadena para evitar que sea mayor a 100 caracteres
        /// </summary>
        /// <param name="cadena">Cadena a validar</param>
        /// <returns>Retorna falso si la cadena en menor a 100 caracteres, verdadero si es mayor</returns>
        public bool ValidarLongitudCadena(string cadena)
        {
            return cadena.Length > 100 ? false : true;
        }

        /// <summary>
        /// Metodo que realiza una bisqueda dentro de toda la informacion de un DataGridStyle,
        /// oculta las filas que no tienen ninguna coincidencia con un texto dado.
        /// </summary>
        /// <param name="dgv">DataGridStyle en el que se buscata</param>
        /// <param name="txbB">TextBox que contoene el texto que se debe buscar.</param>
        public void Buscar(DataGridStyle dgv, TextBox txbB)
        {
            int rows = dgv.RowCount;
            bool[] crows;
            crows = new bool[rows];
            for (int i = 0; i < dgv.RowCount; i++)
            {
                crows[i] = false;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv[j, i].Value.ToString().ToLower().Contains(txbB.Text.ToLower()))
                    {
                        crows[i] = true;
                    }
                }
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Visible = crows[i];
            }
        }
        
        /// <summary>
        /// Metodo para unir dos documentos PDF
        /// </summary>
        /// <param name="archivoNuevo">URL del archivo secundario</param>
        public void MergeDocs(string archivoNuevo)
        {
            CopiarArchivoTemporal(archivoNuevo);
            string archivoExistente= datosArchivo.Ruta + "\\" + datosArchivo.NombreArchivo;
            using (PdfDocument docUno = PdfReader.Open(archivoExistente, PdfDocumentOpenMode.Import))
            using (PdfDocument docDos = PdfReader.Open(archivoExistente+".temp", PdfDocumentOpenMode.Import))
            using (PdfDocument DocNew = new PdfDocument())
            {
                CopiarDocumentos(docUno, DocNew);
                CopiarDocumentos(docDos, DocNew);

                DocNew.Save(archivoExistente);
            }

            void CopiarDocumentos(PdfDocument docFuente, PdfDocument docDestino)
            {
                for (int i = 0; i < docFuente.PageCount; i++)
                {
                    docDestino.AddPage(docFuente.Pages[i]);
                }
            }
        }

        /// <summary>
        /// Metodo que permite seleccionar el documento que se unira al principal
        /// </summary>
        /// <param name="actual">Id del documento actual</param>
        /// <returns>Booleano que indica si la operacion se realizo de manera correcta</returns>
        public bool MezclarDocumento(int actual)
        {
            OpenFileDialog fuente = new OpenFileDialog { Filter = " Archivos PDF(*.pdf)|*.pdf" };
            if (fuente.ShowDialog() == DialogResult.OK)
            {
                string source = fuente.FileName;
                MergeDocs(source);
                fuente.Dispose();
                return true;
            }
            else
            {
                fuente.Dispose();
                return false;
            }
        }
    }
}
