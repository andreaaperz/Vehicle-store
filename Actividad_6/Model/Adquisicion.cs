using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_6.Model
{
    public class Adquisicion
    {
        public int NumPedido { get; set; }
        public DateTime Fecha { get; set; }
        public Empleado _empleado { get; set; }
        public Vehiculo _vehiculo { get; set; }
        public Cliente _Cliente { get; set; }
    }
}
