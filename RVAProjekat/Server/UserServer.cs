using Common.Access;
using Common.Model;
using Common.ServerContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Model.Enums;

namespace Server
{
    public class UserServer : IUserServerExtension
    {
        #region Fields
        ILogger log = ServerLogger.Instance;
        DBManager dBManager = DBManager.Instance;
        #endregion

        #region Operations
        public UserServer() { }

        public bool Add(User user)
        {
            try
            {
                if (dBManager.Add(user))
                {
                    Console.WriteLine(DateTime.Now + ": User Added to Database.");
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "User Added to Database.");
                    return true;
                }
                else
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "User is not Added to Database.");
                    return false;
                }
               
            }
            catch
            {
                log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "User is not Added to Database.");
                return false;
            }
        }
        
        public User Get(String userName)
        {
            Console.WriteLine(DateTime.Now + ": Getting " + userName + " from Database.");
            log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Getting " + userName + " from Database.");
            return dBManager.Get(userName);

        }

        public bool Update(User user)
        {
            try
            {
                if (dBManager.Update(user))
                { 
                    Console.WriteLine(DateTime.Now + ": User Updated to Database.");
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "User Updated to Database.");
                    return true;
                }
                else
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "User is not Updated to Database.");
                    return false;
                }

            }
            catch
            {
                log.LogMessage(Common.Model.Enums.LOGTYPE.ERROR, "User is not Updated to Database.");
                return false;
            }
        }

        public bool Remove(User user)
        {
            try
            {
                if (dBManager.Remove(user))
                {
                    Console.WriteLine(DateTime.Now + ": User Remove from Database.");
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "User Remove from Database.");
                    return true;
                }
                else
                {
                    log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "User is Removed from Database.");
                    return false;
                }
            }
            catch
            {
                log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "User is Removed from Database.");
                return false;
            }
        }

        public bool CheckExisting()
        {
            log.LogMessage(Common.Model.Enums.LOGTYPE.INFO, "Checking for initial data in Database.");
            return dBManager.GetAll();

        }
        #endregion
    }
}
