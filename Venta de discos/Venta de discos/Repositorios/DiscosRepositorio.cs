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
            string sqltxt = "SELECT D.Nombre_Album,D.Cantidad,D.Precio,D.Año_edicion as 'Año edicion',G.nombre as 'Genero',S.nombre as 'Sello Discografico',I.nombre as 'Interprete'  FROM Disco D, Genero G, Sello_Discografico S, Interprete I where D.id_genero = G.id AND D.id_selloDiscografico = S.id AND D.id_interprete = I.id";
            return _BD.consulta(sqltxt);
        }
        public DataTable ObtenerDiscosPorFiltroInterprete(string interpreteId)
        {
            string sqltxt = "SELECT * FROM Disco where id_interprete="+ interpreteId;
            return _BD.consulta(sqltxt);
        }
    }
}
