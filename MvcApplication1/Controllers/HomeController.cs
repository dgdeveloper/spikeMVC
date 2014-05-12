using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
  
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult PageOverlayTransaction()
        {
            ViewBag.Message = "Your PageOverlayTransaction";
            return View();
        }
        public ActionResult FullScreenTransition()
        {
            ViewBag.Message = "Your FullScreenTransition";
            return View();
        }
        public ActionResult ThumbnailGridTransition()
        {
            ViewBag.Message = "Your FullScreenTransition";
            return View();
        }
        public ActionResult D3Spike()
        {
            ViewBag.Message = "Your D3 js spike";
            return View();
        }
         public ActionResult D3Data(string filename)
        {
            String dataFilePath = Server.MapPath("~\\Content\\D3Data\\" + filename + ".tsv");
            return File(dataFilePath, "text/plain");
        }
         public ActionResult DCSpike()
        {
             ViewBag.Message = "Your DC JS spike";
             return View();
        }
         public ActionResult ScrollingSpike()
         {
             ViewBag.Message = "Your Scrolling Spike";
             return View();
         }
         public ActionResult ScrollCoffee()
         {
             ViewBag.Message = "Your ScrollCoffee Spike";
             return View();
         }
    }
}
