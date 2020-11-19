using System;
namespace CapaEntidades
{
    public class Producto
    {
        private String nombre;
        private String codigo;
        private int stock;
        private int precio;
        private String descripcion;
        private int idProducto;

        public Producto()
        {
        }

        public Producto(string nombre, string codigo, int stock, int precio, string descripcion)
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Stock = stock;
            this.Precio = precio;
            this.Descripcion = descripcion;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
    }
}
