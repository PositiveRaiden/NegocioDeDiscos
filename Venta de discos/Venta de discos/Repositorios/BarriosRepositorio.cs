using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_de_discos.Clases;

namespace Venta_de_discos.Repositorios
{
    class BarriosRepositorio
    {

        private acceso_BD _BD;
        public BarriosRepositorio()
        {
            _BD = new acceso_BD();
        }

        public DataTable ObtenerBarrio()
        {
            string sqltxt = "SELECT * FROM Barrio";
            return _BD.consulta(sqltxt);
        }

        public Barrio ObtenerBarrio(string barrioId)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Barrio] WHERE id = {barrioId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var barrio = new Barrio();

            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                barrio.Id = fila.ItemArray[0].ToString(); // Codigo
                barrio.Nombre = fila.ItemArray[1].ToString(); // Nombre
                barrio.Localidad = fila.ItemArray[2].ToString(); // Localidad
            }

            return barrio;
        }

        public bool Guardar(Barrio barrio)
        {//ver aca nombre descripcion
            string sqltxt = $"INSERT[dbo].[Barrio]([Nombre],[Localidad])" +
                $"VALUES " + 
                $"('{barrio.Nombre}', " +
                $"'{barrio.Localidad}')";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string barrioId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Barrio] WHERE id = {barrioId}";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Editar(Barrio barrio)
        {
            string sqltxt = $"UPDATE [dbo].[barrio] SET nombre ='{ barrio.Nombre }'" +
                $", localidad='{ barrio.Localidad}' " +
                $"WHERE id= {barrio.Id}";
            return _BD.EjecutarSQL(sqltxt);

        }
    }
}
