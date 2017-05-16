using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Persistence
{
    class TipoPagoConfiguration:EntityTypeConfiguration<TipoPago>
    {
            //Table configurations
                ToTable("TipoPago");
                HasKey(c => c.TipoPagoId);
                Property(c => c.MetodoPago).IsRequired().HasMaxLength(300);

                //Relationships configurations
                HasRequired(c => c.Venta)
                    .WithMany(c => c.TipoPago)
                    .HasForeignKey(c => c.VentaId);
    }
}
