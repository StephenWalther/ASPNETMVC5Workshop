using Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Authorization.Controllers
{
    public class MoviesController : ApiController
    {
        // GET api/movies
        [Authorize]
        public IEnumerable<Movie> Get()
        {
            return new List<Movie> { 
                new Movie {Title="Star Wars", Director="Lucas"},
                new Movie {Title="King Kong", Director="Jackson"},
                new Movie {Title="Memento", Director="Nolan"}
            };
        }
    }
}
