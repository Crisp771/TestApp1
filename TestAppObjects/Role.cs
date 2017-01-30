using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppData;

namespace TestAppObjects
{
    public class Role
    {
        public int RoleID { get; set; }
        public string Rolename { get; set; }

        public Role()
        {

        }

        public Role(IRole role)
        {
            this.RoleID = role.RoleID;
            this.Rolename = role.Rolename;
        }
    }
}
