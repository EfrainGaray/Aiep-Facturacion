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
        public static int cantidadFacturas=0;
        public static int netoFacturas = 0;
        public List<Documento> GetDocumentosUsers(string user)
        {
            
            daoDocumento daoDoc = new daoDocumento();
            List<Documento> docs =  daoDoc.consultarDocumentoxUsuario(user);
            return docs;
        }

        public bool AnularDcoumento(string folio)
        {
            daoDocumento daoDoc = new daoDocumento();
            return daoDoc.anularDocumento(folio); ;
        }

        public  bool CrearDcoumento()
        {
           
           return true;
        }
    }   


}
