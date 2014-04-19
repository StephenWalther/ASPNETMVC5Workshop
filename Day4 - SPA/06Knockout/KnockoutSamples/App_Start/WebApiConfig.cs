using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace KnockoutSamples {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            //config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Never;



            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
