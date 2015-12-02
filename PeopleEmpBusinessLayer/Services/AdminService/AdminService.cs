
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClasses.Common;
using EntityClasses.User;

namespace PeopleEmpBusinessLayer.Services.AdminService
{

    class AdminService : IAdminService
    {
        public bool AcceptRejectUserRole(UserRole userRole)
        {
            throw new NotImplementedException();
        }

        public Service AddService(Service service)
        {
            throw new NotImplementedException();
        }

        public bool DeleteService(string serviceId)
        {
            throw new NotImplementedException();
        }

        public string TestService()
        {
             
            
            return "I am ready";
        }

        public Service UpdateService(Service service)
        {
            throw new NotImplementedException();
        }

        public IList<UserDetail> ViewServiceAvailers(UserRole user)
        {
            throw new NotImplementedException();
        }

        public UserRole ViewUserRole(UserDetail user)
        {
            throw new NotImplementedException();
        }
    }
}
