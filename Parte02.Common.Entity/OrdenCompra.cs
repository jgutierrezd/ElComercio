using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte02.Common.Entity
{
    public class OrdenCompra
    {
        public string Identificador { get; set; }
        public decimal Monto { get; set; }
        public string Monedad { get; set; }
        public short Estado { get; set; }
        public string Fechapago { get; set; }
    }
}
