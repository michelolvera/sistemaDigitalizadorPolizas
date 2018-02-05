using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica_de_Negocio
{
    public class ControlDirectorioArchivos
    {
        private String directorioDatos = ConfigurationManager.AppSettings["savepath"];//Directorio en donde se guardaran los archivos

        public void CopiarArchivo(String pathDirectorio, String pathArchivo, String nombreArchivo)
        {
            pathDirectorio = directorioDatos + "\\" + pathDirectorio;
            if (Directory.Exists(pathDirectorio))
            {
                if (!File.Exists(pathDirectorio + "\\" + nombreArchivo))
                {
                    File.Copy(pathArchivo, pathDirectorio + "\\" + nombreArchivo);
                }
                else
                {
                    Console.WriteLine("Archivo existente");
                }
            }
            else
            {
                Console.WriteLine("El directorio no existe. Creando...");
                Directory.CreateDirectory(pathDirectorio);
                Console.WriteLine("Directorio Creado");
                if (!File.Exists(pathDirectorio + "\\" + nombreArchivo))
                {
                    File.Copy(pathArchivo, pathDirectorio + "\\" + nombreArchivo);
                }
                else
                {
                    Console.WriteLine("Archivo existente");
                }
            }
        }
    }

}
