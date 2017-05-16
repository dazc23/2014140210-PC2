﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Persistence
{
    class EmpleadoConfiguration : EntityTypeConfiguration<Empleado>
    {
         //Table Configurations
            ToTable("Empleado");
            HasKey(c => c.EmpleadoId);
            Property(c => c.Nombre).IsRequired().HasMaxLength(50);
            Property(c => c.Apellidos).IsRequired().HasMaxLength(250);
            Property(c => c.DNI).IsRequired().HasMaxLength(8);

        //Relationships configurations
        Map<Administrativo>(m => m.Requires("Discriminator").HasValue("Administrativo"));
            Map<Tripulacion>(m => m.Requires("Discriminator").HasValue("Tripulacion"));
    }
}
