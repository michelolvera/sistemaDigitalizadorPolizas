using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La entidad DocumentosInfo permite manejar la información de los documentos de forma mas cómoda 
    /// PosIndex: Contiene el indice del documento
    /// Nombre: Contiene el nombre del documento
    /// Activo: Permite saber si el documento esta activo
    /// CatIndex: Contiene en indice de la categoría
    /// </summary>
    public class DocumentosInfo
    {
        public int PosIndex { get; }
        public string Nombre { get; }
        public bool Activo { get; }
        public int CatIndex { get; }

        public DocumentosInfo(int PosIndex, string Nombre, bool Activo, int CatIndex)
        {
            this.PosIndex = PosIndex;
            this.Nombre = Nombre;
            this.Activo = Activo;
            this.CatIndex = CatIndex;
        }

    }
}
