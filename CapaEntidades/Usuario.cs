using System;

namespace CapaEntidades
{
    public class Usuario
    {
        private String usuari;
        private String password;
        private int cantidadFacturas;

        public string Usuari { get => usuari; set => usuari = value; }
        public string Password { get => password; set => password = value; }
        public int CantidadFacturas { get => cantidadFacturas; set => cantidadFacturas = value; }
    }
}
