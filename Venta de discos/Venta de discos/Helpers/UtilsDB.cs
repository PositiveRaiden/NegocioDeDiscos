using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_discos.Helpers
{
    class UtilsDB
    {
        public static string GetFecha(DateTime f)
        {
            return f != DateTime.MinValue ? f.ToString("yyyy-MM-dd") : null;
        }
    }
}
