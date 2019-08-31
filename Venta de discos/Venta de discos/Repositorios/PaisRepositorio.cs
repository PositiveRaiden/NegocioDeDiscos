using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Venta_de_discos.Repositorios
{
    class PaisRepositorio
    {
        private acceso_BD _BD;

        public PaisRepositorio()
        {
            _BD = new acceso_BD();

        }

        public DataTable ObtenerPais()
        {
            string sqltxt = "SELECT * FROM Pais ORDER BY nombre";

            return _BD.consulta(sqltxt);
        }
    }
}
