using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/EntryByDate

        public ActionResult EntryByDate(DateTime date)
        {
            return View(date);
        }

        //
        // GET: /Blog/EntryById

        public ActionResult EntryById(int id) {
            return View(id);
        }


    }
}
