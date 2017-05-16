using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Entities
{
    public class Empleado
    {
        public int empleadoId { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String correo { get; set; }
        public decimal sueldo { get; set; }

        public Empleado(int empleadoId,String nombre, String apellido, String correo, decimal sueldo)
        {
            this.empleadoId = empleadoId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.sueldo = sueldo;
        }
    }
}
