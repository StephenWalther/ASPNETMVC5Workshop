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

        protected override void HandleUnknownAction(string actionName) {
            this.ViewData.Model = actionName;
            this.View("Default").ExecuteResult(this.ControllerContext);
        }




    }
}
