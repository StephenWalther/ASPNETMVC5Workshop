using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Models {
    public class Product {
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}