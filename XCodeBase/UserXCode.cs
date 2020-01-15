using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XLibrary.Models.DbModels;

namespace XLibrary.XCodeBase
{
    public class UserXCode
    {
        XDbContext dbContext = null;
        public UserXCode() {
            dbContext = new XDbContext();
        }

        public Users AddUpdateUser(Users users)
        {

            return users;
        }

        public Users DeleteUser(Users users)
        {

            return users;
        }

        public Users GetUserDetailById(int userId = 0)
        {
            Users user = null;
            if(userId > 0)
            {
                user = dbContext.Userss.FirstOrDefault(x => x.Id == userId);
            }

            return user;
        }
    }
}