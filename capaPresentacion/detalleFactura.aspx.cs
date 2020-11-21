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
        protected void Page_Load(object sender, EventArgs e)
        {
            string folio = Request.QueryString["folio"];

            DocumentoBLL documentoBLL = new DocumentoBLL();
            
            Documento doc = documentoBLL.GetDocumentosxFolio(folio)[0];

            nombreEmpresa.InnerHtml = doc.Vendedor.RazonSocial;
            telefono.InnerHtml = doc.Vendedor.Telefono;
            giro.InnerHtml = doc.Vendedor.Giro;
            folioh.InnerHtml = folio;
            fecha.InnerHtml = DateTime.Now.ToString("D", CultureInfo.CreateSpecificCulture("es-ES"));
            

            if (!IsPostBack)
            {
                // Create a datatable as a DataSource of your GridView
                DataTable dt = new DataTable();

                // Add three columns in datatable and their names and data types
                dt.Columns.Add(new DataColumn("ID", typeof(int)));
                dt.Columns.Add(new DataColumn("Codigo", typeof(string)));
                dt.Columns.Add(new DataColumn("NombreProducto", typeof(string)));
                dt.Columns.Add(new DataColumn("Descripcion", typeof(string)));
                dt.Columns.Add(new DataColumn("Cantidad", typeof(string)));
                dt.Columns.Add(new DataColumn("Precio", typeof(string)));
            
                // Add five records in datatable
                for (int i = 0; i < 5; i++)
                {
                    dt.Rows.Add(i, "Name" + i, "Country" + i, "chao");
                }

                GridView1.DataSource = dt; // set your datatable to your gridview as datasource
                GridView1.DataBind(); // bind the gridview with datasource
            }
        }
    }
}