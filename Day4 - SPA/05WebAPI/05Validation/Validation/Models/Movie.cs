using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Models {
    public class Movie {

        [Required(ErrorMessage="Must specify movie title!")]
        [StringLength(5, ErrorMessage="Title must be less than 6 characters")]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }
    }
}