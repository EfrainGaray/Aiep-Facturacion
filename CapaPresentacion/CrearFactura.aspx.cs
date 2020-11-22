using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;
using CapaEntidades;
using System.Globalization;

namespace capaPresentacion
{
    public partial class CrearFactura : System.Web.UI.Page
    {
        public string folio;
        Usuario user;
        Empresa empresa;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (Usuario)(Session["usuario"]);
            Random r = new Random();
            folio = r.Next().ToString();
            txtFolio.InnerText = folio;
            EmpresaBLL empresaBLL = new EmpresaBLL();
            empresa = empresaBLL.getEmpresa(user.IdEmpresa);
            nombreEmpresa.InnerHtml = empresa.RazonSocial;
            giro.InnerHtml = empresa.Giro;
            fono.InnerHtml = empresa.Telefono;
            rut.InnerHtml = empresa.Rut;
            fecha.InnerHtml = DateTime.Now.ToString("D", CultureInfo.CreateSpecificCulture("es-ES"));
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
                
                string conPago = txtCondPago.Text;
                string rSocial = txtNombre.Text;


                //limpieza de RUT
                rut.Replace(".", string.Empty);
                rut.Replace("-", string.Empty);
                rut.Trim();

                string dv;
                string rutValidar;

                rutValidar = rut.Substring(0, rut.Length - 1);
                dv = rut.Substring(rut.Length-1, 1);

                if (!Utils.ValidaRut(rutValidar, dv)) {
                    Response.Write("<script>alert('El RUT ingresado no tiene un formato válido.')</script>");
                }


                Cliente cli = new Cliente(rSocial, rut, direccion, telefono, email);
                DocumentoBLL documentBLL = new DocumentoBLL();
                Documento documento = new Documento(folio,0,cli,empresa,new TipoDocumento("Factura Electronica",1),user.User);

                if (documentBLL.CrearDcoumento(documento))
                {
                    Application["facturaUser" + Session.SessionID] = (int)Application["facturaUser" + Session.SessionID] + 1;
                    Application["facturasTotalUsuario"] = (int)Application["facturasTotalUsuario"] + 1;
                    Response.Redirect("detalleFactura?folio="+documento.Folio);
                }
                else {
                    debug("No se logro crear un documento");
                }
            }
            


        }
        public void debug(string data)
        {
            Response.Write("<script>alert('" + data + "');</script>");
        }
    }
}