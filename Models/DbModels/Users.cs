using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XLibrary.Models.DbModels
{
    public class Users : SharedDbModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string PrimaryMobile { get; set; }
        public string SecondaryMobile { get; set; }
        public int LoginAttempts { get; set; }
        public string Email { get; set; }

    }
}