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
        public string UserName { get; private set; }
        public string UserPassword { get; private set; }
        public UsuarioInfo(int UserID, string UserName, string UserPassword)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.UserPassword = UserPassword;
        }
    }
}
