using Parte02.Common.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Parte02.Common.Data
{
    public class BancoProvider : IBancoProvider
    {
        public bool Agregar(Banco entity)
        {
            var appDomain = AppDomain.CurrentDomain;
            string basePath = !string.IsNullOrEmpty(appDomain.RelativeSearchPath) ? appDomain.RelativeSearchPath : appDomain.BaseDirectory;
            string filePath = Path.Combine(basePath, "bancos.json");
            string jsonData = System.IO.File.ReadAllText(filePath);
            JavaScriptSerializer objectSerializer = new JavaScriptSerializer();
            var bancoData = objectSerializer.Deserialize<List<Banco>>(jsonData);
            bancoData.Add(entity);

            string jsonSerializer = JsonConvert.SerializeObject(bancoData.ToArray());
            System.IO.File.WriteAllText(filePath, jsonSerializer);

            return true;
        }

        public bool Eliminar(string key)
        {
            throw new NotImplementedException();
        }

        public Banco Buscar(string key)
        {
            throw new NotImplementedException();
        }

        public bool Actualizar(Banco entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Banco> Listar(string filter)
        {
            var appDomain = AppDomain.CurrentDomain;
            string basePath = !string.IsNullOrEmpty(appDomain.RelativeSearchPath) ? appDomain.RelativeSearchPath : appDomain.BaseDirectory;
            string filePath = Path.Combine(basePath, "bancos.json");
            string jsonData = System.IO.File.ReadAllText(filePath);
            JavaScriptSerializer objectSerializer = new JavaScriptSerializer();
            var bancoData = objectSerializer.Deserialize<List<Banco>>(jsonData);
            return bancoData;
        }
    }
}
