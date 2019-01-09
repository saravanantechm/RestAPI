using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace RestAPIDemo
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        List<Users> GetAllUser();

        [OperationContract]
        List<Users> GetAllUserlist();
    }
}
