using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XLibrary.Models.DbModels;
using XLibrary.XCodeBase.SharedLib;

namespace XLibrary.XCodeBase
{
    public class UserXCode
    {
        XDbContext dbContext = null;
        RoleXCode roleXCode = null;
        public UserXCode() {
            dbContext = new XDbContext();
            roleXCode = new RoleXCode();
        }

        public IEnumerable<Users> GetUsers()
        {
            return dbContext.Userss.ToList();
        }

        public Users GetUserById(int UserId)
        {
            if (UserId > 0)
            {
                return dbContext.Userss.FirstOrDefault(x => x.Id == UserId);
            }
            return null;
        }

        public int UpdateUser(Users user)
        {
            if (user != null && user.Id > 0)
            {
                user.Password = EncryptDecryptCode.Encrypt(user.Password);
                user.UpdatedDate = DateTime.Now;
                dbContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();

                // Is user contains role
                if (user.RoleId > 0 && user.Id > 0)
                {
                    roleXCode.UpdateUserRole(user.Id, user.RoleId);
                }

                return 1;
            }
            return 0;
        }
        public Users AddUser(Users user)
        {
            if (user != null)
            {
                user.Password = EncryptDecryptCode.Encrypt(user.Password);
                user.CreatedDate = DateTime.Now;
                user.UpdatedDate = DateTime.Now;
                dbContext.Userss.Add(user);
                dbContext.SaveChanges();

                // Is user contains role
                if (user.RoleId > 0 && user.Id > 0) {
                    roleXCode.AddUserRole(user.Id, user.RoleId);
                }
                return user;
            }
            return user;
        }

        public void Delete(int id)
        {
        }

    }
}