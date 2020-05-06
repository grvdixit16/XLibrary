using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace XLibrary.Models.DbModels
{
    [Table("Users")]
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
        [NotMapped]
        public int RoleId { get; set; }
        [NotMapped]
        public bool IsAuthenticate { get; set; }


    }
}