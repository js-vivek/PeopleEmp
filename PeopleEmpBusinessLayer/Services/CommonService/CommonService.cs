using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClasses.Common;

namespace PeopleEmpBusinessLayer.Services.CommonService
{
    class CommonService : ICommonService
    {
        public bool AddComplaintComments(UserComplaintDescription complaintDescription)
        {
            throw new NotImplementedException();
        }

        public IList<Service> SearchService(Service service)
        {
            throw new NotImplementedException();
        }

        public string TestService()
        {
            return "Ready to Use";
        }

        public List<UserComplaintDescription> ViewComplaintThread(Complaint complaint)
        {
            throw new NotImplementedException();
        }

        public Service ViewServiceInfo(Service service)
        {
            throw new NotImplementedException();
        }
    }
}
