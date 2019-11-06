using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Venta_de_discos
{
    class Disco
    {
        public string Id { get; set; }
        public string id_interprete { get; set; } //COMBO
        public string nombreAlbum { get; set; }
        public string id_genero { get; set; } //COMBO
        public string id_selloDiscografico { get; set; } //COMBO
        public string añoEdicion { get; set; }
        public string precio { get; set; }
        public string cantidad { get; set; }
        public string stock_minimo { get; set; }
        DiscosRepositorio discosRepositorio = new DiscosRepositorio();

 
        public Disco()
        {

        }

        public bool NombreAlbumValido()
        {
            if (!string.IsNullOrEmpty(nombreAlbum) && nombreAlbum.Length < 25)
                return true;
            return false;
        }

        public bool NombreRepetido(string nombre)
        {
            var discos = discosRepositorio.ObtenerDiscos();
            ArrayList lista = new ArrayList();
            foreach (DataRow row in discos.Rows)
            {
                lista.Add(Convert.ToString(row["nombre Album"]));
            }
            if (lista.Contains(nombre))
            {
                return true;
            }
            return false;
        }

        public bool AñoValido(string año)
        {
            int number;
            int.TryParse(año, out number);
            if (number>1500 && number<= DateTime.Today.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool PrecioValido(string precio)
        {
            int number;
            int.TryParse(precio, out number);
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool StockValido(string stock_minimo)
        {
            int number;
            int.TryParse(stock_minimo, out number);
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
