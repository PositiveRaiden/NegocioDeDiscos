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
            //string sqltxt = "SELECT p.id as 'Numero de pedido', p.fechaPedido, di.nombre_Album as 'Disco', d.cantidad as 'Cantidad Pedida' FROM Pedido P, Detalle_Pedido D, Disco Di WHERE D.id_pedido = P.id AND d.id_Disco = Di.id";
            string sqltxt = "SELECT id as 'Numero de pedido', fechaPedido FROM Pedido";
            return _BD.consulta(sqltxt);
        }
        public DataTable ObtenerDetallesPedido(string idPedido)
        {
            //uso para pedidoForm 
            string sqltxt = $"SELECT  di.nombre_Album as 'Nombre album', d.cantidad as 'Cantidad Pedida' FROM Detalle_Pedido D, Disco Di WHERE d.id_Disco = Di.id AND D.id_pedido = {idPedido}";
            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerDetallesPedidoParaModificar(string idPedido)
        {
            //uso para modificar
            string sqltxt = $"SELECT  d.id_Disco,di.nombre_Album as 'Nombre album',d.cantidad as 'Cantidad Pedida' FROM Detalle_Pedido D, Disco Di WHERE d.id_Disco = Di.id AND D.id_pedido = {idPedido}";
            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerPedido(string id)
        {
            //string sqltxt = "SELECT p.id as 'Numero de pedido', p.fechaPedido, di.nombre_Album as 'Disco', d.cantidad as 'Cantidad Pedida' FROM Pedido P, Detalle_Pedido D, Disco Di WHERE D.id_pedido = P.id AND d.id_Disco = Di.id";
            string sqltxt = $"SELECT id as 'Numero de pedido', fechaPedido FROM Pedido WHERE ID= {id}";
            return _BD.consulta(sqltxt);
        }

        public bool Eliminar(string pedidoId)
        {

            string sqltxt1 = $"DELETE FROM [dbo].[Detalle_Pedido] WHERE id_Pedido ={pedidoId}";
            _BD.EjecutarSQL(sqltxt1);

            string sqltxt = $"DELETE FROM [dbo].[Pedido] WHERE id ={pedidoId}";
            return _BD.EjecutarSQL(sqltxt);

        }       

        public void Editar(string idPedido, Pedido p)
        {


            using (var tx = _BD.IniciarTransaccion())
            {
                try
                {
                    //borro detalles viejos y vuelvo a stock anterior
                    string sqltxt1 = $"SELECT D.cantidad, D.id_disco FROM Detalle_Pedido D WHERE id_Pedido = {idPedido}";
                    DataTable dt = _BD.ConsultaDuranteTransaccion(sqltxt1);
                    foreach (DataRow fila in dt.Rows)
                    {
                        string idDisco = fila["id_Disco"].ToString();
                        string cantidadABorrar = fila["cantidad"].ToString();
                        sqltxt1 = $"UPDATE [dbo].[Disco] SET cantidad = cantidad - {cantidadABorrar} WHERE id={idDisco}";
                        _BD.EjecutarSQLEnTransaccion(sqltxt1);
                    }

                    string sqltxt = $"DELETE FROM [dbo].[Detalle_Pedido] WHERE id_Pedido ={idPedido}";
                    _BD.EjecutarSQLEnTransaccion(sqltxt);
                    //hasta aca



                    foreach (var d in p.detallePedidos)
                    {
                        sqltxt = $"INSERT [dbo].[Detalle_Pedido]" +
                            $"([id_Pedido], [Cantidad], [id_Disco]) " +
                            $"VALUES ('{idPedido}', '{d.cantidad}', '{d.idDisco}')";
                        _BD.EjecutarTransaccion(sqltxt);

                        sqltxt = $"SELECT cantidad FROM Disco WHERE id={d.idDisco}";

                        var stock =
                            int.Parse(_BD.ConsultaDuranteTransaccion(sqltxt).Rows[0]["cantidad"].ToString());

                        int number;
                        if (!int.TryParse(d.cantidad, out number))
                        {

                            throw new ApplicationException("La cantidad ingresada no corresponde.");
                        }
                        if (number <= 0)
                        {
                            throw new ApplicationException("La cantidad ingresada no corresponde.");
                        }
                        int nuevoStock = stock + number;


                        sqltxt = $"UPDATE [dbo].[Disco] SET cantidad = '{nuevoStock}' WHERE id={d.idDisco}";
                        _BD.EjecutarTransaccion(sqltxt);
                    }

                    tx.Commit();
                }
                catch (ApplicationException aex)
                {
                    throw aex;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new Exception("No se pudo realizar la operación.");
                }
                finally
                {
                    _BD.cerrar();
                }
            }
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
                        sqltxt = $"INSERT [dbo].[Detalle_Pedido]" +
                            $"([id_Pedido], [Cantidad], [id_Disco]) " +
                            $"VALUES ('{p.id}', '{d.cantidad}', '{d.idDisco}')";
                        _BD.EjecutarTransaccion(sqltxt);

                        sqltxt = $"SELECT cantidad FROM Disco WHERE id={d.idDisco}";

                        var stock =
                            int.Parse(_BD.ConsultaDuranteTransaccion(sqltxt).Rows[0]["cantidad"].ToString());

                        int number;
                        if(!int.TryParse(d.cantidad, out number))
                        {

                            throw new ApplicationException("La cantidad ingresada no corresponde.");
                        }
                        if (number <= 0)
                        {
                            throw new ApplicationException("La cantidad ingresada no corresponde.");
                        }
                        int nuevoStock = stock + number;


                        sqltxt = $"UPDATE [dbo].[Disco] SET cantidad = '{nuevoStock}' WHERE id={d.idDisco}"; 
                        _BD.EjecutarTransaccion(sqltxt);
                    }

                    tx.Commit();
                }
                catch (ApplicationException aex)
                {
                    throw aex;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new Exception("No se pudo realizar la operación.");
                }
                finally
                {
                    _BD.cerrar();
                }
            }

        }
    }
}
