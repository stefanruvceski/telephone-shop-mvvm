using Common.Access;
using Common.Model;
using Common.ServerContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ShopServer : IShopServerExtension
    {
        #region Fields
        ILogger log = ServerLogger.Instance;
        DBManager dBManager = DBManager.Instance;
        #endregion

        #region Operations
        public bool AddShop(Shop shop)
        {
            try
            {
                if (dBManager.AddShop(shop))
                {
                    Console.WriteLine(DateTime.Now + ": Shop Added to Database.");
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Shop is Added to Database.");
                    return true;
                }
                else
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Shop is not Added to Database.");
                    return false;
                }
            }
            catch
            {
                log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Shop is not Added to Database.");
                return false;
            }
        }

        public bool DeleteShop(Shop shop)
        {
            try
            {
                if (dBManager.DeleteShop(shop))
                {
                    Console.WriteLine(DateTime.Now + ": Shop Removed from Database.");
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Shop from Removed to Database.");
                    return true;
                }
                else
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Shop from not Removed to Database.");
                    return false;
                }
            }
            catch
            {
                log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Shop from not Removed to Database.");
                return false;
            }
        }

        public Shop GetShop(String shopName)
        {
            Console.WriteLine(DateTime.Now + ": Getting " + shopName + " from Database.");
            log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Getting " + shopName + " from Database.");
            return dBManager.GetShop(shopName);
        }

        public List<Shop> GetShops()
        {
            Console.WriteLine(DateTime.Now + ": Getting all Shops from Database.");
            log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Getting all Shops from Database.");
            return dBManager.GetShops();
        }

        public bool UpdateShop(Shop shop)
        {
            try
            {
                if (dBManager.UpdateShop(shop))
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Shop is Updated to Database.");
                    return true;
                }
                else
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Shop is not Updated to Database.");
                    return false;
                }
            }
            catch
            {
                log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Shop is not Updated to Database.");
                return false;
            }
        }

        public bool CheckExisting()
        {
            log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Checking initial Shop data from Database.");
            if (dBManager.GetShops().Count == 0)
            {
                return true;
            }
            else
            {
                return false;   
            }

        }
        #endregion
    }
}
