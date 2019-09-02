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
    class Interprete
    {
        InterpretesRepositorio interpretesRepositorio = new InterpretesRepositorio();
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Id_Pais { get; set; }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length < 51)
                return true;
            return false;
        }
        public bool NombreRepetido(string nombre)
        {
            var interpretes = interpretesRepositorio.ObtenerInterpretes();
            ArrayList lista = new ArrayList();
            foreach (DataRow row in interpretes.Rows)
            {
                lista.Add(Convert.ToString(row["nombre"]));
            }
            if (lista.Contains(nombre))
            {
               return true;
            }
            return false;
        }

        public bool IdValido()
        {
            if (!string.IsNullOrEmpty(Id_Pais) && int.Parse(Id_Pais) >= 1)
                return true;
            return false;
        }




    }
}
