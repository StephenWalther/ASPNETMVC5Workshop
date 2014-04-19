using OData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;

namespace OData {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Query Support won't work with EntitySetController unless you call this method
            config.EnableQuerySupport();

            // Create the odata model
            var modelBuilder = new ODataConventionModelBuilder();
            modelBuilder.EntitySet<Product>("ProductsEntitySet");  // Case Sensitive!!!

            // Expose the odata model
            var model = modelBuilder.GetEdmModel();
            config.Routes.MapODataRoute("ODataRoute", "odata", model);



        }
    }
}
