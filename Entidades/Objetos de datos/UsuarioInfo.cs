using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La entidad UsuarioInfo permite manejar la información de los usuarios de forma mas cómoda 
    /// Id: Contiene el ID del usuario
    /// NombreUsuario : Contiene el nombre de usuario
    /// Contraseña: Contiene la contraseña del usuario que se obtiene en el login
    /// Nombre: nombre del usuario
    /// ApellidoPaterno:Contiene el apellido paterno del usuario 
    /// ApellidoMaterno: Contiene el apellido materno del usuario
    /// IdArea: Contiene el ID del área al cual pertenece el usuario
    /// Administrador: Esta variable permite saber si el usuario es administrador del area a el cual pertenece 
    /// Dios: Esta variable permite saber si el usuario tiene permisos súper administrador
    /// Area: Contiene el nombre del área del usuario
    /// </summary>
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
