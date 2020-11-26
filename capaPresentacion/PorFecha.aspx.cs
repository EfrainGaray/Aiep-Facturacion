using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using capaNegocio;
using CapaEntidades;
using System.Globalization;

namespace capaPresentacion
{
    public partial class PorFecha : System.Web.UI.Page
    {
        Usuario user;
        DocumentoBLL doc = new DocumentoBLL();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.user = (Usuario)Session["usuario"];
            if (!IsPostBack)
            {
                this.updateTable();
            }
        }

        protected void Borrar_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            string folio = (string)button.Attributes["data-folio"];
            if (this.doc.AnularDcoumento(folio))
            {
                debug("Factura Anulada con exito");
                this.updateTable();
            }
            else
            {
                debug("La Factura ya esta anulada");
            }
        }

        public void updateTable()
        {

            this.dt.Columns.Add(new DataColumn("Folio", typeof(string)));
            this.dt.Columns.Add(new DataColumn("RutEmpresa", typeof(string)));
            this.dt.Columns.Add(new DataColumn("RazonSocial", typeof(string)));
            this.dt.Columns.Add(new DataColumn("RutCliente", typeof(string)));
            this.dt.Columns.Add(new DataColumn("NombreCliente", typeof(string)));
            this.dt.Columns.Add(new DataColumn("Total", typeof(int)));
            this.dt.Columns.Add(new DataColumn("IVA", typeof(int)));
            this.dt.Columns.Add(new DataColumn("Estado", typeof(string)));
            this.dt.Columns.Add(new DataColumn("CreadaPor", typeof(string)));
            if (Utils.CheckString(txtFInicial.Text))
            {
                txtFInicial.Text = "01/01/2020";
            }
            DateTime fFinal = DateTime.Now;
            if (!Utils.CheckString(txtFFinal.Text))
            {
                 fFinal = Convert.ToDateTime(txtFFinal.Text);
            }
            txtFFinal.Text = fFinal.ToString("d", CultureInfo.CreateSpecificCulture("es-ES"));


            DateTime fInicial = Convert.ToDateTime(txtFInicial.Text);
           

            DocumentoBLL docBLL = new DocumentoBLL();
            List<Documento> docs = docBLL.GetDocumentosFecha(fInicial,fFinal );
            foreach (var doc in docs)
            {
                string estado = "Borrador";
                if (doc.EstadoEmitido == 1)
                {
                    estado = "Emitida";
                }
                else if (doc.EstadoEmitido == 2)
                {
                    estado = "Anulada";
                }
                this.dt.Rows.Add(doc.Folio, doc.Vendedor.Rut, doc.Vendedor.RazonSocial, doc.Comprador.Rut, doc.Comprador.RazonSocial, doc.Total, doc.Iva, estado,doc.CreadoPor);
            }
            gvDocumentosFecha.DataSource = this.dt;
            gvDocumentosFecha.DataBind();

        }

        protected void anularDocumento_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            string folio = (string)button.Attributes["data-folio"];

            DocumentoBLL docBLL = new DocumentoBLL();
            List<Documento> docs = docBLL.GetDocumentosxFolio(folio);

            foreach (Documento auxDocumento in docs)
            {
                if (auxDocumento.EstadoEmitido == 0)
                {
                    debug("La Factura ya se encuentra en estado Borrados, no es posible anular.");
                }
                else if (auxDocumento.EstadoEmitido == 2)
                {
                    debug("La Factura ya se encuentra en estado Borrados, no es posible anular.");
                }
                else if (this.doc.AnularDcoumento(folio))
                {
                    debug("Factura Anulada con exito");
                    this.updateTable();
                }
            }
        }

        public void debug(string data)
        {
            Response.Write("<script>alert('" + data + "');</script>");
        }

        protected void buscarxFecha_Click(object sender, EventArgs e)
        {
            updateTable();
        }
    }
}