using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_notas.ClasesDatos
{
    class EscuelaDatos
    {
        private int idEscuela;
        private string nombreEscuela;
        private string direccionEscuela;

        public EscuelaDatos()
        {
        }

        public int IdEscuela { get => idEscuela; set => idEscuela = value; }
        public string NombreEscuela { get => nombreEscuela; set => nombreEscuela = value; }
        public string DireccionEscuela { get => direccionEscuela; set => direccionEscuela = value; }
    }
}
