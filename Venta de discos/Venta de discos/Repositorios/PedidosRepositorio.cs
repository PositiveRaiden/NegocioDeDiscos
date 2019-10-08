using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_discos.Repositorios
{
    class PedidosRepositorio
    {
        private acceso_BD _BD;
        public PedidosRepositorio()
        {
            _BD = new acceso_BD();
        }


        public DataTable ObtenerPedidos()
        {
            string sqltxt = "SELECT id as 'Numero de pedido',fechaPedido FROM Pedido";
            return _BD.consulta(sqltxt);
        }

    }
}
