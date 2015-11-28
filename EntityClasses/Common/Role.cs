using EntityClasses.BaseTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses.Common
{
    class Role:Base
    {
        private string _roleId;
        private string _roleName;

        [DataMember]
        public string RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }
        [DataMember]
        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

    }
}
