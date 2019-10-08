using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_de_discos.Clases;

namespace Venta_de_discos.Repositorios
{

    class SelloRepositorio
    {

        private acceso_BD _BD;
        public SelloRepositorio()
        {
            _BD = new acceso_BD();
        }

        public DataTable ObtenerSello()
        {
            string sqltxt = "SELECT Id, Nombre, Telefono, Email FROM Sello_Discografico";
            return _BD.consulta(sqltxt);
        }

        public SelloDiscografico ObtenerSello(string selloId)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Sello_Discografico] WHERE id = {selloId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
       
            var sello = new SelloDiscografico();

            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                sello.Id = fila.ItemArray[0].ToString(); // Codigo
                sello.Nombre = fila.ItemArray[1].ToString(); // Nombre
                sello.Telefono = fila.ItemArray[2].ToString(); // Telefono
                sello.Email = fila.ItemArray[3].ToString(); // Telefono

            }

            return sello;
        }

        public bool Guardar(SelloDiscografico sello)
        {//ver aca nombre descripcion
            string sqltxt = $"INSERT[dbo].[Sello_Discografico]([Nombre],[Telefono],[Email])" +
                $"VALUES " +
                $"('{sello.Nombre}', " +
                $"'{sello.Telefono}', " +
                $"'{sello.Email}')";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string selloId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Sello_Discografico] WHERE id = {selloId}";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Editar(SelloDiscografico sello)
        {
            string sqltxt = $"UPDATE [dbo].[Sello_Discografico] SET nombre ='{ sello.Nombre }'" +
                $", telefono='{ sello.Telefono}' " +
                $", email='{ sello.Email}' " +
                $"WHERE id= {sello.Id}";
            return _BD.EjecutarSQL(sqltxt);

        }

    }
}
