using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DurandalApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Movie title is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage="Movie director is required!")]
        public string Director { get; set; }
    }
}