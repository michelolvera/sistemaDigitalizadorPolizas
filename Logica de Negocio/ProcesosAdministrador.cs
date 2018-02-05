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
        int categoriaID = 0;
        public ProcesosAdministrador(UsuarioInfo Usuario) : base (Usuario)
        {
            
        }

        public DataGridStyle ObtenerTablaDocumentos(DataGridStyle origenTabla, string seleccionado)
        {
           
            //Obetner ID de categoria
            SQLEstado estado = Conexion.EjecutarConsulta("SELECT id_categoria FROM dbo.TBL_DIG_CATEGORIAS WHERE nombre_categoria='" + seleccionado + "';");
            if (estado.Estado && estado.Resultado.HasRows && estado.Resultado.Read())
            {
                categoriaID = estado.Resultado.GetInt32(0);
                estado.Resultado.Close();
            }
                
            estado = Conexion.ObtenerTabla("SELECT * FROM dbo.TBL_DIG_DOCUMENTOS_CATEGORIA WHERE id_categoria = "+ categoriaID +";");
            if (estado.Estado)
            {
                origenTabla.DataSource = bindingSource;
                bindingSource.DataSource = SqlAdministrador.SQLTablaDocumentos(estado.Tabla);
                //Bloquear Celdas no Editables
                origenTabla.Columns["id_documento"].ReadOnly = true;
                origenTabla.Columns["id_categoria"].ReadOnly = true;
                origenTabla.Columns["id_usuario"].ReadOnly = true;
                origenTabla.Columns["fecha_alta"].ReadOnly = true;
                return origenTabla;
            }
            return null;
        }

        public bool ActualizarTablaDocumentos()
        {
            return SqlAdministrador.UpdateTablaDocumentos(bindingSource);
        }

        public ComboBox LlenarComboArea(ComboBox origenCombo, int opc, string seleccionado)
        {
            switch (opc)
            {
                case 0:
                    estado = Conexion.EjecutarConsulta("SELECT nombre_area FROM dbo.TBL_DIG_AREAS;");
                    break;
                case 1:
                    estado = Conexion.EjecutarConsulta("SELECT nombre_expediente FROM dbo.TBL_DIG_EXPEDIENTES INNER JOIN dbo.TBL_DIG_AREAS ON dbo.TBL_DIG_EXPEDIENTES.id_area=dbo.TBL_DIG_AREAS.id_area WHERE nombre_area='"+ seleccionado + "';");
                    break;
                case 2:
                    estado = Conexion.EjecutarConsulta("SELECT nombre_categoria FROM dbo.TBL_DIG_CATEGORIAS INNER JOIN dbo.TBL_DIG_EXPEDIENTES ON dbo.TBL_DIG_CATEGORIAS.id_expediente=dbo.TBL_DIG_EXPEDIENTES.id_expediente WHERE nombre_expediente='"+ seleccionado + "';");
                    break;
            }
            origenCombo.Items.Clear();
            if (estado.Estado)
            {
                SqlDataReader sqlDataReader = estado.Resultado;
                while (sqlDataReader.HasRows && sqlDataReader.Read())
                {
                    origenCombo.Items.Add(sqlDataReader.GetString(0));
                }
                estado.Resultado.Close();
            }
            origenCombo.Items.Add("< Nuevo >");
            origenCombo.Enabled = true;
            return origenCombo;
        }

        public bool GetActivo(int opc, string seleccionado)
        {
            switch (opc)
            {
                case 0:
                    estado = Conexion.EjecutarConsulta("SELECT activo FROM dbo.TBL_DIG_AREAS WHERE nombre_area='"+seleccionado+"';");
                    break;
                case 1:
                    estado = Conexion.EjecutarConsulta("SELECT activo FROM dbo.TBL_DIG_EXPEDIENTES WHERE nombre_expediente='" + seleccionado + "';");
                    break;
                case 2:
                    estado = Conexion.EjecutarConsulta("SELECT activo FROM dbo.TBL_DIG_CATEGORIAS WHERE nombre_categoria='" + seleccionado + "';");
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

        public bool CrearNuevoRegistro(int opc, string nombre, string super)
        {
            SQLEstado estado;
            switch (opc)
            {
                case 0: //Area
                    return Conexion.EjecutarSentencia("INSERT INTO dbo.TBL_DIG_AREAS (nombre_area,activo) VALUES('"+nombre+"',1)").Estado;
                case 1: //Expediente
                    int areaID = 0;
                    //Obetner ID de area
                    estado = Conexion.EjecutarConsulta("SELECT id_area FROM dbo.TBL_DIG_AREAS WHERE nombre_area='" + super + "';");
                    if (estado.Estado && estado.Resultado.HasRows && estado.Resultado.Read())
                    {
                        areaID = estado.Resultado.GetInt32(0);
                        estado.Resultado.Close();
                    }
                    return Conexion.EjecutarSentencia("INSERT INTO dbo.TBL_DIG_EXPEDIENTES (id_area, nombre_expediente, id_usuario, fecha_alta, activo) VALUES("+areaID+",'"+nombre+"','"+Usuario.UserID+"',CURRENT_TIMESTAMP,1)").Estado;
                case 2: //Categoria
                    int expedienteID = 0;
                    estado = Conexion.EjecutarConsulta("SELECT id_expediente FROM dbo.TBL_DIG_EXPEDIENTES WHERE nombre_expediente='" + super + "';");
                    if (estado.Estado && estado.Resultado.HasRows && estado.Resultado.Read())
                    {
                        expedienteID = estado.Resultado.GetInt32(0);
                        estado.Resultado.Close();
                    }
                    return Conexion.EjecutarSentencia("INSERT INTO dbo.TBL_DIG_CATEGORIAS(id_expediente, nombre_categoria, id_usuario, fecha_alta, activo) VALUES(" + expedienteID + ",'" + nombre + "','" + Usuario.UserID + "',CURRENT_TIMESTAMP,1)").Estado;
            }
            return false;
        }

        public bool ActivarDesactivar(int opc, string nombre, bool activo)
        {
            int envio = 0;
            if (activo)
                envio = 1;
            switch (opc)
            {
                case 0: return Conexion.EjecutarSentencia("UPDATE dbo.TBL_DIG_AREAS SET activo = "+ envio + " WHERE nombre_area='"+nombre+"';").Estado;
                case 1: return Conexion.EjecutarSentencia("UPDATE dbo.TBL_DIG_EXPEDIENTES SET activo = " + envio + " WHERE nombre_expediente='" + nombre + "';").Estado;
                case 2: return Conexion.EjecutarSentencia("UPDATE dbo.TBL_DIG_CATEGORIAS SET activo = " + envio + " WHERE nombre_categoria='" + nombre + "';").Estado;
            }
            return false;
        }

        public bool NuevoRegistroDefault(DataGridViewRowEventArgs Grid)
        {
            try {
                Grid.Row.Cells["id_documento"].Value = 1;
                Grid.Row.Cells["id_categoria"].Value = categoriaID;
                //Grid.Row.Cells["nombre_documento"].Value = "";
                Grid.Row.Cells["id_usuario"].Value = Usuario.UserID;
                Grid.Row.Cells["fecha_alta"].Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                Grid.Row.Cells["activo"].Value = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

    }
}
