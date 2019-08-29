using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Venta_de_discos
{
    class Disco
    {
        private string interprete;
        private string nombreAlbum;
        private string genero;
        private string selloDiscografico;
        private int añoEdicion;
        private int precio;
        private int cantidad;

        public Disco(string interprete, string nombreAlbum, string genero, string selloDiscografico, int añoEdicion, int precio, int cantidad)
        {
            this.interprete = interprete;
            this.nombreAlbum = nombreAlbum;
            this.genero = genero;
            this.selloDiscografico = selloDiscografico;
            this.añoEdicion = añoEdicion;
            this.precio = precio;
            this.cantidad = cantidad;


        }

        public string Interprete
        {
            get { return interprete; }
            set { interprete = value; }
        }
        public string NombreAlbum
        {
            get { return nombreAlbum; }
            set { nombreAlbum = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string SelloDiscografico
        {
            get { return selloDiscografico; }
            set { selloDiscografico = value; }
        }
        public int AñoEdicion
        {
            get { return añoEdicion; }
            set { añoEdicion = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }




    }
}
