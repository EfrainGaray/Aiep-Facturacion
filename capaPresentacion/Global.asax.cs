using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using capaPresentacion;

namespace capaPresentacion

{
    public class Global : HttpApplication
    {
        private static int contarFacturasUsuario = 0;
        private static int contarFacturasTotalUsuario = 0;
        private static int contarNetoTotalUsuario = 0;
        private static int contarNetoUsuario = 0;
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["facturasTotalUsuario"] = 0;
            Application["totalNetoTotalUsurio"] = 0;
         
        }
        void Session_Start(Object sender, EventArgs e)
        {
            Session["facturasUsuario"] =0;
            Session["totalNetoUsuario"] = 0;
            
        }

        void Application_EndRequest(object sender, EventArgs e)
        {
            contarFacturasTotalUsuario++;
            contarNetoTotalUsuario++;
            Application["facturasTotalUsuario"] = contarFacturasTotalUsuario;
            Application["totalNetoTotalUsurio"] = contarNetoTotalUsuario;
        }
        void Session_EndRequest(object sender, EventArgs e)
        {
            contarFacturasUsuario ++;
            contarNetoUsuario++;

            Session["facturasUsuario"] = contarFacturasUsuario;
            Session["totalNetoUsuario"] = contarNetoUsuario;

        }
        public static bool confirmacionRegistro() {
            return false;
        }
    }
}