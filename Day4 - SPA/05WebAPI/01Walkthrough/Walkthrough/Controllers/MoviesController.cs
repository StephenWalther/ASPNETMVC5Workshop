using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Walkthrough.Models;

namespace Walkthrough.Controllers
{
    public class MoviesController : ApiController
    {
        private static ConcurrentBag<Movie> _repository = new ConcurrentBag<Movie>();

        // GET api/movies
        public IEnumerable<Movie> GetMovies()
        {
            return from movie in _repository
                   orderby movie.Title
                   select movie;
        }

        // POST api/movies
        public void Post(Movie newMovie)
        {
            _repository.Add(newMovie);
        }

    }
}
