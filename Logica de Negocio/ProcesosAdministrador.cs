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
                    estado = Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_DOCUMENTO] 1, '" + documento.Nombre + "', " + Usuario.UserID + ",  " + documento.Activo + ";");
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

        public bool CrearNuevoRegistro(int opc, string nombre, int super)
        {
            switch (opc)
            {
                case 0: //Area
                    return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_DIGAREAS] '" + nombre + "'").Estado;
                case 1: //Expediente
                    return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_EXPEDIENTES] " + areaId[super] + ",'" + nombre + "','" + Usuario.UserID + "'").Estado;
                case 2: //Categoria
                    return Conexion.EjecutarSentencia("EXECUTE [dbo].[SP_DIG_INSERTAR_TBL_CATEGORIAS] " + expedienteId[super] + ",'" + nombre + "','" + Usuario.UserID + "'").Estado;
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
                case 0: return Conexion.EjecutarSentencia("UPDATE dbo.TBL_DIG_AREAS SET activo = "+ envio + " WHERE id_area="+areaId[index]+";").Estado;
                case 1: return Conexion.EjecutarSentencia("UPDATE dbo.TBL_DIG_EXPEDIENTES SET activo = " + envio + " WHERE id_expediente=" + expedienteId[index] + ";").Estado;
                case 2: return Conexion.EjecutarSentencia("UPDATE dbo.TBL_DIG_CATEGORIAS SET activo = " + envio + " WHERE id_categoria=" + categoriaId[index] + ";").Estado;
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
            return Conexion.EjecutarSentencia("INSERT INTO dbo.TBL_DIG_REGISTRO_EXPEDIENTE VALUES ("+categoriaId[categoria]+",'"+nombre+"', CURRENT_TIMESTAMP, "+Usuario.UserID+", 0);").Estado;
        }

    }
}
