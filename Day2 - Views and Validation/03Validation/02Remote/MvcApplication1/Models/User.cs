using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models {
    public class User {
        [Required]
        [Remote("ValidateUserName", "Validation", ErrorMessage="UserName already taken!", HttpMethod="POST")]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}