using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_Negocio
{
    public class SQLConexion
    {
        string dataSource;//IP o Servidor local
        string dataBase;//Nombre de la base de datos
        string user;//Nombre de usuario
        string password;//Contraseña de usuario
        SqlConnection sqlConnection;//Conexion a SQL Server
        SQLConexion(string dataSource, string dataBase, string user, string password)
        {
            this.dataSource = dataSource;
            this.dataBase = dataBase;
            this.user = user;
            this.password = password;
        }

        bool abrirConexion()
        {
            string connetionString = "Data Source=" + dataSource + ";Initial Catalog=" + dataBase + ";User ID=" + user + ";Password=" + password;
            try
            {
                sqlConnection = new SqlConnection(connetionString);
                sqlConnection.Open();
                Console.WriteLine("Instancia de conexion a base de datos iniciada");
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine("Error conectando al servidor: "+dataSource +" - Mensaje de error: "+ex.Message);
                return false;
            }
        }

        bool cerrarConexion()
        {
            if (sqlConnection != null)
            {
                try
                {
                    sqlConnection.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error al cerrar conexion - Mensaje de error: " + ex.Message);
                    return false;
                }
            }
            Console.WriteLine("Conexion cerrada exitosamente");
            return true;
        }

        bool ejecutarSentencia(string sentenciaSQL)
        {
            SqlCommand sqlCommand;
            try
            {
                if (sqlConnection == null)
                {
                    abrirConexion();
                }
                sqlCommand = new SqlCommand(sentenciaSQL, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine("Error al ejecutar sentencia - Mensaje de error: " + ex.Message);
                return false;
            }
        }

        SqlDataReader ejecutarConsulta(string consultaSQL)
        {
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            try
            {
                if (sqlConnection == null)
                {
                    abrirConexion();
                }
                sqlCommand = new SqlCommand(consultaSQL, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
                return sqlDataReader;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar consulta - Mensaje de error: " + ex.Message);
                return null;
            }
        }
    }
}
