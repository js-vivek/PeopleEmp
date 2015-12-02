using EntityClasses.Common;
using EntityClasses.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PeopleEmpBusinessLayer.Services.CommonService
{
    [ServiceContract]
    interface ICommonService
    {
      
        [OperationContract]
        string TestService();
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        IList<Service> SearchService(Service service);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        Service ViewServiceInfo(Service service);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        bool AddComplaintComments(UserComplaintDescription complaintDescription);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        List<UserComplaintDescription> ViewComplaintThread(Complaint complaint);
    }
}
