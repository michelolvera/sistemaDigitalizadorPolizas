using Entidades;
using System;
using System.Data.SqlClient;
namespace Acceso_a_Datos
{
    /// <summary>
    /// Clase que controla todas las conexiones a la base de datos, debe inicializarse con 
    /// dataSource: La direccion o nombre del servidor
    /// dataBase: Nombre de la base de datos
    /// user: nombre de usuario de la BD
    /// password: contraseña de la base de datos
    /// 
    /// Todos los metodos retornan un objeto SQLEstado que cuenta con toda la informacion
    /// sobre la consulta.
    /// </summary>
    public class SQLConexion
    {
        private string dataSource;//IP o Servidor local
        private string dataBase;//Nombre de la base de datos
        private string user;//Nombre de usuario
        private string password;//Contraseña de usuario
        public SqlConnection sqlConnection;//Conexion a SQL Server 2008

        public SQLConexion(string dataSource, string dataBase, string user, string password)
        {
            this.dataSource = dataSource;
            this.dataBase = dataBase;
            this.user = user;
            this.password = password;
        }

        /// <summary>
        /// Inicia una instancia de conexion a la base de datos. Retorna un objeto
        /// </summary>
        /// <returns>
        /// Retorna el objeto SQLEstado con el mensaje de conexión exitosa.
        /// Variable Estado=true cuando se realizo la conexión.
        /// </returns>
        public SQLEstado AbrirConexion()
        {
            string connetionString = "Data Source=" + dataSource + ";Initial Catalog=" + dataBase + ";User ID=" + user + ";Password=" + password;
            try
            {
                sqlConnection = new SqlConnection(connetionString);
                sqlConnection.Open();
                return new SQLEstado(true, null, "Instancia de conexion a base de datos iniciada");
            }catch(Exception ex)
            {
                return new SQLEstado(false, null, "Error conectando al servidor: " + dataSource + " - Mensaje de error: " + ex.Message);
            }
        }

        /// <summary>
        /// Cierra la instancia de conexion a la base de datos siempre y cuando esta no este abierta.
        /// </summary>
        /// <returns>Retorna el objeto SQLEstado con el mensaje de cerrado y Estado=true si se cerro
        /// de manera correcta.
        /// </returns>
        public SQLEstado CerrarConexion()
        {
            if (sqlConnection != null)
            {
                try
                {
                    sqlConnection.Close();
                }
                catch(Exception ex)
                {
                    return new SQLEstado(false, null, "Error al cerrar conexion - Mensaje de error: " + ex.Message);
                }
            }
            return new SQLEstado(true, null, "Conexion cerrada exitosamente", null);
        }

        /// <summary>
        /// Metodo que ejecuta una sentencia en la base de datos, este metodo no retorna
        /// informacion importante mas que si la sentencia fue correcta o no
        /// </summary>
        /// <param name="sentenciaSQL">El String que contiene la sentencia.</param>
        /// <returns>Un SQLEstado con solo la variable Estado</returns>
        public SQLEstado EjecutarSentencia(string sentenciaSQL)
        {
            SqlCommand sqlCommand;
            try
            {
                if (sqlConnection == null)
                {
                    AbrirConexion();
                }
                sqlCommand = new SqlCommand(sentenciaSQL, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return new SQLEstado(true, null, "Sentencia insertada con exito", null);
            }catch(Exception ex)
            {
                return new SQLEstado(false, null, "Error al ejecutar sentencia - Mensaje de error: " + ex.Message, null);
            }
        }

        /// <summary>
        /// Metodo que ejecuta una consulta en la base de datos
        /// </summary>
        /// <param name="consultaSQL">El String que contiene la consulta.</param>
        /// <returns>Un SQLEstado con todos sus valores llenos, incluye resultado,
        /// estado y mensaje
        /// </returns>
        public SQLEstado EjecutarConsulta(string consultaSQL)
        {
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            try
            {
                if (sqlConnection == null)
                {
                    AbrirConexion();
                }
                sqlCommand = new SqlCommand(consultaSQL, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
                SQLEstado estado = new SQLEstado(true, sqlDataReader, "Consulta generada con exito", null);
                return estado;
            }
            catch (Exception ex)
            {
                return new SQLEstado(false, null, "Error al ejecutar consulta - Mensaje de error: " + ex.Message, null);
            }
        }

    }
}
