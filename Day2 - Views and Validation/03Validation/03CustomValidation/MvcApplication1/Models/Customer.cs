using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models {
    public class Customer {

        public int Id { get; set; }

        [CustomValidation(typeof(CustomerValidator), "ValidateFirstName")]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }
}