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
    class SQLFormat
    {
        //Direccion de servidor
        private String nombreServidor = ConfigurationManager.AppSettings["server"];
        private String nombreBD = ConfigurationManager.AppSettings["dbname"];
        SQLConexion conexion;
        UsuarioInfo Usuario;
        SQLFormat(UsuarioInfo Usuario)
        {
            this.Usuario = Usuario;
            conexion = new SQLConexion(nombreServidor, nombreBD, this.Usuario.UserName, this.Usuario.UserPassword);
        }

        bool IniciarSesion()
        {
            if (conexion.AbrirConexion().Estado)
            {
                SqlDataReader dataReader = conexion.EjecutarConsulta("").Resultado;//Aqui llamar a procedure que regresara resultado de inicio de sesion
                conexion.CerrarConexion();
                //Validacion de datos


                return true; //Verdadero en caso de login correcto
                
            }
            return false;
        }

    }
}
