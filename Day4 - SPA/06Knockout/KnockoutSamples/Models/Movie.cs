using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnockoutSamples.Models {
    public class Movie:IValidatableObject {
        [Required(ErrorMessage="Movie Title is Required!")]
        public string Title { get; set; }

        [Required(ErrorMessage="Movie Director is Required!")]
        public string Director { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            var results = new List<ValidationResult>();
            if (this.Director == "Stephen") {
                results.Add(new ValidationResult("Director cannot be Stephen", new string[] {"Movie.Director"}));
            }
            return results;
        }
    }
}