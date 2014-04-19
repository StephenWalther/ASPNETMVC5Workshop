using ResponseMessage.Infrastructure;
using ResponseMessage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ResponseMessage.Controllers
{
    public class MoviesController : ApiController
    {
        private MoviesRepository _repository = new MoviesRepository();


        // GET api/movies
        public IEnumerable<Movie> Get()
        {
            try {
                return _repository.GetMovies();
            }
            catch {
                // Throws an exception and passes status code to client
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // GET api/movies/5
        public HttpResponseMessage Get(int id)
        {
            var movie = _repository.GetMovie(id);
            
            // If can't find movie, return 404 Not Found
            if (movie == null) {
                // Does not throw exception, but passes status code to client
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Coud not find movie");
            }

            // Otherwise, return the movie
            return Request.CreateResponse(HttpStatusCode.OK, movie);
        }

        // POST api/movies
        public HttpResponseMessage Post(Movie movieToAdd)
        {
            // If new movie created, return Created response code
            _repository.AddMovie(movieToAdd);
            var response = Request.CreateResponse(HttpStatusCode.Created, movieToAdd);

            // Create URI for new movie
            string uri = Url.Link("DefaultApi", new { id = movieToAdd.Id });
            response.Headers.Location = new Uri(uri);

            // Return the response
            return response;
        }

        // PUT api/movies/5
        public void Put(Movie movieToUpdate)
        {
            // If can't find movie to update, then return status code 404
            if (_repository.UpdateMovie(movieToUpdate) == false) {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE api/movies/5
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}
