using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La entidad DatosAchivo es utilizada para gestionar rutas y archivos 
    /// Ruta: Permite construir y consultar la ruta de algún archivo
    /// NombreArchivo: Permite asignar y consultar el nombre de un archivo
    /// </summary> 
    public class DatosArchivo
    {
        public string Ruta { get; set; }
        public string NombreArchivo { get; set; }
    }
}
