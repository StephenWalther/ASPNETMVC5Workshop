using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Infrastructure {
    public class Repository {

        public IQueryable<Movie> Movies {
            get {
                return new List<Movie> {
                    new Movie {Id=1, Title="Star Wars", Director="Lucas"},
                    new Movie {Id=2, Title="Superman", Director="Jackson"},
                    new Movie {Id=3, Title="Spiderman", Director="Nolan"}
                }.AsQueryable();
            }

        }

    }
}