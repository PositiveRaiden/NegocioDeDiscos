using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_discos.Repositorios
{
    class AjustesRepositorio
    {
        private acceso_BD _BD;

        public AjustesRepositorio()
        {
            _BD = new acceso_BD();
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
                $", stock_minimo= {disco.stock_minimo}" +
                $" WHERE id= {disco.Id}";

            return _BD.EjecutarSQL(sqltxt);
        }
        public bool GuardarAjuste(string id, string cantidad, string fecha, string descripcion)
        {
            string sqltxt = $"UPDATE [dbo].[Disco] SET cantidad ='{cantidad}'"+
                $" WHERE id= {id}";
            _BD.EjecutarSQL(sqltxt);
            
            string sqltxt1 = $"INSERT[dbo].[Ajuste_Disco]([id_disco],[fecha],[descripcion])" +
                $"VALUES " +
                $"('{id}', " +
                $"'{fecha}', " +
                $"'{descripcion}')";

            return _BD.EjecutarSQL(sqltxt1);
        }


    }
}
