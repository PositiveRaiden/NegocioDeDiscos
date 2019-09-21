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
        DiscosRepositorio discosRepositorio = new DiscosRepositorio();

 
        public Disco()
        {

        }

        public bool NombreAlbumValido()
        {
            if (!string.IsNullOrEmpty(nombreAlbum) && nombreAlbum.Length < 51)
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
            if (number>1800 && number<2019)
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







    }
}
