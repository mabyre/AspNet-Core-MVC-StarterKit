using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCStarterKit.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Ajout d'un petit commentaire
        public ActionResult PageAccordion()
        {
            ViewBag.Message = "Your Accordion's Page.";
            return View();
        }
    }
}