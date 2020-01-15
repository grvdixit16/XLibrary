using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XLibrary.Models.DbModels;
using XLibrary.Models.XCodeModels;
using XLibrary.XCodeBase.SharedLib;

namespace XLibrary.XCodeBase
{
    public class AuthenticationXCode
    {
        XDbContext dbContext = null;
        public AuthenticationXCode() { 
            
           dbContext = new XDbContext();
        }

        public AuthenticationModel Register(AuthenticationModel authenticationModel) {
            if (authenticationModel != null) {
                Users user = Mapper.Map<AuthenticationModel, Users>(authenticationModel);

                // Encrypt Password Code here
                user.Password = EncryptDecryptCode.Encrypt(user.Password);
                dbContext.Userss.Add(user);
                dbContext.SaveChanges();

                // Add Log Code here

            }
            return authenticationModel;
        }
        public AuthenticationModel Login(AuthenticationModel authenticationModel)
        {
            if (authenticationModel != null)
            {
                var isAuthenticatedUser = GetUserDetailByUsernamePass(authenticationModel);
                if (isAuthenticatedUser != null) {
                    isAuthenticatedUser.IsAuthenticate = true;
                    return isAuthenticatedUser;
                }
            }
            return authenticationModel;
        }

        public AuthenticationModel GetUserDetailByUsernamePass(AuthenticationModel authenticationModel)
        {
           var password = EncryptDecryptCode.Encrypt(authenticationModel.Password);
            var user = dbContext.Userss.FirstOrDefault(x => x.Username == authenticationModel.Username && x.Password == password);
            if (user != null) {
                return authenticationModel;
            }
            return null;
        }

    }
}