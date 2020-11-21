using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using capaPersintencia;

namespace capaNegocio
{
    public class ProductoBLL
    {

        public bool CrearProducto(Producto producto)
        {
            daoProducto dao = new daoProducto();
            if (dao.productoExistente(producto.Codigo)) {
                return false;
            }
            else if (dao.registrarProducto(producto))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
