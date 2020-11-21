using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace capaNegocio
{
    public static class Utils
    {
        public static Object formulario ;
        public static bool CheckString(string txt)
        {

            return string.IsNullOrEmpty(txt.Trim());
        }

       
    }
}
