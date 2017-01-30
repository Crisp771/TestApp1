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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        List<User> GetUserList();

        [OperationContract]
        SignInStatus ValidateUser(TestAppData.IUser user);
        [OperationContract]
        User ValidateUserByUsernameAndPassword(string Username, string Password);
    }
}
