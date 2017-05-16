using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Persistence
{
    class LugarViajeConfiguration:EntityTypeConfiguration<LugarViaje>
    {
         //Table configurations
            ToTable("LugarViaje");
            HasKey(c => c.LugarViajeId);
            Property(c => c.NombreLugar).IsRequired().HasMaxLength(300);

            //Relationships Configurations
            HasMany(c => c.TipoLugar)
                .WithRequired(c => c.LugarViaje)
                .HasForeignKey(c => c.LugarViajeId);

            HasRequired(c => c.Encomienda)
                .WithMany(c => c.LugarViaje)
                .HasForeignKey(c => c.EncomiendaId);

            HasRequired(c => c.Transporte)
                .WithMany(c => c.LugarViaje)
                .HasForeignKey(c => c.TransporteId);
    }
}
