using EntityClasses.BaseTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses.Common
{
    public class Service:Base
    {
        private string _absoluteServiceCharge;
        private string _serviceCategory;
        private string _serviceDescription;
        private string _serviceId;
        private string _serviceName;
        private string _serviceType;
        private string _validFrom;
        private string _validTo;
        [DataMember]
        public string AbsoluteServiceCharge
        {
            get { return _absoluteServiceCharge; }
            set { _absoluteServiceCharge = value; }
        }
        [DataMember]
        public string ServiceCategory
        {
            get { return _serviceCategory; }
            set { _serviceCategory = value; }
        }
        [DataMember]
        public string ServiceDescription
        {
            get { return _serviceDescription; }
            set { _serviceDescription = value; }
        }
        [DataMember]
        public string ServiceId
        {
            get { return _serviceId; }
            set { _serviceId = value; }
        }
        [DataMember]
        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }
        [DataMember]
        public string ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }
        [DataMember]
        public string ValidFrom
        {
            get { return _validFrom; }
            set { _validFrom = value; }
        }
        [DataMember]
        public string ValidTo
        {
            get { return _validTo; }
            set { _validTo = value; }
        }

    }
}
