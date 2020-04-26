using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common.ServerContracts
{
    [ServiceContract]
    public interface IUserServer
    {
        [OperationContract]
        User Get(String userName);

        [OperationContract]
        bool Add(User user);

        [OperationContract]
        bool Update(User user);
    }
}
