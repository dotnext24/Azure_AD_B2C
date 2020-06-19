
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace TaskService.Controllers
{

   

    public class HomeController : Controller
    {

       
        public ActionResult Index()
        {
            
            ViewBag.Title = "Home Page";
            var ss = User.Identity.Name;

            return View();
        }
    }
}
