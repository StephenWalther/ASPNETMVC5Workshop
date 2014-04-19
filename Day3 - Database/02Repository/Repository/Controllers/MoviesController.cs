using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Models;

namespace CodeFirst.Controllers
{
    public class MoviesController : Controller
    {

        private IMoviesRepository _moviesRepository;


        public MoviesController(IMoviesRepository moviesRepository) {
            this._moviesRepository = moviesRepository;
        }

        public MoviesController(): this(new MoviesRepository()) {
        }


        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(_moviesRepository.List());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            return View(_moviesRepository.Find(id));
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _moviesRepository.Create(movie);
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            return View(_moviesRepository.Find(id));
        }

        //
        // POST: /Default1/Edit/5

        //[HttpPost]
        //public ActionResult Edit(Movie movie)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(movie).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(movie);
        //}



        [HttpPost]
        public ActionResult Edit(Movie movie) {
            if (ModelState.IsValid) {
                _moviesRepository.Edit(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }





        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            return View(_moviesRepository.Find(id));
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _moviesRepository.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _moviesRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}