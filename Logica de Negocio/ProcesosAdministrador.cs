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
    /// <summary>
    /// La clase procesos administrador que extiende de procesos usuario
    /// contiene todos los metodos y procesos necesarios para la administracion
    /// </summary>
    public class ProcesosAdministrador : ProcesosUsuario
    {
        protected SQLEstado estado;
        //Listas de IDs
        protected List<int> areaId = new List<int>();
        protected List<int> categoriaId = new List<int>();
        protected List<int> expedienteId = new List<int>();
        private List<int> documentoId = new List<int>();

        public ProcesosAdministrador(UsuarioInfo Usuario) : base (Usuario)
        {
            
        }

        /// <summary>
        /// Llena un DataGridView, extrallendo los datos desde SQLServer
        /// </summary>
        /// <param name="origenTabla">Tabla origen que sera llenada</param>
        /// <param name="index">Indice de la categoria seleccionada</param>
        /// <returns>Tabla llena con datos.</returns>
        public DataGridStyle ObtenerTablaDocumentos(DataGridStyle origenTabla, int index)
        {
            documentoId.Clear();
            origenTabla.Rows.Clear();
            estado = Conexion.EjecutarConsulta("EXECUTE SP_DIG_OBTENER_DOCUMENTOS " + categoriaId[index]);
            if (estado.Estado)
            {
                //Llenar tabla
                while (estado.Resultado.HasRows && estado.Resultado.Read())
                {
                    origenTabla.Rows.Add(estado.Resultado.GetString(0), estado.Resultado.GetString(1), estado.Resultado.GetDateTime(2).ToString("dd/MM/yyyy HH:mm:ss"), estado.Resultado.GetBoolean(3));
                    documentoId.Add(estado.Resultado.GetInt32(4));
                }

                estado.Resultado.Close();
                //Bloquear Columnas no Editables
                origenTabla.Columns["NombreUsuario"].ReadOnly = true;
                origenTabla.Columns["FechaAlta"].ReadOnly = true;
                return origenTabla;
            }
            return null;
        }

        /// <summary>
        /// Envia todos los documentos que se han editado a la Base de datos.
        /// </summary>
        /// <param name="documentosEditados">Lista de documentos que se han editado</param>
        /// <returns>Verdadero si todos los cambios se han guardado, falso si no es asi.</returns>
        public bool ActualizarTablaDocumentos(List<DocumentosInfo> documentosEditados)
        {
            foreach (DocumentosInfo documento in documentosEditados)
            {
                if (documento.PosIndex <= documentoId.Count - 1)
                {
                    //Update del registro
                    estado = Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_ACTUALIZAR_TBL_DOCUMENTO] '" + documento.Nombre + "', " + documento.Activo + ", " + documentoId[documento.PosIndex]);
                }
                else
                {
                    //Insert del nuevo registro
                    estado = Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_DOCUMENTO] "+categoriaId[documento.CatIndex]+", '" + documento.Nombre + "', " + Usuario.Id + ",  " + documento.Activo + ";");
                }
                if (!estado.Estado)
                {
                    Console.WriteLine(estado.Mensaje);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Llena un combo con los datos solicitados
        /// </summary>
        /// <param name="origenCombo">Combo que se va a llenar</param>
        /// <param name="opc">Elige que tipo de dato usara el combo.</param>
        /// <param name="index">Indice del combo superior para saber que id buscar</param>
        /// <returns></returns>
        public ComboBox LlenarCombo(ComboBox origenCombo, int opc, int index)
        {
            switch (opc)
            {
                case 0:
                    areaId.Clear();
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_AREAS];");
                    break;
                case 1:
                    expedienteId.Clear();
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_EXPEDIENTES_AREA] " + areaId[index] + ";");
                    break;
                case 2:
                    categoriaId.Clear();
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_CATEGORIA_EXPEDIENTE] " + expedienteId[index] + ";");
                    break;
            }
            origenCombo.Items.Clear();
            if (estado.Estado)
            {
                while (estado.Resultado.HasRows && estado.Resultado.Read())
                {
                    origenCombo.Items.Add(estado.Resultado.GetString(0));
                    switch (opc)
                    {
                        case 0:
                            areaId.Add(estado.Resultado.GetInt32(1));
                            break;
                        case 1:
                            expedienteId.Add(estado.Resultado.GetInt32(1));
                            break;
                        case 2:
                            categoriaId.Add(estado.Resultado.GetInt32(1));
                            break;
                    }
                }
                estado.Resultado.Close();
            }
            origenCombo.Enabled = true;
            return origenCombo;
        }

        /// <summary>
        /// Obtiene estado activo de cada area, expediente o categoria.
        /// </summary>
        /// <param name="opc">Define si sera area, expediente o categoria.</param>
        /// <param name="index">Indice del combo superior para buscar ID</param>
        /// <returns>Verdadero si esta activa, falso si no.</returns>
        public bool GetActivo(int opc, int index)
        {
            switch (opc)
            {
                case 0:
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_AREAS_ACTIVAS] " + areaId[index] + ";");
                    break;
                case 1:
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_EXPEDIENTES_ACTIVOS] " + expedienteId[index] + ";");
                    break;
                case 2:
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_DIGCATEGORIAS_ACTIVOS] " + categoriaId[index] + ";");
                    break;
            }
            if (estado.Estado && estado.Resultado.HasRows && estado.Resultado.Read())
            {
                bool activo = estado.Resultado.GetBoolean(0);
                estado.Resultado.Close();
                return activo;
            }
            else return false;
        }

        /// <summary>
        /// Crea un area, expediente o categoria en la base de datos.
        /// </summary>
        /// <param name="opc">area, expediente o categoria</param>
        /// <param name="nombre">String del nombre del elemento a crear</param>
        /// <param name="super">indice del combo superior.</param>
        /// <returns>Verdadero si se creo correctamente, falso si no.</returns>
        public bool CrearNuevoRegistro(int opc, string nombre, int super)
        {
            switch (opc)
            {
                case 0: //Area
                    return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_AREAS] '" + nombre + "'").Estado;
                case 1: //Expediente
                    return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_EXPEDIENTES] " + areaId[super] + ",'" + nombre + "','" + Usuario.Id + "'").Estado;
                case 2: //Categoria
                    return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_CATEGORIAS] " + expedienteId[super] + ",'" + nombre + "','" + Usuario.Id + "'").Estado;
            }
            return false;
        }

        /// <summary>
        /// Cambia el estado activo de un area, expediente o categoria.
        /// </summary>
        /// <param name="opc">area, expediente o categoria</param>
        /// <param name="index">Indice para obtener el ID a modificar</param>
        /// <param name="activo">Indica si se activara o desactivara</param>
        /// <returns>Verdadero si se modifico de manera correcta, falso si no.</returns>
        public bool ActivarDesactivar(int opc, int index, bool activo)
        {
            int envio = 0;
            if (activo)
                envio = 1;
            switch (opc)
            {
                case 0: return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_ACTUALIZAR_TBL_AREAS] " + envio + ", " + areaId[index] + ";").Estado;
                case 1: return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_ACTUALIZAR_TBL_EXPEDIENTES] " + envio + ", " + expedienteId[index] + ";").Estado;
                case 2: return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_ACTUALIZAR_TBL_CATEGORIAS] " + envio + ", " + categoriaId[index] + ";").Estado;
            }
            return false;
        }

        /// <summary>
        /// Crea valores predeterminados para el data grid view
        /// </summary>
        /// <param name="Grid">Fila a crear.</param>
        /// <returns>Verdadero si se creo de manera correcta.</returns>
        public bool NuevoRegistroDefault(DataGridViewRowEventArgs Grid)
        {
            try {
                Grid.Row.Cells["NombreUsuario"].Value = Usuario.NombreUsuario;
                Grid.Row.Cells["FechaAlta"].Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                Grid.Row.Cells["Activo"].Value = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Inserta un registro de expediente de manera manual.
        /// </summary>
        /// <param name="nombre">Identificador del registro</param>
        /// <param name="categoria">Indice de la categoria donde se creara el registro para obtener el ID.</param>
        /// <returns>Verdadero si se modifico de manera correcta, falso si no.</returns>
        public bool RegistrarManual(string nombre, int categoria)
        {
            return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_REGISTRO_EXPEDIENTE] " + categoriaId[categoria] + ", '" + nombre + "', " + Usuario.Id).Estado;
        }
        
        /// <summary>
        /// Obtener el ID del Area en base a su indice en un combo box
        /// </summary>
        /// <param name="idArea">Indice del combo box</param>
        /// <returns>ID de area</returns>
        public int ObtenerIndexArea(int idArea)
        {
            return areaId.FindIndex(delegate (int id) { return id == idArea; });
        }
    }
}
