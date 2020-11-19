using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using capaPresentacion;
using capaNegocio;

namespace capaPresentacion

{
    public class Global : HttpApplication
    {
        private static string sessionID;   
        
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           

        }
        void Session_Start(Object sender, EventArgs e)
        {
            Application["facturaUser" + Session.SessionID] = 0;
            Application["facturasTotalUsuario"] = 0;
            Application["totalNetoUsuario" + Session.SessionID] = 0;
            Application["totalNetoTotalUsurio"] = 0;
        }
        
        void Session_End(object sender, EventArgs e)
        {
    
          
        }
   
        /*
        void Application_EndRequest(object sender, EventArgs e)
        {
            DocumentoBLL.cantidadFacturas++;
            DocumentoBLL.netoFacturas++;

            Application["facturasTotalUsuario"] = DocumentoBLL.cantidadFacturas;
            Application["totalNetoTotalUsurio"] = DocumentoBLL.netoFacturas;
        }
        void Session_EndRequest(object sender, EventArgs e)
        {
            contarFacturasUsuario ++;
            contarNetoUsuario++;

            Session["facturasUsuario"] = contarFacturasUsuario;
            Session["totalNetoUsuario"] = contarNetoUsuario;

        }
        */

    }
}