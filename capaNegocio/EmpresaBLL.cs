using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using capaPersintencia;
namespace capaNegocio
{
    public class EmpresaBLL
    {
        public Empresa getEmpresa(int IdEmpresa) {
            daoEmpresa daoEmpresa = new daoEmpresa();
            Empresa empresa  = daoEmpresa.detalleEmpresaId(IdEmpresa);
            return empresa;
        }
    }
}
