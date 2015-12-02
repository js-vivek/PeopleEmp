using EntityClasses.BaseTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses.Common
{
    public class ServiceAvailability : Base
    {
        private string _areaCode;
        private string _description;
        private string _serviceAvailId;
        private string _serviceId;

        [DataMember]
        public string AreaCode
        {
            get { return _areaCode; }
            set { _areaCode = value; }
        }
        [DataMember]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        [DataMember]
        public string ServiceAvailId
        {
            get { return _serviceAvailId; }
            set { _serviceAvailId = value; }
        }
        [DataMember]
        public string ServiceId
        {
            get { return _serviceId; }
            set { _serviceId = value; }
        }

    }
}
