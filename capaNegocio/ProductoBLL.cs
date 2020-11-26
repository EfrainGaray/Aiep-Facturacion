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
        public List<Producto> GetProductos(string search)
        {
            List<Producto> productos = new List<Producto>();

            daoProducto daoProducto = new daoProducto();

            productos = daoProducto.detalleProdutoxNombre(search);
            productos.AddRange(daoProducto.detalleProdutoxCodigo(search));

            return productos;
        }
        public int getId(string folio)
        {
            daoDocumento daoDoc = new daoDocumento();
            return daoDoc.getIdDocumento(folio);
        }
    }
}
