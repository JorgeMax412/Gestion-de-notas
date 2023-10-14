using Gestion_de_notas.ClasesDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_notas.ClasesSQL
{
    class EscuelaSQL
    {
        ConexionSQL conexion;
        public EscuelaSQL()
        { 
            conexion = new ConexionSQL();
        }

        public bool Agregar(EscuelaDatos escuelaDatos)
        {
            try
            {
                return conexion.comandosSinRetornoDatos($"INSERT INTO Escuela (nombreEscuela, direccionEscuela) VALUES ('{escuelaDatos.NombreEscuela}', '{escuelaDatos.DireccionEscuela}')");
            }
            catch 
            {
                return false; 
            }
        }

        public int Eliminar(EscuelaDatos escuelaDatos)
        {
            conexion.comandosSinRetornoDatos("DELETE FROM Escuela WHERE idEscuela =" + escuelaDatos.IdEscuela);
            return 1;
        }

        public int Editar(EscuelaDatos escuelaDatos)
        { 
            conexion.comandosSinRetornoDatos($"UPDATE Escuela SET nombreEscuela = '{escuelaDatos.NombreEscuela}', direccionEscuela = '{escuelaDatos.DireccionEscuela}' WHERE idEscuela = {escuelaDatos.IdEscuela}");
            return 1;
        }

        public DataSet mostrarEscuela()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Escuela");
            return conexion.ejecutarSentencia(sentencia);
        }
    }
}
