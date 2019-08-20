using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_discos
{
    class Cliente
    {
        string tipoDoc;
        int numDoc;
        string nombre;
        string apellido;
        string direccion;
        int telefono;
        string email;

        public Cliente(string tipoDoc,int numDoc, string nombre, string apellido, string direccion, int telefono, string email)
        {
            this.tipoDoc = tipoDoc;
            this.numDoc = numDoc;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
        }

        public string TipoDoc
        {
            get { return tipoDoc; }
            set { tipoDoc = value; }
        }

        public int NumDoc
        {
            get { return numDoc; }
            set { numDoc = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
