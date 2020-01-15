using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XLibrary.Models.DbModels
{
    public class Roles : SharedDbModel
    {
        public string Role { get; set; }
        public string Description { get; set; }

    }
}