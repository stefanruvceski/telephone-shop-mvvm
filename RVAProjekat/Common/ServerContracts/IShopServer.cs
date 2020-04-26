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
    public interface IShopServer
    {
        [OperationContract]
        bool AddShop(Shop shop);

        [OperationContract]
        Shop GetShop(String shopName);

        [OperationContract]
        List<Shop> GetShops();

        [OperationContract]
        bool DeleteShop(Shop shop);

        [OperationContract]
        bool UpdateShop(Shop shop);
    }
}
