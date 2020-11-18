using System;

namespace CapaEntidades
{
    public class Usuario
    {
        private string user;
        private string password;
        private int cantidadFacturas;

        public Usuario() {
        }
        public Usuario(string user, string password, int cantidadFacturas)
        {
            this.user = user;
            this.password = password;
            this.cantidadFacturas = cantidadFacturas;
        }

        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public int CantidadFacturas { get => cantidadFacturas; set => cantidadFacturas = value; }
    }
}
