using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api2/products/list
        [HttpGet]
        public IEnumerable<string> List()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api2/products/get/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST api2/products/create
        [HttpPost]
        public void Create([FromBody]string value)
        {
        }

        // POST api2/products/update/5
        [HttpPost]
        public void Update(int id, [FromBody]string value)
        {
        }

        // POST api2/products/delete/5
        [HttpPost]
        public void Delete(int id)
        {
        }
    }
}
