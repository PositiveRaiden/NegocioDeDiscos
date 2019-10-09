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
    class VentasRepositorio
    {
        private acceso_BD _BD;
        public VentasRepositorio()
        {
            _BD = new acceso_BD();
        }

        public DataTable ObtenerVentas()
        {
            string sqltxt = "SELECT v.id as 'Numero de Venta', v.fecha, v.id_Cliente as 'Número de Cliente', c.Nombre, v.importe_Total as 'Importe Total' FROM Venta v, Cliente c WHERE v.id_Cliente = C.id";
            return _BD.consulta(sqltxt);
        }

        public void Guardar(Venta v)
        {
            using (var tx = _BD.IniciarTransaccion())
            {
                try
                {
                    string sqltxt = $"INSERT [dbo].[Venta] ([fecha])" +
                        $" VALUES ('{UtilsDB.GetFecha(v.fecha)}')";
                    v.id = _BD.EjecutarTransaccion(sqltxt);
                    if (v.id == 0)
                        throw new ApplicationException();

                    foreach (var d in v.detalleVenta)
                    {
                        sqltxt = $"INSERT [dbo].[Detalle_Venta]" +
                            $"([id_Venta], [id_Disco]), [Cantidad], [Precio]" +
                            //$"VALUES ('{v.id_Venta}', '{v.id_disco}','{v.cantidad}', '{v.precio}')";
                        _BD.EjecutarTransaccion(sqltxt);

                        sqltxt = $"SELECT cantidad FROM Disco WHERE id={d.id_disco}";

                        var stock =
                            int.Parse(_BD.ConsultaDuranteTransaccion(sqltxt).Rows[0]["cantidad"].ToString());

                        int number;
                        if (!int.TryParse(d.cantidad, out number))
                        {
                            throw new ApplicationException();
                        }
                        int nuevoStock = stock - number;

                        sqltxt = $"UPDATE [dbo].[Disco] SET cantidad = '{nuevoStock}' WHERE id={d.id_disco}";
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
