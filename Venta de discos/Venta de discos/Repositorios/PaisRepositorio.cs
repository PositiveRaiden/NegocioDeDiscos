using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Venta_de_discos.Clases;

namespace Venta_de_discos.Repositorios
{
    class PaisRepositorio
    {
        private acceso_BD _BD;

        public PaisRepositorio()
        {
            _BD = new acceso_BD();

        }
        public DataTable ObtenerPais()
        {
            string sqltxt = "SELECT P.id,P.nombre FROM Pais P";
            return _BD.consulta(sqltxt);
        }

        public Pais ObtenerPais(string paisId)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Pais] WHERE id = {paisId}";

            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var pais = new Pais();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                pais.Id = fila.ItemArray[0].ToString(); // Codigo
                pais.Nombre = fila.ItemArray[1].ToString(); // Nombre
            }

            return pais;
        }
        

        public bool Guardar(Pais pais)
        {
            string sqltxt = $"INSERT[dbo].[pais]([Nombre])" +
                $"VALUES " +
                $"('{pais.Nombre}')";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string paisId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Pais] WHERE id = {paisId}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Editar(Pais pais)
        {
            string sqltxt = $"UPDATE [dbo].[pais] SET nombre =' { pais.Nombre} '"+ $"WHERE id= {pais.Id}"; ;

            return _BD.EjecutarSQL(sqltxt);
        }
    }
}
