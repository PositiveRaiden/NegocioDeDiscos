using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos.Clases
{
    class Cliente
    {
        ClientesRepositorio clientesRepositorio = new ClientesRepositorio();
        public string Id { get; set; }
        public string TipoDoc { get; set; }
        public int NumDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public Cliente()
        {

        }

    }
}
