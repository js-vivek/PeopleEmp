using EntityClasses.BaseTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses.Common
{
    class Complaint : Base
    {
        private string _assignedTo;
        private string _comlaintId;
        private string _comlaintServiceId;
        private string _serviceService;
        private string _status;

        [DataMember]
        public string AssignedTo
        {
            get { return _assignedTo; }
            set { _assignedTo = value; }
        }
        [DataMember]
        public string ComlaintId
        {
            get { return _comlaintId; }
            set { _comlaintId = value; }
        }
        [DataMember]
        public string ComlaintServiceId
        {
            get { return _comlaintServiceId; }
            set { _comlaintServiceId = value; }
        }
        [DataMember]
        public string ServiceService
        {
            get { return _serviceService; }
            set { _serviceService = value; }
        }
        [DataMember]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

    }
}
