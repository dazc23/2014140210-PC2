using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2014140210_API.DTO
{
    public class EncomiendaDTO : ServicioDTO
    {
        public string AsuntoEncomienda { get; set; }
        public string NombreDestinatario { get; set; }
    }
}