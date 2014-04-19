using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAutoMapper.Models;

namespace TestAutoMapper.Controllers
{
    public class MoviesController : Controller
    {
        private Repository _repository = new Repository();



        public ActionResult Index()
        {
            var movies = _repository.ListMovies();
            return View(movies);
        }

    }
}
