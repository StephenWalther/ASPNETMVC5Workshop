using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration=20)]
        public ActionResult Report() {
            return PartialView("_Report");
        }


    }
}
