using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_de_discos.Clases;
using Venta_de_discos.Helpers;

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

        public void Guardar(Pedido p)
        {
            using (var tx = _BD.IniciarTransaccion())
            {
                try
                {
                    string sqltxt = $"INSERT [dbo].[Pedido] ([fechaPedido])" +
                        $" VALUES ('{UtilsDB.GetFecha(p.fechaPedido)}')";
                    p.id = _BD.EjecutarTransaccion(sqltxt);
                    if (p.id == 0)
                        throw new ApplicationException();

                    foreach (var d in p.detallePedidos)
                    {
                        sqltxt = $"INSERT [dbo].[Detalle_Pedido] " +
                            $"([id_Pedido], [Cantidad], [id_Disco]) " +
                            $"VALUES ({p.id}, {d.cantidad}, {d.idDisco}')";
                        _BD.EjecutarTransaccion(sqltxt);

                        sqltxt = $"SELECT cantidad FROM Disco WHERE id={d.idDisco}";

                        var stock =
                            int.Parse(_BD.ConsultaDuranteTransaccion(sqltxt).Rows[0]["cantidad"].ToString());

                        sqltxt = $"UPDATE [dbo].[Disco] SET cantidad = '{stock + Convert.ToInt16(d.cantidad)}' WHERE id={d.idDisco}"; //solo se alquila de a una pelicula
                        _BD.EjecutarTransaccion(sqltxt);
                    }

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo realizar la operación.");
                }
                finally
                {
                    //_BD.cerrar();
                }
            }

        }
    }
}
