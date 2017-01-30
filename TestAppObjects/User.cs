using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TestAppData;

namespace TestAppObjects
{
    [DataContract(Namespace = "http://example.com")]
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int RoleID { get; set; }

        public User()
        {

        }

        public User(IUser user)
        {
            this.Id = user.UserID;
            this.UserID = user.UserID;
            this.Username = user.Username;
            this.Password = user.Password;
            this.RoleID = user.RoleID;
        }
    }
}
