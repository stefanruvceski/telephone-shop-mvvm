
using Common.Access;
using Common.Model;
using Common.ServerContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class TelephoneServer : ITelephoneServerExtension
    {
        #region Fields
        ILogger log = ServerLogger.Instance;
        IDBManagar dBManagar = DBManager.Instance;
        #endregion

        #region Operations
        public bool AddTelephone(ShopTelephone telephone)
        {
            
            try
            {
                if (dBManagar.AddTelephone(telephone))
                {
                    Console.WriteLine(DateTime.Now + ": Telephone Added to Database.");
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Telephone is Added to Database.");
                    return true;
                }
                else
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Telephone is not Added to Database.");
                    return false;
                }
            }
            catch
            {
                log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Telephone is not Added to Database.");
                return false;
            }
            
        }

        public bool DeleteTelephone(ShopTelephone telephone)
        {
            try
            {
                if (dBManagar.DeleteTelephone(telephone))
                {
                    Console.WriteLine(DateTime.Now + ": Telephone Removed from Database.");
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Telephone is Removed from Database.");
                    return true;
                }
                else
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Telephone is not Removed from Database.");
                    return false;
                }
            }
            catch
            {
                log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Telephone is not Removed from Database.");
                return false;
            }
        }

        public bool UpdateTelephone(ShopTelephone telephone)
        {
            try
            {
                if (dBManagar.UpdateTelephone(telephone))
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Telephone is Updated to Database.");
                    return true;
                }
                else
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Telephone is not Updated to Database.");
                    return false;
                }
            }
            catch
            {
                log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "Telephone is not Updated to Database.");
                return false;
            }
        }
        public bool UpdateNewTelephone(ShopTelephone telephone)
        {
            try
            {
                if (dBManagar.UpdateNewTelephone(telephone))
                {
                    Console.WriteLine(DateTime.Now + ": Telephone Updated to Database.");
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Telephone is Updated to Database.");
                    return true;
                }
                else
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Telephone is Updated to Database.");
                    return false;
                }
            }
            catch
            {
                log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Telephone is Updated to Database.");
                return false;
            }
        }

        public BindingList<ShopTelephone> GetAllTelephones()
        {
            Console.WriteLine(DateTime.Now + ": Getting all Telephones from Database.");
            log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Getting all Telephones from Database.");
            return dBManagar.GetAllTelephones();
        }

        public ShopTelephone GetTelephone(String telephone)
        {
            Console.WriteLine(DateTime.Now + ": Getting " + telephone + " from Database.");
            log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Getting " + telephone + " from Database.");
            return dBManagar.GetTelephone(telephone);
        }

        public BindingList<ShopTelephone> GetTelephones(String shop)
        {
            Console.WriteLine(DateTime.Now + ": Getting all Telephones than belongs to " + shop + " from Database.");
            log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Getting all Telephones than belongs to " + shop + " from Database.");
            return dBManagar.GetTelephones(shop);
        }
        
        public BindingList<ShopTelephone> GetTelephonesByCondition(String name,String condition,String content)
        {
            log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Getting all Telephones by "+condition+"="+content+" from Database.");
            return dBManagar.GetTelephonesByCondition(name, condition, content);
        }
        
        public bool CheckExisting()
        {
            log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Checking initial Telephone data from Database.");
            if (dBManagar.GetAllTelephones().Count == 0)
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
