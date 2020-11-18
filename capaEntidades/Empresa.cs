using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Empresa
    {
        private string rut;
        private string razonSocial;
        private string giro;
        private string email;
        private string direccion;
        private string telefono;
        private int idEmpresa;

        public Empresa() {

        }

        public Empresa(string rut, string razonSocial, string giro, string email, string direccion, string telefono)
        {
            this.rut = rut;
            this.razonSocial = razonSocial;
            this.giro = giro;
            this.email = email;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public string Rut { get => rut; set => rut = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Giro { get => giro; set => giro = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int IdEmpresa { get => IdEmpresa; set => IdEmpresa = value; }
    }
}
