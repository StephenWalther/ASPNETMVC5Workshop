using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models {

    public class Product : IValidatableObject {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext context) {
            // Validate Price
            if (this.Price < 1) {
                yield return new ValidationResult("Price is too low", new[] { "Price" });
            }
            if (this.Price > 1000) {
                yield return new ValidationResult("Price is too high", new[] { "Price" });
            }

        }
    }
}