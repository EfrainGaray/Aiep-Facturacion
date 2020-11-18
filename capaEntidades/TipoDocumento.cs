using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class TipoDocumento
    {
        private string nombre;
        private int idTDocumento;

        public TipoDocumento() {

        }
        public TipoDocumento(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdDetalle { get => idTDocumento; set => idTDocumento = value; }
    }
}
