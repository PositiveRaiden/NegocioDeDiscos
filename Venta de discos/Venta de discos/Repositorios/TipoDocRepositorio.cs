using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Venta_de_discos.Clases;

namespace Venta_de_discos.Repositorios
{
    class TipoDocRepositorio
    {
        private acceso_BD _BD;

        public TipoDocRepositorio()
        {
            _BD = new acceso_BD();
        }

        public DataTable ObtenerTipoDoc()
        {
            string sqltxt = "SELECT id,nombre FROM TipoDoc";
            return _BD.consulta(sqltxt);
        }

        public TipoDoc ObtenerTipoDoc(string tipoDocId)
        {
            string sqltxt = $"SELECT * FROM [dbo].[TipoDoc] WHERE id = {tipoDocId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var tipoDoc = new TipoDoc();

            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                tipoDoc.Id = fila.ItemArray[0].ToString(); // id
                tipoDoc.Nombre = fila.ItemArray[1].ToString(); // Nombre
            }

            return tipoDoc;
        }
    }
}
