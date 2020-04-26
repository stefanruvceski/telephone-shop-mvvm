using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using static Common.Model.Enums;

namespace Common.ServerContracts
{
    [ServiceContract]
    public interface ILogger
    {
        [OperationContract]
        bool LogMessage(LOGTYPE logType, String message);
    }
}
