using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_notas.ClasesDatos
{
    internal class AlumnoDatos
    {
        private int nieAlumno;
        private string nombreAlumno;
        private string apellidoAlumno;
        private DateOnly fechaNacAlumno;
        private string generoAlumno;
        private string direccionAlumno;
        private byte[] fotoAlumno;
        private int idEscuela;

        public AlumnoDatos()
        {
        }

        public int NieAlumno { get => nieAlumno; set => nieAlumno = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string ApellidoAlumno { get => apellidoAlumno; set => apellidoAlumno = value; }
        public DateOnly FechaNacAlumno { get => fechaNacAlumno; set => fechaNacAlumno = value; }
        public string GeneroAlumno { get => generoAlumno; set => generoAlumno = value; }
        public string DireccionAlumno { get => direccionAlumno; set => direccionAlumno = value; }
        public byte[] FotoAlumno { get => fotoAlumno; set => fotoAlumno = value; }
        public int IdEscuela { get => idEscuela; set => idEscuela = value; }
    }
}
