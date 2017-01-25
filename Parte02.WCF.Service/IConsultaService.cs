using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Parte02.WCF.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IConsultaService" in both code and config file together.
    [ServiceContract(Name = "ConsultaServiceContract", Namespace = "http://service.elcomercio.com")]
    public interface IConsultaService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Ordenes/{moneda}")]
        string ListarOrdenes(string moneda);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Sucursales/{empresa}")]
        string ListarSucursales(string empresa);
    }
}
