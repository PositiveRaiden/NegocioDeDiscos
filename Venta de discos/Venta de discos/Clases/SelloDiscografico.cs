using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_de_discos.Repositorios;
using System.Collections;
using System.Data;

namespace Venta_de_discos.Clases
{
    class SelloDiscografico
        //HACER!!
    {
        SelloRepositorio sellosRepositorio = new SelloRepositorio();
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length < 51)
                return true;
            return false;
        }
        public bool NombreRepetido(string nombre)
        {
            var sellos = sellosRepositorio.ObtenerSello();
            ArrayList lista = new ArrayList();
            foreach (DataRow row in sellos.Rows)
            {
                lista.Add(Convert.ToString(row["nombre"]));
            }
            if (lista.Contains(nombre))
            {
                return true;
            }
            return false;
        }

        public bool TelefonoValido()
        {
            if (Telefono.Length < 51)
                return true;
            return false;
        }

        public bool EmailValido()
        {
            if (Email.Length < 51)
                return true;
            return false;
        }
    }


}
