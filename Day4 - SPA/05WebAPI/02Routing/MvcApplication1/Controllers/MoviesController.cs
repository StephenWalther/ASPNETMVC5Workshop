﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class MoviesController : ApiController
    {
        // GET api/movies
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/movies/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/movies
        public void Post([FromBody]string value)
        {
        }

        // PUT api/movies/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/movies/5
        public void Delete(int id)
        {
        }
    }
}
