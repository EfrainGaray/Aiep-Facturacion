using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using capaPersintencia;

namespace capaNegocio
{
    public class DocumentoBLL
    {
        public static int cantidadFacturas = 0;
        public static int cantidadFacturasTotal = 0;
        public List<Documento> GetDocumentosUsers(string user)
        {
            daoDocumento daoDoc = new daoDocumento();
            List<Documento> docs = daoDoc.consultarDocumentoxUsuario(user);
            return docs;
        }

        public List<Documento> GetDocumentos()
        {

            daoDocumento daoDoc = new daoDocumento();
            List<Documento> docs = daoDoc.consultarDocumento();

            return docs;

        }

        public List<Documento> GetDocumentosxFolio(string folio)
        {

            daoDocumento daoDoc = new daoDocumento();
            List<Documento> docs = daoDoc.consultarDocumentoxFolio(folio);

            return docs;

        }

        public List<Documento> GetDocumentosFecha(DateTime fInicial, DateTime fFinal)
        {

            daoDocumento daoDoc = new daoDocumento();
            List<Documento> docs = daoDoc.consultarDocumentoxFecha(fInicial, fFinal);

            return docs;

        }

        public bool AnularDcoumento(string folio)
        {
            daoDocumento daoDoc = new daoDocumento();
            return daoDoc.anularDocumento(folio); ;
        }

        public bool CrearDcoumento(Documento documento)
        {
            daoDocumento dao = new daoDocumento();

            if (dao.registrarDocumento(documento))
            {
                cantidadFacturas++;
                cantidadFacturasTotal++;
                return true;
            }
            else
            {
                return false;
            }

        }
    }


}
