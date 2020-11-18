using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class UsuarioBLL
    {
        private string _usuario;
        private string _password;

        public UsuarioBLL() { }

        public UsuarioBLL(string usuario, string password)
        {
            _usuario = usuario;
            _password = password;
        }

        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
