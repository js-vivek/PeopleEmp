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
    public class ServicePayment : Base
    {
        private string _amount;
        private string _cardType;
        private string _isPaidByHardCash;
        private string _paidByCard;
        private string _serviceRequestId;
        private string _servicePaymentId;

        [DataMember]
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        [DataMember]
        public string CardType
        {
            get { return _cardType; }
            set { _cardType = value; }
        }
        [DataMember]
        public string IsPaidByHardCash
        {
            get { return _isPaidByHardCash; }
            set { _isPaidByHardCash = value; }
        }
        [DataMember]
        public string PaidByCard
        {
            get { return _paidByCard; }
            set { _paidByCard = value; }
        }
        [DataMember]
        public string ServiceRequestId
        {
            get { return _serviceRequestId; }
            set { _serviceRequestId = value; }
        }
        [DataMember]
        public string ServicePaymentId
        {
            get { return _servicePaymentId; }
            set { _servicePaymentId = value; }
        }

    }
}
