using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_discos.Clases;
using Venta_de_discos.Helpers;

namespace Venta_de_discos.Repositorios
{
    class VentasRepositorio
    {
        private acceso_BD _BD;
        public VentasRepositorio()
        {
            _BD = new acceso_BD();
        }

        public DataTable ObtenerVentas()
        {
            string sqltxt = "SELECT v.id as 'Numero de Venta', v.fecha as 'Fecha', " +
                "v.id_Cliente as 'Número de Cliente', c.Nombre, v.importe_Total as 'Importe Total' FROM Venta v, " +
                "Cliente c WHERE v.id_Cliente = c.id";
            return _BD.consulta(sqltxt);
        }

        public void Guardar(Venta v)
        {
            using (var tx = _BD.IniciarTransaccion())
            {
                try
                {
                    string sqltxt = $"INSERT [dbo].[Venta] ([fecha],[id_Cliente],[importe_Total])" +
                        $" VALUES ('{UtilsDB.GetFecha(v.fecha)}','{v.id_Cliente}','{v.importe_Total}')";
                    v.id = _BD.EjecutarTransaccion(sqltxt);
                    if (v.id == 0)
                        throw new ApplicationException();

                    foreach (var d in v.detalleVentas)
                    {
                         sqltxt = $"INSERT [dbo].[Detalle_Venta] " +
                            $"([id_Venta], [id_disco], [cantidad], [precio])" +
                            $" VALUES ('{v.id}','{d.id_disco}','{d.cantidad}','{d.precio}')";
                        _BD.EjecutarTransaccion(sqltxt);


                        sqltxt = $"SELECT cantidad FROM Disco WHERE id={d.id_disco}";

                        var stock =
                            int.Parse(_BD.ConsultaDuranteTransaccion(sqltxt).Rows[0]["cantidad"].ToString());

                        int number;
                        if (!int.TryParse(d.cantidad, out number))
                        {
                            throw new ApplicationException();
                        }
                        if (number <= 0)
                        {
                            throw new ApplicationException("La cantidad ingresada no corresponde.");
                        }
                        int nuevoStock = stock - number;
                        if(nuevoStock < 0)
                        {
                            throw new ApplicationException("No hay stock suficiente.");
                        }

                        sqltxt = $"UPDATE [dbo].[Disco] SET cantidad = '{nuevoStock}' WHERE id={d.id_disco}";
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

        public DataTable ObtenerDetallesVenta(string idVenta)
        {
            //uso para ventasForm 
            string sqltxt = $"SELECT  di.nombre_Album as 'Nombre album', d.cantidad as 'Cantidad Vendida' FROM Detalle_Venta D, Disco Di WHERE d.id_disco = Di.id AND D.id_Venta = {idVenta}";
            return _BD.consulta(sqltxt);


        }

        public bool Eliminar(string ventaId)
        {

            string sqltxt1 = $"DELETE FROM [dbo].[Detalle_Venta] WHERE id_Venta ={ventaId}";
            _BD.EjecutarSQL(sqltxt1);

            string sqltxt = $"DELETE FROM [dbo].[Venta] WHERE id ={ventaId}";
            return _BD.EjecutarSQL(sqltxt);



        }

        public DataTable ObtenerVenta()
        {
            //string sqltxt = "SELECT p.id as 'Numero de pedido', p.fechaPedido, di.nombre_Album as 'Disco', d.cantidad as 'Cantidad Pedida' FROM Pedido P, Detalle_Pedido D, Disco Di WHERE D.id_pedido = P.id AND d.id_Disco = Di.id";
            string sqltxt = "SELECT id as 'Numero de Venta', fecha FROM Venta";
            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerVenta(string id)
        {
            //string sqltxt = "SELECT p.id as 'Numero de pedido', p.fechaPedido, di.nombre_Album as 'Disco', d.cantidad as 'Cantidad Pedida' FROM Pedido P, Detalle_Pedido D, Disco Di WHERE D.id_pedido = P.id AND d.id_Disco = Di.id";
            string sqltxt = $"SELECT id as 'Numero de Venta', fecha FROM Venta WHERE ID= {id}";
            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerDetallesVentaParaModificar(string idVenta)
        {
            //uso para modificar
            string sqltxt = $"SELECT  d.id_Disco,di.nombre_Album as 'Nombre album',d.cantidad as 'Cantidad Vendida' FROM Detalle_Venta D, Disco Di WHERE d.id_Disco = Di.id AND D.id = {idVenta}";
            return _BD.consulta(sqltxt);
        }

        public void Editar(string idVenta, Venta v)
        {


            using (var tx = _BD.IniciarTransaccion())
            {
                try
                {
                    //borro detalles viejos y vuelvo a stock anterior
                    string sqltxt1 = $"SELECT D.cantidad, D.id_disco FROM Detalle_Venta D WHERE id_Venta = {idVenta}";
                    DataTable dt = _BD.ConsultaDuranteTransaccion(sqltxt1);
                    foreach (DataRow fila in dt.Rows)
                    {
                        string idDisco = fila["id_Disco"].ToString();
                        string cantidadABorrar = fila["cantidad"].ToString();
                        sqltxt1 = $"UPDATE [dbo].[Disco] SET cantidad = cantidad - {cantidadABorrar} WHERE id={idDisco}";
                        _BD.EjecutarSQLEnTransaccion(sqltxt1);
                    }

                    string sqltxt = $"DELETE FROM [dbo].[Detalle_Venta] WHERE id_Venta ={idVenta}";
                    _BD.EjecutarSQLEnTransaccion(sqltxt);
                    //hasta aca



                    foreach (var d in v.detalleVentas)
                    {
                        sqltxt = $"INSERT [dbo].[Detalle_Venta]" +
                            $"([id_Venta], [Cantidad], [id_Disco]) " +
                            $"VALUES ('{idVenta}', '{d.cantidad}', '{d.id_disco}')";
                        _BD.EjecutarTransaccion(sqltxt);

                        sqltxt = $"SELECT cantidad FROM Disco WHERE id={d.id_disco}";

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


                        sqltxt = $"UPDATE [dbo].[Disco] SET cantidad = '{nuevoStock}' WHERE id={d.id_disco}";
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

        //public DataTable ObtenerVentasPorFecha(string fecha)
        //{
        //    string sqltxt = "SELECT v.id as 'Numero de Venta', v.fecha as 'Fecha', " +
        //        "v.id_Cliente as 'Número de Cliente', c.Nombre, v.importe_Total as 'Importe Total' FROM Venta v, " +
        //        $"Cliente c WHERE v.id_Cliente = c.id AND v.fecha = {fecha}";
        //    return _BD.consulta(sqltxt);
        //}
    }
}
