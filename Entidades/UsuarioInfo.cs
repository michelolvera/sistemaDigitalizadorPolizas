using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInfo
    {
        public string Nombre { get; private set; }
        public string ApellidoP { get; private set; }
        public string ApellidoM { get; private set; }
        public string UserName { get; private set; }
        public string UserPassword { get; private set; }
        public UsuarioInfo(string Nombre, string ApellidoP, string ApellidoM, string UserName, string UserPassword)
        {
            this.Nombre = Nombre;
            this.ApellidoP = ApellidoP;
            this.ApellidoM = ApellidoM;
            this.UserName = UserName;
            this.UserPassword = UserPassword;
        }
    }
}
