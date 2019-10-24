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
    }
}
