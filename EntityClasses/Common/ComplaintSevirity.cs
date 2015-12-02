using EntityClasses.BaseTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses.Common
{
    public class ComplaintSevirity : Base
    {
        private string _compalinPriority;
        private string _compalinSevirityId;
        private string _compalintSevirity;
        private string _createdByName;

        [DataMember]
        public string CompalinPriority
        {
            get { return _compalinPriority; }
            set { _compalinPriority = value; }
        }
        [DataMember]
        public string CompalinSevirityId
        {
            get { return _compalinSevirityId; }
            set { _compalinSevirityId = value; }
        }
        [DataMember]
        public string CompalintSevirity
        {
            get { return _compalintSevirity; }
            set { _compalintSevirity = value; }
        }
        [DataMember]
        public string CreatedByName
        {
            get { return _createdByName; }
            set { _createdByName = value; }
        }

    }
}
