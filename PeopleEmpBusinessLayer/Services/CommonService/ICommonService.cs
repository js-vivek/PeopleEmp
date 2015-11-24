using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PeopleEmpBusinessLayer.Services.CommonService
{
    [ServiceContract]
    interface ICommonService
    {
        [OperationContract]
        string TestService();
    }
}
