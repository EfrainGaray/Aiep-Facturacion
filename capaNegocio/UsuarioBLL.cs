using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaPersintencia;
using CapaEntidades;
namespace capaNegocio
{
    public class UsuarioBLL
    {
        private string _usuarioBll;
        private string _passwordBll;
        private Usuario _user;
        public UsuarioBLL() { }

        public UsuarioBLL(string usuarioBll, string passwordBll)
        {
            _usuarioBll = usuarioBll;
            _passwordBll = passwordBll;
        }

        public string UsuarioBll { get => _usuarioBll; set => _usuarioBll = value; }
        public string PasswordBll { get => _passwordBll; set => _passwordBll = value; }
        public Usuario User { get => _user; set => _user = value; }

        public bool validaLogin()
        {
            bool valid = false;

            daoUsuario usuarioDao = new daoUsuario();

            List<Usuario> usuarios = usuarioDao.GetUsuarios(this.UsuarioBll);
            foreach (Usuario user in usuarios)
            {
                if (user.Password == PasswordBll) {
                    _user = user;
                    valid = true;
                    break;
                }
            }

            return valid;
        }
    }
}
