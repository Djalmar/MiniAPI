using MiniApi.Controllers.API.ErrorHandler;
using MiniAPI.Controllers.API.ErrorHandler;
using MiniAPI.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniAPI.Controllers.API
{
    public class RutaController : Controller
    {
        [HttpGet]
        [APIErrorHandler]
        public JsonResult GetAll()
        {
            var result = new RutaRepository().GetAll();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [APIErrorHandler]
        public JsonResult Get(int rutaID)
        {
            var result = new RutaRepository().Get(rutaID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [APIErrorHandler]
        public JsonResult GetByNumero(string numero)
        {
            var result = new RutaRepository().GetByNumero(numero);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
