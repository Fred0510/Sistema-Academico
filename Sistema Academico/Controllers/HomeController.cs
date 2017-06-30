using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_Academico.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Se presentará a continuación el sistema academico del intec.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Selección de materias";

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your Test page.";

            return View();
        }

        public ActionResult Select()
        {
            ViewBag.Message = "Pagina en construccion";
            return View("Index");
        }

        public ActionResult Offer()
        {
            ViewBag.Message = "Pagina en construccion";
            return View("Index");
        }
    }
}