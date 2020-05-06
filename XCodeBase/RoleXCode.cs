using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XLibrary.Models.DbModels;
using XLibrary.XCodeBase.SharedLib;

namespace XLibrary.XCodeBase
{
    public class RoleXCode : BaseXCode
    {
        XDbContext dbContext = null;
        public RoleXCode()
        {
            dbContext = new XDbContext();
        }
        public IEnumerable<Roles> GetRole()
        {
            return dbContext.Roless.ToList();
        }

        public Roles AddRole(Roles role)
        {
            if (role != null) {
                role.CreatedDate = GetCurrentDate();
                role.UpdatedDate = GetCurrentDate();
                role.IsActive = true;
                dbContext.Roless.Add(role);
                dbContext.SaveChanges();
            }
            return role;
        }
        public Roles UpdateRole(Roles role)
        {
            if (role != null && role.Id > 0)
            {
                role.UpdatedDate = GetCurrentDate();
                dbContext.Entry(role).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
            return role;
        }

        //Add Role To User
        public int AddUserRole(int UserId, int RoleId)
        {

            var userRoles = GetUserRoleByID(UserId, RoleId);
            if (UserId > 0 & RoleId > 0 && userRoles == null)
            {
                UserRole userRole = new UserRole();
                userRole.RoleId = RoleId;
                userRole.UserId = UserId;
                userRole.CreatedDate = GetCurrentDate();
                userRole.UpdatedDate = GetCurrentDate();
                userRole.IsActive = true;

                dbContext.UserRoles.Add(userRole);
                dbContext.SaveChanges();
                return 1;
            }
            return 0;
        }
        /// <summary>
        /// Update UserRole table updated using UserRole Model, Here User has ony and only one role
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public UserRole UpdateUserRole(UserRole userRole)
        {
            if (userRole != null && userRole.Id > 0)
            {
                userRole.UpdatedDate = GetCurrentDate();
                dbContext.Entry(userRole).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
            return userRole;
        }
        /// <summary>
        /// Update UserRole table using UserId and RoleId, Here User has ony and only one role
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        public int UpdateUserRole(int UserId, int RoleId)
        {
            if (UserId > 0 && RoleId > 0)
            {
                UserRole userRole = GetUserRoleByUserId(UserId);
                if (userRole == null)
                {
                    AddUserRole(UserId, RoleId);
                }
                else
                {
                    userRole.RoleId = RoleId;
                    userRole.UpdatedDate = GetCurrentDate();
                    dbContext.Entry(userRole).State = System.Data.Entity.EntityState.Modified;
                    dbContext.SaveChanges();
                }
                return 1;
            }
            return 0;
        }


        public Roles GetRoleById(int RoleId)
        {
            if (RoleId > 0)
            {
                return dbContext.Roless.FirstOrDefault(x => x.Id == RoleId);
            }
            return null;
        }

        public UserRole GetUserRoleByUserId(int UserId)
        {
            if (UserId > 0)
            {
                return dbContext.UserRoles.FirstOrDefault(x => (x.UserId == UserId));
            }
            return null;
        }

        public UserRole GetUserRoleByID(int UserId, int RoleId)
        {
            if (UserId > 0 & RoleId > 0)
            {
                return dbContext.UserRoles.FirstOrDefault(x => (x.RoleId == RoleId && x.UserId == UserId));
            }
            return null;
        }
    }


}