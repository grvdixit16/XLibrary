using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XLibrary.Models.DbModels;

namespace XLibrary.Models.XCodeModels
{
    public class AuthenticationModel : SharedDbModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string PrimaryMobile { get; set; }
        public string Email { get; set; }
        public bool IsAuthenticate { get; set; }
    }
}