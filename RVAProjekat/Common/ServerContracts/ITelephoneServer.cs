using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common.ServerContracts
{
    [ServiceContract]
    public interface ITelephoneServer
    {
        [OperationContract]
        bool AddTelephone(ShopTelephone telephone);

        [OperationContract]
        BindingList<ShopTelephone> GetAllTelephones();

        [OperationContract]
        BindingList<ShopTelephone> GetTelephones(String shop);

        [OperationContract]
        ShopTelephone GetTelephone(String telephone);

        [OperationContract]
        bool DeleteTelephone(ShopTelephone telephone);

        [OperationContract]
        bool UpdateTelephone(ShopTelephone telephone);

        [OperationContract]
        bool UpdateNewTelephone(ShopTelephone telephone);

        [OperationContract]
        BindingList<ShopTelephone> GetTelephonesByCondition(String name,String condition, String content);

    }
}
