using MvcApplication1.Infrastructure;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class MoviesController : Controller {

        private IGenericRepository _repository;

        public MoviesController() : this(new GenericRepository()) { }

        public MoviesController(IGenericRepository repository) {
            _repository = repository;
        }


        public ActionResult Index() {


            var movies = (from m in _repository.Query<Movie>() select m).ToList();
            return View(movies);
        }

        //
        // GET: /Movies/Details/5

        public ActionResult Details(int id) {
            var movie = _repository.Find<Movie>(id);
            return View(movie);
        }

        //
        // GET: /Movies/Create

        public ActionResult Create() {
            return View();
        }

        //
        // POST: /Movies/Create

        [HttpPost]
        public ActionResult Create(Movie movieToCreate) {
            if (ModelState.IsValid) {
                _repository.Add<Movie>(movieToCreate);
                _repository.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        //
        // GET: /Movies/Edit/5

        public ActionResult Edit(int id) {
            var movie = _repository.Find<Movie>(id);
            return View(movie);
        }

        //
        // POST: /Movies/Edit/5

        [HttpPost]
        public ActionResult Edit(Movie movieToEdit) {
            if (ModelState.IsValid) {
                var originalMovie = _repository.Find<Movie>(movieToEdit.Id);
                originalMovie.Title = movieToEdit.Title;
                originalMovie.Director = movieToEdit.Director;
                _repository.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        //
        // GET: /Movies/Delete/5

        public ActionResult Delete(int id) {
            var movie = _repository.Find<Movie>(id);
            return View(movie);
        }

        //
        // POST: /Movies/Delete/5

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id) {
            _repository.Delete<Movie>(id);
            _repository.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
