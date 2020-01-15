using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XLibrary.Models.DbModels
{
    public class SharedDbModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }


    }
}