using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockoutSamples.Controllers
{
    public class _01MappingController : Controller {

        public ActionResult Index() {
            var vm = new CustomerViewModel {
                FirstName = "Stephen",
                LastName = "Walther",
                BillingAddress = new Address {
                    Street = "101 Main Street",
                    City = "Seattle"
                }
            };

            return View(vm);
        }

    }

    // Server-side view model
    public class CustomerViewModel {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address BillingAddress { get; set; }
    }

    public class Address {
        public string Street { get; set; }
        public string City { get; set; }
    }

}
