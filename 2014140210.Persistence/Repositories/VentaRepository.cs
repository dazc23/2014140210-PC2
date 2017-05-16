using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Persistence.Repositories
{
    public class VentaRepository : Repository<Venta>, IVentaRepository
    {
        private readonly TransporteDbContext _Context;

        private VentaRepository()
        {

        }

        public VentaRepository(TransporteDbContext context)
        {
            _Context = context; 
        }
    }
}
