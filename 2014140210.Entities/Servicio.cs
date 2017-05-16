using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Entities
{
    public abstract class Servicio
    {
        public int servicioId { get; set; }
        public string fechaPartida { get; set; }
        public string fechaLlegada { get; set; }
        public abstract decimal calcularServicio();
        public Servicio(int servicioId, string fechaPartida, string fechaLlegada, decimal calcularServicio)
        {
            this.servicioId = servicioId;
            this.fechaPartida = fechaPartida;
            this.fechaLlegada = fechaLlegada;
            
        }

    }
}
