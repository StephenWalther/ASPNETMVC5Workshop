using KnockoutSamples.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockoutSamples.Controllers
{
    public class MoviesController : ApiController
    {
        private ConcurrentBag<Movie> _repository = new ConcurrentBag<Movie>();

        public MoviesController() {
            _repository.Add(new Movie { Title = "Star Wars", Director = "Lucas" });
            _repository.Add(new Movie { Title = "King Kong", Director = "Jackson" });
        }

        // Invoke with HTTP GET
        public IEnumerable<Movie> GetMovies()
        {
            return from m in _repository
                   orderby m.Title
                   select m;
        }

        // Invoke with HTTP POST
        public HttpResponseMessage PostMovie(Movie newMovie) {
            if (ModelState.IsValid) {
                // Save to database
                _repository.Add(newMovie);

                // Return success response
                return Request.CreateResponse(HttpStatusCode.Created, newMovie);
            }

            // Return errors
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }


    }
}
