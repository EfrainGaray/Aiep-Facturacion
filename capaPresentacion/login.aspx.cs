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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            txtPasword.Attributes.Add("placeholder", "************");
            txtPasword.Attributes.Add("required", "required");
            txtPasword.Attributes.Add("type", "password");
            txtPasword.Attributes.Add("max", "10");
            txtUsuario.Attributes.Add("placeholder", "user");
            txtUsuario.Attributes.Add("required", "required");
            txtUsuario.Attributes.Add("type", "text");
            txtUsuario.Attributes.Add("max", "10");
        }

        protected void sendData_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPasword.Text;
           
            if (Utils.CheckString(usuario) || Utils.CheckString(password))
            {
                error.InnerHtml = "Datos ingresados no son validos";
                error.Style.Add("opacity", "1");
                error.Style.Add("visibility", "visible");
            }
            else
            {
                error.Attributes.Remove("style");
                UsuarioBLL validarUsuario = new UsuarioBLL(usuario, password);
                if (validarUsuario.validaLogin())
                {
                    Usuario user = validarUsuario.User;
                    Session["usuario"] =  user.User;
                    Response.Redirect("index",true);
                }
                else {
                    error.InnerHtml = "Usuario o contraseña son invalidos";
                    error.Style.Add("opacity", "1");
                    error.Style.Add("visibility", "visible");
                }
               
            }
        }
    }
}