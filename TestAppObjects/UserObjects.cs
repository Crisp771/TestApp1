﻿using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppData;

namespace TestAppObjects
{
    public class UserObjects
    {
        private readonly ITestEntities _context;

        public UserObjects()
        {
            _context = new TestEntities();
        }

        public UserObjects(ITestEntities context)
        {
            _context = context;
        }

        public IList<User> GetUsers()
        {
            return _context.tblUsers.ToList().Select(s => new User(s)).ToList();
        }

        public SignInStatus ValidateUser(IUser user)
        {
            var User = _context.tblUsers.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);

            if (User != null)
                return SignInStatus.Success;
            return SignInStatus.Failure;            
        }

        public User ValidateUserByUsernameAndPassword(tblUser user)
        {
            var User = (_context.tblUsers.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password));
            var retUser = new User(User);
            if (User != null)
                return retUser;
            return null;
        }
    }
}
