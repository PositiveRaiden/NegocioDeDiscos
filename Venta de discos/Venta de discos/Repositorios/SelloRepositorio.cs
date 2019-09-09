using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_discos.Repositorios
{
    // HACER!!!
    class SelloRepositorio
    {

        private acceso_BD _BD;
        public SelloRepositorio()
        {
            _BD = new acceso_BD();
        }

        public DataTable ObtenerSellos()
        {
            string sqltxt = "SELECT * FROM Sello_Discografico";
            return _BD.consulta(sqltxt);
        }
    }
}
