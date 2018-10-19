using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que contiene los datos obtenidos en la base de datos, las variables son:
    /// Estado: Permite saber si la sentencia se ejecuto de manera correcta
    /// Resultado: Contiene todos los elementos retornados por un SELECT
    /// Mensaje: Mensaje de ayuda sobre la consulta
    /// </summary>
    public class SQLEstado
    {
        public bool Estado { get; }
        public SqlDataReader Resultado { get; }
        public string Mensaje { get; }

        public SQLEstado(bool Estado, SqlDataReader Resultado, string Mensaje)
        {
            this.Estado = Estado;
            this.Resultado = Resultado;
            this.Mensaje = Mensaje;
        }
    }
}
