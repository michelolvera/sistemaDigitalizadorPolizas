using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInfo
    {
        public int Id { get; }
        public string NombreUsuario { get;  set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int IdArea { get; set; } //Aqui ira el ID de area, debe ser igual al de SQL
        public bool Administrador { get; set; } = false; //Falso por defecto
        public bool Dios { get; set; } = false; //Falso por defecto
        public string Area { get;  set; }
        public UsuarioInfo(int Id, string NombreUsuario, string Contraseña)
        {
            this.Id = Id;
            this.NombreUsuario = NombreUsuario;
            this.Contraseña = Contraseña;
        }
    }
}
