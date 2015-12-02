using EntityClasses.Common;
using EntityClasses.User;
using EntityClasses.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PeopleEmpBusinessLayer.Services.AdminService
{
    [ServiceContract]
    interface IAdminService
    {
        [OperationContract]
        string TestService();
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        bool AcceptRejectUserRole(UserRole userRole);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        Service AddService(Service service);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        Service UpdateService(Service service);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        bool DeleteService(string serviceId);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        UserRole ViewUserRole(UserDetail user);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        IList<UserDetail> ViewServiceAvailers(UserRole user);
    }
}
