using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace CustomConstraint.Infrastructure {
    public class MobileConstraint:IRouteConstraint {
        public bool Match(HttpContextBase httpContext, Route route, 
            string parameterName, RouteValueDictionary values, RouteDirection routeDirection) {

            return httpContext.Request.Browser.IsMobileDevice;            
            //return httpContext.Request.Browser.Browser == "Chrome";
        }
    }
}