using capaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;

namespace capaPresentacion
{
    public partial class CrearProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviarProducto_Click(object sender, EventArgs e)
        {
            bool valid = true;
            foreach (var c in form1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (Utils.CheckString(tb.Text))
                    {
                        valid = false;
                        debug("Por favor ingresar los datos solicitados");
                        break;
                    }
                }

            }
            if (valid)
            {
                string nombre = txtNombrePro.Text;
                string codigo = txtCodigoPro.Text;
                int stock =int.Parse(txtStockPro.Text);
                string descripcion = txtDescripcionPro.Text;
                int precio = int.Parse(txtPrecioPro.Text);


                Producto producto = new Producto(nombre, codigo, stock, precio, descripcion);
                ProductoBLL productoBLL = new ProductoBLL();
                if (productoBLL.CrearProducto(producto))
                {
                    Response.Write("<script>alert('Producto almacenado correctamente.')</script>");

                    txtCodigoPro.Text = "";
                    txtDescripcionPro.Text = "";
                    txtNombrePro.Text = "";
                    txtPrecioPro.Text = "";
                    txtStockPro.Text = "";
                    //Application["facturaUser" + Session.SessionID] = (int)Application["facturaUser" + Session.SessionID] + 1;
                    //Application["facturasTotalUsuario"] = (int)Application["facturasTotalUsuario"] + 1;
                    //Response.Redirect("detalleFactura?folio=" + producto.Folio);
                }
                else
                {
                    debug("No se logro crear el producto.");
                }
            }
        }

            public void debug(string data)
            {
                Response.Write("<script>alert('" + data + "');</script>");
            }
        }
}