using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_discos.Clases
{
    class SelloDiscografico
        //HACER!!
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public SelloDiscografico(string name, int value)
        {
            nombre = name;
            id = value;
        }
    }


}
