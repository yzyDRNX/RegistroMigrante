using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registromigrante.shared
{
    internal class Login
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;

        public DateTime FechaCreacion { get; set; }

        public DateTime UltimoAcceso { get; set; }
    }
}
