using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Validation.Models;

namespace Validation.Controllers
{
    public class MoviesController : ApiController
    {

        // POST api/movies
        public HttpResponseMessage Post(Movie movieToAdd)
        {
            // If movie valid then return status code 201
            if (ModelState.IsValid) {
                return Request.CreateResponse(HttpStatusCode.Created, "New Movie Created!");
            }

            // Otherwise, return modelstate with status code 400
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }


    }
}
