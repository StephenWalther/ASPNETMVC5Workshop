using Serialization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Serialization.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/products
        public IEnumerable<Product> Get()
        {
            return new List<Product> {
                new Product {Name="Milk", Price=2.99m, SecretCode=232},
                new Product {Name="Carrots", Price=1.09m, SecretCode=111},
                new Product {Name="Bread", Price=7.99m, SecretCode=9998}
            };

        }
    }
}
