
using EntityClasses.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleEmpBusinessLayer.Services.UserService
{
    class UserService : IUserService
    {
        public UserDetail AddUser(UserDetail user)
        {
            user.IsSuccess = true;
            return user;
        }

        public string TestService()
        {
            return "Ready to Use";
        }
    }
}
