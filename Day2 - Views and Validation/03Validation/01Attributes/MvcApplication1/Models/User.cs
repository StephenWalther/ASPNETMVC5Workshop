using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models {
    public class User {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        [MinLength(6)]
        public string LastName { get; set; }
        
        [CreditCard]
        public string CreditCard { get; set; }
        
        [Required]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$")]
        public string SSN { get; set; }
    }
}