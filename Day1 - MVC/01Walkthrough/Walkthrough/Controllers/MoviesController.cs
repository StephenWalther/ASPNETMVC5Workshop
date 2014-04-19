using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Walkthrough.Infrastructure;

namespace Walkthrough.Controllers
{
    public class MoviesController : Controller
    {

        private MovieRepository _repository = new MovieRepository();
        
        //
        // GET: /Movies/

        public ActionResult Index()
        {
            var movies = _repository.List();
            return View(movies);
        }

    }
}
