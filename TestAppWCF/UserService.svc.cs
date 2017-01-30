using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TestAppData;
using TestAppObjects;

namespace TestAppWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public List<User> GetUserList()
        {
            return new UserObjects().GetUsers().ToList();
        }

        public SignInStatus ValidateUser(IUser user)
        {
            return new UserObjects().ValidateUser(user);
        }

        public User ValidateUserByUsernameAndPassword(string Username, string Password)
        {
            var User = new TestAppData.tblUser();
            User.Username = Username;
            User.Password = Password;
            return (User)(new UserObjects().ValidateUserByUsernameAndPassword(User));
        }
    }
}
