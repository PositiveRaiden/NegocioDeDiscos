using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos.Clases
{
    class TipoDoc
    {
        BarriosRepositorio barriosRepositorio = new BarriosRepositorio();
        public string Id { get; set; }
        public string Nombre { get; set; }
    }
}
