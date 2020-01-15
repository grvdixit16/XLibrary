using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XLibrary.Models.DbModels
{
    public class LogDetails : SharedDbModel
    {
        public string LogType { get; set; }
        public string Logs { get; set; }
    }
}