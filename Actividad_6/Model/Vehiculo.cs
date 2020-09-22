using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_6.Model
{
    public class Vehiculo
    {
        public string Tipo { get; set; }
        public double Precio { get; set; }
        public string Version { get; set; }
        public string NumSerie { get; set; }
        public string Color { get; set; }
        public Categoria _Categoria { get; set; }
    }
}
