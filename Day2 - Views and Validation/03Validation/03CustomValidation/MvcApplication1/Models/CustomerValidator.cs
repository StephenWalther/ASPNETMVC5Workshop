using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models {
    public class CustomerValidator {

        public static ValidationResult ValidateFirstName(string firstName, ValidationContext context) {
            if (firstName == "Stephen") {
                return new ValidationResult("First name cannot be Stephen", new List<string> { "FirstName" });
            }
            return ValidationResult.Success;
        }

    }
}