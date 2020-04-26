using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Access
{
    public interface IDBManagar
    {
        #region  Telephone
        bool AddTelephone(ShopTelephone telephone);

        bool DeleteTelephone(ShopTelephone telephone);

        bool UpdateTelephone(ShopTelephone telephone);

        bool UpdateNewTelephone(ShopTelephone telephone);

        BindingList<ShopTelephone> GetAllTelephones();

        ShopTelephone GetTelephone(String telephone);

        BindingList<ShopTelephone> GetTelephones(String shop);

        BindingList<ShopTelephone> GetTelephonesByCondition(String name, String condition, String content);
        #endregion

        #region Shop
        bool AddShop(Shop shop);
        bool DeleteShop(Shop shop);

        List<Shop> GetShops();
        Shop GetShop(String shopName);

        bool UpdateShop(Shop shop);
        #endregion

        #region User
        bool Add(User user);

        User Get(String userName);

        bool Update(User user);

        bool Remove(User user);

        bool GetAll();
        #endregion
    }
}
