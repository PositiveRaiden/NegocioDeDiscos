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
            string sqltxt = "SELECT * FROM Disco";
            return _BD.consulta(sqltxt);
        }
    }
}
