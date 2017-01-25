using Parte02.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte02.Common.Data
{
    public interface IBancoProvider:IManager<Banco,string,string>
    {
    }
}
