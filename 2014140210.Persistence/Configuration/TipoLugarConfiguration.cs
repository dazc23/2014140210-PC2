using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Persistence
{
    class TipoLugarConfiguration:EntityTypeConfiguration<TipoLugar>
    {
         //Table configurations
            ToTable("TipoLugar");
            HasKey(c => c.TipoLugarId);
            Property(c => c.NombreTipo).IsRequired().HasMaxLength(300);
    }
}
