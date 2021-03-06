﻿using System;
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
            user= (Usuario)(Session["usuario"]);
            if (user==null)
            {
                Response.Redirect("./login",true);
            }
          
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            factura1.InnerHtml = Application["facturaUser" + Session.SessionID].ToString();
            factura2.InnerHtml = Application["facturasTotalUsuario"].ToString();
            factura3.InnerHtml = Application["totalNetoUsuario" + Session.SessionID].ToString();
            factura4.InnerHtml = Application["totalNetoTotalUsurio"].ToString();
            if (Request.QueryString["logout"] != null) {
                Session.RemoveAll();
                Response.Redirect("./index");
            }
        }

       

        
    }
}