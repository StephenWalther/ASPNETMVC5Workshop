using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class AdvertisementController : Controller
    {

        public ActionResult GetAd() {
            var adText = "Buy more coffee!";

            if (DateTime.Now.Hour > 18) {
                adText = "Buy more warm milk!";
            }

            return PartialView("_Advertisement", adText);
        }


    }
}
