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
        UserXCode userXCode = null;
        public AuthenticationXCode() { 
            
           dbContext = new XDbContext();
            userXCode = new UserXCode();
        }

        public Users Register(Users authenticationModel) {
            if (authenticationModel != null) {
                userXCode.AddUser(authenticationModel);
            }
            return authenticationModel;
        }
        public Users Login(Users authenticationModel)
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

        public Users GetUserDetailByUsernamePass(Users authenticationModel)
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