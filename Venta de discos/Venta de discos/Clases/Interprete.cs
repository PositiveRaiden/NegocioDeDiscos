﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_discos.Clases
{
    class Interprete
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Id_Pais { get; set; }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length < 51)
                return true;
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
