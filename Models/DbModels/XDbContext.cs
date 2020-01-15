using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace XLibrary.Models.DbModels
{
    public class XDbContext : DbContext
    {
        public XDbContext() : base("name=XLibConnection") {

        }

        public DbSet<Modules> Moduless { get; set; }
        public DbSet<RoleModule> RoleModules { get; set; }
        public DbSet<Roles> Roless { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Users> Userss { get; set; }
        public DbSet<UsersAddress> UsersAddresss { get; set; }
    }
}