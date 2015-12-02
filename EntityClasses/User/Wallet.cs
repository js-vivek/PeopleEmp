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
    public class Wallet : Base
    {
        private string _balance;
        private string _cardType;
        private string _linkedMasterAccNo;
        private string _walletHolderId;
        //private string _wallet;

        [DataMember]
        public string Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        [DataMember]
        public string CardType
        {
            get { return _cardType; }
            set { _cardType = value; }
        }
        [DataMember]
        public string LinkedMasterAccNo
        {
            get { return _linkedMasterAccNo; }
            set { _linkedMasterAccNo = value; }
        }
        [DataMember]
        public string WalletHolderId
        {
            get { return _walletHolderId; }
            set { _walletHolderId = value; }
        }
        //[DataMember]
        //public string Wallet
        //{
        //    get { return _wallet; }
        //    set { _wallet = value; }
        //}

    }
}
