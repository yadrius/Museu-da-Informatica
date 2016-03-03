using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Museu_da_Informática.Models;

namespace Museu_da_Informática.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult About()
        {
            ViewBag.Message = "Sobre o Museu da informatica .";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = " Faculdade de Tecnologia de Carapicuíba.";

            return View();
        }

        [Authorize]       
        public ActionResult Cadastro()
        {
            ViewBag.Message = "Museu da informatica.";

            return View();
        }

        public ActionResult Editar()
        {
            ViewBag.Message = "Museu da informatica.";

            return View();
        }

        public ActionResult Exibir(Show_Item model)
        {
            ViewBag.Message = "Museu da informatica.";
           
        

            return View(model.States.ToList());
           
        }
    }
}