using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XLibrary.Models.DbModels;
namespace XLibrary.XCodeBase
{
    public class ModulesXCode
    {
        XDbContext dbContext = null;
        public ModulesXCode() {
            dbContext = new XDbContext();
        }
        public IEnumerable<Modules> GetModules() {
           
            var ModuleList = dbContext.Moduless.ToList();
            return ModuleList;
        }
    }
}