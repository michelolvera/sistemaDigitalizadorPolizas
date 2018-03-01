﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInfo
    {
        public int UserID { get; private set; }
        public string UserName { get;  set; }
        public string UserPassword { get; private set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int IdArea { get; set; } //Aqui ira el ID de area, debe ser igual al de SQL
        public bool EsAdmin { get; set; } = false; //Falso por defecto
        public bool Dios { get; set; }
        public string Area { get;  set; }
        public UsuarioInfo(int UserID, string UserName, string UserPassword)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.UserPassword = UserPassword;
        }
    }
}
