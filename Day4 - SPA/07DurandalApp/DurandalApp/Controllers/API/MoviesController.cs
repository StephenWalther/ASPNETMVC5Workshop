using DurandalApp.Infrastructure;
using DurandalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DurandalApp.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private DataContext _db = new DataContext();

        // GET api/movies
        public IEnumerable<Movie> Get()
        {
            var movies = (from m in _db.Movies select m).ToList();
            return movies;
        }

        // POST api/movies
        public HttpResponseMessage Post(Movie movieToAdd)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movieToAdd);
                _db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, movieToAdd);
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }

    }
}
