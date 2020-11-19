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
                Response.Redirect("login",true);
            }
         
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            factura1.InnerHtml = (string)Session["facturasUsuario"];
            factura2.InnerHtml = (string)Session["facturasTotalUsuario"];
            factura3.InnerHtml = (string)Session["totalNetoUsuario"];
            factura4.InnerHtml = (string)Session["totalNetoTotalUsurio"];
        }
    }
}