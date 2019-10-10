using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_discos.Clases
{
    class Venta
    {
        public int id { get; set; }

        public DateTime fecha { get; set; }

        public decimal importe_Total { get; set; }

        public string id_Cliente { get; set; } //combo

        public IList<DetalleVenta> detalleVentas { get; set; }

    }
}
