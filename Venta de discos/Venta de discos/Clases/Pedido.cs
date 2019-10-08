using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_discos.Clases
{
    class Pedido
    {
        public int id { get; set; }
        public DateTime fechaPedido { get; set; }
        public IList<DetallePedido> detallePedidos { get; set; }
    }
}
