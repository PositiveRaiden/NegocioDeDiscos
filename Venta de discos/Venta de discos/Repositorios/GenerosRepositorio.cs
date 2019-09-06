using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_de_discos.Clases;

namespace Venta_de_discos.Repositorios
{
    class GenerosRepositorio
    {
        private acceso_BD _BD;
        public GenerosRepositorio()
        {
            _BD = new acceso_BD();
        }

        public DataTable ObtenerGenero()
        {
            string sqltxt = "SELECT Nombre, Descripcion FROM Genero";
            return _BD.consulta(sqltxt);
        }

        public Genero ObtenerGenero (string generoId)
        {
            string sqltxt = $"SELECT Nombre, Descripcion FROM [dbo].[Genero] WHERE id = {generoId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var genero = new Genero();

            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                genero.Id = fila.ItemArray[0].ToString(); // Codigo
                genero.Nombre = fila.ItemArray[1].ToString(); // Nombre
                genero.Descripcion = fila.ItemArray[2].ToString(); // Descripcion
            }

            return genero;
        }

        public bool Guardar(Genero genero)
        {
            string sqltxt = $"INSERT[dbo].[Genero]([Nombre],[Descripcion])" +
                $"VALUES " +
                $"('{genero.Nombre}', " +
                $"'{genero.Descripcion}')";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string generoId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Genero] WHERE id = {generoId}";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Editar(Genero genero)
        {
            string sqltxt = $"UPDATE [dbo].[genero] SET nombre ='{ genero.Nombre }'" +
                $", descripcion='{ genero.Descripcion}' " +
                $"WHERE id= {genero.Id}";
            return _BD.EjecutarSQL(sqltxt);

        }
    }
}

