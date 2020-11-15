using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class Cliente
    {
        private string razonSocial;
        private string rut;
        private string direccion;
        private string telefono;
        private string email;

        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
