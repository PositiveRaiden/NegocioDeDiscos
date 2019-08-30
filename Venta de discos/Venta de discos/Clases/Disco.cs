using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Venta_de_discos
{
    class Disco
    {
        public string interprete { get; set; } //COMBO
        public string nombreAlbum { get; set; }
        public string genero { get; set; } //COMBO
        public string selloDiscografico { get; set; } //COMBO
        public int añoEdicion { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }


 
        public Disco()
        {

        }

        public bool NombreAlbumValido()
        {
            if (!string.IsNullOrEmpty(nombreAlbum) && nombreAlbum.Length < 51)
                return true;
            return false;
        }


      



    }
}
