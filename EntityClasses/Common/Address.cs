using EntityClasses.BaseTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses.Common
{
    public class Address:Base
    {
        private string _addressLine1;
        private string _addressLine2;
        private string _areaCode;
        private string _city;
        private string _country;
        private string _pinCode;
        private string _stateOrRegion;
        [DataMember]
        public string AddressLine1
        {
            get { return _addressLine1; }
            set { _addressLine1 = value; }
        }
        [DataMember]
        public string AddressLine2
        {
            get { return _addressLine2; }
            set { _addressLine2 = value; }
        }
        [DataMember]
        public string AreaCode
        {
            get { return _areaCode; }
            set { _areaCode = value; }
        }
        [DataMember]
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        [DataMember]
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        [DataMember]
        public string PinCode
        {
            get { return _pinCode; }
            set { _pinCode = value; }
        }
        [DataMember]
        public string StateOrRegion
        {
            get { return _stateOrRegion; }
            set { _stateOrRegion = value; }
        }

    }
}
