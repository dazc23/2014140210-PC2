﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Persistence.Repositories
{
    class TipoViajeRepository
    {
        private TransporteDbContext _Context;

        public TipoViajeRepository(TransporteDbContext _Context)
        {
            this._Context = _Context;
        }
    }
}