using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wildcard.Controllers
{
    public class DocumentsController : Controller
    {
        //
        // GET: /Documents/

        public ActionResult Index(string page)
        {
            // page represents the entire path such as "Invoices/November/Acme"
            ViewData.Model = page;
            return View();
        }

    }
}
