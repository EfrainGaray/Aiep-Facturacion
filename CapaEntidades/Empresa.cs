using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class Empresa
    {
        private String rut;
        private String razonSocial;
        private String giro;
        private String email;
        private String direccion;
        private String telefono;

        public string Rut { get => rut; set => rut = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Giro { get => giro; set => giro = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
