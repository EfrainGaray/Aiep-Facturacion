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
        public List<Documento> GetDocumentosUsers(string user)
        {
            
            daoDocumento daoDoc = new daoDocumento();
            List<Documento> docs =  daoDoc.consultarDocumentoxUsuario(user);
            return docs;
        }


        public  bool CrearDcoumento()
        {
           return true;
        }
    }   


}
