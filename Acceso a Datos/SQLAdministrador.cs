using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_a_Datos
{
    public class SQLAdministrador
    {
        public SqlCommandBuilder sqlCommandBuilder;
        public SqlDataAdapter dataAdapter;

        public DataTable SQLTablaDocumentos(SqlDataAdapter Tabla)
        {
            dataAdapter = Tabla;
            sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable
            {
                Locale = System.Globalization.CultureInfo.InvariantCulture
            };
            dataAdapter.Fill(table);
            return table;
        }

        public bool UpdateTablaDocumentos(BindingSource bindingSource)
        {
            if (dataAdapter.Update((System.Data.DataTable)bindingSource.DataSource) == 0)
            {
                return false;
            }
            return true;
        }
    }

}
