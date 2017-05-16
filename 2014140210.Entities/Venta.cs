using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Entities
{
    public class Venta
    {
        Administrativo administrativo;
        Cliente cliente;
        Servicio servicio;
        TipoPago tipoPago;
        TipoComprobante tipoComprobante;
        TipoViaje tipoViaje;
        
   



        public Venta(int VentaId, Administrativo administratativo, Cliente cliente, TipoComprobante tipoComprobante, Servicio servicio, TipoPago tipoPago, String fechaVenta, TipoViaje tipoViaje)
        {
            this.VentaId = VentaId;
            this.administrativo = administratativo;
            this.cliente = cliente;
            this.servicio = servicio;
            this.tipoPago = tipoPago;
            this.tipoComprobante = tipoComprobante;
            this.costo = servicio.calcularServicio();
            this.FechaVenta = fechaVenta;
            this.tipoViaje = tipoViaje;


        }

        public int VentaId { get; set; }
        public decimal costo { get; set; }
        public String FechaVenta { get; set; }

        public void info()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Cliente: " + this.cliente.nombres + " " + this.cliente.apellidos);
            Console.WriteLine("Comprobante: " + this.tipoComprobante.nombre);
            Console.WriteLine("Precio: " + this.costo);
            Console.WriteLine("Fecha Venta: " + this.FechaVenta);
            Console.WriteLine("Fecha Partida: " + this.servicio.fechaPartida);
            Console.WriteLine("Fecha Llegada: " + this.servicio.fechaLlegada);
            Console.WriteLine("Tipo de pago:  " + this.tipoPago.nombre);
            Console.WriteLine("Servicio:  " + this.servicio);
            Console.WriteLine("Tipo Viaje:  " + this.tipoViaje.nombre);
        }
    }
}
