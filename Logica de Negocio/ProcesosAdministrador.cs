using Acceso_a_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_Negocio
{
    class ProcesosAdministrador : ProcesosUsuario
    {
        public ProcesosAdministrador(UsuarioInfo Usuario, SQLConexion conexion) : base(Usuario)
        {
            this.conexion = conexion;
        }
    }
}
