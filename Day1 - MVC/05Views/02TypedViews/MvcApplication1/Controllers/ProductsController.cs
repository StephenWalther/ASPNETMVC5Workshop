using MvcApplication1.Models;
using MvcApplication1.Views.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index()
        {
            var products = new List<Product> {
                new Product {Name="Milk", Price=2.99m, OnSale=true},       
                new Product {Name="Bread", Price=3.00m, OnSale=false},       
                new Product {Name="Apples", Price=8.99m, OnSale=true}               
            };

            var vm = new IndexViewModel {
                Products = products
            };

            return View(vm);
        }

    }
}
