using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DocumentosInfo
    {
        public int PosIndex { get; }
        public string Nombre { get; }
        public bool Activo { get; }

        public DocumentosInfo(int PosIndex, string Nombre, bool Activo)
        {
            this.PosIndex = PosIndex;
            this.Nombre = Nombre;
            this.Activo = Activo;
        }

    }
}
