using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XLibrary.Models.DbModels;
using XLibrary.XCodeBase;

namespace XLibrary.Controllers
{
    public class UserController : ApiController
    {
        XDbContext dbContext = null;
        UserXCode userXCode = null;

        public UserController() {
            dbContext = new XDbContext();
            userXCode = new UserXCode();
        }

        public IHttpActionResult GetUserList()
        {
            var getUser = userXCode.GetUsers();
            return Ok(getUser);
        }
        [HttpPost]
        public IHttpActionResult UpdateUser(Users user)
        {
            var updateUser = userXCode.UpdateUser(user);
                return Ok(updateUser);
        }
        [HttpPost]
        public IHttpActionResult AddUser(Users user)
        {
            var addUser = userXCode.AddUser(user);
            return Ok(addUser);
      
        }

    }
}
