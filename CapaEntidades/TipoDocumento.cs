using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class TipoDocumento
    {
        private string nombre;

        public TipoDocumento() {

        }
        public TipoDocumento(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
