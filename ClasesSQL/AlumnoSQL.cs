using Gestion_de_notas.ClasesDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_notas.ClasesSQL
{
    class AlumnoSQL
    {
        ConexionSQL conexion;
        public AlumnoSQL()
        {
            conexion = new ConexionSQL();
        }

        public bool Agregar(AlumnoDatos alumnoDatos)
        {
            try
            {
                SqlCommand SQLcomando = new SqlCommand("INSERT INTO Alumno (nombreAlumno, apellidoAlumno, fechaNacAlumno, generoAlumno, direccionAlumno, fotoAlumno, idEscuela) " +
                                   "VALUES (@nombreAlumno, @apellidoAlumno, @fechaNacAlumno, @generoAlumno, @direccionAlumno, @fotoAlumno, @idEscuela)");

                SQLcomando.Parameters.Add("@nombreAlumno", SqlDbType.NVarChar).Value=alumnoDatos.NombreAlumno;
                SQLcomando.Parameters.Add("@apellidoAlumno", SqlDbType.NVarChar).Value=alumnoDatos.ApellidoAlumno;
                SQLcomando.Parameters.Add("@fechaNacAlumno", SqlDbType.Date).Value = alumnoDatos.FechaNacAlumno.ToString("yyyy-MM-dd");
                SQLcomando.Parameters.Add("@generoAlumno", SqlDbType.NVarChar).Value=alumnoDatos.GeneroAlumno;
                SQLcomando.Parameters.Add("@direccionAlumno", SqlDbType.NVarChar).Value=alumnoDatos.DireccionAlumno;
                //SQLcomando.Parameters.Add("@fotoAlumno", SqlDbType.VarBinary, -1).Value = alumnoDatos.FotoAlumno;
                SQLcomando.Parameters.Add("@fotoAlumno", SqlDbType.Image).Value = alumnoDatos.FotoAlumno;
                SQLcomando.Parameters.Add("@idEscuela", SqlDbType.Int).Value=alumnoDatos.IdEscuela;
            
                return conexion.comandosSinRetornoDatos(SQLcomando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la consulta: " + ex.Message);
                return false;
            }
        }

        public DataSet mostrarAlumno()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Alumno");
            return conexion.ejecutarSentencia(sentencia);
        }

    }
}
