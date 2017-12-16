using Acceso_a_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_Negocio
{
    public class ProcesosAdministrador : ProcesosUsuario
    {
        public ProcesosAdministrador(UsuarioInfo Usuario) : base(Usuario)
        {
            //Constructor vacio que inicializa el SuperConstructor de la clase Base
        }
    }
}
