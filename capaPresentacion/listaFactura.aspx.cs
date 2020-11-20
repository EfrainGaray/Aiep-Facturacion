﻿using System;
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
        DocumentoBLL doc = new DocumentoBLL();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.user = (string)Session["usuario"];
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
        public void updateTable() {

            this.dt.Columns.Add(new DataColumn("Folio", typeof(string)));
            this.dt.Columns.Add(new DataColumn("RutEmpresa", typeof(string)));
            this.dt.Columns.Add(new DataColumn("RazonSocial", typeof(string)));
            this.dt.Columns.Add(new DataColumn("RutCliente", typeof(string)));
            this.dt.Columns.Add(new DataColumn("NombreCliente", typeof(string)));
            this.dt.Columns.Add(new DataColumn("Total", typeof(int)));
            this.dt.Columns.Add(new DataColumn("IVA", typeof(int)));
            this.dt.Columns.Add(new DataColumn("Estado", typeof(string)));
            this.dt.Columns.Add(new DataColumn("Herramientas", typeof(string)));



            DocumentoBLL docBLL = new DocumentoBLL();
            List<Documento> docs = docBLL.GetDocumentosUsers(this.user);
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
                this.dt.Rows.Add(doc.Folio, doc.Vendedor.Rut, doc.Vendedor.RazonSocial, doc.Comprador.Rut, doc.Comprador.RazonSocial, doc.Total, doc.Iva, estado);
            }
            GridView1.DataSource = this.dt;
            GridView1.DataBind();

        }
        public void debug(string data)
        {
            Response.Write("<script>alert('" + data + "');</script>");
        }

        protected void Borrar_Click1(object sender, EventArgs e)
        {

        }
    }
}