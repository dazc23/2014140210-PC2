using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Persistence
{
    class TipoTripulacionConfiguration:EntityTypeConfiguration<TipoTripulacion>
    {
        //Table configurations
            ToTable("TipoTripulacion");
            HasKey(c => c.TipoTripulacionId);
            Property(c => c.Nombre).IsRequired().HasMaxLength(300);

            //Relationships configurations
            HasRequired(c => c.Tripulacion)
                .WithMany(c => c.TipoTripulacion)
                .HasForeignKey(c => c.TripulacionId);
    }
}
