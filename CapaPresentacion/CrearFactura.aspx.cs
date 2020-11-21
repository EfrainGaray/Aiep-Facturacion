using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;
using CapaEntidades;
namespace capaPresentacion
{
    public partial class CrearFactura : System.Web.UI.Page
    {
        public string folio;
        protected void Page_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            folio = r.Next().ToString();
            txtFolio.InnerText = folio;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool valid = true;
            foreach (var c in form1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (Utils.CheckString(tb.Text))
                    {
                        valid = false;
                        debug("Por favor ingresar los datos solicitados");
                        break;
                    }
                }

            }
            if (valid) {
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                string rut = txtRut.Text;
                string email = txtEmail.Text;
                string direccion = txtDireccion.Text;
                string ciudad  = txtCiudad.Text;
                string comuna = txtComuna.Text;
                string conPago = txtCondPago.Text;
                string giro = txtGiro.Text;

                Cliente cli = new Cliente(giro, rut, direccion, telefono, email);
                DocumentoBLL documentBLL = new DocumentoBLL();

                if (documentBLL.CrearDcoumento(cli,this.folio))
                {
                    Application["facturaUser" + Session.SessionID] = (int)Application["facturaUser" + Session.SessionID] + 1;
                    Application["facturasTotalUsuario"] = (int)Application["facturasTotalUsuario"] + 1;
                }
            }
            


        }
        public void debug(string data)
        {
            Response.Write("<script>alert('" + data + "');</script>");
        }
    }
}