using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Views.Products {
    public class IndexViewModel {
        public IList<Product> Products { get; set; }
    }
}