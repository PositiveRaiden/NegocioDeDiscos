using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Venta_de_discos
{

    class DiscosRepositorio
    {
        private acceso_BD _BD;

        public DiscosRepositorio()
        {
            _BD = new acceso_BD();
        }

        public DataTable ObtenerInterprete()
        {
            string sqltxt = "SELECT * FROM Interprete";
            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerDiscos()
        {
            string sqltxt = "SELECT D.id,D.Nombre_Album as 'Nombre Album',D.Cantidad,D.Precio,D.Año_edicion as 'Año edicion'," +
                "G.nombre as 'Genero',S.nombre as 'Sello Discografico',I.nombre as 'Interprete', D.stock_minimo as 'Stock Minimo'" +
                " FROM Disco D, Genero G, Sello_Discografico S, Interprete I " +
                "WHERE D.id_genero = G.id AND D.id_selloDiscografico = S.id AND D.id_interprete = I.id";
            return _BD.consulta(sqltxt);
        }
        public Disco ObtenerDisco(string discoId)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Disco] WHERE id = {discoId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var disco = new Disco();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                disco.Id = fila.ItemArray[0].ToString(); // Codigo
                disco.nombreAlbum = fila.ItemArray[1].ToString(); // Nombre
                disco.cantidad = fila.ItemArray[2].ToString(); // Nacionalidad
                disco.precio = fila.ItemArray[3].ToString();
                disco.añoEdicion = fila.ItemArray[4].ToString();
                disco.id_genero = fila.ItemArray[5].ToString();
                disco.id_selloDiscografico = fila.ItemArray[6].ToString();
                disco.id_interprete = fila.ItemArray[7].ToString();
                disco.stock_minimo = fila.ItemArray[8].ToString();
            }

            return disco;
        }

        public DataTable ObtenerDiscosPorFiltroInterprete(string interpreteId)
        {
            string sqltxt = "SELECT D.id,D.Nombre_Album as 'Nombre Album',D.Cantidad,D.Precio,D.Año_edicion as 'Año edicion',G.nombre as 'Genero',S.nombre as 'Sello Discografico',I.nombre as 'Interprete'  FROM Disco D, Genero G, Sello_Discografico S, Interprete I where D.id_genero = G.id AND D.id_selloDiscografico = S.id AND D.id_interprete = I.id AND id_interprete=" + interpreteId;
            return _BD.consulta(sqltxt);
        }

        public bool Guardar(Disco disc)
        {
            string sqltxt = $"INSERT[dbo].[Disco]([nombre_album],[cantidad],[precio],[año_edicion],[id_genero],[id_selloDiscografico],[id_interprete],[stock_minimo])" +
                $"VALUES " +
                $"('{disc.nombreAlbum}', " +
                $"'{disc.cantidad}', " +
                $"'{disc.precio}'," +
                $"'{disc.añoEdicion}'," +
                $"'{disc.id_genero}'," +
                $"'{disc.id_selloDiscografico}'," +
                $"'{disc.id_interprete}'," +
                $"'{disc.stock_minimo}')";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string discoId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Disco] WHERE id ={discoId}";
            return _BD.EjecutarSQL(sqltxt);
        }


        public bool Editar(Disco disco)
        {
            string sqltxt = $"UPDATE [dbo].[Disco] SET nombre_album ='{ disco.nombreAlbum }'" +
                $", cantidad= { disco.cantidad }" +
                $", precio= { disco.precio }" +
                $", año_edicion= { disco.añoEdicion }" +
                $", id_genero= { disco.id_genero }" +
                $", id_selloDiscografico= { disco.id_selloDiscografico }" +
                $", id_interprete= { disco.id_interprete }" +
                $", stock_minimo= {disco.stock_minimo}"+
                $" WHERE id= {disco.Id}";

            return _BD.EjecutarSQL(sqltxt);
        }
        public DataTable PodraEliminar(string idDisco)
        {
            //select V.id from Venta V JOIN Detalle_Venta De on v.id = De.id_Venta
            string sqltxt = "SELECT V.id from Venta V JOIN Detalle_Venta De ON v.id = De.id_Venta" +
                " JOIN Disco D ON De.id_Disco = D.id " +
                $"WHERE d.Id = {idDisco}";
            return _BD.consulta(sqltxt);
        }
    }
}
