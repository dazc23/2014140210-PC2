using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Entities
{
    public class Tripulacion : Empleado
    {
        TipoTripulacion TipoTripulacion;
        int nroViaje;

        public Tripulacion(String nombre, String apellido, String correo, decimal sueldo, TipoTripulacion TipoTripulacion, int nroViaje) : base(nombre, apellido, correo, sueldo)
        {
            this.TipoTripulacion = TipoTripulacion;
            this.nroViaje = nroViaje;
            this.estado = true;

        }

        public bool estado { get; set; }
    }
}
