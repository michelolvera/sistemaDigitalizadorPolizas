using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInfo
    {
        public string nombre { get; private set; }
        public string apellidoP { get; private set; }
        public string apellidoM { get; private set; }
        public string userName { get; private set; }
        public string userPassword { get; private set; }
        public UsuarioInfo(string nombre, string apellidoP, string apellidoM, string userName, string userPassword)
        {
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.userName = userName;
            this.userPassword = userPassword;
        }

        
    }
}
