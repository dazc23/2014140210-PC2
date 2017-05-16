using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Entities
{
    public class Administrativo : Empleado
    {
        public String horIn { get; set; }
        public String horFn { get; set; }

        public Administrativo(String nombre, String Apellido, String Correo, decimal Sueldo, String horIn, String horFn) : base(nombre, Apellido, Correo, Sueldo)
        {
            this.horIn = horIn;
            this.horFn = horFn;
        }
    }
}
