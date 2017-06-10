using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210_ENT
{
    public class TipoComprobante
    {
        public int TipoComprobanteId { get; set; }
        public string NombreComprobante { get; set; }

        public virtual int VentaId { get; set; }
        public virtual Venta Venta { get; set; }

        public TipoComprobante()
        {

        }
    }
}
