using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaEnLinea
{
    public class Usuario 
    {
        string username;
        string password;
        int nivel;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Nivel { get => nivel; set => nivel = value; }
    }
}