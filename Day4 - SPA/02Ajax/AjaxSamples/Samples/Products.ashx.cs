using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxSamples.Samples {
    /// <summary>
    /// Summary description for products
    /// </summary>
    public class Products : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "application/json";
            context.Response.WriteFile("Products.json");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }

}