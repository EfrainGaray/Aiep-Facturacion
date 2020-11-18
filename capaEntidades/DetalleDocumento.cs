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

        public DetalleDocumento() {

        }

        public DetalleDocumento(int cantidadProducto, int precioProducto, int estado)
        {
            this.cantidadProducto = cantidadProducto;
            this.precioProducto = precioProducto;
            this.estado = estado;
        }

        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public int PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
