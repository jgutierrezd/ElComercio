using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte02.Common.Entity;

namespace Parte02.UI.Model
{
    public class BancoListaViewModel
    {
        public string Filtro { get; set; }
        public IEnumerable<Banco> Bancos { get; set; }
    }
}
