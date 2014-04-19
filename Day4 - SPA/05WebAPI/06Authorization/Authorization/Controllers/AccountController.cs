using Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace Authorization.Controllers
{
    public class AccountController : ApiController
    {

        [AllowAnonymous]
        public HttpResponseMessage Login(LoginViewModel vm)
        {
            if (vm.UserName == "Stephen" && vm.Password == "Secret") {
                FormsAuthentication.SetAuthCookie(vm.UserName, false);
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Invalid username/password");
        }

        [HttpGet]
        public HttpResponseMessage Logout() {
            FormsAuthentication.SignOut();
            return Request.CreateResponse(HttpStatusCode.OK);
        }


    }
}
