using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XLibrary.Models.DbModels;
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
        public IHttpActionResult Register(Users authenticationModel) {
            authenticationXCode.Register(authenticationModel);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult Login(Users Users)
        {
            authenticationXCode.Login(Users);
            return Ok();
        }

    }
}
