using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XLibrary.Models.XCodeModels;
using XLibrary.XCodeBase;

namespace XLibrary.Controllers
{
    public class AuthenticationController : ApiController
    {
        AuthenticationXCode authenticationXCode = null;
        public AuthenticationController() {
            authenticationXCode = new AuthenticationXCode();
        }
        [HttpPost]
        public IHttpActionResult Register(AuthenticationModel authenticationModel) {
            authenticationXCode.Register(authenticationModel);
            return Ok();
        }

    }
}
