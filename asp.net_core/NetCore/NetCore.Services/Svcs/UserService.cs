using NetCore.Data.DataModels;
using NetCore.Data.Models;
using NetCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NetCore.Services.Svcs
{
    public class UserService : IUser
    {
        #region private methods
        private IEnumerable<User> GetUserInfos()
        {
            return new List<User>()
            {
                new User()
                {
                    UserId = "jadejs",
                    UserName = "김정수",
                    UserEmail = "jadejskim@gmail.com",
                    Password = "123456"
                }
            };
        }

        private bool checkTheUserInfo(string userId, string password)
        {
            return GetUserInfos().Where(u => u.UserId.Equals(userId) && u.Password.Equals(password)).Any();
        }
        #endregion

        bool IUser.MatchTheUserInfo(LoginInfo login)
        {
            return checkTheUserInfo(login.UserId, login.Password);
        }
    }
}
