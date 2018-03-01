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
        SQLEstado estado;
        //Listas de IDs
        List<int> areaId = new List<int>();
        List<int> categoriaId = new List<int>();
        List<int> expedienteId = new List<int>();
        List<int> documentoId = new List<int>();
        List<int> usuarioId = new List<int>();

        public ProcesosAdministrador(UsuarioInfo Usuario) : base (Usuario)
        {
            
        }

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
                    estado = Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_DOCUMENTO] "+categoriaId[documento.CatIndex]+", '" + documento.Nombre + "', " + Usuario.UserID + ",  " + documento.Activo + ";");
                }
                if (!estado.Estado)
                {
                    Console.WriteLine(estado.Mensaje);
                    return false;
                }
            }
            return true;
        }

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
                case 3:
                    usuarioId.Clear();
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_USUARIOS] ;");
                    break;
            }
            origenCombo.Items.Clear();
            if (estado.Estado)
            {
                while (estado.Resultado.HasRows && estado.Resultado.Read())
                {
                    origenCombo.Items.Add(estado.Resultado.GetString(0));
                    Console.WriteLine(estado.Resultado.GetString(0));
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
                        case 3:
                            usuarioId.Add(estado.Resultado.GetInt32(1));
                            break;
                    }
                }
                estado.Resultado.Close();
            }
            origenCombo.Enabled = true;
            return origenCombo;
        }

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

        public bool CrearNuevoRegistro(int opc, string nombre, int super, UsuarioInfo usuario, string contrasena)
        {
            switch (opc)
            {
                case 0: //Area
                    return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_AREAS] '" + nombre + "'").Estado;
                case 1: //Expediente
                    return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_EXPEDIENTES] " + areaId[super] + ",'" + nombre + "','" + Usuario.UserID + "'").Estado;
                case 2: //Categoria
                    return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_CATEGORIAS] " + expedienteId[super] + ",'" + nombre + "','" + Usuario.UserID + "'").Estado;
                case 3: //usuario
                    return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_AGREGAR_USUARIO] "+nombre+usuario.Nombre+usuario.ApellidoPaterno+usuario.ApellidoMaterno+contrasena+usuario.IdArea+usuario.EsAdmin+usuario.Dios+";").Estado;
            }
            return false;
        }

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

        public bool NuevoRegistroDefault(DataGridViewRowEventArgs Grid)
        {
            try {
                Grid.Row.Cells["NombreUsuario"].Value = Usuario.UserName;
                Grid.Row.Cells["FechaAlta"].Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                Grid.Row.Cells["Activo"].Value = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool RegistrarManual(string nombre, int categoria)
        {
            return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_REGISTRO_EXPEDIENTE] " + categoriaId[categoria] + ", '" + nombre + "', " + Usuario.UserID).Estado;
        }
        public List<string> listausuarios(ComboBox origenCombo)
        {
            List<string> listau = new List<string>();
            foreach (string item in origenCombo.Items)
            {
                listau.Add(item);
            }
            return listau;
        }
        public bool estaEnUSusarios(int idUsusario)
        {
            if (usuarioId.Exists(id => id == idUsusario))
                return true;
            else
                return false;
        }

        public UsuarioInfo UsuarioSeleccionado(UsuarioInfo uSeleccionado)
        {
            estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_USUARIO_SELECCIONADO] " + uSeleccionado.UserName);
            uSeleccionado.IdArea = estado.Resultado.GetInt32(4);
            uSeleccionado.Nombre = estado.Resultado.GetString(0);
            uSeleccionado.ApellidoPaterno = estado.Resultado.GetString(2);
            uSeleccionado.ApellidoMaterno = estado.Resultado.GetString(3);
            uSeleccionado.EsAdmin = estado.Resultado.GetBoolean(5);
            uSeleccionado.Dios = estado.Resultado.GetBoolean(6);
            return uSeleccionado;
        }
        
        public string obtenerArea(int idArea)
        {
            string area;
            estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_AREA_ID] " + idArea);
            if (estado.Resultado.HasRows && estado.Resultado.Read()){
                area = estado.Resultado.GetString(0);
            }
            else
            {
                area = "Area de usuario inexistente";
            }
            return area;
        }
        public bool actualizarUsuario()
        {
            return true;
        }
    }
}
