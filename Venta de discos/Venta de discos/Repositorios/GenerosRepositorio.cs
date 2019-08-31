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
            string sqltxt = "SELECT * FROM Genero";
            return _BD.consulta(sqltxt);
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

    }
}
