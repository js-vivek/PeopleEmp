using EntityClasses.BaseTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses.User
{
    [DataContract]
    public class ServiceRequest : Base
    {
        private string _amountToBePaid;
        private string _assignTO;
        private string _comments;
        private string _expectedDeadline;
        private string _requestedBy;
        private string _requestStatus;
        private string _serviceId;
        private string _serviceRequestId;

        [DataMember]
        public string AmountToBePaid
        {
            get { return _amountToBePaid; }
            set { _amountToBePaid = value; }
        }
        [DataMember]
        public string AssignTO
        {
            get { return _assignTO; }
            set { _assignTO = value; }
        }
        [DataMember]
        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }
        [DataMember]
        public string ExpectedDeadline
        {
            get { return _expectedDeadline; }
            set { _expectedDeadline = value; }
        }
        [DataMember]
        public string RequestedBy
        {
            get { return _requestedBy; }
            set { _requestedBy = value; }
        }
        [DataMember]
        public string RequestStatus
        {
            get { return _requestStatus; }
            set { _requestStatus = value; }
        }
        [DataMember]
        public string ServiceId
        {
            get { return _serviceId; }
            set { _serviceId = value; }
        }
        [DataMember]
        public string ServiceRequestId
        {
            get { return _serviceRequestId; }
            set { _serviceRequestId = value; }
        }

    }
}
