using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Validation.Models;

namespace Validation.Controllers
{
    //[WebAPIValidationFilter]
    public class ProductsController : ApiController
    {

        // POST api/products
        public HttpResponseMessage Post(Product productToAdd) {
            // Add product to database
            return Request.CreateResponse(HttpStatusCode.Created, "New Product Created!");
        }


    }
}
