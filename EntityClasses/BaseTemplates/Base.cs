using EntityClasses.User;
using EntityClasses.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace EntityClasses.BaseTemplates
{
    [KnownType(typeof(Address))]
    [KnownType(typeof(Complaint))]
    [KnownType(typeof(ComplaintSevirity))]
    [KnownType(typeof(Role))]
    [KnownType(typeof(Service))]
    [KnownType(typeof(ServiceAvailability))]
    [KnownType(typeof(UserComplaintDescription))]
    [KnownType(typeof(ServicePayment))]
    [KnownType(typeof(ServiceRequest))]
    [KnownType(typeof(ServiceResponse))]
    [KnownType(typeof(UserRole))]
    [KnownType(typeof(Wallet))]
    [KnownType(typeof(WalletTransaction))]
    [KnownType(typeof(UserDetail))]
    [DataContract]
   public class Base
    {
        private bool _isActive;
        private bool _isSuccess;
        private string _createdBy;
        private string _updatedBy;
        private string _resultMsg;
        private DateTime _dateUpdated;
        private DateTime _dateCreated;

        [DataMember]
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        [DataMember]
        public bool IsSuccess
        {
            get { return _isSuccess; }
            set { _isSuccess = value; }
        }

        [DataMember]
        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }
        [DataMember]
        public string ResultMsg
        {
            get { return _resultMsg; }
            set { _resultMsg = value; }
        }

        [DataMember]
        public string UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }
        [DataMember]
        public DateTime DateUpdated
        {
            get { return _dateUpdated; }
            set { _dateUpdated = value; }
        }

        [DataMember]
        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { _dateCreated = value; }
        }
    }
}
