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
    public class WalletTransaction : Base
    {
        private string _amount;
        private string _cardType;
        private string _debitedFor;
        private string _isCredit;
        private string _isCreditedByHard;
        private string _isDebited;
        private string _walletTransactionId;

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
        public string DebitedFor
        {
            get { return _debitedFor; }
            set { _debitedFor = value; }
        }
        [DataMember]
        public string IsCredit
        {
            get { return _isCredit; }
            set { _isCredit = value; }
        }
        [DataMember]
        public string IsCreditedByHard
        {
            get { return _isCreditedByHard; }
            set { _isCreditedByHard = value; }
        }
        [DataMember]
        public string IsDebited
        {
            get { return _isDebited; }
            set { _isDebited = value; }
        }
        [DataMember]
        public string WalletTransactionId
        {
            get { return _walletTransactionId; }
            set { _walletTransactionId = value; }
        }

    }
}
