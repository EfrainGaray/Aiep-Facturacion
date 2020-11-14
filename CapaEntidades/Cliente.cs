using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class Cliente
    {
        private String razonSocial;
        private String rut;
        private String direccion;
        private String telefono;
        private String email;

        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
