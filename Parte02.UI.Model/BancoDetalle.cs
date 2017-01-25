using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Parte02.UI.Model
{
    public class BancoDetalleViewModel : Base
    {
        public string Identificador { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Direccion { get; set; }
    }
}
