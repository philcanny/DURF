using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignUrFixie.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // GET /home/index
            return View();
        }
        public ActionResult IndexGallery()
        {
            // GET /home/indexGallery
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our Location";

            return View();
        }

        public ActionResult Result()
        {
            ViewBag.Message = "Your Result page.";

            return View("Result", "_myLayout");//select a different layout page
        }

        public ActionResult Bike()
        {
            ViewBag.Message = "Bike page.";

            return View("Bike", "_myLayout");
        }



      
    }
}