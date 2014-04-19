using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MvcApplication1 {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {

            // Default Web API Route
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            // Action Route
            config.Routes.MapHttpRoute(
                name: "ActionRoute",
                routeTemplate: "api2/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


        }
    }
}
