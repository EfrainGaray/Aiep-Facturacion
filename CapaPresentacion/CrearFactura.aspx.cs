using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;
namespace capaPresentacion
{
    public partial class CrearFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DocumentoBLL documentBLL = new DocumentoBLL();
            /*REscato vvalores formulario y paso */

            documentBLL.CrearDcoumento();

        }
    }
}