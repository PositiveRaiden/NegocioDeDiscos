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


        //TRABAJANDO CON ATRIBUTOS PRIVADOS

        //public Disco(string interprete, string nombreAlbum, string genero, string selloDiscografico, int añoEdicion, int precio, int cantidad)
        //{
        //    this.interprete = interprete;
        //    this.nombreAlbum = nombreAlbum;
        //    this.genero = genero;
        //    this.selloDiscografico = selloDiscografico;
        //    this.añoEdicion = añoEdicion;
        //    this.precio = precio;
        //    this.cantidad = cantidad;


        //}
        //private bool NombreAlbumValido()
        //{
        //    if (!string.IsNullOrEmpty(nombreAlbum) && nombreAlbum.Length < 51)
        //        return true;
        //    return false;
        //}

        //public string Interprete
        //{
        //    get { return interprete; }
        //    set { 
        //            interprete = value;
        //        }
        //}
        //public string NombreAlbum
        //{
        //    get { return nombreAlbum; }
        //    set
        //    {
        //        if (NombreAlbumValido() == true)
        //        { nombreAlbum = value; }

        //    }
        //}
        //public string Genero
        //{
        //    get { return genero; }
        //    set { genero = value; }
        //}
        //public string SelloDiscografico
        //{
        //    get { return selloDiscografico; }
        //    set { selloDiscografico = value; }
        //}
        //public int AñoEdicion
        //{
        //    get { return añoEdicion; }
        //    set { añoEdicion = value; }
        //}
        //public int Precio
        //{
        //    get { return precio; }
        //    set { precio = value; }
        //}
        //public int Cantidad
        //{
        //    get { return cantidad; }
        //    set { cantidad = value; }
        //}




    }
}
