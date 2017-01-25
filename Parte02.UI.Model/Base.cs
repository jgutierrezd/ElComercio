using System;
using System.Web;
using System.Web.Mvc;

namespace Parte02.UI.Model
{
    public abstract class Base
    {
        public bool PostBack { get; set; }

        public bool ModeloCorrecto { get; set; }

        public bool AccionCorrecta { get; set; }

        public bool Exception { get; set; }

        public string Mensaje { get; set; }

        public bool AutoRedireccion { get; set; }

        public bool BotonRetorno { get; set; }


        public string AccionRetorno { get; set; }

        public string ControladorRetorno { get; set; }

        public object ParametrosRetorno { get; set; }

        public string Titulo { get; set; }

        public string RutaRetorno
        {
            get
            {
                var url = new UrlHelper(HttpContext.Current.Request.RequestContext);
                return url.Action(AccionRetorno, ControladorRetorno, ParametrosRetorno);
            }
        }

        protected Base()
        {
            PostBack = false;
            ModeloCorrecto = true;
            AccionCorrecta = true;
            BotonRetorno = false;
            Exception = false;
            AutoRedireccion = false;
        }
    }
}
