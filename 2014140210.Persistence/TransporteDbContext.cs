using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Persistence
{
    class TransporteDbContext : Dbcontext

    {
        public DbSet<Bus>Bus { get; set; }
        public DbSet<Administrativo> Administrativo { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Empleado> Empleado{ get; set; }
        public DbSet<Encomienda> Encomienda { get; set; }
        public DbSet<LugarViaje> LugarViaje { get; set; }

        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<TipoComprobante> TipoComprobante { get; set; }
        public DbSet<TipoLugar> TipoLugar { get; set; }
        public DbSet<TipoPago> TipoPago { get; set; }
        public DbSet<TipoTripulacion> TipoTripulacion { get; set; }

        public DbSet<TipoViaje> TipoViaje { get; set; }
        public DbSet<Transporte> Transporte { get; set; }
        public DbSet<Tripulacion> Tripulacion { get; set; }
        public DbSet<Venta> Venta { get; set; }
    }
}
