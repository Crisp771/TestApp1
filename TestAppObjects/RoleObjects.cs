using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppData;

namespace TestAppObjects
{
    public class RoleObjects
    {
        private readonly ITestEntities _context;

        public RoleObjects()
        {
            _context = new TestEntities();
        }

        public RoleObjects(ITestEntities context)
        {
            _context = context;
        }

        public IList<Role> GetRoles()
        {
            return _context.tblRoles.Select(s => new Role(s)).ToList();
        }
    }
}
