using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registromigrante.shared
{
    public class Formulario
    {
        public int id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellidos { get; set; } = string.Empty;

        public int Edad { get; set; }

        public string OcupacionPrevia { get; set; } = string.Empty;
        public string OcupacionDeseada { get; set; } = string.Empty;

        public string LugarOrigen { get; set; } = string.Empty;

        public string Observaciones { get; set; } = string.Empty;
    }
}
