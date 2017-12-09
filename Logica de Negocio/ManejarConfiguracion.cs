using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Logica_de_Negocio
{
    public class ManejarConfiguracion
    {
        public string ObtenerConfiguracionPorNombre(string nombre)
        {
            return ConfigurationManager.AppSettings[nombre];
        }
    }
}
