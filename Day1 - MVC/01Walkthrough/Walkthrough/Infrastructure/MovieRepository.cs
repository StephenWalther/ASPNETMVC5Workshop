using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Walkthrough.Models;

namespace Walkthrough.Infrastructure {
    public class MovieRepository {
        public IList<Movie> List() {
            return new List<Movie> {
                new Movie {Id=1, Title="Star Wars", Director="Lucas"},
                new Movie {Id=2, Title="King Kong", Director="Jackson"},
                new Movie {Id=3, Title="Memento", Director="Nolan"}
            };
        }
    }
}