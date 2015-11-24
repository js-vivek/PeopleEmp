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
    public class UserDetail:Base
    {
        private string _userName;
        [DataMember]
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
    }
}
