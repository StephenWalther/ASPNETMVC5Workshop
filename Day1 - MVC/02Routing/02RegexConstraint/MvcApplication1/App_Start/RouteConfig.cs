using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1 {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "BlogById",
                url: "Blog/{id}",
                defaults: new { controller = "Blog", action = "EntryById" },
                constraints: new {id = @"\d+" }
            );


            routes.MapRoute(
                name: "BlogByDate",
                url: "Blog/{date}",
                defaults: new { controller = "Blog", action = "EntryByDate"}
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}