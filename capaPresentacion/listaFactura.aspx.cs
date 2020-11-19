using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using capaNegocio;
using CapaEntidades;
namespace capaPresentacion
{
    public partial class listaFactura : System.Web.UI.Page
    {
        string user;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.user = (string)Session["usuario"];
            if (!IsPostBack)
            {
               
                DataTable dt = new DataTable();

               
                dt.Columns.Add(new DataColumn("Folio", typeof(int)));
                dt.Columns.Add(new DataColumn("RutEmpresa", typeof(string)));
                dt.Columns.Add(new DataColumn("RazonSocial", typeof(string)));
                dt.Columns.Add(new DataColumn("RutCliente", typeof(string)));
                dt.Columns.Add(new DataColumn("NombreCliente", typeof(string)));
                dt.Columns.Add(new DataColumn("Total", typeof(string)));
                dt.Columns.Add(new DataColumn("IVA", typeof(string)));
                dt.Columns.Add(new DataColumn("Estado", typeof(string)));
                dt.Columns.Add(new DataColumn("Herramientas", typeof(string)));

                DocumentoBLL docBLL = new DocumentoBLL();
                List<Documento> docs = docBLL.GetDocumentosUsers(this.user);
                for (int i = 0; i < docs.Count; i++)
                {
                    dt.Rows.Add(i, "Name" + i, "Country" + i,"chao");
                }
                GridView1.DataSource = dt;
                GridView1.DataBind(); 
            }
        }
    }
}