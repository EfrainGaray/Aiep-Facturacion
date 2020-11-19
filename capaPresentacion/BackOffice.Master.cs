using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;
using CapaEntidades;
namespace Aiep_Facturacion
{
    public partial class BackOffice : System.Web.UI.MasterPage
    {
        Usuario user;
        protected void Page_Init(object sender, EventArgs e)
        {
            this.user= (Usuario)(Session["usuario"]);
            if (user==null)
            {
                Response.Redirect("login",true);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script>alert('"+ user.User + "');</script>");
        }
    }
}