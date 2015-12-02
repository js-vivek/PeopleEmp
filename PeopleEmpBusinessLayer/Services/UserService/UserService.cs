
using EntityClasses.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClasses.Common;

namespace PeopleEmpBusinessLayer.Services.UserService
{
    class UserService : IUserService
    {
        public ServiceResponse AcceptServiceRequest(ServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public Address AddAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public bool AddComplaintComments(UserComplaintDescription complaintDescription)
        {
            throw new NotImplementedException();
        }

        public UserDetail AddUser(UserDetail user)
        {
            user.IsSuccess = true;
            return user;
        }

        public UserRole AddUserRole(UserRole role)
        {
            throw new NotImplementedException();
        }

        public IList<UserDetail> AvailForService(ServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public Wallet ConfigureWallet(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public Complaint CreateComplaint(Complaint complaint)
        {
            throw new NotImplementedException();
        }

        public Wallet CreditWallet(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public Wallet DebitFromWallet(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public ServiceRequest DeleteServiceRequest(ServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public UserRole DeleteUserRole(UserRole role)
        {
            throw new NotImplementedException();
        }

        public Service DenyFromService(Service Service)
        {
            throw new NotImplementedException();
        }

        public IList<ServiceRequest> GetRequestHistory(UserRole role)
        {
            throw new NotImplementedException();
        }

        public ServiceRequest GetServiceRequestInfo(ServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public bool Login(UserDetail user)
        {
            throw new NotImplementedException();
        }

        public ServicePayment MakeServicePayment(ServicePayment payment)
        {
            throw new NotImplementedException();
        }

        public ServiceRequest RaiseServiceRequest(ServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public UserDetail RegisterUser(UserDetail user)
        {
            throw new NotImplementedException();
        }

        public ServiceRequest RejectServiceRequest(ServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public string TestService()
        {
            return "Ready to Use";
        }

        public ServiceRequest UpdateServiceRequest(ServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public UserRole UpdateUserRole(UserRole role)
        {
            throw new NotImplementedException();
        }

        public IList<Service> ViewRequestHistory(UserDetail user)
        {
            IList<Service> allServices = new List<Service>();
            for (int i = 0; i < 10; i++)
            {
                allServices.Add(new Service { CreatedBy = user.UserId,
                    IsActive = true,
                    AbsoluteServiceCharge = "" + i,
                    ResultMsg = "N/A",
                    ServiceName = "S_Name" + i
                });
            }
            return allServices;
        }
    }
}
