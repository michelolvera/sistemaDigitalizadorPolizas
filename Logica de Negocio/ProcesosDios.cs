using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_a_Datos;
using Entidades;

namespace Logica_de_Negocio
{
    /// <summary>
    /// Clase que contiene todas las operaciones que puede realizar un usuario DIOS, extiene de procesos administrador
    /// usuarioId: Lista de IDs de Usuario
    /// nombreUsuario: Lista de los nombres de usuario
    /// </summary>
    public class ProcesosDios : ProcesosAdministrador
    {
        List<int> usuarioId = new List<int>();
        List<string> nombreUsuario = new List<string>();
        public ProcesosDios(UsuarioInfo Usuario) : base(Usuario)
        {

        }

        /// <summary>
        /// Metodo que permite llenar combobox con datos solicitados
        /// </summary>
        /// <param name="origenCombo">ComboBox que se llenara de datos</param>
        /// <param name="opc">Entero que simboliza las opciones de datos para llenar el combo</param>
        /// <returns>El combobox con los datos solicitados</returns>
        public ComboBox LlenarCombo(ComboBox origenCombo, int opc)
        {
            switch (opc)
            {
                case 0:
                    areaId.Clear();
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_AREAS];");
                    break;
                case 1:
                    usuarioId.Clear();
                    nombreUsuario.Clear();
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_USUARIOS];");
                    break;
            }
            origenCombo.Items.Clear();
            if (estado.Estado)
            {
                while (estado.Resultado.HasRows && estado.Resultado.Read())
                {
                    nombreUsuario.Add(estado.Resultado.GetString(0).ToLower());
                    origenCombo.Items.Add(estado.Resultado.GetString(0));
                    switch (opc)
                    {
                        case 0:
                            areaId.Add(estado.Resultado.GetInt32(1));
                            break;
                        case 1:
                            usuarioId.Add(estado.Resultado.GetInt32(1));
                            break;
                    }
                }
                estado.Resultado.Close();
            }
            origenCombo.Enabled = true;
            return origenCombo;
        }

        /// <summary>
        /// Metodo que obtiene la informacion del usuario desde la BD
        /// </summary>
        /// <param name="index">Indice de posicion del usuario en el combo y por lo tanto en la lista</param>
        /// <returns>Entidad con toda la informacion del usuario</returns>
        public UsuarioInfo ObtenerUsuario (int index)
        {
            estado = Conexion.EjecutarConsulta("EXECUTE SP_DIG_OBTENER_USUARIO_SELECCIONADO "+ usuarioId[index]);
            UsuarioInfo usuarioInfo = null;
            if (estado.Estado && estado.Resultado.HasRows && estado.Resultado.Read())
            {
                usuarioInfo = new UsuarioInfo(estado.Resultado.GetInt32(0), estado.Resultado.GetString(1), estado.Resultado.GetString(8))
                {
                    Nombre = estado.Resultado.GetString(2),
                    ApellidoPaterno = estado.Resultado.GetString(3),
                    ApellidoMaterno = estado.Resultado.GetString(4),
                    IdArea = estado.Resultado.GetInt32(5),
                    Administrador = estado.Resultado.GetBoolean(6),
                    Dios = estado.Resultado.GetBoolean(7)
                };
            }
            estado.Resultado.Close();
            return usuarioInfo;
        }

        /// <summary>
        /// Metodo que permite registrar un usuario.
        /// </summary>
        /// <param name="EsNuevo">Indica si el usuario es nuevo o es actualizacion</param>
        /// <param name="usuario">La informacion del usuario</param>
        /// <param name="saPass">Contaseña de usuario SA en SQL</param>
        /// <returns></returns>
        public bool RegistroUsuario(bool EsNuevo, UsuarioInfo usuario, string saPass) {
            SQLConexion ConexionSA = new SQLConexion(nombreServidor, nombreBD, "sa", saPass);
            if (ConexionSA.AbrirConexion().Estado == false)
                return false;
            estado = EsNuevo ? ConexionSA.EjecutarSentencia("EXECUTE SP_DIG_AGREGAR_USUARIO '" + usuario.NombreUsuario + "', '" + usuario.Nombre + "', '" + usuario.ApellidoPaterno + "', '" + usuario.ApellidoMaterno + "', '" + usuario.Contraseña + "', " + areaId[usuario.IdArea] + ", " + usuario.Administrador + ", " + usuario.Dios) : ConexionSA.EjecutarSentencia("EXECUTE SP_DIG_ACTUALIZAR_USUARIO_SELECCIONADO " + usuario.Id + ", '" + usuario.Nombre + "', '" + usuario.ApellidoPaterno + "', '" + usuario.ApellidoMaterno + "', '" + usuario.Contraseña + "', " + areaId[usuario.IdArea] + ", " + usuario.Administrador + ", " + usuario.Dios);
            ConexionSA.CerrarConexion();
            return estado.Estado;
        }

        /// <summary>
        /// Metodo que comprueba la existencia de un nombre de usuario
        /// </summary>
        /// <param name="nombre">Nombre a comprobar</param>
        /// <returns>Verdadero si existe, falso si no.</returns>
        public bool ComprobarUsuarioExiste(string nombre)
        {
            return nombreUsuario.Contains(nombre.ToLower());
        }
        
    }
}
