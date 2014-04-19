using MvcApplication1.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class MoviesController : Controller
    {
        private Repository _repository = new Repository();

        //
        // GET: /Movies/

        public ActionResult Suggest(string term)
        {
            var matches = (from m in _repository.Movies
                    where m.Title.StartsWith(term, StringComparison.OrdinalIgnoreCase)
                    orderby m.Title
                    select new Suggestion { label = m.Title, id = m.Id.ToString() }).ToList();

            return Json(matches, JsonRequestBehavior.AllowGet);
        }

    }


    public class Suggestion {
        public string label { get; set; }
        public string id { get; set; }
    }

}
