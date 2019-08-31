using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Venta_de_discos.Clases;

namespace Venta_de_discos.Repositorios
{
    class InterpretesRepositorio
    {
        private acceso_BD _BD;
        public InterpretesRepositorio()
        {
            _BD = new acceso_BD();
        }

        public DataTable ObtenerInterpretes()
        {
            string sqltxt = "SELECT I.Id,I.Nombre, P.nombre as 'Pais' FROM Interprete I, Pais P where I.id_pais=P.id";
            return _BD.consulta(sqltxt);
        }

        public Interprete ObtenerInterprete(string interpreteId)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Interprete] WHERE id = {interpreteId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var interprete = new Interprete();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                interprete.Id = fila.ItemArray[0].ToString(); // Codigo
                interprete.Nombre = fila.ItemArray[1].ToString(); // Nombre
                interprete.Id_Pais   = fila.ItemArray[2].ToString(); // Nacionalidad
            }

            return interprete;
        }

        public bool Guardar(Interprete interprete)
        {
            string sqltxt = $"INSERT[dbo].[interprete]([Nombre],[id_Pais])" +
                $"VALUES " +
                $"('{interprete.Nombre}', " +
                $"'{interprete.Id_Pais}')";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string interpreteId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Interprete] WHERE id = {interpreteId}";
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Editar(Interprete interprete)
        {
            string sqltxt = $"UPDATE [dbo].[interprete] SET nombre =' { interprete.Nombre } '" +
                $", id_pais= { interprete.Id_Pais }"  +
                $"WHERE id= {interprete.Id}";

            return _BD.EjecutarSQL(sqltxt);
        }


    }
}
