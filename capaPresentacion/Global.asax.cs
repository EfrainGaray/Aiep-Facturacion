using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using capaNegocio;
namespace capaPresentacion
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["facturasTotalUsuario"] = "0";
            Application["totalNetoTotalUsurio"] = "0";
         
        }
        protected void Session_Start(Object sender, EventArgs e)
        {
            Session["facturasUsuario"] = "0";
            Session["totalNetoUsuario"] = "0";
            
        }
        protected void Application_EndRequest(Object sender, EventArgs e)
        {
            
        }
            

    }
}