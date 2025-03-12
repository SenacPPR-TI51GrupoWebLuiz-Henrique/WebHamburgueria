using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHamburgueria.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        // Página de erro padrão
        public ActionResult Index()
        {
            ViewBag.ErrorCode = Response.StatusCode;
            return View();
        }

        // Página para erros 404 - Não Encontrado
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            ViewBag.ErrorCode = Response.StatusCode;
            return View();
        }

        // Página para erros 500 - Erro Interno do Servidor
        public ActionResult ServerError()
        {
            Response.StatusCode = 500;
            ViewBag.ErrorCode = Response.StatusCode;
            return View();
        }
    }
}