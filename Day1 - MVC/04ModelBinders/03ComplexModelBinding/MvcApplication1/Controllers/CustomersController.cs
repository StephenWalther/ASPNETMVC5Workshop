using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CustomersController : Controller {

        //
        // GET: /Customers/Create

        public ActionResult Create() {
            return View();
        }

        //
        // POST: /Customers/Create

        [HttpPost]
        public ActionResult Create(Customer customerToCreate) {
            Debugger.Break();
            return View();
        }
    
    
    }
}
