using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public static class Utils
    {
        public static bool CheckString(string txt)
        {
            bool valid = true;
            valid = valid && string.IsNullOrEmpty( txt.Trim() );
            return valid;
        }
        
    }
}
