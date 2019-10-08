using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_de_discos.Clases;

namespace Venta_de_discos.Repositorios
{
    class ClientesRepositorio
    {
        private acceso_BD _BD;
        public ClientesRepositorio()
        {
            _BD = new acceso_BD();
        }

        //aca
        public DataTable ObtenerCliente()
        {
            //string sqltxt = "SELECT Id,Nombre,Apellido,Calle,NumDoc,id_TipoDocumento FROM Cliente";
            string sqltxt = "SELECT Cliente.Id,Cliente.Nombre,Cliente.Apellido,Cliente.Calle,Cliente.NumDoc,TipoDoc.nombre FROM Cliente, TipoDoc WHERE Cliente.id_TipoDocumento=TipoDoc.id";
            return _BD.consulta(sqltxt);
        }

        //aca
        public Cliente ObtenerCliente(string clienteId)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Cliente] WHERE id = {clienteId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var cliente = new Cliente();

            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; 

                cliente.Id = fila.ItemArray[0].ToString();
                cliente.Nombre = fila.ItemArray[1].ToString();
                cliente.Apellido = fila.ItemArray[2].ToString();
                cliente.Calle = fila.ItemArray[3].ToString();
                cliente.NumDoc = fila.ItemArray[4].ToString();
                cliente.Id_TipoDoc = fila.ItemArray[5].ToString();
                //cliente.TipoDoc = fila.ItemArray[5].ToString();
            }

            return cliente;
        }

        //aca
        public bool Guardar(Cliente cliente)
        {
            string sqltxt = $"INSERT[dbo].[Cliente]([Nombre],[Apellido],[Calle],[NumDoc],[id_TipoDocumento],[id_Barrio])" +
                $"VALUES " +
                $"('{cliente.Nombre}', " +
                $"'{cliente.Apellido}'," +
                $"'{cliente.Calle}'," +
                $"'{cliente.NumDoc}'," +
                $"'{cliente.Id_TipoDoc}'," +
                $"'{cliente.Id_Barrio}')";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string clienteId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Cliente] WHERE id = {clienteId}";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Editar(Cliente cliente)
        {
            string sqltxt = $"UPDATE [dbo].[cliente] SET nombre ='{ cliente.Nombre }'" +
                $", apellido='{ cliente.Apellido}' " +
                $", calle='{ cliente.Calle}' " +
                $", numDoc='{ cliente.NumDoc}' " +
                $"WHERE id= {cliente.Id}";
            return _BD.EjecutarSQL(sqltxt);

        }
    }
}
