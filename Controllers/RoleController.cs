using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XLibrary.Models.DbModels;
using XLibrary.XCodeBase;

namespace XLibrary.Controllers
{
    public class RoleController : ApiController
    {
        RoleXCode roleCode = null;
        public RoleController() {
            roleCode = new RoleXCode();
        }
        
        public IHttpActionResult GetRole()
        {
            var getRole = roleCode.GetRole();
            return Ok(getRole);
        }

        [Route("api/Role/GetRoleById/{RoleId}")]
        public IHttpActionResult GetRoleById(int RoleId)
        {
            var getRoleById = roleCode.GetRoleById(RoleId);
            return Ok(getRoleById);
        }

        public IHttpActionResult AddRole(Roles role)
        {
            var addRole = roleCode.AddRole(role);
            return Ok(addRole);
        }

        public IHttpActionResult UpdateRole(Roles role)
        {
            var updateRole = roleCode.UpdateRole(role);
            return Ok(updateRole);
        }

        [Route("api/Role/AddUserRole/{userId}/{RoleId}")]
        public IHttpActionResult AddUserRole(int userId, int RoleId)
        {
            var addUserRole = roleCode.AddUserRole(userId, RoleId);
            return Ok(addUserRole);
        }

        public IHttpActionResult UpdateUserRole(UserRole userRole)
        {
            var updateUserRole = roleCode.UpdateUserRole(userRole);
            return Ok(updateUserRole);
        }

    }
}
