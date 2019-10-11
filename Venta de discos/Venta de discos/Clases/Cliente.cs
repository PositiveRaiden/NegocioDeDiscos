using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos.Clases
{
    class Cliente
    {
        ClientesRepositorio clientesRepositorio = new ClientesRepositorio();
        public string Id { get; set; }
        public string Id_TipoDoc { get; set; }
        public string Id_Barrio { get; set; }
        public string NumDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public string TipoDoc { get; set; }
        public string Barrio { get; set; }


        public Cliente()
        {

        }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length < 25)
                return true;
            return false;
        }
        public bool ApellidoValido()
        {
            if (!string.IsNullOrEmpty(Apellido) && Apellido.Length < 25)
                return true;
            return false;
        }
        public bool CalleValida()
        {
            if (!string.IsNullOrEmpty(Calle) && Calle.Length < 30)
                return true;
            return false;
        }
        //TIPOS DE DOCUMENTO
        public bool DNIValido()
        {
            int number;
            if (!string.IsNullOrEmpty(NumDoc) && NumDoc.Length == 8 && int.TryParse(NumDoc, out number))
                return true;
            return false;
        }
        public bool LCValido()
        {
            int number;
            if (!string.IsNullOrEmpty(NumDoc) && NumDoc.Length == 7 && int.TryParse(NumDoc, out number))
                return true;
            return false;
        }
        public bool PasaporteValido()
        {
            String expresion;
            expresion = "^[a-z]{3}[0-9]{6}[a-z]{1}$";
            if (Regex.IsMatch(NumDoc, expresion))
            {
                if (Regex.Replace(NumDoc, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool numDocRepetido(string numDoc)
        {
            var clientes = clientesRepositorio.ObtenerCliente();
            ArrayList lista = new ArrayList();
            foreach (DataRow row in clientes.Rows)
            {
                lista.Add(Convert.ToString(row["numDoc"]));
            }
            if (lista.Contains(numDoc))
            {
                return true;
            }
            return false;
        }




    }
}
