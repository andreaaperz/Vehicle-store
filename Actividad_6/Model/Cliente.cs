using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_6.Model
{
    public class Cliente : Usuario
    {
        public string Nombre { get; set; }
        public string ApMaterno { get; set; }
        public string ApPaterno { get; set; }
        public int NumCuenta { get; set; }
        public string Email { get; set; }

    }
}
