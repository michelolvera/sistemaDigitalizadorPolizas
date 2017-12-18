using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SQLEstado
    {
        public bool Estado { get; }
        public SqlDataReader Resultado { get; }
        public string Mensaje { get; }
        public SqlDataAdapter Tabla { get; }

        public SQLEstado(bool Estado, SqlDataReader Resultado, string Mensaje, SqlDataAdapter Tabla)
        {
            this.Estado = Estado;
            this.Resultado = Resultado;
            this.Mensaje = Mensaje;
            this.Tabla = Tabla;
        }
    }
}
