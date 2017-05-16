using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Persistence.Repositories
{
    class TripulacionRepository
    {
        private TransporteDbContext _Context;

        public TripulacionRepository(TransporteDbContext _Context)
        {
            this._Context = _Context;
        }
    }
}
