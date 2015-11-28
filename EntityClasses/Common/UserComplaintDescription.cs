using EntityClasses.BaseTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses.Common
{
    class UserComplaintDescription : Base
    {
        private string _complaintDescription;
        private string _comlaintId;

        [DataMember]
        public string ComplaintDescription
        {
            get { return _complaintDescription; }
            set { _complaintDescription = value; }
        }
        [DataMember]
        public string ComlaintId
        {
            get { return _comlaintId; }
            set { _comlaintId = value; }
        }

    }
}
