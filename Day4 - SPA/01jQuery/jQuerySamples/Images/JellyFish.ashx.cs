using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

namespace jQueryWorkshop.Images {
    /// <summary>
    /// Summary description for JellyFish
    /// </summary>
    public class JellyFish : IHttpHandler {

        public void ProcessRequest(HttpContext context) {

            Thread.Sleep(1000 * 5);

            context.Response.ContentType = "image/jpeg";
            context.Response.Cache.SetNoStore();
            context.Response.WriteFile(context.Server.MapPath("~/Images/JellyFish.jpg"));
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}