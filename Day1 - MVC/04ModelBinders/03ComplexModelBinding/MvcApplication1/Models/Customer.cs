using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models {
    public class Customer {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
    }
}