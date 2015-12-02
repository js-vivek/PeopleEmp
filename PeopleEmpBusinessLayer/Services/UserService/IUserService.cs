
using EntityClasses.User;
using EntityClasses.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using EntityClasses.CustomException;

namespace PeopleEmpBusinessLayer.Services.UserService
{
    [ServiceContract]
    interface IUserService
    {
        [OperationContract]
        string TestService();
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        UserDetail RegisterUser(UserDetail user);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        Address AddAddress(Address address);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        bool AddComplaintComments(UserComplaintDescription complaintDescription);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        Complaint CreateComplaint(Complaint complaint);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        bool Login(UserDetail user);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        Wallet ConfigureWallet(Wallet wallet);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        Wallet CreditWallet(Wallet wallet);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        Wallet DebitFromWallet(Wallet wallet);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        IList<Service> ViewRequestHistory(UserDetail user);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        ServicePayment MakeServicePayment(ServicePayment payment);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        ServiceRequest RaiseServiceRequest(ServiceRequest request);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        ServiceRequest UpdateServiceRequest(ServiceRequest request);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        ServiceRequest DeleteServiceRequest(ServiceRequest request);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        ServiceResponse AcceptServiceRequest(ServiceRequest request);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        UserRole AddUserRole(UserRole role);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        UserRole DeleteUserRole(UserRole role);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        UserRole UpdateUserRole(UserRole role);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        IList<UserDetail> AvailForService(ServiceRequest request);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        Service DenyFromService(Service Service);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        IList<ServiceRequest> GetRequestHistory(UserRole role);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        ServiceRequest GetServiceRequestInfo(ServiceRequest request);
        [FaultContract(typeof(PeopleEmpException))]
        [OperationContract]
        ServiceRequest RejectServiceRequest(ServiceRequest request);
    }
}
