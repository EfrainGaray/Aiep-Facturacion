using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class DetalleDocumento
    {
        private int cantidadProducto;
        private int precioProducto; 
        private int estado;
        private int idDDocumento;
        private int idProducto;
        private int idDocumento;


        public DetalleDocumento() {

        }

        public DetalleDocumento(int cantidadProducto, int precioProducto, int estado, int idDDocumento, int idProducto, int idDocumento)
        {
            this.cantidadProducto = cantidadProducto;
            this.precioProducto = precioProducto;
            this.estado = estado;
            this.idDDocumento = idDDocumento;
            this.idProducto = idProducto;
            this.idDocumento = idDocumento;
        }

        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public int PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int Estado { get => estado; set => estado = value; }
        public int IdDDocumento { get => idDDocumento; set => idDDocumento = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdDocumento { get => idDocumento; set => idDocumento = value; }
    }
}
