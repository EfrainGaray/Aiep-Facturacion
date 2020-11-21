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
        string user;
        protected void Page_Init(object sender, EventArgs e)
        {
            this.user= (string)(Session["usuario"]);
            if (user==null)
            {
                Response.Redirect("./login",true);
            }
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            factura1.InnerHtml = Application["facturaUser" + Session.SessionID].ToString();
            factura2.InnerHtml = Application["facturasTotalUsuario"].ToString();
            if (Request.QueryString["logout"] != null) {
                Session.RemoveAll();
                Response.Redirect("./index");
            }
        }

       

        
    }
}