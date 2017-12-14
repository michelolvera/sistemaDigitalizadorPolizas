using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{   //Comunicacion y formateo de datos con SQL Server 2008
    class SQLFormat
    {
        //Direccion de servidor
        private String nombreServidor = ConfigurationManager.AppSettings["server"];
        private String nombreBD = "digitalizador_procesos";
        SQLConexion conexion;
        UsuarioInfo Usuario;
        SQLFormat(UsuarioInfo Usuario)
        {
            this.Usuario = Usuario;
            conexion = new SQLConexion(nombreServidor, nombreBD, this.Usuario.UserName, this.Usuario.UserPassword);
        }

        bool iniciarSesion()
        {
            if (conexion.AbrirConexion())
            {
                SqlDataReader dataReader = conexion.EjecutarConsulta("");//Aqui llamar a procedure que regresara resultado de inicio de sesion
                conexion.CerrarConexion();

                //Validacion de datos


                return true; //Verdadero en caso de login correcto
                
            }
            return false;
        }

    }
}
