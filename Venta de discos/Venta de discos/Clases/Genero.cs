using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_discos.Clases
{
    class Genero
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length < 51)
                return true;
            return false;
        }

    }
}
