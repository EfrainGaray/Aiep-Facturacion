using System;
using System.Collections.Generic;

namespace CapaEntidades
{
    public class Documento
    {
        private string folio;
        private int estadoEmitido;
        private int subTotal;
        private int total;
        private int iva;
        private int tipoPago;
        private Cliente comprador;
        private Empresa vendedor;
        private TipoDocumento tipoDoc;
        private List<DetalleDocumento> detalleDocumentos;
        private DateTime fechaEmision;
        private string observacion;
        private string creadoPor;

        public Documento()
        {
           
        }

        public Documento(string folio, int estadoEmitido, int subTotal, int total, int iva, int tipoPago, Cliente comprador, Empresa vendedor, TipoDocumento tipoDoc, List<DetalleDocumento> detalleDocumentos, DateTime fechaEmision, string observacion, string creadoPor)
        {
            this.folio = folio;
            this.estadoEmitido = estadoEmitido;
            this.subTotal = subTotal;
            this.total = total;
            this.iva = iva;
            this.tipoPago = tipoPago;
            this.comprador = comprador;
            this.vendedor = vendedor;
            this.tipoDoc = tipoDoc;
            this.detalleDocumentos = detalleDocumentos;
            this.fechaEmision = fechaEmision;
            this.observacion = observacion;
            this.creadoPor = creadoPor;
        }

        public string Folio { get => folio; set => folio = value; }
        public int EstadoEmitido { get => estadoEmitido; set => estadoEmitido = value; }
        public int SubTotal { get => subTotal; set => subTotal = value; }
        public int Total { get => total; set => total = value; }
        public int Iva { get => iva; set => iva = value; }
        public int TipoPago { get => tipoPago; set => tipoPago = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string CreadoPor { get => creadoPor; set => creadoPor = value; }
        internal Cliente Comprador { get => comprador; set => comprador = value; }
        internal Empresa Vendedor { get => vendedor; set => vendedor = value; }
        internal TipoDocumento TipoDoc { get => tipoDoc; set => tipoDoc = value; }
        internal List<DetalleDocumento> DetalleDocumentos { get => detalleDocumentos; set => detalleDocumentos = value; }
    }
}
