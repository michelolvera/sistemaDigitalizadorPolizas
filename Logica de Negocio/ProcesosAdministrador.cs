﻿using Acceso_a_Datos;
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
        public ProcesosAdministrador(UsuarioInfo Usuario) : base (Usuario)
        {
            
        }

        public DataGridView ObtenerTablaDocumentos(DataGridView origenTabla, string seleccionado)
        {
            int categoriaID = 0;
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

    }
}
