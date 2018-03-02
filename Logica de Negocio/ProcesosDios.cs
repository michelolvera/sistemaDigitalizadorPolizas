using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Logica_de_Negocio
{
    public class ProcesosDios : ProcesosAdministrador
    {
        List<int> usuarioId = new List<int>();

        public ProcesosDios(UsuarioInfo Usuario) : base(Usuario)
        {

        }

        public new ComboBox LlenarCombo(ComboBox origenCombo, int opc, int index)
        {
            switch (opc)
            {
                case 0:
                    areaId.Clear();
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_AREAS];");
                    break;
                case 1:
                    expedienteId.Clear();
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_EXPEDIENTES_AREA] " + areaId[index] + ";");
                    break;
                case 2:
                    categoriaId.Clear();
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_CATEGORIA_EXPEDIENTE] " + expedienteId[index] + ";");
                    break;
                case 3:
                    usuarioId.Clear();
                    estado = Conexion.EjecutarConsulta("EXECUTE [dbo].[SP_DIG_OBTENER_USUARIOS];");
                    break;
            }
            origenCombo.Items.Clear();
            if (estado.Estado)
            {
                while (estado.Resultado.HasRows && estado.Resultado.Read())
                {
                    origenCombo.Items.Add(estado.Resultado.GetString(0));
                    switch (opc)
                    {
                        case 0:
                            areaId.Add(estado.Resultado.GetInt32(1));
                            break;
                        case 1:
                            expedienteId.Add(estado.Resultado.GetInt32(1));
                            break;
                        case 2:
                            categoriaId.Add(estado.Resultado.GetInt32(1));
                            break;
                        case 3:
                            usuarioId.Add(estado.Resultado.GetInt32(1));
                            break;
                    }
                }
                estado.Resultado.Close();
            }
            origenCombo.Enabled = true;
            return origenCombo;
        }

        UsuarioInfo ObtenerUsuario (int index)
        {
            estado = Conexion.EjecutarConsulta("EXECUTE SP_DIG_OBTENER_USUARIO_SELECCIONADO "+usuarioId[index]);
            UsuarioInfo usuarioInfo = null;
            if (estado.Estado && estado.Resultado.HasRows && estado.Resultado.Read())
            {
                usuarioInfo = new UsuarioInfo(estado.Resultado.GetInt32(0), estado.Resultado.GetString(1), "******")
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
    }
}
