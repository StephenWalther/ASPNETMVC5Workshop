using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ValidationController : Controller
    {

        public ActionResult ValidateUserName(string userName) {
            if (userName == "Stephen") {
                return Json(false);
            }
            return Json(true);
        }
    
    
    }
}
