using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte02.Common.Data;
using Parte02.Common.Entity;

namespace Parte02.UI.Domain
{
    public class BancoLogic
    {
        private readonly IBancoProvider _provider;

        public BancoLogic()
        {
            _provider = new BancoProvider();
        }

        public IEnumerable<Banco> Listar()
        {
            return _provider.Listar(null);
        }

        public bool Agregar(Banco entidad)
        {
            entidad.Identificador = Guid.NewGuid().ToString();
            entidad.FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd");
            return _provider.Agregar(entidad);
        }
    }
}
