using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Validation {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {

            // Register global Web API filter
            config.Filters.Add(new WebAPIValidationFilterAttribute());


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
