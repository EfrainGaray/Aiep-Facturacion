using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace capaPresentacion
{
    public partial class listaFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Create a datatable as a DataSource of your GridView
                DataTable dt = new DataTable();

                // Add three columns in datatable and their names and data types
                dt.Columns.Add(new DataColumn("Folio", typeof(int)));
                dt.Columns.Add(new DataColumn("RutEmpresa", typeof(string)));
                dt.Columns.Add(new DataColumn("RazonSocial", typeof(string)));
                dt.Columns.Add(new DataColumn("RutCliente", typeof(string)));
                dt.Columns.Add(new DataColumn("NombreCliente", typeof(string)));
                dt.Columns.Add(new DataColumn("Total", typeof(string)));
                dt.Columns.Add(new DataColumn("IVA", typeof(string)));
                dt.Columns.Add(new DataColumn("Estado", typeof(string)));
                dt.Columns.Add(new DataColumn("Herramientas", typeof(string)));

                // Add five records in datatable
                for (int i = 0; i < 5; i++)
                {
                    dt.Rows.Add(i, "Name" + i, "Country" + i,"chao");
                }

                GridView1.DataSource = dt; // set your datatable to your gridview as datasource
                GridView1.DataBind(); // bind the gridview with datasource
            }
        }
    }
}