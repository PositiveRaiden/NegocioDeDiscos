using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Venta_de_discos
{

    class discoRepertorio
    {
        private acceso_BD _BD;
        public void DiscoRepertorio()
        {
            _BD = new acceso_BD();
        }

        public DataTable ObtenerInterprete()
        {
            string sqltxt = "select * FROM Interprete";
            return _BD.consulta(sqltxt);
        }
    }
}
