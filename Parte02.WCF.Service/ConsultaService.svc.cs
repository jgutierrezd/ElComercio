using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Parte02.WCF.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ConsultaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ConsultaService.svc or ConsultaService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(Name = "ConsultaService", Namespace = "http://service.elcomercio.com/ConsultaService")]
    public class ConsultaService : IConsultaService
    {
        public string ListarOrdenes(string moneda)
        {
            throw new NotImplementedException();
        }

        public string ListarSucursales(string empresa)
        {
            return "<People><Person><Name>Nick</Name></Person><Person><Name>Bonnie</Name></Person></People>";
        }
    }
}
