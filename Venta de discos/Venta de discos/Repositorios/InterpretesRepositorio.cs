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

        public DataTable ObtenerInterprete()
        {
            string sqltxt = "SELECT * FROM Interprete";
            return _BD.consulta(sqltxt);
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


    }
}
