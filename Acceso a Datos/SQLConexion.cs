using Entidades;
using System;
using System.Data.SqlClient;
namespace Acceso_a_Datos
{
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
            return new SQLEstado(true, null, "Conexion cerrada exitosamente");
        }

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
                return new SQLEstado(true, null, "Sentencia insertada con exito");
            }catch(Exception ex)
            {
                return new SQLEstado(false, null, "Error al ejecutar sentencia - Mensaje de error: " + ex.Message);
            }
        }

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
                return new SQLEstado(true, sqlDataReader, "Consulta generada con exito");
            }
            catch (Exception ex)
            {
                return new SQLEstado(false, null, "Error al ejecutar consulta - Mensaje de error: " + ex.Message);
            }
        }
    }
}
