using EntityClasses.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace EntityClasses.BaseTemplates
{
    [KnownType(typeof(UserDetail))]
    [DataContract]
   public class Base
    {
        private bool _isActive;
        private bool _isSuccess;
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
    }
}
