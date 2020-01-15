using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XLibrary.Models.DbModels
{
    public class UsersAddress : SharedDbModel
    {
        public int UserId { get; set; }
        public string AddressType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Area { get; set; }
        public string Pincode { get; set; }
        public string Address { get; set; }


    }
}