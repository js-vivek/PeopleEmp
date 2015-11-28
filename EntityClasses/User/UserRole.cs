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
    public class UserRole : Base
    {
        private string _documentPath;
        private string _idExpiryDate;
        private string _lification;
        private string _roleId;
        private string _userId;
        private string _verifiactionType;
        private string _verifiactionUserId;

        [DataMember]
        public string DocumentPath
        {
            get { return _documentPath; }
            set { _documentPath = value; }
        }
        [DataMember]
        public string IdExpiryDate
        {
            get { return _idExpiryDate; }
            set { _idExpiryDate = value; }
        }
        [DataMember]
        public string lification
        {
            get { return _lification; }
            set { _lification = value; }
        }
        [DataMember]
        public string RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }
        [DataMember]
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        [DataMember]
        public string VerifiactionType
        {
            get { return _verifiactionType; }
            set { _verifiactionType = value; }
        }
        [DataMember]
        public string VerifiactionUserId
        {
            get { return _verifiactionUserId; }
            set { _verifiactionUserId = value; }
        }

    }
}
