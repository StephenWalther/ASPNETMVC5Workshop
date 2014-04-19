using MvcApplication1.Models;
using MvcApplication1.Views.Movies;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class MoviesController : Controller
    {

        private SelectList _categoriesSelectList;


        public MoviesController() {
            var categories = new List<Category> {
                new Category {Id=1, Name="Science Fiction"},
                new Category {Id=2, Name="Horror"},
                new Category {Id=3, Name="Action"}
            };
            _categoriesSelectList = new SelectList(categories, "Id", "Name");
        }

        //
        // GET: /Movies/Create

        public ActionResult Create()
        {
            var vm = new CreateViewModel {
                Categories = _categoriesSelectList
            };
            return View(vm);
        }

        //
        // POST: /Movies/Create

        [HttpPost]
        public ActionResult Create(CreateViewModel vm)
        {
            Debugger.Break();

            // If things go wrong, repopulate the list of categories
            vm.Categories = _categoriesSelectList;
            return View(vm);
        }

    }
}
