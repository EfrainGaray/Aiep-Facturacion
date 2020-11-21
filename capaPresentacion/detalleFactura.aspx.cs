using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace capaPresentacion
{
    public partial class detalleFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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