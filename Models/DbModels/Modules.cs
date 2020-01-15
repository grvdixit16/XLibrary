using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XLibrary.Models.DbModels
{
    public class Modules : SharedDbModel
    {
        public string Module { get; set; }
        public string Description { get; set;}

    }
}