using EntityClasses.BaseTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses.User
{
    public enum UserTypeEnum { GENERAL,ADMIN,SERVICE_Provider};
    [DataContract]
    public class UserDetail:Base
    {
        private string _userName;
        private int _addressId;
        private string _emailId;
        private string _userId;
        private string _password;
        private string _securityQn;
        private string _securityAns;
        private UserTypeEnum _userType;

        [DataMember]
        public UserTypeEnum UserType
        {
            get { return _userType; }
            set { _userType = value; }
        }
        [DataMember]
        public string SecurityAns
        {
            get { return _securityAns; }
            set { _securityAns = value; }
        }
        [DataMember]
        public string SecurityQn
        {
            get { return _securityQn; }
            set { _securityQn = value; }
        }
        [DataMember]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        [DataMember]
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        [DataMember]
        public string EmailId
        {
            get { return _emailId; }
            set { _emailId = value; }
        }
        [DataMember]
        public int AddressId
        {
            get { return _addressId; }
            set { _addressId = value; }
        }

        [DataMember]
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        
    }
}
