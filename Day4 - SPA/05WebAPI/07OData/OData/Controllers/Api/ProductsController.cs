using OData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OData.Controllers
{
    public class ProductsController : ApiController
    {
        [Queryable]
        public IEnumerable<Product> Get()
        {
            return new List<Product> {
                new Product {Id=1, Name="milk", Price=3.44m},
                new Product {Id=2, Name="mushrooms", Price=12.88m},
                new Product {Id=3, Name="marmalade", Price=3.50m},
                new Product {Id=4, Name="maple syrup", Price=1.99m},
                new Product {Id=5, Name="apples", Price=5.50m},
                new Product {Id=6, Name="marshmellows", Price=3.00m},
                new Product {Id=7, Name="apricots", Price=12.99m}
            };
        }
    }
}
