using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;
using CapaEntidades;
using System.Globalization;

namespace capaPresentacion
{
    public partial class detalleFactura : System.Web.UI.Page
    {
        public DataTable dt = new DataTable();
        public List<Producto> prods;
        public ProductoBLL productoBLL = new ProductoBLL();
        public DocumentoBLL documentoBLL = new DocumentoBLL();
        public List<DetalleDocumento> detalleDoc = new List<DetalleDocumento>();
        public string folio;
        protected void Page_Load(object sender, EventArgs e)
        {
            folio = Request.QueryString["folio"];

           

            Documento doc = documentoBLL.GetDocumentosxFolio(folio)[0];
            CampoBuscar.Attributes.Add("placeholder","Buscar nombre del Producto o codigo EJ: Teclado");
            nombreEmpresa.InnerHtml = doc.Vendedor.RazonSocial;
            telefono.InnerHtml = doc.Vendedor.Telefono;
            giro.InnerHtml = doc.Vendedor.Giro;
            folioh.InnerHtml = folio;
            fecha.InnerHtml = DateTime.Now.ToString("D", CultureInfo.CreateSpecificCulture("es-ES"));
            txtSenior.Text = doc.Comprador.RazonSocial;
            txtRut.Text = doc.Comprador.Rut;
            txtDireccion.Text = doc.Comprador.Direccion;
            txtTelefono.Text = doc.Comprador.Telefono;
            txtEmail.Text = doc.Comprador.Email;
            txtPago.Text = doc.TipoPago.ToString();



        }

     

      
        protected void Button3_Click(object sender, EventArgs e)
        {
            string buscar = CampoBuscar.Text;
           
            prods = productoBLL.GetProductos(buscar);
            UpdateData();
            /*
            foreach (Producto prod in productos)
            {
                
                Label label = new Label();
                label.Text = prod.Nombre;
                TextBox cantidad = new TextBox();
                cantidad.ID = "c"+prod.Codigo;
                cantidad.Attributes.Add("placeholder", "Ingrese la cantidad");
                Button btn = new Button();
                btn.Text = "Agergar";
                btn.Click += this.agregarProd;

                System.Web.UI.HtmlControls.HtmlGenericControl div1 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                System.Web.UI.HtmlControls.HtmlGenericControl div2 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                div1.Attributes.Add("class", "col-2 mt-2");
                btn.Attributes.Add("data-codigo",prod.Codigo);
                div2.Attributes.Add("class", "col-10 text-left mt-2");
                div1.Controls.Add(label);
                div2.Controls.Add(cantidad);
                div2.Controls.Add(btn);
                resultSearch.Controls.Add(div1);
                resultSearch.Controls.Add(div2);




        }
                            */
        }
     
        public void UpdateData() {



            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("Codigo", typeof(string)));
            dt.Columns.Add(new DataColumn("NombreProducto", typeof(string)));
            dt.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dt.Columns.Add(new DataColumn("Precio", typeof(string)));
            dt.Columns.Add(new DataColumn("Cantidad", typeof(string)));
    
    


            foreach (Producto prod in prods)
            {

                dt.Rows.Add(1,prod.Codigo , prod.Nombre , prod.Descripcion ,prod.Precio,"1");
            }
              
            

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        public void debug(string data)
        {
            Response.Write("<script>alert('" + data + "');</script>");
        }



        protected void AgregarProd_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            string codigo = (string)button.Attributes["data-codigo"];
            Producto producto = productoBLL.GetProductos(codigo)[0];
            foreach (GridViewRow row in GridView1.Rows)
            {
                TextBox c = (TextBox)row.FindControl("txt_Cantidad");
                if (c is TextBox) {
                    TextBox tb = (TextBox)c;

                    if (codigo.Equals((string)c.Attributes["data-codigo"]))
                    {
                        int IdProd = productoBLL.getId(codigo);
                        int IdDoc = documentoBLL.getId(folio);
                        DetalleDocumento detalleDocumento = new DetalleDocumento(int.Parse(tb.Text), producto.Precio, 0,IdDoc,IdProd,0);
                        detalleDoc.Add(detalleDocumento);
                    }
                   
                }
            }
        }
    }
}