
//using PeopleEmpBusinessLayer.EntityClasses.User;
using EntityClasses.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PeopleEmpBusinessLayer.Services.UserService
{
    [ServiceContract]
    interface IUserService
    {
        [OperationContract]
        string TestService();
        [OperationContract]
        UserDetail AddUser(UserDetail user);
    }
}
