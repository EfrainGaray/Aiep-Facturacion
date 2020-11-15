using System;

namespace CapaEntidades
{
    public class Usuario
    {
        private string usuari;
        private string password;
        private int cantidadFacturas;

        public Usuario() {
        }
        public Usuario(string usuari, string password, int cantidadFacturas)
        {
            this.usuari = usuari;
            this.password = password;
            this.cantidadFacturas = cantidadFacturas;
        }

        public string Usuari { get => usuari; set => usuari = value; }
        public string Password { get => password; set => password = value; }
        public int CantidadFacturas { get => cantidadFacturas; set => cantidadFacturas = value; }
    }
}
