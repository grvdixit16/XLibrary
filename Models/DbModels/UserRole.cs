using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XLibrary.Models.DbModels
{
    public class UserRole : SharedDbModel
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }

    }
}