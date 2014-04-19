using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AjaxSamples.Controllers.Api
{
    public class ProductsController : ApiController
    {

        public IList<Product> GetProducts() {
            return new List<Product> {
                new Product {Name="Bread"},
                new Product {Name="Cheese"}
            };
        }
    }



    public class Product {
        public string Name { get; set; }
    }


}
