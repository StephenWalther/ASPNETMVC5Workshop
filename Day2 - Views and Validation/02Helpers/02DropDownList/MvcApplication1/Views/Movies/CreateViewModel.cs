using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Views.Movies {
    public class CreateViewModel {
        public Movie MovieToCreate { get; set; }
        public SelectList Categories { get; set; }
    }
}