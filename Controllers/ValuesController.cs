using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XLibrary.Models.DbModels;
using XLibrary.XCodeBase;

namespace XLibrary.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Modules> Get()
        {
            ModulesXCode xCode = new ModulesXCode();
            return xCode.GetModules();
        }
        
    }
}
