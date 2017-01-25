using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parte02.Common.Entity;
using Parte02.UI.Model;
using Parte02.UI.Domain;

namespace Parte02.UI.Website.Controllers
{
    public class BancoController : Controller
    {
        private readonly BancoLogic _provider;

        public BancoController()
        {
            _provider = new BancoLogic();
        }

        //
        // GET: /Banco/

        [HttpGet]
        public ActionResult Lista()
        {
            var viewModel = new BancoListaViewModel();
            viewModel.Bancos = _provider.Listar();
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Detalle()
        {
            var viewModel = new BancoDetalleViewModel();

            viewModel.AccionRetorno = "Lista";
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Detalle(BancoDetalleViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var entidadBanco = new Banco
                {
                    Nombre = viewModel.Nombre,
                    Direccion = viewModel.Direccion
                };

                var resultado = _provider.Agregar(entidadBanco);
                if (resultado)
                {
                    viewModel.BotonRetorno = true;
                }
                else
                {
                    viewModel.Mensaje = "La operación no se pudo realizar correctamente, por favor intente nuevamente.";
                    viewModel.ModeloCorrecto = false;
                }
            }
            else
            {
                viewModel.ModeloCorrecto = false;
            }

            viewModel.AccionRetorno = "Lista";
            viewModel.PostBack = true;
            return View(viewModel);
        }
    }
}
