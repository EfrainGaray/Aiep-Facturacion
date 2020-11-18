using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aiep_Facturacion
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtPasword.Attributes.Add("placeholder", "************");
            txtPasword.Attributes.Add("required", "required");
            txtPasword.Attributes.Add("type", "password");
            txtUsuario.Attributes.Add("placeholder", "user");
            txtUsuario.Attributes.Add("required", "required");
            txtUsuario.Attributes.Add("type", "text");
        }
    }
}